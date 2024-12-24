using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class V1_UpdateEntitiesAttrToMatchDiagramV4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_TrainerProfiles_TrainerProfileId",
                table: "Courses");

            migrationBuilder.DropTable(
                name: "CourseLessons");

            migrationBuilder.DropTable(
                name: "SlotEquipments");

            migrationBuilder.DropTable(
                name: "CourseEquipments");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Lessons",
                newName: "Objective");

            migrationBuilder.RenameColumn(
                name: "TrainerProfileId",
                table: "Courses",
                newName: "CreatedTrainerId");

            migrationBuilder.RenameIndex(
                name: "IX_Courses_TrainerProfileId",
                table: "Courses",
                newName: "IX_Courses_CreatedTrainerId");

            migrationBuilder.AddColumn<int>(
                name: "Duration",
                table: "Lessons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Environment",
                table: "Lessons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LessonTitle",
                table: "Lessons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EquipmentCategoryId",
                table: "Equipments",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DogBreedId",
                table: "Dogs",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CustomerRoleId",
                table: "CustomerProfiles",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CageCategoryId",
                table: "Cages",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "CageCategories",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CageCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerRoles",
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
                    table.PrimaryKey("PK_CustomerRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DogBreeds",
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
                    table.PrimaryKey("PK_DogBreeds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentCategories",
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
                    table.PrimaryKey("PK_EquipmentCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LessonEquipments",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LessonId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EquipmentId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessonEquipments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LessonEquipments_Equipments_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LessonEquipments_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SlotLessons",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SlotId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LessonId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
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
                name: "IX_Equipments_EquipmentCategoryId",
                table: "Equipments",
                column: "EquipmentCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Dogs_DogBreedId",
                table: "Dogs",
                column: "DogBreedId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerProfiles_CustomerRoleId",
                table: "CustomerProfiles",
                column: "CustomerRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Cages_CageCategoryId",
                table: "Cages",
                column: "CageCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_LessonEquipments_EquipmentId",
                table: "LessonEquipments",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_LessonEquipments_LessonId",
                table: "LessonEquipments",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_SlotLessons_LessonId",
                table: "SlotLessons",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_SlotLessons_SlotId",
                table: "SlotLessons",
                column: "SlotId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cages_CageCategories_CageCategoryId",
                table: "Cages",
                column: "CageCategoryId",
                principalTable: "CageCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_TrainerProfiles_CreatedTrainerId",
                table: "Courses",
                column: "CreatedTrainerId",
                principalTable: "TrainerProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerProfiles_CustomerRoles_CustomerRoleId",
                table: "CustomerProfiles",
                column: "CustomerRoleId",
                principalTable: "CustomerRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Dogs_DogBreeds_DogBreedId",
                table: "Dogs",
                column: "DogBreedId",
                principalTable: "DogBreeds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipments_EquipmentCategories_EquipmentCategoryId",
                table: "Equipments",
                column: "EquipmentCategoryId",
                principalTable: "EquipmentCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cages_CageCategories_CageCategoryId",
                table: "Cages");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_TrainerProfiles_CreatedTrainerId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerProfiles_CustomerRoles_CustomerRoleId",
                table: "CustomerProfiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Dogs_DogBreeds_DogBreedId",
                table: "Dogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipments_EquipmentCategories_EquipmentCategoryId",
                table: "Equipments");

            migrationBuilder.DropTable(
                name: "CageCategories");

            migrationBuilder.DropTable(
                name: "CustomerRoles");

            migrationBuilder.DropTable(
                name: "DogBreeds");

            migrationBuilder.DropTable(
                name: "EquipmentCategories");

            migrationBuilder.DropTable(
                name: "LessonEquipments");

            migrationBuilder.DropTable(
                name: "SlotLessons");

            migrationBuilder.DropIndex(
                name: "IX_Equipments_EquipmentCategoryId",
                table: "Equipments");

            migrationBuilder.DropIndex(
                name: "IX_Dogs_DogBreedId",
                table: "Dogs");

            migrationBuilder.DropIndex(
                name: "IX_CustomerProfiles_CustomerRoleId",
                table: "CustomerProfiles");

            migrationBuilder.DropIndex(
                name: "IX_Cages_CageCategoryId",
                table: "Cages");

            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Lessons");

            migrationBuilder.DropColumn(
                name: "Environment",
                table: "Lessons");

            migrationBuilder.DropColumn(
                name: "LessonTitle",
                table: "Lessons");

            migrationBuilder.DropColumn(
                name: "EquipmentCategoryId",
                table: "Equipments");

            migrationBuilder.DropColumn(
                name: "DogBreedId",
                table: "Dogs");

            migrationBuilder.DropColumn(
                name: "CustomerRoleId",
                table: "CustomerProfiles");

            migrationBuilder.DropColumn(
                name: "CageCategoryId",
                table: "Cages");

            migrationBuilder.RenameColumn(
                name: "Objective",
                table: "Lessons",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "CreatedTrainerId",
                table: "Courses",
                newName: "TrainerProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_Courses_CreatedTrainerId",
                table: "Courses",
                newName: "IX_Courses_TrainerProfileId");

            migrationBuilder.CreateTable(
                name: "CourseEquipments",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CourseId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EquipmentId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseEquipments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseEquipments_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CourseEquipments_Equipments_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CourseLessons",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CourseId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LessonId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                        name: "FK_CourseLessons_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SlotEquipments",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CourseEquipmentId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SlotId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SlotEquipments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SlotEquipments_CourseEquipments_CourseEquipmentId",
                        column: x => x.CourseEquipmentId,
                        principalTable: "CourseEquipments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SlotEquipments_Slots_SlotId",
                        column: x => x.SlotId,
                        principalTable: "Slots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseEquipments_CourseId",
                table: "CourseEquipments",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseEquipments_EquipmentId",
                table: "CourseEquipments",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseLessons_CourseId",
                table: "CourseLessons",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseLessons_LessonId",
                table: "CourseLessons",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_SlotEquipments_CourseEquipmentId",
                table: "SlotEquipments",
                column: "CourseEquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_SlotEquipments_SlotId",
                table: "SlotEquipments",
                column: "SlotId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_TrainerProfiles_TrainerProfileId",
                table: "Courses",
                column: "TrainerProfileId",
                principalTable: "TrainerProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
