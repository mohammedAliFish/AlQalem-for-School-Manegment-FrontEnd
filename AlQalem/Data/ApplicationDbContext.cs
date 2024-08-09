using AlQalem.Models;
using Microsoft.EntityFrameworkCore;

namespace AlQalem.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        // DbSets for each entity
        public DbSet<School> Schools { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<StudentStatus> StudentStatuses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<AcademicYear> AcademicYears { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Attachment> Attachments { get; set; }
        public DbSet<StudentAttachment> StudentAttachments { get; set; }
        public DbSet<ClassSubjectTeacher> ClassSubjectTeachers { get; set; }
        public DbSet<ClassTeacher> ClassTeachers { get; set; }
        public DbSet<TeacherSubject> TeacherSubjects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure composite keys
            modelBuilder.Entity<RolePermission>()
                .HasKey(rp => new { rp.RoleId, rp.PermissionId });

            modelBuilder.Entity<ClassTeacher>()
                .HasKey(ct => new { ct.ClassId, ct.TeacherId });

            modelBuilder.Entity<TeacherSubject>()
                .HasKey(ts => new { ts.TeacherId, ts.SubjectId });

            // one to many 
            modelBuilder.Entity<School>()
                .HasMany(s => s.Classes)
                .WithOne(c => c.School)
                .HasForeignKey(c => c.SchoolId)
                .OnDelete(DeleteBehavior.NoAction); 

            modelBuilder.Entity<Class>()
                .HasMany(c => c.Students)
                .WithOne(s => s.Class)
                .HasForeignKey(s => s.ClassId)
                .OnDelete(DeleteBehavior.NoAction); 

            modelBuilder.Entity<Class>()
                .HasMany(c => c.ClassSubjectTeachers)
                .WithOne(cst => cst.Class)
                .HasForeignKey(cst => cst.ClassId)
                .OnDelete(DeleteBehavior.NoAction); 

            modelBuilder.Entity<Teacher>()
                .HasMany(t => t.ClassTeachers)
                .WithOne(ct => ct.Teacher)
                .HasForeignKey(ct => ct.TeacherId)
                .OnDelete(DeleteBehavior.NoAction); 

            modelBuilder.Entity<Teacher>()
                .HasMany(t => t.TeacherSubjects)
                .WithOne(ts => ts.Teacher)
                .HasForeignKey(ts => ts.TeacherId)
                .OnDelete(DeleteBehavior.NoAction); 

            modelBuilder.Entity<Subject>()
                .HasMany(s => s.ClassSubjectTeachers)
                .WithOne(cst => cst.Subject)
                .HasForeignKey(cst => cst.SubjectId)
                .OnDelete(DeleteBehavior.NoAction); 

            modelBuilder.Entity<Student>()
                .HasMany(s => s.Grades)
                .WithOne(g => g.Student)
                .HasForeignKey(g => g.StudentId)
                .OnDelete(DeleteBehavior.NoAction); 

            modelBuilder.Entity<Student>()
                .HasMany(s => s.StudentAttachments)
                .WithOne(sa => sa.Student)
                .HasForeignKey(sa => sa.StudentId)
                .OnDelete(DeleteBehavior.NoAction); 

            modelBuilder.Entity<Attachment>()
                .HasMany(a => a.StudentAttachments)
                .WithOne(sa => sa.Attachment)
                .HasForeignKey(sa => sa.AttachmentId)
                .OnDelete(DeleteBehavior.NoAction); 

            modelBuilder.Entity<Role>()
                .HasMany(r => r.Users)
                .WithOne(u => u.Role)
                .HasForeignKey(u => u.RoleId)
                .OnDelete(DeleteBehavior.NoAction); 

            modelBuilder.Entity<Role>()
                .HasMany(r => r.RolePermissions)
                .WithOne(rp => rp.Role)
                .HasForeignKey(rp => rp.RoleId)
                .OnDelete(DeleteBehavior.NoAction); 

            modelBuilder.Entity<Permission>()
                .HasMany(p => p.RolePermissions)
                .WithOne(rp => rp.Permission)
                .HasForeignKey(rp => rp.PermissionId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<AcademicYear>()
                .HasMany(a => a.Grades)
                .WithOne(g => g.AcademicYear)
                .HasForeignKey(g => g.AcademicYearId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<StudentStatus>()
                .HasMany(ss => ss.Students)
                .WithOne(s => s.Status)
                .HasForeignKey(s => s.StatusId)
                .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<Grade>()
               .Property(g => g.Score)
               .HasColumnType("decimal(18,2)");



            // one to one
            modelBuilder.Entity<Teacher>()
                .HasOne(t => t.User)
                .WithOne(u => u.Teacher)
                .HasForeignKey<Teacher>(t => t.UserId)
                .OnDelete(DeleteBehavior.NoAction);
        }

    }
}
