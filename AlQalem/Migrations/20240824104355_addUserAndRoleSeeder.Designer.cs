﻿// <auto-generated />
using System;
using AlQalem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AlQalem.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240824104355_addUserAndRoleSeeder")]
    partial class addUserAndRoleSeeder
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AlQalem.Models.AcademicYear", b =>
                {
                    b.Property<Guid>("AcademicYearId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Year")
                        .HasColumnType("datetime2");

                    b.HasKey("AcademicYearId");

                    b.ToTable("AcademicYears");

                    b.HasData(
                        new
                        {
                            AcademicYearId = new Guid("fab5ca9a-a437-4983-877e-47a154d61cbb"),
                            Year = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AcademicYearId = new Guid("49988a7b-5030-47c0-8d25-3c1268fdc50d"),
                            Year = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AcademicYearId = new Guid("55b0d654-0187-4705-b358-a023e3307abc"),
                            Year = new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AcademicYearId = new Guid("93f60a5e-f76c-4a4b-bf8c-9e830ad438c2"),
                            Year = new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AcademicYearId = new Guid("f78a0aca-40d3-4520-9c43-391b1f0dde38"),
                            Year = new DateTime(2027, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AcademicYearId = new Guid("3835f7fb-0b6f-42bc-847e-96597b9544cc"),
                            Year = new DateTime(2028, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AcademicYearId = new Guid("f0ce96e0-82c2-43e3-9fd9-07fbdf5824e3"),
                            Year = new DateTime(2029, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AcademicYearId = new Guid("d343028f-20b8-4d38-8738-6fa5d1ca4f08"),
                            Year = new DateTime(2030, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("AlQalem.Models.Attachment", b =>
                {
                    b.Property<Guid>("AttachmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FileExtension")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FileSize")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("AttachmentId");

                    b.ToTable("Attachments");
                });

            modelBuilder.Entity("AlQalem.Models.Class", b =>
                {
                    b.Property<Guid>("ClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GradeLevelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SchoolId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ClassId");

                    b.HasIndex("GradeLevelId");

                    b.HasIndex("SchoolId");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("AlQalem.Models.ClassSubjectTeacher", b =>
                {
                    b.Property<Guid>("ClassSubjectTeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClassId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SubjectId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TeacherId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ClassSubjectTeacherId");

                    b.HasIndex("ClassId");

                    b.HasIndex("SubjectId");

                    b.HasIndex("TeacherId");

                    b.ToTable("ClassSubjectTeachers");
                });

            modelBuilder.Entity("AlQalem.Models.ClassTeacher", b =>
                {
                    b.Property<Guid>("ClassId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TeacherId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ClassId", "TeacherId");

                    b.HasIndex("TeacherId");

                    b.ToTable("ClassTeachers");
                });

            modelBuilder.Entity("AlQalem.Models.GradeLevels", b =>
                {
                    b.Property<Guid>("GradeLevelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GradeLevelId");

                    b.ToTable("GradeLevels");

                    b.HasData(
                        new
                        {
                            GradeLevelId = new Guid("27c9c5a3-c154-4e58-9736-33cb8c22cdf6"),
                            Name = "الاول متوسط"
                        },
                        new
                        {
                            GradeLevelId = new Guid("7b41ac1c-3e97-4a41-a0c6-c7389d4b6ee7"),
                            Name = "الثاني متوسط"
                        },
                        new
                        {
                            GradeLevelId = new Guid("36f47bcc-c69b-41e1-9571-ab92d4da42a4"),
                            Name = "الثالث متوسط "
                        });
                });

            modelBuilder.Entity("AlQalem.Models.School", b =>
                {
                    b.Property<Guid>("SchoolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LogoPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("Type")
                        .HasColumnType("tinyint");

                    b.HasKey("SchoolId");

                    b.ToTable("Schools");
                });

            modelBuilder.Entity("AlQalem.Models.Student", b =>
                {
                    b.Property<Guid>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClassId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<Guid>("StatusId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("StudentId");

                    b.HasIndex("ClassId");

                    b.HasIndex("StatusId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("AlQalem.Models.StudentAttachment", b =>
                {
                    b.Property<Guid>("StudentAttachmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AttachmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsProfilePicture")
                        .HasColumnType("bit");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("StudentAttachmentId");

                    b.HasIndex("AttachmentId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentAttachments");
                });

            modelBuilder.Entity("AlQalem.Models.StudentStatus", b =>
                {
                    b.Property<Guid>("StudentStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentStatusId");

                    b.ToTable("StudentStatuses");

                    b.HasData(
                        new
                        {
                            StudentStatusId = new Guid("cc1a4666-0f46-4e01-94c1-4fffaf1a5a34"),
                            IsDeleted = false,
                            Name = "Ongoing"
                        },
                        new
                        {
                            StudentStatusId = new Guid("3ac5f658-6e3b-4cdd-a104-a648b9f148b5"),
                            IsDeleted = false,
                            Name = "Transferred"
                        },
                        new
                        {
                            StudentStatusId = new Guid("db59aca4-bae1-4d66-96c3-ca01bbe0b39e"),
                            IsDeleted = false,
                            Name = "Expelled"
                        },
                        new
                        {
                            StudentStatusId = new Guid("8806c169-87b0-48cf-9d6a-def57971302a"),
                            IsDeleted = false,
                            Name = "Interrupted"
                        });
                });

            modelBuilder.Entity("AlQalem.Models.Subject", b =>
                {
                    b.Property<Guid>("SubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubjectId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("AlQalem.Models.Teacher", b =>
                {
                    b.Property<Guid>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeacherId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("AlQalem.Models.TeacherSubject", b =>
                {
                    b.Property<Guid>("TeacherId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SubjectId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("TeacherId", "SubjectId");

                    b.HasIndex("SubjectId");

                    b.ToTable("TeacherSubjects");
                });

            modelBuilder.Entity("AlQalem.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Grade", b =>
                {
                    b.Property<Guid>("GradeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AcademicYearId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GradeLevelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("GradeType")
                        .HasColumnType("int");

                    b.Property<decimal>("Score")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SubjectId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("GradeId");

                    b.HasIndex("AcademicYearId");

                    b.HasIndex("GradeLevelId");

                    b.HasIndex("StudentId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("AlQalem.Models.Class", b =>
                {
                    b.HasOne("AlQalem.Models.GradeLevels", "GradeLevel")
                        .WithMany("Classes")
                        .HasForeignKey("GradeLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AlQalem.Models.School", "School")
                        .WithMany("Classes")
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("GradeLevel");

                    b.Navigation("School");
                });

            modelBuilder.Entity("AlQalem.Models.ClassSubjectTeacher", b =>
                {
                    b.HasOne("AlQalem.Models.Class", "Class")
                        .WithMany("ClassSubjectTeachers")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("AlQalem.Models.Subject", "Subject")
                        .WithMany("ClassSubjectTeachers")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("AlQalem.Models.Teacher", "Teacher")
                        .WithMany("ClassSubjectTeachers")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");

                    b.Navigation("Subject");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("AlQalem.Models.ClassTeacher", b =>
                {
                    b.HasOne("AlQalem.Models.Class", "Class")
                        .WithMany("ClassTeachers")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("AlQalem.Models.Teacher", "Teacher")
                        .WithMany("ClassTeachers")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Class");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("AlQalem.Models.Student", b =>
                {
                    b.HasOne("AlQalem.Models.Class", "Class")
                        .WithMany("Students")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("AlQalem.Models.StudentStatus", "Status")
                        .WithMany("Students")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("AlQalem.Models.StudentAttachment", b =>
                {
                    b.HasOne("AlQalem.Models.Attachment", "Attachment")
                        .WithMany("StudentAttachments")
                        .HasForeignKey("AttachmentId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("AlQalem.Models.Student", "Student")
                        .WithMany("StudentAttachments")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Attachment");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("AlQalem.Models.TeacherSubject", b =>
                {
                    b.HasOne("AlQalem.Models.Subject", "Subject")
                        .WithMany("TeacherSubjects")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AlQalem.Models.Teacher", "Teacher")
                        .WithMany("TeacherSubjects")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Subject");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Grade", b =>
                {
                    b.HasOne("AlQalem.Models.AcademicYear", "AcademicYear")
                        .WithMany("Grades")
                        .HasForeignKey("AcademicYearId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("AlQalem.Models.GradeLevels", "GradeLevel")
                        .WithMany("Grades")
                        .HasForeignKey("GradeLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AlQalem.Models.Student", "Student")
                        .WithMany("Grades")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("AlQalem.Models.Subject", "Subject")
                        .WithMany("Grades")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("AcademicYear");

                    b.Navigation("GradeLevel");

                    b.Navigation("Student");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("AlQalem.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("AlQalem.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AlQalem.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("AlQalem.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AlQalem.Models.AcademicYear", b =>
                {
                    b.Navigation("Grades");
                });

            modelBuilder.Entity("AlQalem.Models.Attachment", b =>
                {
                    b.Navigation("StudentAttachments");
                });

            modelBuilder.Entity("AlQalem.Models.Class", b =>
                {
                    b.Navigation("ClassSubjectTeachers");

                    b.Navigation("ClassTeachers");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("AlQalem.Models.GradeLevels", b =>
                {
                    b.Navigation("Classes");

                    b.Navigation("Grades");
                });

            modelBuilder.Entity("AlQalem.Models.School", b =>
                {
                    b.Navigation("Classes");
                });

            modelBuilder.Entity("AlQalem.Models.Student", b =>
                {
                    b.Navigation("Grades");

                    b.Navigation("StudentAttachments");
                });

            modelBuilder.Entity("AlQalem.Models.StudentStatus", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("AlQalem.Models.Subject", b =>
                {
                    b.Navigation("ClassSubjectTeachers");

                    b.Navigation("Grades");

                    b.Navigation("TeacherSubjects");
                });

            modelBuilder.Entity("AlQalem.Models.Teacher", b =>
                {
                    b.Navigation("ClassSubjectTeachers");

                    b.Navigation("ClassTeachers");

                    b.Navigation("TeacherSubjects");
                });
#pragma warning restore 612, 618
        }
    }
}