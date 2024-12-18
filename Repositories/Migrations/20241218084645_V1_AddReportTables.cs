using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class V1_AddReportTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Attendance",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClassId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DogId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attendance_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Attendance_Dogs_DogId",
                        column: x => x.DogId,
                        principalTable: "Dogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TrainerReport",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrainerProfileId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CustomerProfileId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainerReport", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainerReport_CustomerProfiles_CustomerProfileId",
                        column: x => x.CustomerProfileId,
                        principalTable: "CustomerProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TrainerReport_TrainerProfiles_TrainerProfileId",
                        column: x => x.TrainerProfileId,
                        principalTable: "TrainerProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TrainingReport",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BehaviorType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Intensity = table.Column<int>(type: "int", nullable: false),
                    ReactionToCommands = table.Column<int>(type: "int", nullable: false),
                    Socialization = table.Column<int>(type: "int", nullable: false),
                    StressLevel = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DogId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TrainerProfileId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingReport", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingReport_Dogs_DogId",
                        column: x => x.DogId,
                        principalTable: "Dogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TrainingReport_TrainerProfiles_TrainerProfileId",
                        column: x => x.TrainerProfileId,
                        principalTable: "TrainerProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProgressReport",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Feedback = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HealthObservation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BehaviorObservation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PerformanceObservation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    AttendanceId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TrainerProfileId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgressReport", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProgressReport_Attendance_AttendanceId",
                        column: x => x.AttendanceId,
                        principalTable: "Attendance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProgressReport_TrainerProfiles_TrainerProfileId",
                        column: x => x.TrainerProfileId,
                        principalTable: "TrainerProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attendance_ClassId",
                table: "Attendance",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Attendance_DogId",
                table: "Attendance",
                column: "DogId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgressReport_AttendanceId",
                table: "ProgressReport",
                column: "AttendanceId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgressReport_TrainerProfileId",
                table: "ProgressReport",
                column: "TrainerProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainerReport_CustomerProfileId",
                table: "TrainerReport",
                column: "CustomerProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainerReport_TrainerProfileId",
                table: "TrainerReport",
                column: "TrainerProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingReport_DogId",
                table: "TrainingReport",
                column: "DogId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingReport_TrainerProfileId",
                table: "TrainingReport",
                column: "TrainerProfileId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProgressReport");

            migrationBuilder.DropTable(
                name: "TrainerReport");

            migrationBuilder.DropTable(
                name: "TrainingReport");

            migrationBuilder.DropTable(
                name: "Attendance");
        }
    }
}
