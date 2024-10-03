using AlQalem.Data;
using Microsoft.EntityFrameworkCore;
using AlQalem.Mappings;
using AlQalem.Services;
using AlQalem.Middlewares;
using AlQalem.Models;
using Microsoft.AspNetCore.Identity;
using AlQalem.Extentions;
using AlQalem.Seeders;
using AlQalem.ServiceInterfaces;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddAutoMapper(typeof(MappingProfile));

builder.Services.AddScoped<InterfaceSchoolService, SchoolService>();
builder.Services.AddScoped<InterfaceClassService, ClassService>();
builder.Services.AddScoped<InterfaceTeacherService, TeacherService>();
builder.Services.AddScoped<InterfaceStudentService, StudentService>();
builder.Services.AddScoped<InterfaceSubjectService, SubjectService>();
builder.Services.AddScoped<InterfaceGradeService, GradeService>();
builder.Services.AddScoped<InterfaceGradeLevelService, GradeLevelService>();

builder.Services.AddIdentity<User, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
       
        options.JsonSerializerOptions.Converters.Add(new System.Text.Json.Serialization.JsonStringEnumConverter());
    });
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddCustomJwtAuth(builder.Configuration);
builder.Services.AddSwaggerGenJwtAuth();
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("myConnection")));


builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin",
        builder => builder
            .WithOrigins("http://localhost:5173") 
            .AllowAnyMethod()
            .AllowAnyHeader());
});

var app = builder.Build();

app.UseMiddleware<ExceptionHandler>();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseCors("AllowSpecificOrigin");

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<ApplicationDbContext>();
    context.Database.Migrate();
}

using (var scope = app.Services.CreateScope())
{
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<User>>();
    var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

    
    await AcademicYearSeeder.Seed(context);
    await GradeLevelSeeder.Seed(context);
    await StudentStatusSeeder.Seed(context);

    await RoleSeeder.SeedRoles(roleManager);
    await UserSeeder.SeedUsers(userManager, roleManager);
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();
