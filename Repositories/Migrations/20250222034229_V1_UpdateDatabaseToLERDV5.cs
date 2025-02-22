using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class V1_UpdateDatabaseToLERDV5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dogs_CustomerProfiles_CustomerProfileId",
                table: "Dogs");

            migrationBuilder.DropIndex(
                name: "IX_Dogs_CustomerProfileId",
                table: "Dogs");

            migrationBuilder.DropColumn(
                name: "CustomerProfileId",
                table: "Dogs");

            migrationBuilder.CreateTable(
                name: "CourseDogs",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DogBreedId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseDogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseDogs_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CourseDogs_DogBreeds_DogBreedId",
                        column: x => x.DogBreedId,
                        principalTable: "DogBreeds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CourseLessons",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LessonId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseLessons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseLessons_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CourseLessons_Lessons_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DogOwnerships",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FromDate = table.Column<DateOnly>(type: "date", nullable: false),
                    ToDate = table.Column<DateOnly>(type: "date", nullable: false),
                    CustomerProfileId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DogId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DogOwnerships", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DogOwnerships_CustomerProfiles_CustomerProfileId",
                        column: x => x.CustomerProfileId,
                        principalTable: "CustomerProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DogOwnerships_Dogs_DogId",
                        column: x => x.DogId,
                        principalTable: "Dogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PreTests",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TestDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    DogId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClassId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreTests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PreTests_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PreTests_Dogs_DogId",
                        column: x => x.DogId,
                        principalTable: "Dogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseDogs_CourseId",
                table: "CourseDogs",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseDogs_DogBreedId",
                table: "CourseDogs",
                column: "DogBreedId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseLessons_CourseId",
                table: "CourseLessons",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_DogOwnerships_CustomerProfileId",
                table: "DogOwnerships",
                column: "CustomerProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_DogOwnerships_DogId",
                table: "DogOwnerships",
                column: "DogId");

            migrationBuilder.CreateIndex(
                name: "IX_PreTests_ClassId",
                table: "PreTests",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_PreTests_DogId",
                table: "PreTests",
                column: "DogId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseDogs");

            migrationBuilder.DropTable(
                name: "CourseLessons");

            migrationBuilder.DropTable(
                name: "DogOwnerships");

            migrationBuilder.DropTable(
                name: "PreTests");

            migrationBuilder.AddColumn<string>(
                name: "CustomerProfileId",
                table: "Dogs",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Dogs_CustomerProfileId",
                table: "Dogs",
                column: "CustomerProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dogs_CustomerProfiles_CustomerProfileId",
                table: "Dogs",
                column: "CustomerProfileId",
                principalTable: "CustomerProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
