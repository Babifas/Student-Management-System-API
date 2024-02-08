namespace Student_Management_System_API.Models
{
    public class StudentUpdateDto
    {
        
        public string Name { get; set; }
        public int Age { get; set; }
      // public DateOnly Dob { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public int Password { get; set; }
        public int CourseId { get; set; }

    }
}
