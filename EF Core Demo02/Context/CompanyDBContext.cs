using EF_Core_Demo02.Configrations;
using EF_Core_Demo02.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Demo02.Context
{
    internal class CompanyDBContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Employee>(new EmployeeConfigrations());
            //modelBuilder.Entity<Employee>().HasKey(E=>E.EmpId);
            //modelBuilder.Entity<Employee>().Property(E => E.EmpId).UseIdentityColumn(1,1);

            //modelBuilder.Entity<Employee>().HasOne(E => E.Department)
            //                               .WithOne(E => E.Manager)
            //                               .HasForeignKey<Department>(D=>D.EmpId);
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = CompanyDB02; Trusted_Connection = True;Encrypt=True;TrustServerCertificate=True");
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}

