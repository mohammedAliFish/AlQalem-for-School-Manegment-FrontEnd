using AlQalem.Models;
using AlQalem.Seeders;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace AlQalem.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }

        public DbSet<School> Schools { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
      
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
        public DbSet<GradeLevels> GradeLevels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure composite keys
            

            modelBuilder.Entity<ClassTeacher>()
                .HasKey(ct => new { ct.ClassId, ct.TeacherId });

            modelBuilder.Entity<TeacherSubject>()
                .HasKey(ts => new { ts.TeacherId, ts.SubjectId });

           

            modelBuilder.Entity<School>()
                .HasMany(s => s.Classes)
                .WithOne(c => c.School)
                .HasForeignKey(c => c.SchoolId)
                .OnDelete(DeleteBehavior.Restrict);

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

            modelBuilder.Entity<Class>()
                .HasMany(c => c.ClassTeachers)
                .WithOne(ct => ct.Class)
                .HasForeignKey(ct => ct.ClassId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Class>()
                .HasOne(c => c.GradeLevel)
                .WithMany(gl => gl.Classes)
                .HasForeignKey(c => c.GradeLevelId);

            modelBuilder.Entity<Grade>()
                .HasOne(g => g.GradeLevel)
                .WithMany(gl => gl.Grades)
                .HasForeignKey(g => g.GradeLevelId);

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
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Subject>()
                .HasMany(s => s.Grades)
                .WithOne(g => g.Subject)
                .HasForeignKey(g => g.SubjectId)
                .OnDelete(DeleteBehavior.Restrict);

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

            modelBuilder.Entity<Student>()
                .HasOne(s => s.Status)
                .WithMany(ss => ss.Students)
                .HasForeignKey(s => s.StatusId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Attachment>()
                .HasMany(a => a.StudentAttachments)
                .WithOne(sa => sa.Attachment)
                .HasForeignKey(sa => sa.AttachmentId)
                .OnDelete(DeleteBehavior.NoAction);

           

        


            modelBuilder.Entity<AcademicYear>()
                .HasMany(a => a.Grades)
                .WithOne(g => g.AcademicYear)
                .HasForeignKey(g => g.AcademicYearId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Grade>()
                .Property(g => g.Score)
                .HasColumnType("decimal(18,2)");

           

            // Global query filters
            modelBuilder.Entity<School>()
                .HasQueryFilter(s => !s.IsDeleted);

            modelBuilder.Entity<Class>()
                .HasQueryFilter(c => !c.IsDeleted);

            modelBuilder.Entity<ClassSubjectTeacher>()
                .HasQueryFilter(cst => !cst.Class.IsDeleted && !cst.Subject.IsDeleted);

            modelBuilder.Entity<ClassTeacher>()
                .HasQueryFilter(ct => !ct.Class.IsDeleted && !ct.Teacher.IsDeleted);

            modelBuilder.Entity<Student>()
                .HasQueryFilter(s => !s.IsDeleted);

            modelBuilder.Entity<GradeLevels>()
                .HasKey(gl => gl.GradeLevelId);

           
            // Seed data
          
            StudentStatusSeeder.Seed(modelBuilder);
            GradeLevelSeeder.Seed(modelBuilder);
            AcademicYearSeeder.Seed(modelBuilder);
        }
    }
}
