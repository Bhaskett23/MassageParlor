using MassageParlor.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MassageParlor.Context
{
    public class MassageParlorContext : DbContext
    {
        public MassageParlorContext(DbContextOptions<MassageParlorContext> options) : base(options)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Massage> Massages { get; set; }

        public DbSet<EmployeeMassage> EmployeeMassages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {            
            modelBuilder.Entity<EmployeeMassage>()
                .HasData(
                    new EmployeeMassage()
                    {
                        Id = Guid.Parse("5b1c3c4d-48c7-402a-80c3-cc796ad49c6b"),
                        EmployeeId = Guid.Parse("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b"),
                        MassageId = Guid.Parse("da2fd609-d754-4feb-8acd-c4f9ff13ba96")
                    },
                    new EmployeeMassage()
                    {
                        Id = Guid.Parse("1b3c3c4d-48c7-402a-80c3-cc796ad49c6b"),
                        EmployeeId = Guid.Parse("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b"),
                        MassageId = Guid.Parse("da2fd609-d754-4feb-8acd-c4f9ff13ba96")
                    },
                    new EmployeeMassage()
                    {
                        Id = Guid.Parse("1b3c3c4d-48c7-402a-70c5-cc796ad49c6b"),
                        EmployeeId = Guid.Parse("d8663e5e-7494-4f81-8739-6e0de1bea7ee"),
                        MassageId = Guid.Parse("da2fd609-d754-4feb-8acd-c4f9ff13ba96")
                    });

            // modelBuilder.Entity<EmployeeMassage>()
            //     // .HasNoKey();
            //     .HasKey(x => new { x.MassageId, x.EmployeeId });
            modelBuilder.Entity<EmployeeMassage>()
    .HasOne<Employee>(x => x.Employee);
    //.WithMany(x => x.MassageServices);
            modelBuilder.Entity<EmployeeMassage>()
                .HasOne<Massage>(x => x.Massage)
                .WithMany(x => x.EmployeesThatPerformThis);
            modelBuilder.Entity<Employee>()
                .HasData(
                    new Employee()
                    {
                        Id = Guid.Parse("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b"),
                        FirstName = "Alex",
                        LastName = "Down",
                        Description = "Started doing massages out of high school joined company in the summer of 2005",
                        StartDate = DateTime.Parse("2005/06/06")
                    },
                    new Employee()
                    {
                        Id = Guid.Parse("d8663e5e-7494-4f81-8739-6e0de1bea7ee"),
                        FirstName = "Brandon",
                        LastName = "Ten",
                        Description = "Brandon comes with extensive experience as our oldest memeber starting back in 1996",
                        StartDate = DateTime.Parse("1996/05/12")
                    }
                );
            modelBuilder.Entity<Massage>()
                .HasData(
                    new Massage()
                    {
                        Id = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                        Name = "Swedish",
                        Description = "Swedish massage is a gentle type of full-body massage."
                    },
                    new Massage()
                    {
                        Id = Guid.Parse("da2fd609-d754-4feb-8acd-c4f9ff13ba96"),
                        Name = "Hot stone massage",
                        Description = "Hot stone massage is best for people who have muscle pain and tension or who simply want to relax."
                    }
                );
        }
    }
}
