using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI2.Models;
using WebAPI2.Reporsitory.Contract;

namespace WebAPI2.Reporsitory
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentMngContext _context;
        public StudentRepository(StudentMngContext context)
        {
            _context = context;  
        }
        public async Task<bool> CreateStudentAsync(Student std)
        {
           await _context.Students.AddAsync(std);
            return await Save();
        }

        public async Task<ICollection<Student>> GetStudentAsync()
        {
            return await _context.Students.ToListAsync();
        }

        public async Task<Student> GetStudentByIDAsync(int id)
        {
            return await _context.Students.FirstOrDefaultAsync(Student=>Student.Id == id);
        }

        public async Task<bool> HardDeleteStudentAsync(Student std)
        {
             _context.Students.Remove(std);
            return await Save();
        }

        public async Task<bool> UpdateStudentAsync(Student std)
        {
            _context.Students.Update(std);
            return await Save();
        }
        private async Task<bool> Save()
        {
            return await _context.SaveChangesAsync() >= 0 ? true : false;
        }
    }

}
