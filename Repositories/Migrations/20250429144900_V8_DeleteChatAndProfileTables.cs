using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class V8_DeleteChatAndProfileTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chats");

            migrationBuilder.DropTable(
                name: "CustomerProfiles");

            migrationBuilder.DropTable(
                name: "StaffProfiles");

            migrationBuilder.DropTable(
                name: "TrainerProfiles");

            migrationBuilder.DropTable(
                name: "CustomerRoles");

            migrationBuilder.DropTable(
                name: "StaffRoles");

            migrationBuilder.DropTable(
                name: "TrainerRoles");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "00786efb729542fa87a19d44fb3cdf79",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 29, 21, 48, 57, 148, DateTimeKind.Unspecified).AddTicks(3844), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 29, 21, 48, 57, 148, DateTimeKind.Unspecified).AddTicks(3844), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$kvdKf2HaOdWYsgMDUNv8IORkkzxZgMRM2Uwv4Evzzc9xC9ZRnGsDS" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "2bf1c6f4a7db4fed825958e6d78e7226",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 29, 21, 48, 57, 7, DateTimeKind.Unspecified).AddTicks(4917), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 29, 21, 48, 57, 7, DateTimeKind.Unspecified).AddTicks(4917), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$3foO1.sXM43cju.UmM683e7z2d1O7Ln.jvbRjAkbFbjq.plHD4K4O" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "54d3a3e95adc4b38885e43af50e12e42",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 29, 21, 48, 56, 581, DateTimeKind.Unspecified).AddTicks(1910), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 29, 21, 48, 56, 581, DateTimeKind.Unspecified).AddTicks(1910), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$P15HKa4EspWAzn7rzcg6debP.xKfzsbD2ryNc2RsZH7n/IBfl2R3." });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "6144c9fe6b7e4f4294ea469ffb6a90fd",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 29, 21, 48, 56, 436, DateTimeKind.Unspecified).AddTicks(2120), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 29, 21, 48, 56, 436, DateTimeKind.Unspecified).AddTicks(2120), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$eCCzB.1rwG2gZT/RCsquse/x/G8882kmJfn4GQG6rubYDZN/V6TIO" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "9f7c3e8a4b6d49f19a8d2e3f4c7b5680",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 29, 21, 48, 57, 434, DateTimeKind.Unspecified).AddTicks(2932), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 29, 21, 48, 57, 434, DateTimeKind.Unspecified).AddTicks(2932), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$5uR60ZLArEdVpC2q9U77aeBh/Dn15a3r3Nw1CzlncU2fgKBcBhm02" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "a1b2c3d4e5f648a9b0c1d2e3f4a5b6c1",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 29, 21, 48, 58, 937, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 29, 21, 48, 58, 937, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$6lZVJA8gI/p2PvpVV2V.bOi4pcQNDxKA0avhnhF2do2saOrTXyr42" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "a1b2c3d4e5f648a9b0c1d2e3f4a5b6c7",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 29, 21, 48, 57, 565, DateTimeKind.Unspecified).AddTicks(7706), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 29, 21, 48, 57, 565, DateTimeKind.Unspecified).AddTicks(7706), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$AshKS4HE6sCl2TgFQlQeyuyzMm3A66041r2TZYKHfwiKaCFIjk6He" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "a5b6c7d8e9f0a1b2c3d4e5f648a9b0c1",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 29, 21, 48, 58, 800, DateTimeKind.Unspecified).AddTicks(6150), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 29, 21, 48, 58, 800, DateTimeKind.Unspecified).AddTicks(6150), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$e0aCMDrBUK/Qy1PC5gs5r.hYay6emFpeh5LsP/ybkrzffNrInwT2m" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "a9b0c1d2e3f4a5b6c7d8e9f0a1b2c3d4",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 29, 21, 48, 58, 392, DateTimeKind.Unspecified).AddTicks(3408), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 29, 21, 48, 58, 392, DateTimeKind.Unspecified).AddTicks(3408), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$M3kTCgD7brYT8EeEqkp1sObubU.UjWfOplpOSORU3ge9Nj/yTOJfy" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "b2c3d4e5f648a9b0c1d2e3f4a5b6c1d2",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 29, 21, 48, 59, 68, DateTimeKind.Unspecified).AddTicks(4186), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 29, 21, 48, 59, 68, DateTimeKind.Unspecified).AddTicks(4186), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$4bVlXl5Rrv2LzdfsP39xB.bljkiUJn2yFSB50qpUoGjmJEM.sgW8u" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "b2c3d4e5f648a9b0c1d2e3f4a5b6c7d8",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 29, 21, 48, 57, 696, DateTimeKind.Unspecified).AddTicks(9448), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 29, 21, 48, 57, 696, DateTimeKind.Unspecified).AddTicks(9448), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$XNGwhXKyVgFACrRhkCjbdO62kCJM7MIaNPVvcRQ/0NMz5dZN2.PLK" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "c1d2e3f4a5b6c7d8e9f0a1b2c3d4e5f6",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 29, 21, 48, 58, 533, DateTimeKind.Unspecified).AddTicks(720), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 29, 21, 48, 58, 533, DateTimeKind.Unspecified).AddTicks(720), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$SrO4/EFhDGR/SvTScjjjmedmnpQH07DF9o.RjrTUNgK5/Z1QNCCWS" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "c3d4e5f648a9b0c1d2e3f4a5b6c1d2e3",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 29, 21, 48, 59, 206, DateTimeKind.Unspecified).AddTicks(3115), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 29, 21, 48, 59, 206, DateTimeKind.Unspecified).AddTicks(3115), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$W.UaEVZEtI1.bT9ghQWwf.jq8oLjEySDf6cUPWiWMSjefD.ewyoTS" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "c3d4e5f648a9b0c1d2e3f4a5b6c7d8e9",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 29, 21, 48, 57, 828, DateTimeKind.Unspecified).AddTicks(3203), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 29, 21, 48, 57, 828, DateTimeKind.Unspecified).AddTicks(3203), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$uaLsJL4t2kcGq1IZ/z9Wtu97SW.mZiNs9Huw6mBsVRRX8vq8sBJSK" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "d4e5f648a9b0c1d2e3f4a5b6c1d2e3f4",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 29, 21, 48, 59, 342, DateTimeKind.Unspecified).AddTicks(3038), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 29, 21, 48, 59, 342, DateTimeKind.Unspecified).AddTicks(3038), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$Y.Hx5LG/sOkOTn5Wp5ZYWuotfICLoMc4ZSyCr6leE0tbMQvpNXC22" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "d4e5f648a9b0c1d2e3f4a5b6c7d8e9f0",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 29, 21, 48, 57, 969, DateTimeKind.Unspecified).AddTicks(1943), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 29, 21, 48, 57, 969, DateTimeKind.Unspecified).AddTicks(1943), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$ktYyxbWrrNt1943u9BXcqO8o/6VL7bmcVESW6xPUK5/9Eo6xVhsfa" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "e3f4a5b6c7d8e9f0a1b2c3d4e5f648a9",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 29, 21, 48, 58, 669, DateTimeKind.Unspecified).AddTicks(1245), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 29, 21, 48, 58, 669, DateTimeKind.Unspecified).AddTicks(1245), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$OcU6poyCgpjIXIcAR.1zI.LhzHRlOZ/B3Wqn7hcJJMVvGoWYv0M7a" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "e5f648a9b0c1d2e3f4a5b6c1d2e3f4a5",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 29, 21, 48, 59, 492, DateTimeKind.Unspecified).AddTicks(1130), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 29, 21, 48, 59, 492, DateTimeKind.Unspecified).AddTicks(1130), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$JoED/n4O3MxIcpdR0TXRS.AUDlD3UYMkli/8WnDmuhdO3OKoH7Ihi" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "e5f648a9b0c1d2e3f4a5b6c7d8e9f0a1",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 29, 21, 48, 58, 105, DateTimeKind.Unspecified).AddTicks(6478), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 29, 21, 48, 58, 105, DateTimeKind.Unspecified).AddTicks(6478), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$95wnYVwKeG7ItKUGm5lWQOt2zpVtEELjoU4kzmmECwdP3GvCdLwD6" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "ea46ce4e457f42dfb18b6347bd4ea1f4",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 29, 21, 48, 56, 869, DateTimeKind.Unspecified).AddTicks(9885), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 29, 21, 48, 56, 869, DateTimeKind.Unspecified).AddTicks(9885), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$6JAxRHWcwxm1M.GjyNWWEeySyyMVytVLrIcIPVaRdKAWua.vc.Ccm" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "eaa27cff0c91479087bb22370ffbb6d0",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 29, 21, 48, 57, 287, DateTimeKind.Unspecified).AddTicks(5487), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 29, 21, 48, 57, 287, DateTimeKind.Unspecified).AddTicks(5487), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$Z0jd0spApzbNxZE1eZZQTuD6XFg1pBRwPPkEYxX1wCoAxE.JFWyza" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "f648a9b0c1d2e3f4a5b6c7d8e9f0a1b2",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 29, 21, 48, 58, 252, DateTimeKind.Unspecified).AddTicks(4463), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 29, 21, 48, 58, 252, DateTimeKind.Unspecified).AddTicks(4463), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$BMTUJrCQ8psPUdSY9aqV6Oix1b1patG/enGtfM7MGg/.SQFke1ujq" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "fa13bc18b0c54ba0b9886b007f4d8b08",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 29, 21, 48, 56, 732, DateTimeKind.Unspecified).AddTicks(9218), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 29, 21, 48, 56, 732, DateTimeKind.Unspecified).AddTicks(9218), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$YD7pWagPyeW2rotKFkYhkezYb5WAHDe3kdTMsgsWNbkmRg18ne4o6" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Chats",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ReceiverId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SenderId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    IsRead = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chats_Accounts_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Chats_Accounts_SenderId",
                        column: x => x.SenderId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CustomerRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StaffRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrainerRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainerRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerProfiles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AccountId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CustomerRoleId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerProfiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerProfiles_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerProfiles_CustomerRoles_CustomerRoleId",
                        column: x => x.CustomerRoleId,
                        principalTable: "CustomerRoles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StaffProfiles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AccountId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DateOfHire = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmploymentType = table.Column<int>(type: "int", nullable: false),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    StaffRoleId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffProfiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StaffProfiles_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StaffProfiles_StaffRoles_StaffRoleId",
                        column: x => x.StaffRoleId,
                        principalTable: "StaffRoles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TrainerProfiles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AccountId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DateOfHire = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmploymentStatus = table.Column<int>(type: "int", nullable: false),
                    EmploymentType = table.Column<int>(type: "int", nullable: false),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    TrainerRoleId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainerProfiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainerProfiles_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainerProfiles_TrainerRoles_TrainerRoleId",
                        column: x => x.TrainerRoleId,
                        principalTable: "TrainerRoles",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "00786efb729542fa87a19d44fb3cdf79",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 27, 16, 53, 20, 928, DateTimeKind.Unspecified).AddTicks(4740), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 27, 16, 53, 20, 928, DateTimeKind.Unspecified).AddTicks(4740), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$2/28M4iZiNb6KTme/VBTAeiOQdm0Ai4ckaKIPj4KGowWxhJm3XJB." });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "2bf1c6f4a7db4fed825958e6d78e7226",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 27, 16, 53, 20, 811, DateTimeKind.Unspecified).AddTicks(861), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 27, 16, 53, 20, 811, DateTimeKind.Unspecified).AddTicks(861), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$HDJlsEsaNL7z7G4C5txfq./H8QTchmFdB6PXi7gQghkehO2.h4Gtq" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "54d3a3e95adc4b38885e43af50e12e42",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 27, 16, 53, 20, 449, DateTimeKind.Unspecified).AddTicks(1708), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 27, 16, 53, 20, 449, DateTimeKind.Unspecified).AddTicks(1708), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$LS.A08GENV2LKCk1yFp9keuHVNsotVWNd8LaWWr.QqQZEUxx7cbxu" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "6144c9fe6b7e4f4294ea469ffb6a90fd",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 27, 16, 53, 20, 325, DateTimeKind.Unspecified).AddTicks(4241), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 27, 16, 53, 20, 325, DateTimeKind.Unspecified).AddTicks(4241), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$HvLHG6DdjY2HoXQ8Nd.sqeK2lZ1hraIaN4scClrItjwgNFQ6jh.Ya" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "9f7c3e8a4b6d49f19a8d2e3f4c7b5680",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 27, 16, 53, 21, 167, DateTimeKind.Unspecified).AddTicks(7036), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 27, 16, 53, 21, 167, DateTimeKind.Unspecified).AddTicks(7036), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$LPF6DKxMqsLWQ0VEn5/gR.2MIanA80F/cNPJXBtXZeX3qwWt4zQ9W" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "a1b2c3d4e5f648a9b0c1d2e3f4a5b6c1",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 27, 16, 53, 22, 489, DateTimeKind.Unspecified).AddTicks(3076), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 27, 16, 53, 22, 489, DateTimeKind.Unspecified).AddTicks(3076), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$G5PSCesitr8yClziveoF0.Vf9QfjCDB3tMBK30vKZ2zyDmInJRz6m" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "a1b2c3d4e5f648a9b0c1d2e3f4a5b6c7",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 27, 16, 53, 21, 287, DateTimeKind.Unspecified).AddTicks(6998), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 27, 16, 53, 21, 287, DateTimeKind.Unspecified).AddTicks(6998), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$dGlCM1sAnEIXznSiNCuNd.b9h/MajL9szNyagO5B/1ebVEZb7xPhS" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "a5b6c7d8e9f0a1b2c3d4e5f648a9b0c1",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 27, 16, 53, 22, 370, DateTimeKind.Unspecified).AddTicks(8472), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 27, 16, 53, 22, 370, DateTimeKind.Unspecified).AddTicks(8472), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$oWdROQUrNc.q.qyuxMAKzeZPTyW0oHNyF2ZZ71XZu87AGG1nTRHSq" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "a9b0c1d2e3f4a5b6c7d8e9f0a1b2c3d4",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 27, 16, 53, 22, 9, DateTimeKind.Unspecified).AddTicks(3117), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 27, 16, 53, 22, 9, DateTimeKind.Unspecified).AddTicks(3117), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$jN22UrDDUYGZiqSfUih3ve7RbsRwoq4XVFhiIgk9r1kJBQZTp5G.y" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "b2c3d4e5f648a9b0c1d2e3f4a5b6c1d2",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 27, 16, 53, 22, 608, DateTimeKind.Unspecified).AddTicks(9317), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 27, 16, 53, 22, 608, DateTimeKind.Unspecified).AddTicks(9317), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$DOaOFIYHnx.meGL2Hbn2DePTvKcQcYcOkAPxJBnFpXnlmhYHZNohG" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "b2c3d4e5f648a9b0c1d2e3f4a5b6c7d8",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 27, 16, 53, 21, 410, DateTimeKind.Unspecified).AddTicks(407), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 27, 16, 53, 21, 410, DateTimeKind.Unspecified).AddTicks(407), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$xNtwjWjnnYf.BM2eLAJmSuwN6u/DF4NBoXoBcx4yc9qvWC3Z2X6ne" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "c1d2e3f4a5b6c7d8e9f0a1b2c3d4e5f6",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 27, 16, 53, 22, 130, DateTimeKind.Unspecified).AddTicks(4734), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 27, 16, 53, 22, 130, DateTimeKind.Unspecified).AddTicks(4734), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$y8NV0kxD7LkqXDZb0f3trelWRftRb7GDPh6ZWQCJrQ/SXk2ahAJ/q" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "c3d4e5f648a9b0c1d2e3f4a5b6c1d2e3",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 27, 16, 53, 22, 729, DateTimeKind.Unspecified).AddTicks(8876), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 27, 16, 53, 22, 729, DateTimeKind.Unspecified).AddTicks(8876), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$0ABRnBsUV1FPujFSPQEd8OKkTtZV0mQO78DXfIxBoFSvoWg6QrzW2" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "c3d4e5f648a9b0c1d2e3f4a5b6c7d8e9",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 27, 16, 53, 21, 531, DateTimeKind.Unspecified).AddTicks(7958), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 27, 16, 53, 21, 531, DateTimeKind.Unspecified).AddTicks(7958), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$Z36YE6CCbcP1/.v2FdMguuKp64uWlqYFRXe6IF9Ailp5OFhNBmQoy" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "d4e5f648a9b0c1d2e3f4a5b6c1d2e3f4",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 27, 16, 53, 22, 851, DateTimeKind.Unspecified).AddTicks(8888), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 27, 16, 53, 22, 851, DateTimeKind.Unspecified).AddTicks(8888), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$yo9wboHAIkYhuEY561aItOp8vCosiLSKfTfnFLlqcUlI5uD1eN9di" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "d4e5f648a9b0c1d2e3f4a5b6c7d8e9f0",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 27, 16, 53, 21, 653, DateTimeKind.Unspecified).AddTicks(3079), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 27, 16, 53, 21, 653, DateTimeKind.Unspecified).AddTicks(3079), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$.hNyqgmjM0/MzmZ249FZeOJOzenjaIaRuC8O0Mu04Zto/7.bs1qdK" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "e3f4a5b6c7d8e9f0a1b2c3d4e5f648a9",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 27, 16, 53, 22, 249, DateTimeKind.Unspecified).AddTicks(1822), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 27, 16, 53, 22, 249, DateTimeKind.Unspecified).AddTicks(1822), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$Ct9ItoH9xxabRxKfFU3b5uz50xSgPPGUe740bzgwCFn8oVYOOnsU." });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "e5f648a9b0c1d2e3f4a5b6c1d2e3f4a5",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 27, 16, 53, 22, 971, DateTimeKind.Unspecified).AddTicks(5034), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 27, 16, 53, 22, 971, DateTimeKind.Unspecified).AddTicks(5034), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$.GTrrdidX27hk7sVMs.yJOlHInRgRguCJwahISYQ9Ns18AWaZ73mq" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "e5f648a9b0c1d2e3f4a5b6c7d8e9f0a1",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 27, 16, 53, 21, 773, DateTimeKind.Unspecified).AddTicks(4963), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 27, 16, 53, 21, 773, DateTimeKind.Unspecified).AddTicks(4963), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$BMCd.ki/txGn4EMts5APReajYqM3myAMcJ/iYfS7qo5gaRhlJR9TC" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "ea46ce4e457f42dfb18b6347bd4ea1f4",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 27, 16, 53, 20, 690, DateTimeKind.Unspecified).AddTicks(2512), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 27, 16, 53, 20, 690, DateTimeKind.Unspecified).AddTicks(2512), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$K5Arey5djdTV6PlsSUMfn.qgNaEt0WQ2llB4RMfmZmP7foqk5vqvi" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "eaa27cff0c91479087bb22370ffbb6d0",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 27, 16, 53, 21, 47, DateTimeKind.Unspecified).AddTicks(4233), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 27, 16, 53, 21, 47, DateTimeKind.Unspecified).AddTicks(4233), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$simQmaW8tPegOIT/3CnNOOB5IMrA.nWlzAA7Jh0a7hbcmQvfJUtSa" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "f648a9b0c1d2e3f4a5b6c7d8e9f0a1b2",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 27, 16, 53, 21, 892, DateTimeKind.Unspecified).AddTicks(5377), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 27, 16, 53, 21, 892, DateTimeKind.Unspecified).AddTicks(5377), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$deP9OYzCcbgaGwWd2f4a7.Ty9noCtW8eVvfNH.QaDH4VfMiuGWnHu" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "fa13bc18b0c54ba0b9886b007f4d8b08",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 27, 16, 53, 20, 570, DateTimeKind.Unspecified).AddTicks(7226), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 27, 16, 53, 20, 570, DateTimeKind.Unspecified).AddTicks(7226), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$C7ZRXvSgFtG1fXCLjd/MQ.azPNlkA2HSHktJGG/Wu3jN7gSaTeOce" });

            migrationBuilder.CreateIndex(
                name: "IX_Chats_ReceiverId",
                table: "Chats",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_Chats_SenderId",
                table: "Chats",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerProfiles_AccountId",
                table: "CustomerProfiles",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerProfiles_CustomerRoleId",
                table: "CustomerProfiles",
                column: "CustomerRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_StaffProfiles_AccountId",
                table: "StaffProfiles",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_StaffProfiles_StaffRoleId",
                table: "StaffProfiles",
                column: "StaffRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainerProfiles_AccountId",
                table: "TrainerProfiles",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainerProfiles_TrainerRoleId",
                table: "TrainerProfiles",
                column: "TrainerRoleId");
        }
    }
}
