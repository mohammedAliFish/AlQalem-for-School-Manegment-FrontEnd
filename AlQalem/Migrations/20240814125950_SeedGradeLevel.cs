using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AlQalem.Migrations
{
    /// <inheritdoc />
    public partial class SeedGradeLevel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "AcademicYearId",
                keyValue: new Guid("1728f2c0-7bba-4435-ba8c-d7df647cda2a"));

            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "AcademicYearId",
                keyValue: new Guid("23c1c7d2-2cba-405a-bb5d-d2ced826e7d5"));

            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "AcademicYearId",
                keyValue: new Guid("34594cfd-bffe-4e3c-b637-d94b20ab2c07"));

            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "AcademicYearId",
                keyValue: new Guid("4b0075b8-5db2-4962-b58c-22c6b3082091"));

            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "AcademicYearId",
                keyValue: new Guid("4fbc8e50-f273-42b0-9c76-459b46e4c9a0"));

            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "AcademicYearId",
                keyValue: new Guid("a9dbe4cf-c49c-4497-ab6b-2dc06cfee26b"));

            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "AcademicYearId",
                keyValue: new Guid("c1892b1e-741b-48db-8660-a34ddbd606f9"));

            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "AcademicYearId",
                keyValue: new Guid("d85dea0d-146d-401d-bcb6-a1f2ba1a1e37"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("9c73adc2-7caa-4747-b85a-d78613dfe062"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("a44b9f03-78e7-4187-b67c-e82f7bd60338"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("bf0f1456-615a-41a0-a363-09a17cd28f12"));

            migrationBuilder.DeleteData(
                table: "StudentStatuses",
                keyColumn: "StudentStatusId",
                keyValue: new Guid("6f1081c7-af6f-4af9-91cc-da6cb493c06e"));

            migrationBuilder.DeleteData(
                table: "StudentStatuses",
                keyColumn: "StudentStatusId",
                keyValue: new Guid("96252ddd-c612-4c94-af2a-96976185721b"));

            migrationBuilder.DeleteData(
                table: "StudentStatuses",
                keyColumn: "StudentStatusId",
                keyValue: new Guid("b4b190c9-bead-4777-b1e6-c06e1100f4d4"));

            migrationBuilder.DeleteData(
                table: "StudentStatuses",
                keyColumn: "StudentStatusId",
                keyValue: new Guid("e2a79d53-4f74-4e99-9f13-9cb264aa2699"));

            migrationBuilder.DropColumn(
                name: "GradeLevel",
                table: "Grades");

            migrationBuilder.DropColumn(
                name: "GradeLevel",
                table: "Classes");

            migrationBuilder.AddColumn<Guid>(
                name: "GradeLevelId",
                table: "Grades",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "GradeLevelId",
                table: "Classes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "GradeLevels",
                columns: table => new
                {
                    GradeLevelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GradeLevels", x => x.GradeLevelId);
                });

            migrationBuilder.InsertData(
                table: "AcademicYears",
                columns: new[] { "AcademicYearId", "Year" },
                values: new object[,]
                {
                    { new Guid("01295d6f-0f0c-4429-98ab-3af293205de8"), new DateTime(2029, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3a281a9f-95c0-4e8d-ba0f-ff36f05b64a5"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("54e16a16-a341-46be-a78b-c6105a9f0685"), new DateTime(2030, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8fd43ef1-76b3-4159-8ea0-9690499e4a07"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b48de529-1b9d-4254-b162-59807635765e"), new DateTime(2027, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dc50280b-fb60-4dff-a2b7-4ee1dcd35494"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e2c08ff0-0c4f-4822-ac45-b272de6eea52"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f88071f6-8346-444e-b324-1f68157266fd"), new DateTime(2028, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "GradeLevels",
                columns: new[] { "GradeLevelId", "Name" },
                values: new object[,]
                {
                    { new Guid("50d6aba4-ac3c-45be-a839-b672fca86b70"), "الاول متوسط" },
                    { new Guid("702aa6d3-c4e4-4bc6-ba23-0b4f439d0d57"), "الثالث متوسط " },
                    { new Guid("c8419b51-f63e-4ba0-b2ce-924dfd1d0af3"), "الثاني متوسط" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "Name" },
                values: new object[,]
                {
                    { new Guid("426cfe33-bdf4-4520-9869-3d7621c3a9ba"), "Teacher" },
                    { new Guid("57cd43c7-ea48-44e4-9bf5-af6c74e9b42b"), "Admin" },
                    { new Guid("6cb913de-a93c-4457-b389-6d0e951514a1"), "Student" }
                });

            migrationBuilder.InsertData(
                table: "StudentStatuses",
                columns: new[] { "StudentStatusId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("09d11b90-ea01-4260-ad9c-71ac585621f4"), false, "Transferred" },
                    { new Guid("5f4863fe-3f58-43fd-9ded-0d40be6ad943"), false, "Interrupted" },
                    { new Guid("6d68c1b4-d633-4b70-bb25-5884372638ea"), false, "Ongoing" },
                    { new Guid("fe2b2432-caf3-4a81-b78b-ba00b679a42c"), false, "Expelled" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Grades_GradeLevelId",
                table: "Grades",
                column: "GradeLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_GradeLevelId",
                table: "Classes",
                column: "GradeLevelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_GradeLevels_GradeLevelId",
                table: "Classes",
                column: "GradeLevelId",
                principalTable: "GradeLevels",
                principalColumn: "GradeLevelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_GradeLevels_GradeLevelId",
                table: "Grades",
                column: "GradeLevelId",
                principalTable: "GradeLevels",
                principalColumn: "GradeLevelId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_GradeLevels_GradeLevelId",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK_Grades_GradeLevels_GradeLevelId",
                table: "Grades");

            migrationBuilder.DropTable(
                name: "GradeLevels");

            migrationBuilder.DropIndex(
                name: "IX_Grades_GradeLevelId",
                table: "Grades");

            migrationBuilder.DropIndex(
                name: "IX_Classes_GradeLevelId",
                table: "Classes");

            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "AcademicYearId",
                keyValue: new Guid("01295d6f-0f0c-4429-98ab-3af293205de8"));

            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "AcademicYearId",
                keyValue: new Guid("3a281a9f-95c0-4e8d-ba0f-ff36f05b64a5"));

            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "AcademicYearId",
                keyValue: new Guid("54e16a16-a341-46be-a78b-c6105a9f0685"));

            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "AcademicYearId",
                keyValue: new Guid("8fd43ef1-76b3-4159-8ea0-9690499e4a07"));

            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "AcademicYearId",
                keyValue: new Guid("b48de529-1b9d-4254-b162-59807635765e"));

            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "AcademicYearId",
                keyValue: new Guid("dc50280b-fb60-4dff-a2b7-4ee1dcd35494"));

            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "AcademicYearId",
                keyValue: new Guid("e2c08ff0-0c4f-4822-ac45-b272de6eea52"));

            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "AcademicYearId",
                keyValue: new Guid("f88071f6-8346-444e-b324-1f68157266fd"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("426cfe33-bdf4-4520-9869-3d7621c3a9ba"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("57cd43c7-ea48-44e4-9bf5-af6c74e9b42b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("6cb913de-a93c-4457-b389-6d0e951514a1"));

            migrationBuilder.DeleteData(
                table: "StudentStatuses",
                keyColumn: "StudentStatusId",
                keyValue: new Guid("09d11b90-ea01-4260-ad9c-71ac585621f4"));

            migrationBuilder.DeleteData(
                table: "StudentStatuses",
                keyColumn: "StudentStatusId",
                keyValue: new Guid("5f4863fe-3f58-43fd-9ded-0d40be6ad943"));

            migrationBuilder.DeleteData(
                table: "StudentStatuses",
                keyColumn: "StudentStatusId",
                keyValue: new Guid("6d68c1b4-d633-4b70-bb25-5884372638ea"));

            migrationBuilder.DeleteData(
                table: "StudentStatuses",
                keyColumn: "StudentStatusId",
                keyValue: new Guid("fe2b2432-caf3-4a81-b78b-ba00b679a42c"));

            migrationBuilder.DropColumn(
                name: "GradeLevelId",
                table: "Grades");

            migrationBuilder.DropColumn(
                name: "GradeLevelId",
                table: "Classes");

            migrationBuilder.AddColumn<int>(
                name: "GradeLevel",
                table: "Grades",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "GradeLevel",
                table: "Classes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AcademicYears",
                columns: new[] { "AcademicYearId", "Year" },
                values: new object[,]
                {
                    { new Guid("1728f2c0-7bba-4435-ba8c-d7df647cda2a"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("23c1c7d2-2cba-405a-bb5d-d2ced826e7d5"), new DateTime(2029, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("34594cfd-bffe-4e3c-b637-d94b20ab2c07"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4b0075b8-5db2-4962-b58c-22c6b3082091"), new DateTime(2030, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4fbc8e50-f273-42b0-9c76-459b46e4c9a0"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a9dbe4cf-c49c-4497-ab6b-2dc06cfee26b"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c1892b1e-741b-48db-8660-a34ddbd606f9"), new DateTime(2027, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d85dea0d-146d-401d-bcb6-a1f2ba1a1e37"), new DateTime(2028, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "Name" },
                values: new object[,]
                {
                    { new Guid("9c73adc2-7caa-4747-b85a-d78613dfe062"), "Teacher" },
                    { new Guid("a44b9f03-78e7-4187-b67c-e82f7bd60338"), "Student" },
                    { new Guid("bf0f1456-615a-41a0-a363-09a17cd28f12"), "Admin" }
                });

            migrationBuilder.InsertData(
                table: "StudentStatuses",
                columns: new[] { "StudentStatusId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("6f1081c7-af6f-4af9-91cc-da6cb493c06e"), false, "Interrupted" },
                    { new Guid("96252ddd-c612-4c94-af2a-96976185721b"), false, "Expelled" },
                    { new Guid("b4b190c9-bead-4777-b1e6-c06e1100f4d4"), false, "Ongoing" },
                    { new Guid("e2a79d53-4f74-4e99-9f13-9cb264aa2699"), false, "Transferred" }
                });
        }
    }
}
