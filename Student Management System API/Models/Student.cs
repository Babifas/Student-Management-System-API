using System.ComponentModel.DataAnnotations;

namespace Student_Management_System_API.Models
{
    public class Student
    {
        [Key]
        public int studentId {  get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
       // public DateOnly Dob {  get; set; }
        public string  Email { get; set; }
        public int PhoneNumber { get; set; }
        public int Password {  get; set; }
        public int CourseId {  get; set; }
        public Course Course { get; set; }
        

    }
}
