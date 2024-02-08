using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Student_Management_System_API.Data;
using Student_Management_System_API.Models;

namespace Student_Management_System_API.Services
{
    public class CourseService:ICourseService
    {
        private readonly StudentDbContext _contex;
        private readonly IMapper _mapper;
        public CourseService(StudentDbContext studentDbContext, IMapper mapper)
        {
            _contex = studentDbContext;
            _mapper = mapper;
        }
        public List<Course> GetAllCourses()
        {
            var res=_contex.Courses.Include(c=>c.students).ToList();
            var courses=res.Select(c => new Course
            {
                CourseId = c.CourseId,
                CourseName = c.CourseName,
                TeacherName = c.TeacherName,
                students = c.students.Select(s => new Student
                {
                    studentId=s.studentId,
                    Name = s.Name,
                    Age = s.Age,
                    CourseId = s.CourseId,

                }).ToList(),
            });
            return courses.ToList();
        }
        public void AddCourse(CourseUpadateDto coursedto)
        {
            var course=_mapper.Map<Course>(coursedto);
            _contex.Courses.Add(course);
            _contex.SaveChanges();
        }
    }
}
