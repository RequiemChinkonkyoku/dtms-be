using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class V1_UpdateDBToMatchLogicalV6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendances_Classes_ClassId",
                table: "Attendances");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingReports_Dogs_DogId",
                table: "TrainingReports");

            migrationBuilder.DropTable(
                name: "SlotLessons");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "CageCategories");

            migrationBuilder.AlterColumn<string>(
                name: "DogId",
                table: "TrainingReports",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "EnrollmentId",
                table: "TrainingReports",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LessonId",
                table: "Slots",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DogTypeId",
                table: "DogBreeds",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DogTypeId",
                table: "CageCategories",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClassId",
                table: "Attendances",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<DateOnly>(
                name: "Date",
                table: "Attendances",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "SlotId",
                table: "Attendances",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "DogTypes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DogTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TrainingReports_EnrollmentId",
                table: "TrainingReports",
                column: "EnrollmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Slots_LessonId",
                table: "Slots",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_DogBreeds_DogTypeId",
                table: "DogBreeds",
                column: "DogTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CageCategories_DogTypeId",
                table: "CageCategories",
                column: "DogTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_SlotId",
                table: "Attendances",
                column: "SlotId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendances_Classes_ClassId",
                table: "Attendances",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendances_Slots_SlotId",
                table: "Attendances",
                column: "SlotId",
                principalTable: "Slots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CageCategories_DogTypes_DogTypeId",
                table: "CageCategories",
                column: "DogTypeId",
                principalTable: "DogTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DogBreeds_DogTypes_DogTypeId",
                table: "DogBreeds",
                column: "DogTypeId",
                principalTable: "DogTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Slots_Lessons_LessonId",
                table: "Slots",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingReports_Dogs_DogId",
                table: "TrainingReports",
                column: "DogId",
                principalTable: "Dogs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingReports_Enrollments_EnrollmentId",
                table: "TrainingReports",
                column: "EnrollmentId",
                principalTable: "Enrollments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendances_Classes_ClassId",
                table: "Attendances");

            migrationBuilder.DropForeignKey(
                name: "FK_Attendances_Slots_SlotId",
                table: "Attendances");

            migrationBuilder.DropForeignKey(
                name: "FK_CageCategories_DogTypes_DogTypeId",
                table: "CageCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_DogBreeds_DogTypes_DogTypeId",
                table: "DogBreeds");

            migrationBuilder.DropForeignKey(
                name: "FK_Slots_Lessons_LessonId",
                table: "Slots");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingReports_Dogs_DogId",
                table: "TrainingReports");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingReports_Enrollments_EnrollmentId",
                table: "TrainingReports");

            migrationBuilder.DropTable(
                name: "DogTypes");

            migrationBuilder.DropIndex(
                name: "IX_TrainingReports_EnrollmentId",
                table: "TrainingReports");

            migrationBuilder.DropIndex(
                name: "IX_Slots_LessonId",
                table: "Slots");

            migrationBuilder.DropIndex(
                name: "IX_DogBreeds_DogTypeId",
                table: "DogBreeds");

            migrationBuilder.DropIndex(
                name: "IX_CageCategories_DogTypeId",
                table: "CageCategories");

            migrationBuilder.DropIndex(
                name: "IX_Attendances_SlotId",
                table: "Attendances");

            migrationBuilder.DropColumn(
                name: "EnrollmentId",
                table: "TrainingReports");

            migrationBuilder.DropColumn(
                name: "LessonId",
                table: "Slots");

            migrationBuilder.DropColumn(
                name: "DogTypeId",
                table: "DogBreeds");

            migrationBuilder.DropColumn(
                name: "DogTypeId",
                table: "CageCategories");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Attendances");

            migrationBuilder.DropColumn(
                name: "SlotId",
                table: "Attendances");

            migrationBuilder.AlterColumn<string>(
                name: "DogId",
                table: "TrainingReports",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "CageCategories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "ClassId",
                table: "Attendances",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "SlotLessons",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LessonId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SlotId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SlotLessons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SlotLessons_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SlotLessons_Slots_SlotId",
                        column: x => x.SlotId,
                        principalTable: "Slots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SlotLessons_LessonId",
                table: "SlotLessons",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_SlotLessons_SlotId",
                table: "SlotLessons",
                column: "SlotId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendances_Classes_ClassId",
                table: "Attendances",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingReports_Dogs_DogId",
                table: "TrainingReports",
                column: "DogId",
                principalTable: "Dogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
