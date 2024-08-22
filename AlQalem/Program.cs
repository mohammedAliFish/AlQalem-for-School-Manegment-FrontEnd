﻿using AlQalem.Data;
using Microsoft.EntityFrameworkCore;
using AlQalem.Mappings;
using AlQalem.Services;
using AlQalem.Middlewares;
using AlQalem.Models;
using Microsoft.AspNetCore.Identity;
using AlQalem.Extentions;




var builder = WebApplication.CreateBuilder(args);
builder.Services.AddAutoMapper(typeof(MappingProfile));

// Add services to the container.

builder.Services.AddScoped<InterfaceSchoolService, SchoolService>();
builder.Services.AddScoped<InterfaceClassService, ClassService>();
builder.Services.AddScoped<InterfaceTeacherService, TeacherService>();
builder.Services.AddScoped<InterfaceStudentService, StudentService>();
builder.Services.AddScoped<InterfaceSubjectService, SubjectService>();
builder.Services.AddScoped<InterfaceGradeService, GradeService>();


builder.Services.AddIdentity<User,IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddCustomJwtAuth(builder.Configuration);
builder.Services.AddSwaggerGenJwtAuth();
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("myConnection")));




var app = builder.Build();

app.UseMiddleware<ExceptionHandler>();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();
