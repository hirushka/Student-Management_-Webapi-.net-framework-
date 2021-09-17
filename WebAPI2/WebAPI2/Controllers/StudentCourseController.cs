using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    [EnableCors("MyCorsImplementationPolicy")]
  //  [EnableCors(origins: "http://mywebclient.azurewebsites.net", headers: "*", methods: "*")]
    public class StudentCourseController : ControllerBase
    {
        private readonly IStudentCourseService _studentCourseService;

        public StudentCourseController(IStudentCourseService studentCourseService)
        {
            _studentCourseService = studentCourseService;  
        }

       
        //Get api/ course/id
        [HttpGet("{id}")]
        public async Task<IEnumerable<Student_Course>> GetCourseBySId(int id)
        {
            return await _studentCourseService.GetStudentCourseBySIDAsync(id);
  
        }

        //post student
        [HttpPost]
        public async Task<ActionResult<bool>> PostCourse(Student_Course crs)
        {
            return await _studentCourseService.CreateStudentCourseAsync(crs);

        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteStudent(int id)
        {
            var std = await _studentCourseService.GetStudentCourseById(id);
            if (std == null)
            {
                NotFound();
            }

            return await _studentCourseService.HardDeleteStudentCourseAsync(std);
        }
    }
}
