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
    public class StudentController : ControllerBase
    {
       // private readonly StudentMngContext _context;
        private readonly IStudentSevice _studentService; 
        public StudentController(IStudentSevice studentSevice)
        {
            _studentService = studentSevice;
        }

        //Get api/Student
        [HttpGet]
        public async Task<IEnumerable<Student>> GetStudents()
        {
            return await _studentService.GetStudentAsync();
        }
        //Get api/ student/id
        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetStudentById(int id)
        {
            var std = await _studentService.GetStudentByIdAsync(id);

            if (std == null)
            {
                return NotFound();
            }

            return std;
        }

        //post student
        [HttpPost]
        public async Task<ActionResult<bool>> PostStudent(Student std)
        {
            return await _studentService.AddStudentAsync(std);
          
        }

        //put student
        [HttpPut("{id}")]
        public async Task<ActionResult<bool>> PutStudent(int id, Student std)
        {
            if (id != std.Id)
            {
                return BadRequest();
            }

            return await _studentService.UpdateStudentAsync(std);  

            
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteStudent(int id)
        {
            var std = await _studentService.GetStudentByIdAsync(id);
            if (std == null)
            {
                NotFound();
            }

            return await _studentService.HardStudentAsync(std);
        }


    }

}
