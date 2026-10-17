using first14.ADL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace first14.ADL.Database
{
    internal class First14DbContext : DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=./;Database=emplyee;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Topic>().HasKey(t => t.ID);
            modelBuilder.Entity<Course>().HasKey(c => c.CID);
            modelBuilder.Entity<Instructor>().HasKey(i => i.InsID);
            modelBuilder.Entity<Department>().HasKey(d => d.DID);
            modelBuilder.Entity<Student>().HasKey(s => s.SID);
            modelBuilder.Entity<CourseInstructor>()
                .HasKey(ci => new { ci.CourseId, ci.InstructorId });
            modelBuilder.Entity<StudentCourse>()
               .HasKey(sc => new { sc.StudentId, sc.CourseId });

            modelBuilder.Entity<Course>()
                .HasOne(c => c.Topic)
                .WithMany(t => t.Courses)
                .HasForeignKey(c => c.TopicId);

            modelBuilder.Entity<Instructor>()
                .HasOne(i => i.department)
                .WithMany(d => d.Instructors)
                .HasForeignKey(i => i.DepartmentID);

            modelBuilder.Entity<Student>()
                .HasOne(s => s.department)
                .WithMany(d => d.Students)
                .HasForeignKey(s => s.DepartmentID);

            modelBuilder.Entity<Department>()
                .HasOne(d => d.Manager)
                .WithOne(i=>i.ManagedDepartment)
                .HasForeignKey<Department>(d => d.ManagerId);

            modelBuilder.Entity<Student>()
                .HasOne(s => s.Super)
                .WithMany(s => s.Supers)
                .HasForeignKey(s => s.SuperId);
            
            
            modelBuilder.Entity<CourseInstructor>()
                .HasOne(ci => ci.Instructor)
                .WithMany(i =>i.CourseInstructor)
                .HasForeignKey(ci => ci.CourseId);
            modelBuilder.Entity<CourseInstructor>()
                .HasOne(ci => ci.Course)
                .WithMany(c => c.CourseInstructor)
                .HasForeignKey(ci => ci.InstructorId);

            modelBuilder.Entity<StudentCourse>()
                .HasOne(sc => sc.Student)
                .WithMany(c => c.StudentCourse)
                .HasForeignKey(sc => sc.StudentId);
            modelBuilder.Entity<StudentCourse>()
                .HasOne(sc => sc.Course)
                .WithMany(s => s.StudentCourse)
                .HasForeignKey(sc => sc.CourseId);

            base.OnModelCreating(modelBuilder);

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        public DbSet<CourseInstructor> CourseInstructors { get; set; }


    }
}
