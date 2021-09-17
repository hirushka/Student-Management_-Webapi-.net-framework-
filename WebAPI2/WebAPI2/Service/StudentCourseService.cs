using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI2.Models;
using WebAPI2.Reporsitory.Contract;
using WebAPI2.Service.Contract;

namespace WebAPI2.Service
{
    public class StudentCourseService : IStudentCourseService
    {
        private readonly IStudentCourseRepository _studentCourseRepository;

        public StudentCourseService(IStudentCourseRepository studentCourseRepository)
        {
            _studentCourseRepository = studentCourseRepository;
        }

        public async Task<bool> CreateStudentCourseAsync(Student_Course std)
        {
            return await _studentCourseRepository.CreateStudentCourseAsync(std);
        }

        public async Task<Student_Course> GetStudentCourseById(int id)
        {
            return await _studentCourseRepository.GetStudentCourseById(id);
        }

        public async Task<ICollection<Student_Course>> GetStudentCourseBySIDAsync(int id)
        {
            return await _studentCourseRepository.GetStudentCourseBySIDAsync(id);
        }

        public async Task<bool> HardDeleteStudentCourseAsync(Student_Course std)
        {
            return await _studentCourseRepository.HardDeleteStudentCourseAsync(std);
        }
    }
}
