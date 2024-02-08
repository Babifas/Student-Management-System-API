using System.ComponentModel.DataAnnotations;

namespace Student_Management_System_API.Models
{
    public class CourseStudentsDto
    {
        [Key]
        public int studentId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public int CourseId { get; set; }

    }
}
