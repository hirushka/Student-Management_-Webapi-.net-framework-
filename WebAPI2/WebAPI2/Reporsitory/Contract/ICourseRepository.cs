using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI2.Models;

namespace WebAPI2.Reporsitory.Contract
{
    public interface ICourseRepository
    {
        Task<ICollection<Course>> GetCoursesAsync();
        Task<Course> GetCourseByIDAsync(int id);
        Task<bool> CreateCourseAsync(Course crs);
    }
}
