using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI2.Models
{
    public class Student
    {
        

        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Email { get; set; }
        public int Age { get; set; }
        public int AcedemicYear { get; set; }
        public DateTime RegisteredDate { get; set; }
        public int DepartmentId { get; set; }
        public string Gender { get; set; }
        public List<Student_Course> Student_Courses { get; set; }
       // public int DepartmentId { get; set; }
       // public Department Department { get; set; }
    }
}
