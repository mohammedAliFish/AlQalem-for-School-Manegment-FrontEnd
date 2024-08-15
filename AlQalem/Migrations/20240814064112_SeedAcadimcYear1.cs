using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AlQalem.Migrations
{
    /// <inheritdoc />
    public partial class SeedAcadimcYear1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
