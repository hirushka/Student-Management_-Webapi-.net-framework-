using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI2.Models;
using WebAPI2.Reporsitory.Contract;

namespace WebAPI2.Reporsitory
{
    class CourseRepository : ICourseRepository
    {
        private readonly StudentMngContext _context;
        public CourseRepository(StudentMngContext context)
        {
            _context = context;
        }
        public async Task<bool> CreateCourseAsync(Course crs)
        {
            await _context.Courses.AddAsync(crs);
            return await Save();
        }

        public async Task<Course> GetCourseByIDAsync(int id)
        {
           // return await _context.Courses.FirstOrDefaultAsync(Crs => Crs.Id == id);

           return  await _context.Courses
                        .Include(i => i.Department)
                        .FirstOrDefaultAsync(i => i.Id == id);
        }

        public async Task<ICollection<Course>> GetCoursesAsync()
        {
            return await _context.Courses.Include(i => i.Department).ToListAsync();
        }

        private async Task<bool> Save()
        {
            return await _context.SaveChangesAsync() >= 0 ? true : false;
        }
    }
}
