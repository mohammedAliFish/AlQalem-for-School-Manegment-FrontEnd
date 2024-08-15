using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AlQalem.Migrations
{
    /// <inheritdoc />
    public partial class UpdateGradeLevelFromIntToString : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Schools_SchoolId",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassTeachers_Classes_ClassId",
                table: "ClassTeachers");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentAttachments_Students_StudentId",
                table: "StudentAttachments");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("86d08d55-a776-4d6a-9017-61f5ddd0100d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("cc307caa-3330-4eed-809b-1101a2ddf600"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("d8b9080e-3669-4cd0-9851-3fd769ab18ca"));

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "SchoolId",
                keyValue: new Guid("6bd91311-833b-4869-ba92-cc97a39c9a1f"));

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "SchoolId",
                keyValue: new Guid("aff5df62-7ed2-4f93-b92e-5f8284603a6a"));

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "SchoolId",
                keyValue: new Guid("f30d63d8-0761-4a76-8e3b-9a5fa93b1fac"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "StudentStatuses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "GradeLevel",
                table: "Classes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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
                name: "FK_Classes_Schools_SchoolId",
                table: "Classes",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "SchoolId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassTeachers_Classes_ClassId",
                table: "ClassTeachers",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "ClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentAttachments_Students_StudentId",
                table: "StudentAttachments",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Schools_SchoolId",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassTeachers_Classes_ClassId",
                table: "ClassTeachers");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentAttachments_Students_StudentId",
                table: "StudentAttachments");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("3b9557cf-f7a5-46a7-b4ac-af51eb057c75"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("adb08d00-e616-41ea-a09e-064a280a5b49"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("d7e01179-b3a6-4085-a77a-c7e7b56f8fa1"));

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "StudentStatuses");

            migrationBuilder.AlterColumn<int>(
                name: "GradeLevel",
                table: "Classes",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "Name" },
                values: new object[,]
                {
                    { new Guid("86d08d55-a776-4d6a-9017-61f5ddd0100d"), "Student" },
                    { new Guid("cc307caa-3330-4eed-809b-1101a2ddf600"), "Admin" },
                    { new Guid("d8b9080e-3669-4cd0-9851-3fd769ab18ca"), "Teacher" }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "SchoolId", "IsDeleted", "LogoPath", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("6bd91311-833b-4869-ba92-cc97a39c9a1f"), false, "default_logo.png", "اعدادي", (byte)3 },
                    { new Guid("aff5df62-7ed2-4f93-b92e-5f8284603a6a"), false, "default_logo.png", "متوسطه", (byte)2 },
                    { new Guid("f30d63d8-0761-4a76-8e3b-9a5fa93b1fac"), false, "default_logo.png", "ابتدائي", (byte)1 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Schools_SchoolId",
                table: "Classes",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "SchoolId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassTeachers_Classes_ClassId",
                table: "ClassTeachers",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "ClassId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentAttachments_Students_StudentId",
                table: "StudentAttachments",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId");
        }
    }
}
