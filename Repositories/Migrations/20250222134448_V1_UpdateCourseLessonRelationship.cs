using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class V1_UpdateCourseLessonRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseLessons_Lessons_CourseId",
                table: "CourseLessons");

            migrationBuilder.AlterColumn<string>(
                name: "LessonId",
                table: "CourseLessons",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_CourseLessons_LessonId",
                table: "CourseLessons",
                column: "LessonId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseLessons_Lessons_LessonId",
                table: "CourseLessons",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseLessons_Lessons_LessonId",
                table: "CourseLessons");

            migrationBuilder.DropIndex(
                name: "IX_CourseLessons_LessonId",
                table: "CourseLessons");

            migrationBuilder.AlterColumn<string>(
                name: "LessonId",
                table: "CourseLessons",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseLessons_Lessons_CourseId",
                table: "CourseLessons",
                column: "CourseId",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
