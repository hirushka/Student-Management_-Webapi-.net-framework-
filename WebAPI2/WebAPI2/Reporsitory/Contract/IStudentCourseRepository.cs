using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI2.Models;

namespace WebAPI2.Reporsitory.Contract
{
    public interface IStudentCourseRepository
    {
        Task<ICollection<Student_Course>> GetStudentCourseBySIDAsync(int id);
        Task<bool> CreateStudentCourseAsync(Student_Course std);
        Task<bool> HardDeleteStudentCourseAsync(Student_Course std);
        Task<Student_Course> GetStudentCourseById(int id);
    }

}
