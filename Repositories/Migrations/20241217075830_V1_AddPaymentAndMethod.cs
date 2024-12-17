using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class V1_AddPaymentAndMethod : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StaffProfile_Accounts_AccountId",
                table: "StaffProfile");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainerProfile_Accounts_AccountId",
                table: "TrainerProfile");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TrainerProfile",
                table: "TrainerProfile");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StaffProfile",
                table: "StaffProfile");

            migrationBuilder.RenameTable(
                name: "TrainerProfile",
                newName: "TrainerProfiles");

            migrationBuilder.RenameTable(
                name: "StaffProfile",
                newName: "StaffProfiles");

            migrationBuilder.RenameIndex(
                name: "IX_TrainerProfile_AccountId",
                table: "TrainerProfiles",
                newName: "IX_TrainerProfiles_AccountId");

            migrationBuilder.RenameIndex(
                name: "IX_StaffProfile_AccountId",
                table: "StaffProfiles",
                newName: "IX_StaffProfiles_AccountId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrainerProfiles",
                table: "TrainerProfiles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StaffProfiles",
                table: "StaffProfiles",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Enrollments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrollments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmountDue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EnrollmentId = table.Column<int>(type: "int", nullable: false),
                    MembershipId = table.Column<int>(type: "int", nullable: true),
                    PaymentMethodId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_Enrollments_EnrollmentId",
                        column: x => x.EnrollmentId,
                        principalTable: "Enrollments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payments_Memberships_MembershipId",
                        column: x => x.MembershipId,
                        principalTable: "Memberships",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Payments_PaymentMethods_PaymentMethodId",
                        column: x => x.PaymentMethodId,
                        principalTable: "PaymentMethods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Payments_EnrollmentId",
                table: "Payments",
                column: "EnrollmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_MembershipId",
                table: "Payments",
                column: "MembershipId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_PaymentMethodId",
                table: "Payments",
                column: "PaymentMethodId");

            migrationBuilder.AddForeignKey(
                name: "FK_StaffProfiles_Accounts_AccountId",
                table: "StaffProfiles",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainerProfiles_Accounts_AccountId",
                table: "TrainerProfiles",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StaffProfiles_Accounts_AccountId",
                table: "StaffProfiles");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainerProfiles_Accounts_AccountId",
                table: "TrainerProfiles");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Enrollments");

            migrationBuilder.DropTable(
                name: "PaymentMethods");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TrainerProfiles",
                table: "TrainerProfiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StaffProfiles",
                table: "StaffProfiles");

            migrationBuilder.RenameTable(
                name: "TrainerProfiles",
                newName: "TrainerProfile");

            migrationBuilder.RenameTable(
                name: "StaffProfiles",
                newName: "StaffProfile");

            migrationBuilder.RenameIndex(
                name: "IX_TrainerProfiles_AccountId",
                table: "TrainerProfile",
                newName: "IX_TrainerProfile_AccountId");

            migrationBuilder.RenameIndex(
                name: "IX_StaffProfiles_AccountId",
                table: "StaffProfile",
                newName: "IX_StaffProfile_AccountId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrainerProfile",
                table: "TrainerProfile",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StaffProfile",
                table: "StaffProfile",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StaffProfile_Accounts_AccountId",
                table: "StaffProfile",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainerProfile_Accounts_AccountId",
                table: "TrainerProfile",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
