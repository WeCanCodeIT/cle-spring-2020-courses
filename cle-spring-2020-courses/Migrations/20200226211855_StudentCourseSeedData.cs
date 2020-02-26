using Microsoft.EntityFrameworkCore.Migrations;

namespace cle_spring_2020_courses.Migrations
{
    public partial class StudentCourseSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Ferris Bueller" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Cameron Frye" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Sloane Peterson" });

            migrationBuilder.InsertData(
                table: "StudentCourse",
                columns: new[] { "Id", "CourseId", "StudentId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 5, 3, 1 },
                    { 2, 1, 2 },
                    { 3, 2, 2 },
                    { 4, 2, 3 },
                    { 6, 3, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentCourse",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StudentCourse",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StudentCourse",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StudentCourse",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "StudentCourse",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "StudentCourse",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
