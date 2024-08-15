using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AlQalem.Migrations
{
    /// <inheritdoc />
    public partial class SeedAcadimcYear : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClassSubjectTeachers_Subjects_SubjectId",
                table: "ClassSubjectTeachers");

            migrationBuilder.DropForeignKey(
                name: "FK_Grades_Students_StudentId",
                table: "Grades");

            migrationBuilder.DropForeignKey(
                name: "FK_Grades_Subjects_SubjectId",
                table: "Grades");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentAttachments_Students_StudentId",
                table: "StudentAttachments");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("004b728f-1d05-40b5-af96-4ccb2c7e025e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("166aebe3-16e2-47cf-9971-8c43aeee4caa"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("c3cb7440-c7ad-44f7-82c0-7973f32ce767"));

            migrationBuilder.DeleteData(
                table: "StudentStatuses",
                keyColumn: "StudentStatusId",
                keyValue: new Guid("09520c7f-41a6-44ee-89cc-fe92bc8a1e3b"));

            migrationBuilder.DeleteData(
                table: "StudentStatuses",
                keyColumn: "StudentStatusId",
                keyValue: new Guid("266a9dc0-744e-4e98-803a-d5bd24476186"));

            migrationBuilder.DeleteData(
                table: "StudentStatuses",
                keyColumn: "StudentStatusId",
                keyValue: new Guid("86c60cb3-f2f3-46b5-a01a-e8b8b2f7b076"));

            migrationBuilder.DeleteData(
                table: "StudentStatuses",
                keyColumn: "StudentStatusId",
                keyValue: new Guid("9efb9ce3-391e-43c5-b400-68a00159192f"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "Name" },
                values: new object[,]
                {
                    { new Guid("415e4c09-a835-4e4c-8209-6e55eb92c897"), "Student" },
                    { new Guid("5733bc2b-4254-4026-adbf-d89ff3606fbd"), "Teacher" },
                    { new Guid("d1aa7a6a-7638-4a10-8488-a886a42c54b2"), "Admin" }
                });

            migrationBuilder.InsertData(
                table: "StudentStatuses",
                columns: new[] { "StudentStatusId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("390a5c83-6d17-408e-9d00-58757d133331"), false, "Ongoing" },
                    { new Guid("784decec-e5bd-4421-bba6-8adad08a0546"), false, "Expelled" },
                    { new Guid("8d3e1001-6a50-4e4c-b66a-770ab7a3c0e2"), false, "Transferred" },
                    { new Guid("f50505cc-b51e-4c7a-a948-ceaa9230d17b"), false, "Interrupted" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ClassSubjectTeachers_Subjects_SubjectId",
                table: "ClassSubjectTeachers",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "SubjectId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_Students_StudentId",
                table: "Grades",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_Subjects_SubjectId",
                table: "Grades",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "SubjectId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentAttachments_Students_StudentId",
                table: "StudentAttachments",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClassSubjectTeachers_Subjects_SubjectId",
                table: "ClassSubjectTeachers");

            migrationBuilder.DropForeignKey(
                name: "FK_Grades_Students_StudentId",
                table: "Grades");

            migrationBuilder.DropForeignKey(
                name: "FK_Grades_Subjects_SubjectId",
                table: "Grades");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentAttachments_Students_StudentId",
                table: "StudentAttachments");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("415e4c09-a835-4e4c-8209-6e55eb92c897"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("5733bc2b-4254-4026-adbf-d89ff3606fbd"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("d1aa7a6a-7638-4a10-8488-a886a42c54b2"));

            migrationBuilder.DeleteData(
                table: "StudentStatuses",
                keyColumn: "StudentStatusId",
                keyValue: new Guid("390a5c83-6d17-408e-9d00-58757d133331"));

            migrationBuilder.DeleteData(
                table: "StudentStatuses",
                keyColumn: "StudentStatusId",
                keyValue: new Guid("784decec-e5bd-4421-bba6-8adad08a0546"));

            migrationBuilder.DeleteData(
                table: "StudentStatuses",
                keyColumn: "StudentStatusId",
                keyValue: new Guid("8d3e1001-6a50-4e4c-b66a-770ab7a3c0e2"));

            migrationBuilder.DeleteData(
                table: "StudentStatuses",
                keyColumn: "StudentStatusId",
                keyValue: new Guid("f50505cc-b51e-4c7a-a948-ceaa9230d17b"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "Name" },
                values: new object[,]
                {
                    { new Guid("004b728f-1d05-40b5-af96-4ccb2c7e025e"), "Admin" },
                    { new Guid("166aebe3-16e2-47cf-9971-8c43aeee4caa"), "Teacher" },
                    { new Guid("c3cb7440-c7ad-44f7-82c0-7973f32ce767"), "Student" }
                });

            migrationBuilder.InsertData(
                table: "StudentStatuses",
                columns: new[] { "StudentStatusId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("09520c7f-41a6-44ee-89cc-fe92bc8a1e3b"), false, "Ongoing" },
                    { new Guid("266a9dc0-744e-4e98-803a-d5bd24476186"), false, "Transferred" },
                    { new Guid("86c60cb3-f2f3-46b5-a01a-e8b8b2f7b076"), false, "Expelled" },
                    { new Guid("9efb9ce3-391e-43c5-b400-68a00159192f"), false, "Interrupted" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ClassSubjectTeachers_Subjects_SubjectId",
                table: "ClassSubjectTeachers",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_Students_StudentId",
                table: "Grades",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_Subjects_SubjectId",
                table: "Grades",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "SubjectId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentAttachments_Students_StudentId",
                table: "StudentAttachments",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
