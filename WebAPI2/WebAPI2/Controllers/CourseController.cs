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
    public class CourseController : ControllerBase
    {
        //private readonly StudentMngContext _context;
        private readonly ICourseService _courseService;
        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }


        [HttpGet]
        public async Task<IEnumerable<Course>> GetCourses()
        {
            return await _courseService.GetCoursesAsync();
        }
        //Get api/ course/id
        [HttpGet("{id}")]
        public async Task<ActionResult<Course>> GetCourseById(int id)
        {
            var crs = await _courseService.GetCourseByIdAsync(id);

            if (crs == null)
            {
                return NotFound();
            }

            return crs;
        }

        //post student
        [HttpPost]
        public async Task<ActionResult<bool>> PostCourse(Course crs)
        {
            return await _courseService.AddCourseAsync(crs);
            
        }
    }
}
