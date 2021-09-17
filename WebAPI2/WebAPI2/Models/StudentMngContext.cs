using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI2.Models
{
    public class StudentMngContext :DbContext
    {
        public StudentMngContext(DbContextOptions<StudentMngContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>()
                .HasOne(c => c.Department)
                .WithMany(d => d.Courses);


            modelBuilder.Entity<Student_Course>()
                .HasOne<Student>(sc => sc.Student)
                .WithMany(s => s.Student_Courses)
                .HasForeignKey(sc => sc.StudentId);


            modelBuilder.Entity<Student_Course>()
                .HasOne<Course>(sc => sc.Course)
                .WithMany(s => s.Student_Courses)
                .HasForeignKey(sc => sc.CourseId);

            //modelBuilder.Entity<Student>()
            //    .HasOne(s => s.Department)
            //    .WithMany(d => d.Students).OnDelete(DeleteBehavior.Restrict);
                
        }




        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Student_Course> Students_Courses { get; set; }
    }
}
