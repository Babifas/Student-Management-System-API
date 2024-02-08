using Microsoft.EntityFrameworkCore;
using Student_Management_System_API.Models;

namespace Student_Management_System_API.Data
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext(DbContextOptions options):base(options) 
        { 
        
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
               .HasOne(s => s.Course)
               .WithMany(c => c.students)
               .HasForeignKey(s => s.CourseId);
                      
        }
    }
}
