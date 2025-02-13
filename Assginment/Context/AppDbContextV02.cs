using Assginment.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment.Context
{
    internal class AppDbContextV02 : DbContext
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Topic>().HasKey(T => T.Id);
            modelBuilder.Entity<Student>().HasKey(S =>S.Id);
            modelBuilder.Entity<Course>().HasKey(C =>C.Id);
            modelBuilder.Entity<Department>().HasKey(D =>D.Id);
            modelBuilder.Entity<Instructor>().HasKey(I =>I.Id);

            modelBuilder.Entity<Course_Inst>().HasKey(CI => new {CI.Course_ID , CI.inst_ID});

            modelBuilder.Entity<Stud_Course>().HasKey(SC => new {SC.Course_ID , SC.stud_ID});


        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = AppV02; Trusted_Connection = True; TrustServerCertificate = True");
        }


        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }

        public DbSet<Topic> Topics { get; set; }
        public DbSet<Stud_Course> Stud_Courses { get; set; }
        public DbSet<Instructor> Instructor { get; set; }
        public DbSet<Course_Inst> Course_Insts { get; set; }



    }
}
