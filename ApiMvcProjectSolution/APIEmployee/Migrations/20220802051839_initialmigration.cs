using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIEmployee.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "Varchar(50)", nullable: false),
                    LastName = table.Column<string>(type: "Varchar(50)", nullable: false),
                    MobileNumber = table.Column<string>(type: "Char(10)", nullable: false),
                    Email = table.Column<string>(type: "Varchar(50)", nullable: false),
                    AddressLine1 = table.Column<string>(type: "Varchar(100)", nullable: false),
                    AddressLine2 = table.Column<string>(type: "Varchar(100)", nullable: false),
                    PostalCode = table.Column<string>(type: "Varchar(10)", nullable: false),
                    City = table.Column<string>(type: "Varchar(50)", nullable: false),
                    Country = table.Column<string>(type: "Varchar(50)", nullable: false),
                    DateOfJoining = table.Column<DateTime>(type: "Datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Email",
                table: "Employees",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_MobileNumber",
                table: "Employees",
                column: "MobileNumber",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
