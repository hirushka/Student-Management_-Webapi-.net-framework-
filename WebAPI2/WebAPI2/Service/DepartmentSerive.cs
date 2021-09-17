using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI2.Dtos;
using WebAPI2.Models;
using WebAPI2.Reporsitory.Contract;
using WebAPI2.Service.Contract;


namespace WebAPI2.Service
{
    public class DepartmentSerive : IDepartmentSerivce
    {
         private readonly IDepartmentRepository _departmentReporsitory;

        public DepartmentSerive(IDepartmentRepository departmentRepository)
        {
            _departmentReporsitory = departmentRepository;
        }

        public async Task<bool> AddDepartmentAsync(Department dept)
        {
            return await _departmentReporsitory.CreateDepartAsync(dept);
        }

        public async Task<ICollection<Department>> GetDepartmentsAsync()
        {
          return await _departmentReporsitory.GetDepartmentsAsync();
        }

        public async Task<Department> GetDeptartmentByIdAsync(int Id)
        {
            return await _departmentReporsitory.GetDepartmentByIDAsync(Id);
        }

        public async Task<bool> HardDeleteDeptAsync(Department departmentDTO)
        {
            return await _departmentReporsitory.HardDeleteDeptAsync(departmentDTO);
        }

        public async Task<bool> UpdateDepartmentAsync(Department updateDeptDto)
        {
            return await _departmentReporsitory.UpdateDepatAsync(updateDeptDto);
        }
    }
}
