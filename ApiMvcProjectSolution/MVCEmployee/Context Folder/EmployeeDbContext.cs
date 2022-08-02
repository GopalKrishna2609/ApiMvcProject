using Microsoft.EntityFrameworkCore;
using MVCEmployee.Models;

namespace MVCEmployee.Context_Folder
{
    public class EmployeeDbContext : DbContext
    {

        public DbSet<EmployeeViewModel> Employees { get; set; }
        public EmployeeDbContext()
        {

        }
        public EmployeeDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-CEIJQT1;Initial Catalog=WebPageEmployee;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<EmployeeViewModel>(entity =>
            {
                entity.HasIndex(e => e.MobileNumber).IsUnique();
                entity.HasIndex(e => e.Email).IsUnique();
            });
        }

    }
}
