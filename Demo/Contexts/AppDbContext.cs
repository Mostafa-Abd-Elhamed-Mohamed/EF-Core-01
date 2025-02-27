﻿using Demo.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Contexts
{
    internal class AppDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = App; Trusted_Connection = True; TrustServerCertificate = True");
        }


       public DbSet<Employee> Employees { get; set; }

        public DbSet<Department> Departments { get; set; }



    }
}
