using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI2.Models
{
    public class Course
    {
        

        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        public string CourseName { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public List<Student_Course> Student_Courses { get; set; }
    }
}
