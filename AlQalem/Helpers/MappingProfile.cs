using AutoMapper;
using AlQalem.Models;
using AlQalem.DTOs.School;
using AlQalem.DTOs.Class;
using AlQalem.DTOs.Grade;
using AlQalem.DTOs.Student;
using AlQalem.DTOs.Subject;
using AlQalem.DTOs.Teacher;
using AlQalem.DTOs.User;
using AlQalem.DTOs.StudentAttachment;
using System.Diagnostics;
using AlQalem.DTOs.GradeLevel;


namespace AlQalem.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            
          

           
            CreateMap<Class, ClassDTO>()
                .ReverseMap();
            CreateMap<CreateClassDTO, Class>().ReverseMap();
            CreateMap<UpdateClassDTO, Class>().ReverseMap();


            CreateMap<CreateTeacherDTO, Teacher>();
            CreateMap<UpdateTeacherDTO, Teacher>().ForMember(dest => dest.TeacherId, opt => opt.Ignore());
            CreateMap<Teacher, TeacherDTO>();


            CreateMap<User, UserDTO>()
                .ReverseMap();
            CreateMap<CreateUserDTO, User>();
            CreateMap<UpdateUserDTO, User>();


            CreateMap<Student, StudentDTO>()
           .ReverseMap();
            CreateMap<CreateStudentDto, Student>();
            CreateMap<UpdateStudentDTO, Student>();


            CreateMap<GradeLevels, GradeLevelDTO>().ReverseMap();
            CreateMap<CreateGradeLevelDTO, GradeLevels>();
            CreateMap<UpdateGradeLevelDTO, GradeLevels>();


            CreateMap<CreateGradeDTO, Grade>()
            .ForMember(dest => dest.GradeId, opt => opt.Ignore());

            CreateMap<Grade, GradeDTO>();

            CreateMap<CreateGradeDTO, GradeDTO>()   
                .ReverseMap();


            CreateMap<Subject, SubjectDTO>().ReverseMap();
            CreateMap<CreateSubjectDTO, Subject>();
            CreateMap<UpdateSubjectDTO, Subject>();

            CreateMap<Grade, GradeDTO>()
                .ReverseMap();

            CreateMap<School, SchoolDTO>()
           .ForMember(dest => dest.LogoPath, opt => opt.MapFrom(src => src.LogoPath));

            CreateMap<StudentAttachment, StudentAttachmentDTO>()
               .ReverseMap();

            CreateMap<CreateStudentAttachmentDTO, StudentAttachment>();
            CreateMap<UpdateStudentAttachmentDTO, StudentAttachment>();



        }

    }
}
