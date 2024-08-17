using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AlQalem.Migrations
{
    /// <inheritdoc />
    public partial class AddGradeTypeToGrade1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "AcademicYearId",
                keyValue: new Guid("19186c5c-eaa7-4f1d-a742-df57489788c2"));

            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "AcademicYearId",
                keyValue: new Guid("3127bce4-cfb2-4479-be8a-f1996ed17a83"));

            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "AcademicYearId",
                keyValue: new Guid("55e37b09-d6a5-436f-9674-e62814e13575"));

            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "AcademicYearId",
                keyValue: new Guid("7b7fdfd1-2a2c-483e-9bb6-1ab166b868e1"));

            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "AcademicYearId",
                keyValue: new Guid("810546ba-01fb-4b71-b603-3cac8fca64e8"));

            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "AcademicYearId",
                keyValue: new Guid("ae195ee0-dce9-4983-b766-0b7a95cd142d"));

            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "AcademicYearId",
                keyValue: new Guid("c2a212eb-77e8-4c29-ae2f-235f3c2df372"));

            migrationBuilder.DeleteData(
                table: "AcademicYears",
                keyColumn: "AcademicYearId",
                keyValue: new Guid("ffdda266-9172-4286-8048-74223cdacde4"));

            migrationBuilder.DeleteData(
                table: "GradeLevels",
                keyColumn: "GradeLevelId",
                keyValue: new Guid("1330be0c-b393-4c42-9177-83ddb693963e"));

            migrationBuilder.DeleteData(
                table: "GradeLevels",
                keyColumn: "GradeLevelId",
                keyValue: new Guid("3b1704eb-8810-42d6-aae6-39dd58f30c8e"));

            migrationBuilder.DeleteData(
                table: "GradeLevels",
                keyColumn: "GradeLevelId",
                keyValue: new Guid("a6f533ac-4f3f-4624-81e4-7ff9f881b314"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("6afab5be-06f7-48bb-9925-0bd27a16dd83"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("b03cc6d2-c799-4185-8d39-c3042a9bc132"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("e3234635-4f81-4406-ba19-28d448ec6c16"));

            migrationBuilder.DeleteData(
                table: "StudentStatuses",
                keyColumn: "StudentStatusId",
                keyValue: new Guid("0763e3b3-4d7a-4009-85cf-873224a7080e"));

            migrationBuilder.DeleteData(
                table: "StudentStatuses",
                keyColumn: "StudentStatusId",
                keyValue: new Guid("0e79efb1-3075-45d5-833d-8b50b1e41bfe"));

            migrationBuilder.DeleteData(
                table: "StudentStatuses",
                keyColumn: "StudentStatusId",
                keyValue: new Guid("5db99a82-618b-4c62-9f73-a6717fbda980"));

            migrationBuilder.DeleteData(
                table: "StudentStatuses",
                keyColumn: "StudentStatusId",
                keyValue: new Guid("cb4d9552-7720-4c94-a4c8-18b8ad76466d"));

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
                table: "Roles",
                columns: new[] { "RoleId", "Name" },
                values: new object[,]
                {
                    { new Guid("0862688c-9742-4d70-9d85-f2197f48c8a6"), "Teacher" },
                    { new Guid("66cd92a5-61f3-488f-bfb2-cb994191eb7c"), "Student" },
                    { new Guid("d68e9703-6722-4cf2-9d73-b5e2f1c064d8"), "Admin" }
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("0862688c-9742-4d70-9d85-f2197f48c8a6"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("66cd92a5-61f3-488f-bfb2-cb994191eb7c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("d68e9703-6722-4cf2-9d73-b5e2f1c064d8"));

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
                    { new Guid("19186c5c-eaa7-4f1d-a742-df57489788c2"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3127bce4-cfb2-4479-be8a-f1996ed17a83"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("55e37b09-d6a5-436f-9674-e62814e13575"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7b7fdfd1-2a2c-483e-9bb6-1ab166b868e1"), new DateTime(2030, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("810546ba-01fb-4b71-b603-3cac8fca64e8"), new DateTime(2028, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ae195ee0-dce9-4983-b766-0b7a95cd142d"), new DateTime(2027, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c2a212eb-77e8-4c29-ae2f-235f3c2df372"), new DateTime(2029, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ffdda266-9172-4286-8048-74223cdacde4"), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "GradeLevels",
                columns: new[] { "GradeLevelId", "Name" },
                values: new object[,]
                {
                    { new Guid("1330be0c-b393-4c42-9177-83ddb693963e"), "الثالث متوسط " },
                    { new Guid("3b1704eb-8810-42d6-aae6-39dd58f30c8e"), "الثاني متوسط" },
                    { new Guid("a6f533ac-4f3f-4624-81e4-7ff9f881b314"), "الاول متوسط" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "Name" },
                values: new object[,]
                {
                    { new Guid("6afab5be-06f7-48bb-9925-0bd27a16dd83"), "Admin" },
                    { new Guid("b03cc6d2-c799-4185-8d39-c3042a9bc132"), "Teacher" },
                    { new Guid("e3234635-4f81-4406-ba19-28d448ec6c16"), "Student" }
                });

            migrationBuilder.InsertData(
                table: "StudentStatuses",
                columns: new[] { "StudentStatusId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("0763e3b3-4d7a-4009-85cf-873224a7080e"), false, "Transferred" },
                    { new Guid("0e79efb1-3075-45d5-833d-8b50b1e41bfe"), false, "Ongoing" },
                    { new Guid("5db99a82-618b-4c62-9f73-a6717fbda980"), false, "Interrupted" },
                    { new Guid("cb4d9552-7720-4c94-a4c8-18b8ad76466d"), false, "Expelled" }
                });
        }
    }
}
