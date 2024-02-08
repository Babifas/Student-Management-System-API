using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Student_Management_System_API.Models;
using Student_Management_System_API.Services;

namespace Student_Management_System_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            return Ok(_studentService.GetAllStudents());
        }
        [HttpGet("{id}")]
        public IActionResult GetStudentById(int id)
        {
            return Ok(_studentService.GetStudentById(id));
        }
        [HttpPost]
        public IActionResult AddStudent([FromBody] StudentUpdateDto studentdto)
        {
            _studentService.AddStudent(studentdto);
            return Ok("added successfully");
        }
        [HttpPut("{id}")]
        public IActionResult UpdateStudent([FromBody] StudentUpdateDto studentdto,int id)
        {
          _studentService.UpdateStudent(studentdto,id);
            return Ok("updated successfully");
        }
        [HttpDelete]
        public IActionResult DeleteStudentById(int id)
        {
            _studentService.DeleteStudent(id);
            return Ok("deleted successfully");
        }
        [HttpGet("GetStudentByName")]
        public IActionResult GetStudentByName(string name)
        {
            return Ok(_studentService.GetStudentsByName(name));
        }

    }
}
