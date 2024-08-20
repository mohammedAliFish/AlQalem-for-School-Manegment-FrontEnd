using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AlQalem.Migrations
{
    /// <inheritdoc />
    public partial class addIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

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
    }
}
