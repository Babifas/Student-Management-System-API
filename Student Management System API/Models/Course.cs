using System.ComponentModel.DataAnnotations;

namespace Student_Management_System_API.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string? CourseName { get; set; }
        public string? TeacherName {  get; set; }
        public List<Student> students { get; set; }

    }
}
