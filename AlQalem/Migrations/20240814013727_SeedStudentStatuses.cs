using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AlQalem.Migrations
{
    /// <inheritdoc />
    public partial class SeedStudentStatuses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grades_Students_StudentId",
                table: "Grades");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_StudentStatuses_StatusId",
                table: "Students");

           

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "StudentStatuses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Students",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
                name: "FK_Grades_Students_StudentId",
                table: "Grades",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_StudentStatuses_StatusId",
                table: "Students",
                column: "StatusId",
                principalTable: "StudentStatuses",
                principalColumn: "StudentStatusId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grades_Students_StudentId",
                table: "Grades");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_StudentStatuses_StatusId",
                table: "Students");

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

            migrationBuilder.AlterColumn<byte>(
                name: "Name",
                table: "StudentStatuses",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "Name" },
                values: new object[,]
                {
                    { new Guid("3b9557cf-f7a5-46a7-b4ac-af51eb057c75"), "Student" },
                    { new Guid("adb08d00-e616-41ea-a09e-064a280a5b49"), "Admin" },
                    { new Guid("d7e01179-b3a6-4085-a77a-c7e7b56f8fa1"), "Teacher" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_Students_StudentId",
                table: "Grades",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_StudentStatuses_StatusId",
                table: "Students",
                column: "StatusId",
                principalTable: "StudentStatuses",
                principalColumn: "StudentStatusId");
        }
    }
}
