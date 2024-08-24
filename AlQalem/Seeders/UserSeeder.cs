using AlQalem.Models;
using Microsoft.AspNetCore.Identity;


public static class UserSeeder
{
    public static async Task SeedUsers(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
    {
        // تحقق من الأدوار وأنشئها إذا لم تكن موجودة
        if (!await roleManager.RoleExistsAsync("Admin"))
        {
            await roleManager.CreateAsync(new IdentityRole("Admin"));
        }
        if (!await roleManager.RoleExistsAsync("Teacher"))
        {
            await roleManager.CreateAsync(new IdentityRole("Teacher"));
        }
        if (!await roleManager.RoleExistsAsync("Student"))
        {
            await roleManager.CreateAsync(new IdentityRole("Student"));
        }

        // إنشاء مستخدم مدير
        var adminUser = new User
        {
            UserName = "admin",
            Email = "admin@example.com" // إضافة البريد الإلكتروني
        };

        if (userManager.Users.All(u => u.UserName != adminUser.UserName))
        {
            var result = await userManager.CreateAsync(adminUser, "Admin123!");
            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(adminUser, "Admin");
            }
        }

        // إنشاء مستخدم مدرس
        var teacherUser = new User
        {
            UserName = "teacher",
            Email = "teacher@example.com" // إضافة البريد الإلكتروني
        };

        if (userManager.Users.All(u => u.UserName != teacherUser.UserName))
        {
            var result = await userManager.CreateAsync(teacherUser, "Teacher123!");
            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(teacherUser, "Teacher");
            }
        }

        // إنشاء مستخدم طالب
        var studentUser = new User
        {
            UserName = "student",
            Email = "student@example.com" // إضافة البريد الإلكتروني
        };

        if (userManager.Users.All(u => u.UserName != studentUser.UserName))
        {
            var result = await userManager.CreateAsync(studentUser, "Student123!");
            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(studentUser, "Student");
            }
        }
    }
}
