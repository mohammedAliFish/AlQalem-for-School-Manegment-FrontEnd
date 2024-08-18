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
    [Migration("20240817200242_AddGradeTypeToGrade")]
    partial class AddGradeTypeToGrade
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
                            AcademicYearId = new Guid("3127bce4-cfb2-4479-be8a-f1996ed17a83"),
                            Year = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AcademicYearId = new Guid("55e37b09-d6a5-436f-9674-e62814e13575"),
                            Year = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AcademicYearId = new Guid("ffdda266-9172-4286-8048-74223cdacde4"),
                            Year = new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AcademicYearId = new Guid("19186c5c-eaa7-4f1d-a742-df57489788c2"),
                            Year = new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AcademicYearId = new Guid("ae195ee0-dce9-4983-b766-0b7a95cd142d"),
                            Year = new DateTime(2027, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AcademicYearId = new Guid("810546ba-01fb-4b71-b603-3cac8fca64e8"),
                            Year = new DateTime(2028, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AcademicYearId = new Guid("c2a212eb-77e8-4c29-ae2f-235f3c2df372"),
                            Year = new DateTime(2029, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AcademicYearId = new Guid("7b7fdfd1-2a2c-483e-9bb6-1ab166b868e1"),
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
                            GradeLevelId = new Guid("a6f533ac-4f3f-4624-81e4-7ff9f881b314"),
                            Name = "الاول متوسط"
                        },
                        new
                        {
                            GradeLevelId = new Guid("3b1704eb-8810-42d6-aae6-39dd58f30c8e"),
                            Name = "الثاني متوسط"
                        },
                        new
                        {
                            GradeLevelId = new Guid("1330be0c-b393-4c42-9177-83ddb693963e"),
                            Name = "الثالث متوسط "
                        });
                });

            modelBuilder.Entity("AlQalem.Models.Permission", b =>
                {
                    b.Property<Guid>("PermissionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PermissionNumber")
                        .HasColumnType("int");

                    b.HasKey("PermissionId");

                    b.ToTable("Permissions");

                    b.HasData(
                        new
                        {
                            PermissionId = new Guid("a7f5d1f8-6b57-4d5e-8ed1-76e2d6e9f0c3"),
                            Name = "View",
                            PermissionNumber = 0
                        },
                        new
                        {
                            PermissionId = new Guid("b7f5d1f8-6b57-4d5e-8ed1-76e2d6e9f0c3"),
                            Name = "Create",
                            PermissionNumber = 0
                        },
                        new
                        {
                            PermissionId = new Guid("c7f5d1f8-6b57-4d5e-8ed1-76e2d6e9f0c3"),
                            Name = "Edit",
                            PermissionNumber = 0
                        },
                        new
                        {
                            PermissionId = new Guid("d7f5d1f8-6b57-4d5e-8ed1-76e2d6e9f0c3"),
                            Name = "Delete",
                            PermissionNumber = 0
                        });
                });

            modelBuilder.Entity("AlQalem.Models.Role", b =>
                {
                    b.Property<Guid>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            RoleId = new Guid("6afab5be-06f7-48bb-9925-0bd27a16dd83"),
                            Name = "Admin"
                        },
                        new
                        {
                            RoleId = new Guid("b03cc6d2-c799-4185-8d39-c3042a9bc132"),
                            Name = "Teacher"
                        },
                        new
                        {
                            RoleId = new Guid("e3234635-4f81-4406-ba19-28d448ec6c16"),
                            Name = "Student"
                        },
                        new
                        {
                            RoleId = new Guid("b7f5d1f8-6b57-4d5e-8ed1-76e2d6e9f0c3"),
                            Name = "Admin"
                        },
                        new
                        {
                            RoleId = new Guid("c7f5d1f8-6b57-4d5e-8ed1-76e2d6e9f0c3"),
                            Name = "Teacher"
                        },
                        new
                        {
                            RoleId = new Guid("d7f5d1f8-6b57-4d5e-8ed1-76e2d6e9f0c3"),
                            Name = "Student"
                        });
                });

            modelBuilder.Entity("AlQalem.Models.RolePermission", b =>
                {
                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PermissionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("RoleId", "PermissionId");

                    b.HasIndex("PermissionId");

                    b.ToTable("RolePermissions");
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
                            StudentStatusId = new Guid("0e79efb1-3075-45d5-833d-8b50b1e41bfe"),
                            IsDeleted = false,
                            Name = "Ongoing"
                        },
                        new
                        {
                            StudentStatusId = new Guid("0763e3b3-4d7a-4009-85cf-873224a7080e"),
                            IsDeleted = false,
                            Name = "Transferred"
                        },
                        new
                        {
                            StudentStatusId = new Guid("cb4d9552-7720-4c94-a4c8-18b8ad76466d"),
                            IsDeleted = false,
                            Name = "Expelled"
                        },
                        new
                        {
                            StudentStatusId = new Guid("5db99a82-618b-4c62-9f73-a6717fbda980"),
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

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("TeacherId");

                    b.HasIndex("UserId")
                        .IsUnique();

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
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
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

            modelBuilder.Entity("AlQalem.Models.RolePermission", b =>
                {
                    b.HasOne("AlQalem.Models.Permission", "Permission")
                        .WithMany("RolePermissions")
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("AlQalem.Models.Role", "Role")
                        .WithMany("RolePermissions")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Permission");

                    b.Navigation("Role");
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

            modelBuilder.Entity("AlQalem.Models.Teacher", b =>
                {
                    b.HasOne("AlQalem.Models.User", "User")
                        .WithOne("Teacher")
                        .HasForeignKey("AlQalem.Models.Teacher", "UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("User");
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

            modelBuilder.Entity("AlQalem.Models.User", b =>
                {
                    b.HasOne("AlQalem.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Role");
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

            modelBuilder.Entity("AlQalem.Models.Permission", b =>
                {
                    b.Navigation("RolePermissions");
                });

            modelBuilder.Entity("AlQalem.Models.Role", b =>
                {
                    b.Navigation("RolePermissions");

                    b.Navigation("Users");
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

            modelBuilder.Entity("AlQalem.Models.User", b =>
                {
                    b.Navigation("Teacher")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}