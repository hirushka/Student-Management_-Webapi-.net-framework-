using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI2.Models;
using WebAPI2.Service.Contract;

namespace WebAPI2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        //private readonly StudentMngContext _context;
        private readonly IDepartmentSerivce _departmentService;

        public DepartmentController(IDepartmentSerivce departmentSerivce)
        {
            _departmentService = departmentSerivce;
        }

        [HttpGet]
        public async Task<IEnumerable<Department>> GetDepartments()
        {
            return await _departmentService.GetDepartmentsAsync();
        }
        //Get api/ course/id
        [HttpGet("{id}")]
        public async Task<ActionResult<Department>> GetDeptById(int id)
        {
            var dept = await _departmentService.GetDeptartmentByIdAsync(id);

            if (dept == null)
            {
                return NotFound();
            }

            return dept;
        }

        //post student
        [HttpPost]
        public async Task<ActionResult<bool>> PostDepartment(Department dept)
        {
            return await _departmentService.AddDepartmentAsync(dept);
            
            //return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
            
        }
    }

}
