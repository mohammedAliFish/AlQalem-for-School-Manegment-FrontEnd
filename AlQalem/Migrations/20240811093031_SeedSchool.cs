using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AlQalem.Migrations
{
    /// <inheritdoc />
    public partial class SeedSchool : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "PermissionId", "Name", "PermissionNumber" },
                values: new object[,]
                {
                    { new Guid("a7f5d1f8-6b57-4d5e-8ed1-76e2d6e9f0c3"), "View", 0 },
                    { new Guid("b7f5d1f8-6b57-4d5e-8ed1-76e2d6e9f0c3"), "Create", 0 },
                    { new Guid("c7f5d1f8-6b57-4d5e-8ed1-76e2d6e9f0c3"), "Edit", 0 },
                    { new Guid("d7f5d1f8-6b57-4d5e-8ed1-76e2d6e9f0c3"), "Delete", 0 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "Name" },
                values: new object[,]
                {
                    { new Guid("86d08d55-a776-4d6a-9017-61f5ddd0100d"), "Student" },
                    { new Guid("b7f5d1f8-6b57-4d5e-8ed1-76e2d6e9f0c3"), "Admin" },
                    { new Guid("c7f5d1f8-6b57-4d5e-8ed1-76e2d6e9f0c3"), "Teacher" },
                    { new Guid("cc307caa-3330-4eed-809b-1101a2ddf600"), "Admin" },
                    { new Guid("d7f5d1f8-6b57-4d5e-8ed1-76e2d6e9f0c3"), "Student" },
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: new Guid("a7f5d1f8-6b57-4d5e-8ed1-76e2d6e9f0c3"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: new Guid("b7f5d1f8-6b57-4d5e-8ed1-76e2d6e9f0c3"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: new Guid("c7f5d1f8-6b57-4d5e-8ed1-76e2d6e9f0c3"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: new Guid("d7f5d1f8-6b57-4d5e-8ed1-76e2d6e9f0c3"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("86d08d55-a776-4d6a-9017-61f5ddd0100d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("b7f5d1f8-6b57-4d5e-8ed1-76e2d6e9f0c3"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("c7f5d1f8-6b57-4d5e-8ed1-76e2d6e9f0c3"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("cc307caa-3330-4eed-809b-1101a2ddf600"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("d7f5d1f8-6b57-4d5e-8ed1-76e2d6e9f0c3"));

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
        }
    }
}
