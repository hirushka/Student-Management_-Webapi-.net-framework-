using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI2.Models;

namespace WebAPI2.Service.Contract
{
    public interface IDepartmentSerivce
    {
        /// <summary>
        /// Return list of companies which are not marked as deleted.
        /// </summary>
        /// <returns>List Of CompanyDto</returns>
        Task<ICollection<Department>> GetDepartmentsAsync();
        /// <summary>
        /// Return company record.
        /// </summary>
        // <param name="Id"></param>
        /// <returns>CompanyDto</returns>
        Task<Department> GetDeptartmentByIdAsync(int Id);
        /// <summary>
        /// Add new company record in db
        /// </summary>
        // <param name="createCompanyDto"></param>
        /// <returns>CompanyDto</returns>
        Task<bool> AddDepartmentAsync(Department dept);
        /// <summary>
        /// Update company record
        /// </summary>
        // <param name="updateCompanyDto"></param>
        /// <returns>CompanyDto</returns>
        Task<bool> UpdateDepartmentAsync(Department updateDeptDto);
        Task<bool> HardDeleteDeptAsync(Department departmentDTO);



    }
}
