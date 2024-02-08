using Student_Management_System_API.Models;

namespace Student_Management_System_API.Services
{
    public interface IStudentService
    {
        List<Student> GetAllStudents();
        Student GetStudentById(int id);
        void AddStudent(StudentUpdateDto student);
        void UpdateStudent(StudentUpdateDto student, int id);
        void DeleteStudent(int id);
        List<Student> GetStudentsByName(string name);
    }
}
