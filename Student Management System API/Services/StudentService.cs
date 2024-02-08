using AutoMapper;
using Student_Management_System_API.Data;
using Student_Management_System_API.Models;

namespace Student_Management_System_API.Services
{
    public class StudentService:IStudentService
    {
        private readonly StudentDbContext _context;
        private readonly IMapper _mapper;
        public StudentService(StudentDbContext studentDbContext, IMapper mapper)
        {
            _context = studentDbContext;
            _mapper = mapper;
        }
        public List<Student> GetAllStudents()
        {
            return _context.Students.ToList();
         }
        public Student GetStudentById(int id)
        {
            return _context.Students.Find(id);
             
        }
        public void AddStudent(StudentUpdateDto student)
        {
           var std= _mapper.Map<Student>(student);
            _context.Students.Add(std);
            _context.SaveChanges();
        }
        public void UpdateStudent(StudentUpdateDto student, int id)
        {
           var std=_context.Students.Find(id);
            std.Name = student.Name;
            std.CourseId = student.CourseId;
            std.Age = student.Age;
            std.PhoneNumber = student.PhoneNumber;
            std.Email = student.Email;
        
            _context.SaveChanges();

        }
        public void DeleteStudent(int id)
        {
            var std = _context.Students.Find(id);
            _context.Students.Remove(std);
            _context.SaveChanges();
        }
    }
}
