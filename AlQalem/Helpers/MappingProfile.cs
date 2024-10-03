using AutoMapper;
using AlQalem.Models;
using AlQalem.DTOs.School;
using AlQalem.DTOs.Class;
using AlQalem.DTOs.Grade;
using AlQalem.DTOs.Student;
using AlQalem.DTOs.Subject;
using AlQalem.DTOs.Teacher;

using AlQalem.DTOs.StudentAttachment;
using AlQalem.DTOs.GradeLevel;



namespace AlQalem.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            CreateMap<CreateClassDTO, Class>()
             .ForMember(dest => dest.ClassId, opt => opt.Ignore())
             .ForMember(dest => dest.ClassSubjectTeachers, opt => opt.Ignore()) 
             .ForMember(dest => dest.Students, opt => opt.Ignore()) 
             .ForMember(dest => dest.IsDeleted, opt => opt.Ignore()); 

       


            CreateMap<ClassSubjectTeacher, SubjectTeacherDto>().ReverseMap();



            CreateMap<Class, ClassDTO>()
               
                 .ForMember(dest => dest.Subjects, opt => opt.MapFrom(src => src.ClassSubjectTeachers.Select(cst => cst.Subject)))
                 .ForMember(dest => dest.Teachers, opt => opt.MapFrom(src => src.ClassSubjectTeachers.Select(cst => cst.Teacher)))

                
                .ReverseMap();

            CreateMap<CreateClassDTO, Class>().ReverseMap();
            CreateMap<UpdateClassDTO, Class>().ReverseMap();


            CreateMap<CreateTeacherDTO, Teacher>();
            CreateMap<Teacher, TeacherDTO>();
            CreateMap<UpdateTeacherDTO, Teacher>();





            CreateMap<Student, StudentDTO>()
                .ForMember(dest => dest.ClassName,opt =>opt.MapFrom(src => src.Class.Name))
                .ForMember(dest => dest.GradeLevelName, opt => opt.MapFrom(src => src.Class.GradeLevel.Name))

     .ReverseMap();

           
            CreateMap<CreateStudentDTO, Student>();

           
            CreateMap<UpdateStudentDTO, Student>();


            CreateMap<GradeLevels, GradeLevelDTO>().ForMember(dest => dest.LevelName, opt => opt.MapFrom(src => src.Name)).ReverseMap();
            CreateMap<CreateGradeLevelDTO, GradeLevels>();
            CreateMap<UpdateGradeLevelDTO, GradeLevels>();


            CreateMap<CreateGradeDTO, Grade>()
            .ForMember(dest => dest.GradeId, opt => opt.Ignore());

            CreateMap<Grade, GradeDTO>()
              .ForMember(dest => dest.StudentName, opt => opt.MapFrom(src => src.Student.Name))
              .ForMember(dest => dest.SubjectName, opt => opt.MapFrom(src => src.Subject.Name))
                 .ReverseMap();





            CreateMap<CreateGradeDTO, GradeDTO>()   
                .ReverseMap();

            CreateMap<CreateSubjectDTO, Subject>();
            CreateMap<Subject, SubjectDTO>();
       
           
            CreateMap<UpdateSubjectDTO, Subject>();

           

           


            CreateMap<School, SchoolDTO>()
           .ForMember(dest => dest.LogoPath, opt => opt.MapFrom(src => src.LogoPath));
            CreateMap<CreateSchoolDTO, SchoolDTO>();

            CreateMap<StudentAttachment, StudentAttachmentDTO>()
               .ReverseMap();

            CreateMap<CreateStudentAttachmentDTO, StudentAttachment>();
            CreateMap<UpdateStudentAttachmentDTO, StudentAttachment>();



        }

    }
}
