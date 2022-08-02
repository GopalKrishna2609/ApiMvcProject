﻿// <auto-generated />
using System;
using APItoDbConnection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APIEmployee.Migrations
{
    [DbContext(typeof(EmployeeDbContext))]
    [Migration("20220802051839_initialmigration")]
    partial class initialmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("APItoDbConnection.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasColumnType("Varchar(100)");

                    b.Property<string>("AddressLine2")
                        .IsRequired()
                        .HasColumnType("Varchar(100)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("Varchar(50)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("Varchar(50)");

                    b.Property<DateTime?>("DateOfJoining")
                        .IsRequired()
                        .HasColumnType("Datetime");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("Varchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("Varchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("Varchar(50)");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("Char(10)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("Varchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("MobileNumber")
                        .IsUnique();

                    b.ToTable("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}