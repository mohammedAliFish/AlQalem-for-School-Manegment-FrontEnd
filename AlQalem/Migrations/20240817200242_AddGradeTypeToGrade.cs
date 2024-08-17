using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AlQalem.Migrations
{
    /// <inheritdoc />
    public partial class AddGradeTypeToGrade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
                

            migrationBuilder.AddColumn<int>(
                name: "GradeType",
                table: "Grades",
                type: "int",
                nullable: false,
                defaultValue: 0);

       

           

           
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
              
            migrationBuilder.DropColumn(
                name: "GradeType",
                table: "Grades");

           

           

           
            
        }
    }
}
