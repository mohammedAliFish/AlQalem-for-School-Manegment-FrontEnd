﻿using AlQalem.Data;
using AlQalem.DTOs.Teacher;
using AlQalem.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;


namespace AlQalem.Services
{
    public class TeacherService : InterfaceTeacherService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public TeacherService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // Retrieve all teachers
        public async Task<IEnumerable<TeacherDTO>> GetTeachersAsync()
        {
            var teachers = await _context.Teachers
                .Include(t => t.User)
                .Include(t => t.ClassTeachers)
                .Include(t => t.TeacherSubjects)
                .ToListAsync();
            return _mapper.Map<IEnumerable<TeacherDTO>>(teachers);
        }

        

       
        public async Task<TeacherDTO> GetTeacherByIdAsync(Guid id)
        {
            var teacher = await _context.Teachers
                .Include(t => t.User) 
                .Include(t => t.ClassTeachers)
                .Include(t => t.TeacherSubjects)
                .FirstOrDefaultAsync(t => t.TeacherId == id);
            return _mapper.Map<TeacherDTO>(teacher);
        }

        
        public async Task<TeacherDTO> CreateTeacherAsync(CreateTeacherDTO createTeacherDto)
        {
            var teacher = _mapper.Map<Teacher>(createTeacherDto);
            _context.Teachers.Add(teacher);
            await _context.SaveChangesAsync();
            return _mapper.Map<TeacherDTO>(teacher);
        }

        
        public async Task<TeacherDTO> UpdateTeacherAsync(Guid id, UpdateTeacherDTO updateTeacherDto)
        {
            var teacher = await _context.Teachers.FindAsync(id);
            if (teacher == null) return null;

            _mapper.Map(updateTeacherDto, teacher);
            _context.Teachers.Update(teacher);
            await _context.SaveChangesAsync();
            return _mapper.Map<TeacherDTO>(teacher);
        }

        
        public async Task DeleteTeacherAsync(Guid id)
        {
            var teacher = await _context.Teachers.FindAsync(id);
            if (teacher == null) return;
            teacher.IsDeleted=true;
            _context.Teachers.Update(teacher);
            await _context.SaveChangesAsync();
        }
        public async Task<bool> CheckIfUserExistsAsync(Guid userId)
        {
            return await _context.Users.AnyAsync(u => u.UserId == userId);
        }
    }
}
