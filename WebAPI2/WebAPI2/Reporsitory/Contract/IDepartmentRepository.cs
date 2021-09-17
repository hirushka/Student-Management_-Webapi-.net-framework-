using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI2.Models;

namespace WebAPI2.Reporsitory.Contract
{
    public interface IDepartmentRepository
    {
        /// <summary>
        /// Return list of companies which are not marked as deleted.
        /// </summary>
        /// <returns>Entites.Company</returns>
        Task<ICollection<Department>> GetDepartmentsAsync();

        /// <summary>
        /// Return a company record
        /// </summary>
        // <param name="CompanyId"></param>
        /// <returns>Entites.Company</returns>
        Task<Department> GetDepartmentByIDAsync(int id);

        /// <summary>
        /// Add a new record for company
        /// </summary>
        // <param name="company"></param>
        /// <returns>bool</returns>
        Task<bool> CreateDepartAsync(Department dept);
        /// <summary>
        /// Update a record in db
        /// </summary>
        // <param name="company"></param>
        /// <returns>bool</returns>
        Task<bool> UpdateDepatAsync(Department dept);
        /// <summary>
        /// Permanently remove a record from db
        /// </summary>
        // <param name="company"></param>
        /// <returns></returns>
        Task<bool> HardDeleteDeptAsync(Department dept);
    }
}
