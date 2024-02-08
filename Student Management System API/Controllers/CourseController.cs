using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Student_Management_System_API.Models;
using Student_Management_System_API.Services;

namespace Student_Management_System_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;
        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }
        [HttpGet]
        public IActionResult GetAllCourse() 
        {
            return Ok(_courseService.GetAllCourses());
        }
        [HttpPost]
        public IActionResult AddCourse(CourseUpadateDto coursedto)
        {
            _courseService.AddCourse(coursedto);
            return Ok("Added successfully");
        }
    }
}
