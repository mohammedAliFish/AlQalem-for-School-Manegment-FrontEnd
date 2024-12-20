﻿using AlQalem.DTOs.Class;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using AlQalem.Models;
using AlQalem.Exceptions;
using AlQalem.Exceptions.ClassExceptions;
using Microsoft.AspNetCore.Authorization;
using AlQalem.DTOs.Teacher;
namespace AlQalem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class ClassesController : ControllerBase
    {
        private readonly InterfaceClassService _classService;
        private readonly IMapper _mapper;

        public ClassesController(InterfaceClassService classService, IMapper mapper)
        {
            _classService = classService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClassDTO>>> GetClasses()
        {
            var classes = await _classService.GetAllClassesAsync();
            var classDtos = _mapper.Map<IEnumerable<ClassDTO>>(classes);
            return Ok(classDtos);

          //  return CreatedAtAction(nameof(GetTeacher), new { id = teacherDTO.TeacherId }, teacherDTO);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ClassDTO>> GetClassById(Guid id)
        {
            var classEntity = await _classService.GetClassByIdAsync(id);

            if (classEntity == null)
            {
                throw new NotFoundException();
            }

            var classDto = _mapper.Map<ClassDTO>(classEntity);
            return Ok(classDto);
        }

        [HttpPost]
        public async Task<ActionResult<ClassDTO>> CreateClass([FromBody] CreateClassDTO createClassDto)
        {
            if (createClassDto == null)
            {
                return BadRequest("البيانات المدخلة غير صحيحة.");
            }

            var classEntity = _mapper.Map<Class>(createClassDto);
            var createdClass = await _classService.CreateClassAsync(createClassDto);

            var ClassDto = _mapper.Map<ClassDTO>(createdClass);

            return CreatedAtAction(nameof(GetClassById), new { id = ClassDto.ClassId }, ClassDto);
        }



        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateClass(Guid id, [FromBody] UpdateClassDTO updateClassDTO)
        {

            var classEntity = _mapper.Map<Class>(updateClassDTO);
            var updatedClass = await _classService.UpdateClassAsync(id, updateClassDTO);

            if (updatedClass == null)
            {
                throw new ClassNotFoundException();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClass(Guid id)
        {
            await _classService.DeleteClassAsync(id);
            return NoContent();
        }

      
    }
}
