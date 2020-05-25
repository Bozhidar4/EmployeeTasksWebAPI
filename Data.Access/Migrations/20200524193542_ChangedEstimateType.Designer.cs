﻿// <auto-generated />
using Data.Access.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Access.Migrations
{
    [DbContext(typeof(EmployeeContext))]
    [Migration("20200524193542_ChangedEstimateType")]
    partial class ChangedEstimateType
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Data.Access.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new { Id = 1, FirstName = "Ross", LastName = "Geller" },
                        new { Id = 2, FirstName = "Rachel", LastName = "Green" },
                        new { Id = 3, FirstName = "Chandler", LastName = "Bing" },
                        new { Id = 4, FirstName = "Joey", LastName = "Tribbiani" },
                        new { Id = 5, FirstName = "Monica", LastName = "Geller-Bing" },
                        new { Id = 6, FirstName = "Phoebe", LastName = "Buffay-Hannigan" }
                    );
                });

            modelBuilder.Entity("Data.Access.Models.PriorityLevel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("PriorityLevel");

                    b.HasData(
                        new { Id = 1, Name = "Critical" },
                        new { Id = 2, Name = "Medium" },
                        new { Id = 3, Name = "Low" }
                    );
                });

            modelBuilder.Entity("Data.Access.Models.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("State");

                    b.HasData(
                        new { Id = 1, Name = "New" },
                        new { Id = 2, Name = "Active" },
                        new { Id = 3, Name = "Resolved" },
                        new { Id = 4, Name = "Closed" }
                    );
                });

            modelBuilder.Entity("Data.Access.Models.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<int>("EmployeeId");

                    b.Property<string>("Estimate");

                    b.Property<int>("PriorityLevelId");

                    b.Property<int>("StateId");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Tasks");

                    b.HasData(
                        new { Id = 1, Description = "Description 1", EmployeeId = 1, Estimate = "1", PriorityLevelId = 1, StateId = 2, Title = "Task 1" },
                        new { Id = 2, Description = "Description 2", EmployeeId = 2, Estimate = "1", PriorityLevelId = 1, StateId = 2, Title = "Task 2" },
                        new { Id = 3, Description = "Description 3", EmployeeId = 1, Estimate = "2", PriorityLevelId = 3, StateId = 1, Title = "Task 3" },
                        new { Id = 4, Description = "Description 4", EmployeeId = 2, Estimate = "2", PriorityLevelId = 3, StateId = 3, Title = "Task 4" },
                        new { Id = 5, Description = "Description 5", EmployeeId = 1, Estimate = "3", PriorityLevelId = 2, StateId = 3, Title = "Task 5" },
                        new { Id = 6, Description = "Description 6", EmployeeId = 2, Estimate = "3", PriorityLevelId = 2, StateId = 4, Title = "Task 6" },
                        new { Id = 7, Description = "Description 7", EmployeeId = 3, Estimate = "1", PriorityLevelId = 1, StateId = 2, Title = "Task 7" },
                        new { Id = 8, Description = "Description 8", EmployeeId = 4, Estimate = "1", PriorityLevelId = 1, StateId = 2, Title = "Task 8" },
                        new { Id = 9, Description = "Description 9", EmployeeId = 3, Estimate = "2", PriorityLevelId = 3, StateId = 1, Title = "Task 9" },
                        new { Id = 10, Description = "Description 10", EmployeeId = 4, Estimate = "2", PriorityLevelId = 3, StateId = 3, Title = "Task 10" },
                        new { Id = 11, Description = "Description 11", EmployeeId = 3, Estimate = "3", PriorityLevelId = 2, StateId = 3, Title = "Task 11" },
                        new { Id = 12, Description = "Description 12", EmployeeId = 4, Estimate = "3", PriorityLevelId = 2, StateId = 4, Title = "Task 12" },
                        new { Id = 13, Description = "Description 13", EmployeeId = 5, Estimate = "1", PriorityLevelId = 1, StateId = 4, Title = "Task 13" },
                        new { Id = 14, Description = "Description 14", EmployeeId = 6, Estimate = "1", PriorityLevelId = 1, StateId = 4, Title = "Task 14" },
                        new { Id = 15, Description = "Description 15", EmployeeId = 5, Estimate = "2", PriorityLevelId = 3, StateId = 3, Title = "Task 15" },
                        new { Id = 16, Description = "Description 16", EmployeeId = 6, Estimate = "2", PriorityLevelId = 3, StateId = 3, Title = "Task 16" },
                        new { Id = 17, Description = "Description 17", EmployeeId = 5, Estimate = "3", PriorityLevelId = 2, StateId = 1, Title = "Task 17" },
                        new { Id = 18, Description = "Description 18", EmployeeId = 6, Estimate = "3", PriorityLevelId = 2, StateId = 1, Title = "Task 18" }
                    );
                });

            modelBuilder.Entity("Data.Access.Models.Task", b =>
                {
                    b.HasOne("Data.Access.Models.Employee")
                        .WithMany("Tasks")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
