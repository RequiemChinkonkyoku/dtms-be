using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class V1_UpdateProfileRelaRemove : Migration
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
                name: "FK_Courses_TrainerProfiles_TrainerProfileId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerProfiles_CustomerRoles_CustomerRoleId",
                table: "CustomerProfiles");

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
                name: "FK_StaffProfiles_StaffRoles_StaffRoleId",
                table: "StaffProfiles");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainerAssignments_TrainerProfiles_TrainerProfileId",
                table: "TrainerAssignments");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainerProfiles_TrainerRoles_TrainerRoleId",
                table: "TrainerProfiles");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainerReports_CustomerProfiles_CustomerProfileId",
                table: "TrainerReports");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainerReports_TrainerProfiles_TrainerProfileId",
                table: "TrainerReports");

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

            migrationBuilder.DropIndex(
                name: "IX_WishLists_CustomerProfileId",
                table: "WishLists");

            migrationBuilder.DropIndex(
                name: "IX_TrainingReports_TrainerProfileId",
                table: "TrainingReports");

            migrationBuilder.DropIndex(
                name: "IX_TrainerSpecializations_TrainerProfileId",
                table: "TrainerSpecializations");

            migrationBuilder.DropIndex(
                name: "IX_TrainerSkills_TrainerProfileId",
                table: "TrainerSkills");

            migrationBuilder.DropIndex(
                name: "IX_TrainerAssignments_TrainerProfileId",
                table: "TrainerAssignments");

            migrationBuilder.DropIndex(
                name: "IX_ProgressReports_TrainerProfileId",
                table: "ProgressReports");

            migrationBuilder.DropIndex(
                name: "IX_LegalDocuments_CustomerProfileId",
                table: "LegalDocuments");

            migrationBuilder.DropIndex(
                name: "IX_DogOwnerships_CustomerProfileId",
                table: "DogOwnerships");

            migrationBuilder.DropIndex(
                name: "IX_CustomerProfiles_MembershipId",
                table: "CustomerProfiles");

            migrationBuilder.DropIndex(
                name: "IX_Courses_TrainerProfileId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Certifications_TrainerProfileId",
                table: "Certifications");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_StaffProfileId",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Availabilities_TrainerProfileId",
                table: "Availabilities");

            migrationBuilder.DropColumn(
                name: "CustomerProfileId",
                table: "WishLists");

            migrationBuilder.DropColumn(
                name: "TrainerProfileId",
                table: "TrainingReports");

            migrationBuilder.DropColumn(
                name: "TrainerProfileId",
                table: "TrainerSpecializations");

            migrationBuilder.DropColumn(
                name: "TrainerProfileId",
                table: "TrainerSkills");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "TrainerProfiles");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "TrainerProfiles");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "TrainerProfiles");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "TrainerProfiles");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "TrainerProfiles");

            migrationBuilder.DropColumn(
                name: "TrainerProfileId",
                table: "TrainerAssignments");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "StaffProfiles");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "StaffProfiles");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "StaffProfiles");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "StaffProfiles");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "StaffProfiles");

            migrationBuilder.DropColumn(
                name: "TrainerProfileId",
                table: "ProgressReports");

            migrationBuilder.DropColumn(
                name: "CustomerProfileId",
                table: "LegalDocuments");

            migrationBuilder.DropColumn(
                name: "CustomerProfileId",
                table: "DogOwnerships");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "CustomerProfiles");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "CustomerProfiles");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "CustomerProfiles");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "CustomerProfiles");

            migrationBuilder.DropColumn(
                name: "MembershipId",
                table: "CustomerProfiles");

            migrationBuilder.DropColumn(
                name: "MembershipPoints",
                table: "CustomerProfiles");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "CustomerProfiles");

            migrationBuilder.DropColumn(
                name: "TrainerProfileId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "TrainerProfileId",
                table: "Certifications");

            migrationBuilder.DropColumn(
                name: "StaffProfileId",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "TrainerProfileId",
                table: "Availabilities");

            migrationBuilder.RenameColumn(
                name: "TrainerProfileId",
                table: "TrainerReports",
                newName: "TrainerId");

            migrationBuilder.RenameColumn(
                name: "CustomerProfileId",
                table: "TrainerReports",
                newName: "CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_TrainerReports_TrainerProfileId",
                table: "TrainerReports",
                newName: "IX_TrainerReports_TrainerId");

            migrationBuilder.RenameIndex(
                name: "IX_TrainerReports_CustomerProfileId",
                table: "TrainerReports",
                newName: "IX_TrainerReports_CustomerId");

            migrationBuilder.AlterColumn<string>(
                name: "TrainerRoleId",
                table: "TrainerProfiles",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "StaffRoleId",
                table: "StaffProfiles",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerRoleId",
                table: "CustomerProfiles",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerProfiles_CustomerRoles_CustomerRoleId",
                table: "CustomerProfiles",
                column: "CustomerRoleId",
                principalTable: "CustomerRoles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StaffProfiles_StaffRoles_StaffRoleId",
                table: "StaffProfiles",
                column: "StaffRoleId",
                principalTable: "StaffRoles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TrainerProfiles_TrainerRoles_TrainerRoleId",
                table: "TrainerProfiles",
                column: "TrainerRoleId",
                principalTable: "TrainerRoles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TrainerReports_Accounts_CustomerId",
                table: "TrainerReports",
                column: "CustomerId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainerReports_Accounts_TrainerId",
                table: "TrainerReports",
                column: "TrainerId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerProfiles_CustomerRoles_CustomerRoleId",
                table: "CustomerProfiles");

            migrationBuilder.DropForeignKey(
                name: "FK_StaffProfiles_StaffRoles_StaffRoleId",
                table: "StaffProfiles");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainerProfiles_TrainerRoles_TrainerRoleId",
                table: "TrainerProfiles");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainerReports_Accounts_CustomerId",
                table: "TrainerReports");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainerReports_Accounts_TrainerId",
                table: "TrainerReports");

            migrationBuilder.RenameColumn(
                name: "TrainerId",
                table: "TrainerReports",
                newName: "TrainerProfileId");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "TrainerReports",
                newName: "CustomerProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_TrainerReports_TrainerId",
                table: "TrainerReports",
                newName: "IX_TrainerReports_TrainerProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_TrainerReports_CustomerId",
                table: "TrainerReports",
                newName: "IX_TrainerReports_CustomerProfileId");

            migrationBuilder.AddColumn<string>(
                name: "CustomerProfileId",
                table: "WishLists",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TrainerProfileId",
                table: "TrainingReports",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TrainerProfileId",
                table: "TrainerSpecializations",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TrainerProfileId",
                table: "TrainerSkills",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TrainerRoleId",
                table: "TrainerProfiles",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "TrainerProfiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "TrainerProfiles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "TrainerProfiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "TrainerProfiles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "TrainerProfiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TrainerProfileId",
                table: "TrainerAssignments",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StaffRoleId",
                table: "StaffProfiles",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "StaffProfiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "StaffProfiles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "StaffProfiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "StaffProfiles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "StaffProfiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TrainerProfileId",
                table: "ProgressReports",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerProfileId",
                table: "LegalDocuments",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerProfileId",
                table: "DogOwnerships",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerRoleId",
                table: "CustomerProfiles",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "CustomerProfiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "CustomerProfiles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "CustomerProfiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "CustomerProfiles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "MembershipId",
                table: "CustomerProfiles",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "MembershipPoints",
                table: "CustomerProfiles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "CustomerProfiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TrainerProfileId",
                table: "Courses",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TrainerProfileId",
                table: "Certifications",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StaffProfileId",
                table: "Blogs",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TrainerProfileId",
                table: "Availabilities",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WishLists_CustomerProfileId",
                table: "WishLists",
                column: "CustomerProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingReports_TrainerProfileId",
                table: "TrainingReports",
                column: "TrainerProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainerSpecializations_TrainerProfileId",
                table: "TrainerSpecializations",
                column: "TrainerProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainerSkills_TrainerProfileId",
                table: "TrainerSkills",
                column: "TrainerProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainerAssignments_TrainerProfileId",
                table: "TrainerAssignments",
                column: "TrainerProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgressReports_TrainerProfileId",
                table: "ProgressReports",
                column: "TrainerProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_LegalDocuments_CustomerProfileId",
                table: "LegalDocuments",
                column: "CustomerProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_DogOwnerships_CustomerProfileId",
                table: "DogOwnerships",
                column: "CustomerProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerProfiles_MembershipId",
                table: "CustomerProfiles",
                column: "MembershipId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TrainerProfileId",
                table: "Courses",
                column: "TrainerProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Certifications_TrainerProfileId",
                table: "Certifications",
                column: "TrainerProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_StaffProfileId",
                table: "Blogs",
                column: "StaffProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Availabilities_TrainerProfileId",
                table: "Availabilities",
                column: "TrainerProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Availabilities_TrainerProfiles_TrainerProfileId",
                table: "Availabilities",
                column: "TrainerProfileId",
                principalTable: "TrainerProfiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_StaffProfiles_StaffProfileId",
                table: "Blogs",
                column: "StaffProfileId",
                principalTable: "StaffProfiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Certifications_TrainerProfiles_TrainerProfileId",
                table: "Certifications",
                column: "TrainerProfileId",
                principalTable: "TrainerProfiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_TrainerProfiles_TrainerProfileId",
                table: "Courses",
                column: "TrainerProfileId",
                principalTable: "TrainerProfiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerProfiles_CustomerRoles_CustomerRoleId",
                table: "CustomerProfiles",
                column: "CustomerRoleId",
                principalTable: "CustomerRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerProfiles_Memberships_MembershipId",
                table: "CustomerProfiles",
                column: "MembershipId",
                principalTable: "Memberships",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DogOwnerships_CustomerProfiles_CustomerProfileId",
                table: "DogOwnerships",
                column: "CustomerProfileId",
                principalTable: "CustomerProfiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LegalDocuments_CustomerProfiles_CustomerProfileId",
                table: "LegalDocuments",
                column: "CustomerProfileId",
                principalTable: "CustomerProfiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProgressReports_TrainerProfiles_TrainerProfileId",
                table: "ProgressReports",
                column: "TrainerProfileId",
                principalTable: "TrainerProfiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StaffProfiles_StaffRoles_StaffRoleId",
                table: "StaffProfiles",
                column: "StaffRoleId",
                principalTable: "StaffRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainerAssignments_TrainerProfiles_TrainerProfileId",
                table: "TrainerAssignments",
                column: "TrainerProfileId",
                principalTable: "TrainerProfiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TrainerProfiles_TrainerRoles_TrainerRoleId",
                table: "TrainerProfiles",
                column: "TrainerRoleId",
                principalTable: "TrainerRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainerReports_CustomerProfiles_CustomerProfileId",
                table: "TrainerReports",
                column: "CustomerProfileId",
                principalTable: "CustomerProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainerReports_TrainerProfiles_TrainerProfileId",
                table: "TrainerReports",
                column: "TrainerProfileId",
                principalTable: "TrainerProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainerSkills_TrainerProfiles_TrainerProfileId",
                table: "TrainerSkills",
                column: "TrainerProfileId",
                principalTable: "TrainerProfiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TrainerSpecializations_TrainerProfiles_TrainerProfileId",
                table: "TrainerSpecializations",
                column: "TrainerProfileId",
                principalTable: "TrainerProfiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingReports_TrainerProfiles_TrainerProfileId",
                table: "TrainingReports",
                column: "TrainerProfileId",
                principalTable: "TrainerProfiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WishLists_CustomerProfiles_CustomerProfileId",
                table: "WishLists",
                column: "CustomerProfileId",
                principalTable: "CustomerProfiles",
                principalColumn: "Id");
        }
    }
}
