using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class V1_UpdateAccountRelaFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Availabilities_TrainerProfiles_TrainerProfileId",
                table: "Availabilities");

            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_StaffProfiles_StaffProfileId",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Certifications_TrainerProfiles_TrainerProfileId",
                table: "Certifications");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_TrainerProfiles_CreatedTrainerId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerProfiles_Memberships_MembershipId",
                table: "CustomerProfiles");

            migrationBuilder.DropForeignKey(
                name: "FK_DogOwnerships_CustomerProfiles_CustomerProfileId",
                table: "DogOwnerships");

            migrationBuilder.DropForeignKey(
                name: "FK_LegalDocuments_CustomerProfiles_CustomerProfileId",
                table: "LegalDocuments");

            migrationBuilder.DropForeignKey(
                name: "FK_ProgressReports_TrainerProfiles_TrainerProfileId",
                table: "ProgressReports");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainerAssignments_TrainerProfiles_TrainerProfileId",
                table: "TrainerAssignments");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainerSkills_TrainerProfiles_TrainerProfileId",
                table: "TrainerSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainerSpecializations_TrainerProfiles_TrainerProfileId",
                table: "TrainerSpecializations");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingReports_TrainerProfiles_TrainerProfileId",
                table: "TrainingReports");

            migrationBuilder.DropForeignKey(
                name: "FK_WishLists_CustomerProfiles_CustomerProfileId",
                table: "WishLists");

            migrationBuilder.DropColumn(
                name: "ProfileType",
                table: "Accounts");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerProfileId",
                table: "WishLists",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "CustomerId",
                table: "WishLists",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "TrainerProfileId",
                table: "TrainingReports",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "TrainerId",
                table: "TrainingReports",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "TrainerProfileId",
                table: "TrainerSpecializations",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "TrainerId",
                table: "TrainerSpecializations",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "TrainerProfileId",
                table: "TrainerSkills",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "TrainerId",
                table: "TrainerSkills",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "TrainerProfileId",
                table: "TrainerAssignments",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "TrainerId",
                table: "TrainerAssignments",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "TrainerProfileId",
                table: "ProgressReports",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "TrainerId",
                table: "ProgressReports",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CustomerId",
                table: "Payments",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerProfileId",
                table: "LegalDocuments",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "CustomerId",
                table: "LegalDocuments",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StaffId",
                table: "Enrollments",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerProfileId",
                table: "DogOwnerships",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "CustomerId",
                table: "DogOwnerships",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TrainerProfileId",
                table: "Courses",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TrainerProfileId",
                table: "Certifications",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "TrainerId",
                table: "Certifications",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "StaffProfileId",
                table: "Blogs",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "StaffId",
                table: "Blogs",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "TrainerProfileId",
                table: "Availabilities",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "TrainerId",
                table: "Availabilities",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Accounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "Accounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "MembershipId",
                table: "Accounts",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "MembershipPoints",
                table: "Accounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RoleId",
                table: "Accounts",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WishLists_CustomerId",
                table: "WishLists",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingReports_TrainerId",
                table: "TrainingReports",
                column: "TrainerId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainerSpecializations_TrainerId",
                table: "TrainerSpecializations",
                column: "TrainerId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainerSkills_TrainerId",
                table: "TrainerSkills",
                column: "TrainerId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainerAssignments_TrainerId",
                table: "TrainerAssignments",
                column: "TrainerId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgressReports_TrainerId",
                table: "ProgressReports",
                column: "TrainerId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_CustomerId",
                table: "Payments",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_LegalDocuments_CustomerId",
                table: "LegalDocuments",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_StaffId",
                table: "Enrollments",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_DogOwnerships_CustomerId",
                table: "DogOwnerships",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TrainerProfileId",
                table: "Courses",
                column: "TrainerProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Certifications_TrainerId",
                table: "Certifications",
                column: "TrainerId");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_StaffId",
                table: "Blogs",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_Availabilities_TrainerId",
                table: "Availabilities",
                column: "TrainerId");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_MembershipId",
                table: "Accounts",
                column: "MembershipId");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_RoleId",
                table: "Accounts",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Memberships_MembershipId",
                table: "Accounts",
                column: "MembershipId",
                principalTable: "Memberships",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Roles_RoleId",
                table: "Accounts",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Availabilities_Accounts_TrainerId",
                table: "Availabilities",
                column: "TrainerId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Availabilities_TrainerProfiles_TrainerProfileId",
                table: "Availabilities",
                column: "TrainerProfileId",
                principalTable: "TrainerProfiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Accounts_StaffId",
                table: "Blogs",
                column: "StaffId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_StaffProfiles_StaffProfileId",
                table: "Blogs",
                column: "StaffProfileId",
                principalTable: "StaffProfiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Certifications_Accounts_TrainerId",
                table: "Certifications",
                column: "TrainerId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Certifications_TrainerProfiles_TrainerProfileId",
                table: "Certifications",
                column: "TrainerProfileId",
                principalTable: "TrainerProfiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Accounts_CreatedTrainerId",
                table: "Courses",
                column: "CreatedTrainerId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_TrainerProfiles_TrainerProfileId",
                table: "Courses",
                column: "TrainerProfileId",
                principalTable: "TrainerProfiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerProfiles_Memberships_MembershipId",
                table: "CustomerProfiles",
                column: "MembershipId",
                principalTable: "Memberships",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DogOwnerships_Accounts_CustomerId",
                table: "DogOwnerships",
                column: "CustomerId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DogOwnerships_CustomerProfiles_CustomerProfileId",
                table: "DogOwnerships",
                column: "CustomerProfileId",
                principalTable: "CustomerProfiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Accounts_StaffId",
                table: "Enrollments",
                column: "StaffId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LegalDocuments_Accounts_CustomerId",
                table: "LegalDocuments",
                column: "CustomerId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LegalDocuments_CustomerProfiles_CustomerProfileId",
                table: "LegalDocuments",
                column: "CustomerProfileId",
                principalTable: "CustomerProfiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Accounts_CustomerId",
                table: "Payments",
                column: "CustomerId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProgressReports_Accounts_TrainerId",
                table: "ProgressReports",
                column: "TrainerId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProgressReports_TrainerProfiles_TrainerProfileId",
                table: "ProgressReports",
                column: "TrainerProfileId",
                principalTable: "TrainerProfiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TrainerAssignments_Accounts_TrainerId",
                table: "TrainerAssignments",
                column: "TrainerId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainerAssignments_TrainerProfiles_TrainerProfileId",
                table: "TrainerAssignments",
                column: "TrainerProfileId",
                principalTable: "TrainerProfiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TrainerSkills_Accounts_TrainerId",
                table: "TrainerSkills",
                column: "TrainerId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainerSkills_TrainerProfiles_TrainerProfileId",
                table: "TrainerSkills",
                column: "TrainerProfileId",
                principalTable: "TrainerProfiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TrainerSpecializations_Accounts_TrainerId",
                table: "TrainerSpecializations",
                column: "TrainerId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainerSpecializations_TrainerProfiles_TrainerProfileId",
                table: "TrainerSpecializations",
                column: "TrainerProfileId",
                principalTable: "TrainerProfiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingReports_Accounts_TrainerId",
                table: "TrainingReports",
                column: "TrainerId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingReports_TrainerProfiles_TrainerProfileId",
                table: "TrainingReports",
                column: "TrainerProfileId",
                principalTable: "TrainerProfiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WishLists_Accounts_CustomerId",
                table: "WishLists",
                column: "CustomerId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WishLists_CustomerProfiles_CustomerProfileId",
                table: "WishLists",
                column: "CustomerProfileId",
                principalTable: "CustomerProfiles",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Memberships_MembershipId",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Roles_RoleId",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Availabilities_Accounts_TrainerId",
                table: "Availabilities");

            migrationBuilder.DropForeignKey(
                name: "FK_Availabilities_TrainerProfiles_TrainerProfileId",
                table: "Availabilities");

            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Accounts_StaffId",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_StaffProfiles_StaffProfileId",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Certifications_Accounts_TrainerId",
                table: "Certifications");

            migrationBuilder.DropForeignKey(
                name: "FK_Certifications_TrainerProfiles_TrainerProfileId",
                table: "Certifications");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Accounts_CreatedTrainerId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_TrainerProfiles_TrainerProfileId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerProfiles_Memberships_MembershipId",
                table: "CustomerProfiles");

            migrationBuilder.DropForeignKey(
                name: "FK_DogOwnerships_Accounts_CustomerId",
                table: "DogOwnerships");

            migrationBuilder.DropForeignKey(
                name: "FK_DogOwnerships_CustomerProfiles_CustomerProfileId",
                table: "DogOwnerships");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Accounts_StaffId",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_LegalDocuments_Accounts_CustomerId",
                table: "LegalDocuments");

            migrationBuilder.DropForeignKey(
                name: "FK_LegalDocuments_CustomerProfiles_CustomerProfileId",
                table: "LegalDocuments");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Accounts_CustomerId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_ProgressReports_Accounts_TrainerId",
                table: "ProgressReports");

            migrationBuilder.DropForeignKey(
                name: "FK_ProgressReports_TrainerProfiles_TrainerProfileId",
                table: "ProgressReports");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainerAssignments_Accounts_TrainerId",
                table: "TrainerAssignments");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainerAssignments_TrainerProfiles_TrainerProfileId",
                table: "TrainerAssignments");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainerSkills_Accounts_TrainerId",
                table: "TrainerSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainerSkills_TrainerProfiles_TrainerProfileId",
                table: "TrainerSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainerSpecializations_Accounts_TrainerId",
                table: "TrainerSpecializations");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainerSpecializations_TrainerProfiles_TrainerProfileId",
                table: "TrainerSpecializations");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingReports_Accounts_TrainerId",
                table: "TrainingReports");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingReports_TrainerProfiles_TrainerProfileId",
                table: "TrainingReports");

            migrationBuilder.DropForeignKey(
                name: "FK_WishLists_Accounts_CustomerId",
                table: "WishLists");

            migrationBuilder.DropForeignKey(
                name: "FK_WishLists_CustomerProfiles_CustomerProfileId",
                table: "WishLists");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_WishLists_CustomerId",
                table: "WishLists");

            migrationBuilder.DropIndex(
                name: "IX_TrainingReports_TrainerId",
                table: "TrainingReports");

            migrationBuilder.DropIndex(
                name: "IX_TrainerSpecializations_TrainerId",
                table: "TrainerSpecializations");

            migrationBuilder.DropIndex(
                name: "IX_TrainerSkills_TrainerId",
                table: "TrainerSkills");

            migrationBuilder.DropIndex(
                name: "IX_TrainerAssignments_TrainerId",
                table: "TrainerAssignments");

            migrationBuilder.DropIndex(
                name: "IX_ProgressReports_TrainerId",
                table: "ProgressReports");

            migrationBuilder.DropIndex(
                name: "IX_Payments_CustomerId",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_LegalDocuments_CustomerId",
                table: "LegalDocuments");

            migrationBuilder.DropIndex(
                name: "IX_Enrollments_StaffId",
                table: "Enrollments");

            migrationBuilder.DropIndex(
                name: "IX_DogOwnerships_CustomerId",
                table: "DogOwnerships");

            migrationBuilder.DropIndex(
                name: "IX_Courses_TrainerProfileId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Certifications_TrainerId",
                table: "Certifications");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_StaffId",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Availabilities_TrainerId",
                table: "Availabilities");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_MembershipId",
                table: "Accounts");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_RoleId",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "WishLists");

            migrationBuilder.DropColumn(
                name: "TrainerId",
                table: "TrainingReports");

            migrationBuilder.DropColumn(
                name: "TrainerId",
                table: "TrainerSpecializations");

            migrationBuilder.DropColumn(
                name: "TrainerId",
                table: "TrainerSkills");

            migrationBuilder.DropColumn(
                name: "TrainerId",
                table: "TrainerAssignments");

            migrationBuilder.DropColumn(
                name: "TrainerId",
                table: "ProgressReports");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "LegalDocuments");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "Enrollments");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "DogOwnerships");

            migrationBuilder.DropColumn(
                name: "TrainerProfileId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "TrainerId",
                table: "Certifications");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "TrainerId",
                table: "Availabilities");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "MembershipId",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "MembershipPoints",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "Accounts");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerProfileId",
                table: "WishLists",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TrainerProfileId",
                table: "TrainingReports",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TrainerProfileId",
                table: "TrainerSpecializations",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TrainerProfileId",
                table: "TrainerSkills",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TrainerProfileId",
                table: "TrainerAssignments",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TrainerProfileId",
                table: "ProgressReports",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerProfileId",
                table: "LegalDocuments",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerProfileId",
                table: "DogOwnerships",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TrainerProfileId",
                table: "Certifications",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StaffProfileId",
                table: "Blogs",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TrainerProfileId",
                table: "Availabilities",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProfileType",
                table: "Accounts",
                type: "int",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Availabilities_TrainerProfiles_TrainerProfileId",
                table: "Availabilities",
                column: "TrainerProfileId",
                principalTable: "TrainerProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_StaffProfiles_StaffProfileId",
                table: "Blogs",
                column: "StaffProfileId",
                principalTable: "StaffProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Certifications_TrainerProfiles_TrainerProfileId",
                table: "Certifications",
                column: "TrainerProfileId",
                principalTable: "TrainerProfiles",
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
                name: "FK_CustomerProfiles_Memberships_MembershipId",
                table: "CustomerProfiles",
                column: "MembershipId",
                principalTable: "Memberships",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DogOwnerships_CustomerProfiles_CustomerProfileId",
                table: "DogOwnerships",
                column: "CustomerProfileId",
                principalTable: "CustomerProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LegalDocuments_CustomerProfiles_CustomerProfileId",
                table: "LegalDocuments",
                column: "CustomerProfileId",
                principalTable: "CustomerProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProgressReports_TrainerProfiles_TrainerProfileId",
                table: "ProgressReports",
                column: "TrainerProfileId",
                principalTable: "TrainerProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainerAssignments_TrainerProfiles_TrainerProfileId",
                table: "TrainerAssignments",
                column: "TrainerProfileId",
                principalTable: "TrainerProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainerSkills_TrainerProfiles_TrainerProfileId",
                table: "TrainerSkills",
                column: "TrainerProfileId",
                principalTable: "TrainerProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainerSpecializations_TrainerProfiles_TrainerProfileId",
                table: "TrainerSpecializations",
                column: "TrainerProfileId",
                principalTable: "TrainerProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingReports_TrainerProfiles_TrainerProfileId",
                table: "TrainingReports",
                column: "TrainerProfileId",
                principalTable: "TrainerProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WishLists_CustomerProfiles_CustomerProfileId",
                table: "WishLists",
                column: "CustomerProfileId",
                principalTable: "CustomerProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
