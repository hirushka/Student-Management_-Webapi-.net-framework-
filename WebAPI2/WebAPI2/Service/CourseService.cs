using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI2.Models;
using WebAPI2.Reporsitory.Contract;
using WebAPI2.Service.Contract;

namespace WebAPI2.Service
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository ;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public async Task<bool> AddCourseAsync(Course course)
        {
            return await _courseRepository.CreateCourseAsync(course);
        }

        public async Task<ICollection<Course>> GetCoursesAsync()
        {
            return await _courseRepository.GetCoursesAsync();
        }

        public async Task<Course> GetCourseByIdAsync(int Id)
        {
            return await _courseRepository.GetCourseByIDAsync(Id);
        }
    }
}
