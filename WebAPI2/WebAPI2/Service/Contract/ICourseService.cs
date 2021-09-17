using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI2.Models;

namespace WebAPI2.Service.Contract
{
    public interface ICourseService
    {
        Task<ICollection<Course>> GetCoursesAsync();
        Task<Course> GetCourseByIdAsync(int Id);
        Task<bool> AddCourseAsync(Course dept);
    }
}
