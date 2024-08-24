using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AlQalem.Migrations
{
    /// <inheritdoc />
    public partial class addUserAndRoleSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "AcademicYearId",
                keyValue: new Guid("0364b3ad-90ea-4a4a-9127-9811ce96338b"));

            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "AcademicYearId",
                keyValue: new Guid("50ced06d-1563-4d80-bf5b-7f0a852adb09"));

            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "AcademicYearId",
                keyValue: new Guid("539284e8-5924-4aa2-8ca8-fed3224f8d7d"));

            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "AcademicYearId",
                keyValue: new Guid("75ff4eb6-dcce-4f39-a459-222c2dc4032e"));

            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "AcademicYearId",
                keyValue: new Guid("8ba84cec-c2b6-428b-91e9-538b44723c4b"));

            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "AcademicYearId",
                keyValue: new Guid("8f16adf8-d375-4a2f-b160-b744607d2959"));

            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "AcademicYearId",
                keyValue: new Guid("baf2ed98-d40b-47c8-9f9c-5c980d188978"));

            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "AcademicYearId",
                keyValue: new Guid("cdc2d10f-e1e1-4126-9ec1-221114e72414"));

            migrationBuilder.DeleteData(
                table: "GradeLevels",
                keyColumn: "GradeLevelId",
                keyValue: new Guid("48286a89-f9b7-49bf-8a6c-d2123d143e02"));

            migrationBuilder.DeleteData(
                table: "GradeLevels",
                keyColumn: "GradeLevelId",
                keyValue: new Guid("8fd1719a-8403-4c77-b3eb-6fe9bed2c9de"));

            migrationBuilder.DeleteData(
                table: "GradeLevels",
                keyColumn: "GradeLevelId",
                keyValue: new Guid("ff745932-4971-4346-87d8-703d96687967"));

            migrationBuilder.DeleteData(
                table: "StudentStatuses",
                keyColumn: "StudentStatusId",
                keyValue: new Guid("06a8f1ce-8abc-49e1-b6e1-9bcf35fbcdbd"));

            migrationBuilder.DeleteData(
                table: "StudentStatuses",
                keyColumn: "StudentStatusId",
                keyValue: new Guid("92722d94-fcfe-498e-8520-1acc494a40ed"));

            migrationBuilder.DeleteData(
                table: "StudentStatuses",
                keyColumn: "StudentStatusId",
                keyValue: new Guid("b6479d7e-f4d0-49a0-9abb-b67058ddce53"));

            migrationBuilder.DeleteData(
                table: "StudentStatuses",
                keyColumn: "StudentStatusId",
                keyValue: new Guid("ced0d555-c021-4161-92ec-f466f74361ce"));

            migrationBuilder.InsertData(
                table: "AcademicYears",
                columns: new[] { "AcademicYearId", "Year" },
                values: new object[,]
                {
                    { new Guid("3835f7fb-0b6f-42bc-847e-96597b9544cc"), new DateTime(2028, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("49988a7b-5030-47c0-8d25-3c1268fdc50d"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("55b0d654-0187-4705-b358-a023e3307abc"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("93f60a5e-f76c-4a4b-bf8c-9e830ad438c2"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d343028f-20b8-4d38-8738-6fa5d1ca4f08"), new DateTime(2030, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f0ce96e0-82c2-43e3-9fd9-07fbdf5824e3"), new DateTime(2029, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f78a0aca-40d3-4520-9c43-391b1f0dde38"), new DateTime(2027, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fab5ca9a-a437-4983-877e-47a154d61cbb"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "GradeLevels",
                columns: new[] { "GradeLevelId", "Name" },
                values: new object[,]
                {
                    { new Guid("27c9c5a3-c154-4e58-9736-33cb8c22cdf6"), "الاول متوسط" },
                    { new Guid("36f47bcc-c69b-41e1-9571-ab92d4da42a4"), "الثالث متوسط " },
                    { new Guid("7b41ac1c-3e97-4a41-a0c6-c7389d4b6ee7"), "الثاني متوسط" }
                });

            migrationBuilder.InsertData(
                table: "StudentStatuses",
                columns: new[] { "StudentStatusId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("3ac5f658-6e3b-4cdd-a104-a648b9f148b5"), false, "Transferred" },
                    { new Guid("8806c169-87b0-48cf-9d6a-def57971302a"), false, "Interrupted" },
                    { new Guid("cc1a4666-0f46-4e01-94c1-4fffaf1a5a34"), false, "Ongoing" },
                    { new Guid("db59aca4-bae1-4d66-96c3-ca01bbe0b39e"), false, "Expelled" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "AcademicYearId",
                keyValue: new Guid("3835f7fb-0b6f-42bc-847e-96597b9544cc"));

            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "AcademicYearId",
                keyValue: new Guid("49988a7b-5030-47c0-8d25-3c1268fdc50d"));

            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "AcademicYearId",
                keyValue: new Guid("55b0d654-0187-4705-b358-a023e3307abc"));

            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "AcademicYearId",
                keyValue: new Guid("93f60a5e-f76c-4a4b-bf8c-9e830ad438c2"));

            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "AcademicYearId",
                keyValue: new Guid("d343028f-20b8-4d38-8738-6fa5d1ca4f08"));

            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "AcademicYearId",
                keyValue: new Guid("f0ce96e0-82c2-43e3-9fd9-07fbdf5824e3"));

            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "AcademicYearId",
                keyValue: new Guid("f78a0aca-40d3-4520-9c43-391b1f0dde38"));

            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "AcademicYearId",
                keyValue: new Guid("fab5ca9a-a437-4983-877e-47a154d61cbb"));

            migrationBuilder.DeleteData(
                table: "GradeLevels",
                keyColumn: "GradeLevelId",
                keyValue: new Guid("27c9c5a3-c154-4e58-9736-33cb8c22cdf6"));

            migrationBuilder.DeleteData(
                table: "GradeLevels",
                keyColumn: "GradeLevelId",
                keyValue: new Guid("36f47bcc-c69b-41e1-9571-ab92d4da42a4"));

            migrationBuilder.DeleteData(
                table: "GradeLevels",
                keyColumn: "GradeLevelId",
                keyValue: new Guid("7b41ac1c-3e97-4a41-a0c6-c7389d4b6ee7"));

            migrationBuilder.DeleteData(
                table: "StudentStatuses",
                keyColumn: "StudentStatusId",
                keyValue: new Guid("3ac5f658-6e3b-4cdd-a104-a648b9f148b5"));

            migrationBuilder.DeleteData(
                table: "StudentStatuses",
                keyColumn: "StudentStatusId",
                keyValue: new Guid("8806c169-87b0-48cf-9d6a-def57971302a"));

            migrationBuilder.DeleteData(
                table: "StudentStatuses",
                keyColumn: "StudentStatusId",
                keyValue: new Guid("cc1a4666-0f46-4e01-94c1-4fffaf1a5a34"));

            migrationBuilder.DeleteData(
                table: "StudentStatuses",
                keyColumn: "StudentStatusId",
                keyValue: new Guid("db59aca4-bae1-4d66-96c3-ca01bbe0b39e"));

            migrationBuilder.InsertData(
                table: "AcademicYears",
                columns: new[] { "AcademicYearId", "Year" },
                values: new object[,]
                {
                    { new Guid("0364b3ad-90ea-4a4a-9127-9811ce96338b"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("50ced06d-1563-4d80-bf5b-7f0a852adb09"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("539284e8-5924-4aa2-8ca8-fed3224f8d7d"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("75ff4eb6-dcce-4f39-a459-222c2dc4032e"), new DateTime(2029, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8ba84cec-c2b6-428b-91e9-538b44723c4b"), new DateTime(2027, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8f16adf8-d375-4a2f-b160-b744607d2959"), new DateTime(2028, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("baf2ed98-d40b-47c8-9f9c-5c980d188978"), new DateTime(2030, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cdc2d10f-e1e1-4126-9ec1-221114e72414"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "GradeLevels",
                columns: new[] { "GradeLevelId", "Name" },
                values: new object[,]
                {
                    { new Guid("48286a89-f9b7-49bf-8a6c-d2123d143e02"), "الثاني متوسط" },
                    { new Guid("8fd1719a-8403-4c77-b3eb-6fe9bed2c9de"), "الاول متوسط" },
                    { new Guid("ff745932-4971-4346-87d8-703d96687967"), "الثالث متوسط " }
                });

            migrationBuilder.InsertData(
                table: "StudentStatuses",
                columns: new[] { "StudentStatusId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("06a8f1ce-8abc-49e1-b6e1-9bcf35fbcdbd"), false, "Expelled" },
                    { new Guid("92722d94-fcfe-498e-8520-1acc494a40ed"), false, "Ongoing" },
                    { new Guid("b6479d7e-f4d0-49a0-9abb-b67058ddce53"), false, "Interrupted" },
                    { new Guid("ced0d555-c021-4161-92ec-f466f74361ce"), false, "Transferred" }
                });
        }
    }
}
