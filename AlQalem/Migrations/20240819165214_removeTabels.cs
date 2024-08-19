using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AlQalem.Migrations
{
    /// <inheritdoc />
    public partial class removeTabels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

           

            

            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "AcademicYearId",
                keyValue: new Guid("053dd4fb-89aa-435c-9145-7cd7c64dda86"));

            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "AcademicYearId",
                keyValue: new Guid("531891c0-c252-457d-9e52-b3814dd958bc"));

            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "AcademicYearId",
                keyValue: new Guid("683c78bf-221d-4351-89b2-149553b5067d"));

            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "AcademicYearId",
                keyValue: new Guid("7456aafd-363a-477d-b653-31ce9cc7c99c"));

            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "AcademicYearId",
                keyValue: new Guid("93eb11e9-959e-41bd-9577-978d72b37a05"));

            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "AcademicYearId",
                keyValue: new Guid("b77a3f93-5d03-4604-9e38-25df850e279c"));

            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "AcademicYearId",
                keyValue: new Guid("c53180e4-97d0-47eb-b987-b25d5de7f6f0"));

            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "AcademicYearId",
                keyValue: new Guid("e527cd83-0e18-4e80-a426-1e482383ee1c"));

            migrationBuilder.DeleteData(
                table: "GradeLevels",
                keyColumn: "GradeLevelId",
                keyValue: new Guid("8d192da8-9799-4916-8b24-497444a647db"));

            migrationBuilder.DeleteData(
                table: "GradeLevels",
                keyColumn: "GradeLevelId",
                keyValue: new Guid("d877be1f-3c41-4441-9c4e-34d3df6c146b"));

            migrationBuilder.DeleteData(
                table: "GradeLevels",
                keyColumn: "GradeLevelId",
                keyValue: new Guid("ecb0bcce-4a80-4669-8be3-b11cd3abe516"));

            migrationBuilder.DeleteData(
                table: "StudentStatuses",
                keyColumn: "StudentStatusId",
                keyValue: new Guid("b0592458-6abe-4542-873e-dfd4be400581"));

            migrationBuilder.DeleteData(
                table: "StudentStatuses",
                keyColumn: "StudentStatusId",
                keyValue: new Guid("b8608202-3970-4010-be45-110e245cee30"));

            migrationBuilder.DeleteData(
                table: "StudentStatuses",
                keyColumn: "StudentStatusId",
                keyValue: new Guid("be17c64f-930c-4d1d-b92c-7d3e764309b3"));

            migrationBuilder.DeleteData(
                table: "StudentStatuses",
                keyColumn: "StudentStatusId",
                keyValue: new Guid("d094cc93-bdde-475a-bf16-805af13a7840"));

   

            migrationBuilder.InsertData(
                table: "AcademicYears",
                columns: new[] { "AcademicYearId", "Year" },
                values: new object[,]
                {
                    { new Guid("3a73a6a9-3ec0-4e6a-acbe-e83e73550d58"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3eab258c-21ce-4f98-ae59-0ca794d15d22"), new DateTime(2029, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("822a767a-1494-4bb1-8929-277a7c2458e6"), new DateTime(2028, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9c7b9021-dba2-4114-bfaa-9867fbf6a146"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a9f6fba1-da67-4f1b-b4b4-05241e21553c"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b67586db-be7b-435c-a8c4-355b7a8f3cb8"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cc297061-e8c6-4320-a7cf-983c8994c527"), new DateTime(2030, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d92a74af-3b36-4c72-a62b-b43652e142e0"), new DateTime(2027, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "GradeLevels",
                columns: new[] { "GradeLevelId", "Name" },
                values: new object[,]
                {
                    { new Guid("0b92c6cb-28ab-4492-bf40-613d7ebbab73"), "الثاني متوسط" },
                    { new Guid("3ef92bda-33a2-43b7-bad7-5fa684494504"), "الاول متوسط" },
                    { new Guid("465b9ed6-93c8-4dd6-bf4c-e0af4708df69"), "الثالث متوسط " }
                });

            migrationBuilder.InsertData(
                table: "StudentStatuses",
                columns: new[] { "StudentStatusId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("3c4e2082-85dd-4755-be45-5b965ca7ffec"), false, "Transferred" },
                    { new Guid("4a7eedf2-4949-467c-9c33-b25f788e9292"), false, "Ongoing" },
                    { new Guid("52102e44-b40e-4aee-be65-69889dc8bdf9"), false, "Interrupted" },
                    { new Guid("86ede45f-052c-48f6-9787-c8b9ae4eb971"), false, "Expelled" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "AcademicYearId",
                keyValue: new Guid("3a73a6a9-3ec0-4e6a-acbe-e83e73550d58"));

            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "AcademicYearId",
                keyValue: new Guid("3eab258c-21ce-4f98-ae59-0ca794d15d22"));

            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "AcademicYearId",
                keyValue: new Guid("822a767a-1494-4bb1-8929-277a7c2458e6"));

            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "AcademicYearId",
                keyValue: new Guid("9c7b9021-dba2-4114-bfaa-9867fbf6a146"));

            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "AcademicYearId",
                keyValue: new Guid("a9f6fba1-da67-4f1b-b4b4-05241e21553c"));

            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "AcademicYearId",
                keyValue: new Guid("b67586db-be7b-435c-a8c4-355b7a8f3cb8"));

            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "AcademicYearId",
                keyValue: new Guid("cc297061-e8c6-4320-a7cf-983c8994c527"));

            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "AcademicYearId",
                keyValue: new Guid("d92a74af-3b36-4c72-a62b-b43652e142e0"));

            migrationBuilder.DeleteData(
                table: "GradeLevels",
                keyColumn: "GradeLevelId",
                keyValue: new Guid("0b92c6cb-28ab-4492-bf40-613d7ebbab73"));

            migrationBuilder.DeleteData(
                table: "GradeLevels",
                keyColumn: "GradeLevelId",
                keyValue: new Guid("3ef92bda-33a2-43b7-bad7-5fa684494504"));

            migrationBuilder.DeleteData(
                table: "GradeLevels",
                keyColumn: "GradeLevelId",
                keyValue: new Guid("465b9ed6-93c8-4dd6-bf4c-e0af4708df69"));

            migrationBuilder.DeleteData(
                table: "StudentStatuses",
                keyColumn: "StudentStatusId",
                keyValue: new Guid("3c4e2082-85dd-4755-be45-5b965ca7ffec"));

            migrationBuilder.DeleteData(
                table: "StudentStatuses",
                keyColumn: "StudentStatusId",
                keyValue: new Guid("4a7eedf2-4949-467c-9c33-b25f788e9292"));

            migrationBuilder.DeleteData(
                table: "StudentStatuses",
                keyColumn: "StudentStatusId",
                keyValue: new Guid("52102e44-b40e-4aee-be65-69889dc8bdf9"));

            migrationBuilder.DeleteData(
                table: "StudentStatuses",
                keyColumn: "StudentStatusId",
                keyValue: new Guid("86ede45f-052c-48f6-9787-c8b9ae4eb971"));

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Teachers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    PermissionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PermissionNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.PermissionId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "RolePermissions",
                columns: table => new
                {
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PermissionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolePermissions", x => new { x.RoleId, x.PermissionId });
                    table.ForeignKey(
                        name: "FK_RolePermissions_Permissions_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permissions",
                        principalColumn: "PermissionId");
                    table.ForeignKey(
                        name: "FK_RolePermissions_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId");
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId");
                });

            migrationBuilder.InsertData(
                table: "AcademicYears",
                columns: new[] { "AcademicYearId", "Year" },
                values: new object[,]
                {
                    { new Guid("053dd4fb-89aa-435c-9145-7cd7c64dda86"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("531891c0-c252-457d-9e52-b3814dd958bc"), new DateTime(2029, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("683c78bf-221d-4351-89b2-149553b5067d"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7456aafd-363a-477d-b653-31ce9cc7c99c"), new DateTime(2030, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("93eb11e9-959e-41bd-9577-978d72b37a05"), new DateTime(2027, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b77a3f93-5d03-4604-9e38-25df850e279c"), new DateTime(2028, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c53180e4-97d0-47eb-b987-b25d5de7f6f0"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e527cd83-0e18-4e80-a426-1e482383ee1c"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "GradeLevels",
                columns: new[] { "GradeLevelId", "Name" },
                values: new object[,]
                {
                    { new Guid("8d192da8-9799-4916-8b24-497444a647db"), "الثالث متوسط " },
                    { new Guid("d877be1f-3c41-4441-9c4e-34d3df6c146b"), "الاول متوسط" },
                    { new Guid("ecb0bcce-4a80-4669-8be3-b11cd3abe516"), "الثاني متوسط" }
                });

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
                    { new Guid("0862688c-9742-4d70-9d85-f2197f48c8a6"), "Teacher" },
                    { new Guid("66cd92a5-61f3-488f-bfb2-cb994191eb7c"), "Student" },
                    { new Guid("b7f5d1f8-6b57-4d5e-8ed1-76e2d6e9f0c3"), "Admin" },
                    { new Guid("c7f5d1f8-6b57-4d5e-8ed1-76e2d6e9f0c3"), "Teacher" },
                    { new Guid("d68e9703-6722-4cf2-9d73-b5e2f1c064d8"), "Admin" },
                    { new Guid("d7f5d1f8-6b57-4d5e-8ed1-76e2d6e9f0c3"), "Student" }
                });

            migrationBuilder.InsertData(
                table: "StudentStatuses",
                columns: new[] { "StudentStatusId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("b0592458-6abe-4542-873e-dfd4be400581"), false, "Transferred" },
                    { new Guid("b8608202-3970-4010-be45-110e245cee30"), false, "Expelled" },
                    { new Guid("be17c64f-930c-4d1d-b92c-7d3e764309b3"), false, "Ongoing" },
                    { new Guid("d094cc93-bdde-475a-bf16-805af13a7840"), false, "Interrupted" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_UserId",
                table: "Teachers",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RolePermissions_PermissionId",
                table: "RolePermissions",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Users_UserId",
                table: "Teachers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId");
        }
    }
}
