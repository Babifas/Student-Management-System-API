using Student_Management_System_API.Models;

namespace Student_Management_System_API.Services
{
    public interface ICourseService
    {
        List<Course> GetAllCourses();
        void AddCourse(CourseUpadateDto coursedto);
    }
}
