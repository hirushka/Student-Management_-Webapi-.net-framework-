using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI2.Models;
using WebAPI2.Reporsitory.Contract;

namespace WebAPI2.Reporsitory
{
    public class StudentCourseRepository : IStudentCourseRepository
    {
        private readonly StudentMngContext _context;

        public StudentCourseRepository(StudentMngContext studentMngContext)
        {
            _context = studentMngContext;
        }
        public async Task<bool> CreateStudentCourseAsync(Student_Course sc)
        {
            await _context.Students_Courses.AddAsync(sc);
            return await Save();
        }

        public async Task<Student_Course> GetStudentCourseById(int id)
        {
            return await _context.Students_Courses.FirstOrDefaultAsync(SC => SC.Id == id);
        }

        public async Task<ICollection<Student_Course>> GetStudentCourseBySIDAsync(int id)
        {
            return await _context.Students_Courses.Where(sc => sc.StudentId == id).ToListAsync();
        }

        public async Task<bool> HardDeleteStudentCourseAsync(Student_Course std)
        {
             _context.Students_Courses.Remove(std);
            return await Save();
        }

        private async Task<bool> Save()
        {
            return await _context.SaveChangesAsync() >= 0 ? true : false;
        }
    }
}
