using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class V1_RemoveProfileType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TrainerProfiles_AccountId",
                table: "TrainerProfiles");

            migrationBuilder.DropIndex(
                name: "IX_StaffProfiles_AccountId",
                table: "StaffProfiles");

            migrationBuilder.DropIndex(
                name: "IX_CustomerProfiles_AccountId",
                table: "CustomerProfiles");

            migrationBuilder.DropColumn(
                name: "CustomerProfileId",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "StaffProfileId",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "TrainerProfileId",
                table: "Accounts");

            migrationBuilder.CreateIndex(
                name: "IX_TrainerProfiles_AccountId",
                table: "TrainerProfiles",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_StaffProfiles_AccountId",
                table: "StaffProfiles",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerProfiles_AccountId",
                table: "CustomerProfiles",
                column: "AccountId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TrainerProfiles_AccountId",
                table: "TrainerProfiles");

            migrationBuilder.DropIndex(
                name: "IX_StaffProfiles_AccountId",
                table: "StaffProfiles");

            migrationBuilder.DropIndex(
                name: "IX_CustomerProfiles_AccountId",
                table: "CustomerProfiles");

            migrationBuilder.AddColumn<string>(
                name: "CustomerProfileId",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StaffProfileId",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TrainerProfileId",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TrainerProfiles_AccountId",
                table: "TrainerProfiles",
                column: "AccountId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StaffProfiles_AccountId",
                table: "StaffProfiles",
                column: "AccountId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerProfiles_AccountId",
                table: "CustomerProfiles",
                column: "AccountId",
                unique: true);
        }
    }
}
