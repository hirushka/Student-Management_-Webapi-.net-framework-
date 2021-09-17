using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI2.Models;
using WebAPI2.Reporsitory.Contract;

namespace WebAPI2.Reporsitory
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly StudentMngContext _context;

        public DepartmentRepository(StudentMngContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateDepartAsync(Department dept)
        {
            await _context.Departments.AddAsync(dept);
            return await Save();
        }

        public async Task<Department> GetDepartmentByIDAsync(int id)
        {
            return await _context.Departments.Include(i => i.Courses).FirstOrDefaultAsync(Dept => Dept.Id == id);
        }

        public async Task<ICollection<Department>> GetDepartmentsAsync()
        {
            return await _context.Departments.Include(i => i.Courses).ToListAsync();
        }

        public async Task<bool> HardDeleteDeptAsync(Department dept)
        {
            _context.Remove(dept);
            return await Save();
        }

        public async Task<bool> UpdateDepatAsync(Department dept)
        {
            _context.Departments.Update(dept);
            return await Save();
        }

        private async Task<bool> Save()
        {
            return await _context.SaveChangesAsync() >= 0 ? true : false;
        }
    }
}
