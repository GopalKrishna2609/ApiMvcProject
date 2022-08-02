using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCEmployee.Context_Folder;
using MVCEmployee.Models;
using Newtonsoft.Json;

namespace MVCEmployee.Controllers
{
    public class EmployeeViewModelsController : Controller
    {
        Uri baseAddress = new Uri("https://localhost:7294/api");
        HttpClient client;
        public EmployeeViewModelsController()
        {
            client = new HttpClient();
            client.BaseAddress = baseAddress;
        }

        public IActionResult Index()
        {
            List<EmployeeViewModel> employees = new List<EmployeeViewModel>();
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/employees").Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                employees = JsonConvert.DeserializeObject<List<EmployeeViewModel>>(data);
            }
            return View(employees);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateOrUpdate(EmployeeViewModel employee)
        {
            string data = JsonConvert.SerializeObject(employee);
            StringContent stringContent = new StringContent(data, Encoding.UTF8, "application/json");

            if (employee.Id == 0)
            {
                HttpResponseMessage response = client.PostAsync(client.BaseAddress + "/employees", stringContent).Result;
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                return View("Create", employee);
            }
            else
            {
                HttpResponseMessage response = client.PutAsync(client.BaseAddress + $"/employees?id={employee.Id}", stringContent).Result;
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                return View("Create", employee);
            }
        }


        public ActionResult Delete(int empId)
        {
            HttpResponseMessage response = client.DeleteAsync(client.BaseAddress + $"/employees/" + empId).Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return BadRequest("Something went Wrong");
        }

        public ActionResult Edit(EmployeeViewModel employee)
        {
            return View("Create", employee);
        }

        public ActionResult Search(string searchString)
        {
            List<EmployeeViewModel> employees = new List<EmployeeViewModel>();
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/employees/" + searchString).Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                employees = JsonConvert.DeserializeObject<List<EmployeeViewModel>>(data);
            }
            return View("Index", employees);
        }
    }
}
