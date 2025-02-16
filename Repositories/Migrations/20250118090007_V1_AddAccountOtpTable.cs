using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class V1_AddAccountOtpTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountOtps",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OtpCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpirationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AccountId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsExpiredOrUsed = table.Column<bool>(type: "bit", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountOtps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccountOtps_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccountOtps_AccountId",
                table: "AccountOtps",
                column: "AccountId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountOtps");
        }
    }
}
