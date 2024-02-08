using AutoMapper;
using Student_Management_System_API.Models;

namespace Student_Management_System_API.Mapper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile() 
        {
           CreateMap<Student,StudentUpdateDto>().ReverseMap();
            CreateMap<Student,CourseStudentsDto>().ReverseMap();
            CreateMap<Course,CourseUpadateDto>().ReverseMap();
        }
    }
}
