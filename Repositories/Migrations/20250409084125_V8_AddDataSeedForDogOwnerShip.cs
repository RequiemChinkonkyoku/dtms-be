using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class V8_AddDataSeedForDogOwnerShip : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "00786efb729542fa87a19d44fb3cdf79",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 15, 41, 22, 735, DateTimeKind.Unspecified).AddTicks(4415), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 15, 41, 22, 735, DateTimeKind.Unspecified).AddTicks(4415), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$w6ogJflgn5UKLaCJmzDAKO2EVneVlvEg7kAl7xwZbUlphX/Z5Fgli" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "2bf1c6f4a7db4fed825958e6d78e7226",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 15, 41, 22, 622, DateTimeKind.Unspecified).AddTicks(4463), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 15, 41, 22, 622, DateTimeKind.Unspecified).AddTicks(4463), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$ifJN/L3bOGsdmq1mhfNsGe066ECw2hC9msadzFFNuyubVn.vkQ7Fu" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "54d3a3e95adc4b38885e43af50e12e42",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 15, 41, 22, 283, DateTimeKind.Unspecified).AddTicks(2473), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 15, 41, 22, 283, DateTimeKind.Unspecified).AddTicks(2473), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$PVrnhqGwRT6Yp7DZTTOJR.JlPQoCnDOwXKj7tF/9HC0qBrJgOkIDq" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "6144c9fe6b7e4f4294ea469ffb6a90fd",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 15, 41, 22, 169, DateTimeKind.Unspecified).AddTicks(4615), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 15, 41, 22, 169, DateTimeKind.Unspecified).AddTicks(4615), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$Ioz4GzKtC47hPCB6Ymf1VetHh0OiLZmerH7WkRMNlIlGWR4qI5obO" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "9f7c3e8a4b6d49f19a8d2e3f4c7b5680",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 15, 41, 22, 957, DateTimeKind.Unspecified).AddTicks(5085), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 15, 41, 22, 957, DateTimeKind.Unspecified).AddTicks(5085), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$e6cZ0SuNlu0f8aFjT1GMvuTs/Ur/mdNMF14escb0P2e0LGg3tghmC" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "a1b2c3d4e5f648a9b0c1d2e3f4a5b6c1",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 15, 41, 24, 178, DateTimeKind.Unspecified).AddTicks(5291), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 15, 41, 24, 178, DateTimeKind.Unspecified).AddTicks(5291), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$QFan7wuYGnMhXMNHmmvV3OSdSFG4tTtKWzh95KJH8OojI5tjtlrIq" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "a1b2c3d4e5f648a9b0c1d2e3f4a5b6c7",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 15, 41, 23, 67, DateTimeKind.Unspecified).AddTicks(8862), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 15, 41, 23, 67, DateTimeKind.Unspecified).AddTicks(8862), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$xPH/taMf6XCRvbKivDQdoe1TXd2Sfh55WNFzi9st61eMykfDchDha" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "a5b6c7d8e9f0a1b2c3d4e5f648a9b0c1",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 15, 41, 24, 67, DateTimeKind.Unspecified).AddTicks(8962), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 15, 41, 24, 67, DateTimeKind.Unspecified).AddTicks(8962), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$jfpZqPD3AK/i9qUhbp6ZSeb4OXW23miEhMVZpMzPE42gyGf5a0Tni" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "a9b0c1d2e3f4a5b6c7d8e9f0a1b2c3d4",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 15, 41, 23, 735, DateTimeKind.Unspecified).AddTicks(1605), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 15, 41, 23, 735, DateTimeKind.Unspecified).AddTicks(1605), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$z9kjnx4Fl/LToCON8di5x.IOV/PRNcQt5dQBauKtzpqjRuMn4BWTW" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "b2c3d4e5f648a9b0c1d2e3f4a5b6c1d2",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 15, 41, 24, 288, DateTimeKind.Unspecified).AddTicks(9785), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 15, 41, 24, 288, DateTimeKind.Unspecified).AddTicks(9785), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$7P87QCHdnd/9Sdhw0ucxbuK8haqrtYf/sSn/6mrNL.dQeWZj69.P2" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "b2c3d4e5f648a9b0c1d2e3f4a5b6c7d8",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 15, 41, 23, 179, DateTimeKind.Unspecified).AddTicks(6111), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 15, 41, 23, 179, DateTimeKind.Unspecified).AddTicks(6111), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$jYRGlyQKZUIB36OFxjOTOuHI/sVsTusH8er6aJjuTficzHl/XkFM6" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "c1d2e3f4a5b6c7d8e9f0a1b2c3d4e5f6",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 15, 41, 23, 845, DateTimeKind.Unspecified).AddTicks(9793), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 15, 41, 23, 845, DateTimeKind.Unspecified).AddTicks(9793), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$.6c0mwRZ1IzgYIvarj6BLessRXqvEfkbnDRPewpsr891rJ5upTXBG" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "c3d4e5f648a9b0c1d2e3f4a5b6c1d2e3",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 15, 41, 24, 401, DateTimeKind.Unspecified).AddTicks(6577), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 15, 41, 24, 401, DateTimeKind.Unspecified).AddTicks(6577), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$nRcF8OZACeTzwW3lJyzmW.IvAo0pLgMWSkQoP82lCF1xjzq6TugsS" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "c3d4e5f648a9b0c1d2e3f4a5b6c7d8e9",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 15, 41, 23, 292, DateTimeKind.Unspecified).AddTicks(4862), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 15, 41, 23, 292, DateTimeKind.Unspecified).AddTicks(4862), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$SHrVTzev7I2HxqxpzyjY.OE3ns60gzGeGHOCpAZiI3dDULjoIcA6W" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "d4e5f648a9b0c1d2e3f4a5b6c1d2e3f4",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 15, 41, 24, 513, DateTimeKind.Unspecified).AddTicks(9081), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 15, 41, 24, 513, DateTimeKind.Unspecified).AddTicks(9081), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$g/0j6iwD1FAudeD0YPCsMe9pnGCZPAJyFPTOUIjvc09BUV/GP6aAS" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "d4e5f648a9b0c1d2e3f4a5b6c7d8e9f0",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 15, 41, 23, 403, DateTimeKind.Unspecified).AddTicks(7293), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 15, 41, 23, 403, DateTimeKind.Unspecified).AddTicks(7293), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$zIyPZIxx5YYFJ55QySnug.2R4TLNthNHjrSgfhwJGi0vJiS9.lJiq" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "e3f4a5b6c7d8e9f0a1b2c3d4e5f648a9",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 15, 41, 23, 957, DateTimeKind.Unspecified).AddTicks(1678), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 15, 41, 23, 957, DateTimeKind.Unspecified).AddTicks(1678), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$SSkMgJKq.SrHqCwLJTr3hufW3W5W/p8.lwVJgIeaEQJEIKs0mb.Ne" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "e5f648a9b0c1d2e3f4a5b6c1d2e3f4a5",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 15, 41, 24, 624, DateTimeKind.Unspecified).AddTicks(5943), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 15, 41, 24, 624, DateTimeKind.Unspecified).AddTicks(5943), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$WfgVCs5S3lIDaRVBX7Wk.ex7TmnHY6A4Fw7znIYe9Arr8Anw7zMae" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "e5f648a9b0c1d2e3f4a5b6c7d8e9f0a1",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 15, 41, 23, 514, DateTimeKind.Unspecified).AddTicks(1597), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 15, 41, 23, 514, DateTimeKind.Unspecified).AddTicks(1597), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$LswHKNhcagDodNrZkNVX8OEVvxzDM4peMNb2MqSeBINdRCIdrJvX2" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "ea46ce4e457f42dfb18b6347bd4ea1f4",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 15, 41, 22, 509, DateTimeKind.Unspecified).AddTicks(3482), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 15, 41, 22, 509, DateTimeKind.Unspecified).AddTicks(3482), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$Y7hlwmdyIzwhctbVGUJP5e1yTcWDT4gqbop3dgmpU35eV5sIpgOfm" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "eaa27cff0c91479087bb22370ffbb6d0",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 15, 41, 22, 847, DateTimeKind.Unspecified).AddTicks(602), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 15, 41, 22, 847, DateTimeKind.Unspecified).AddTicks(602), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$th1LoOD/VDqZ//rYbDtD.OCbk3DQgzkbioYYxwvXNGby2m4k5MseO" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "f648a9b0c1d2e3f4a5b6c7d8e9f0a1b2",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 15, 41, 23, 624, DateTimeKind.Unspecified).AddTicks(8823), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 15, 41, 23, 624, DateTimeKind.Unspecified).AddTicks(8823), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$/u9VHLzdjkLJzKNCKlf.zevCZSzM6PG95P3TDav1SOFmBjVEf3kvC" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "fa13bc18b0c54ba0b9886b007f4d8b08",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 15, 41, 22, 396, DateTimeKind.Unspecified).AddTicks(9965), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 15, 41, 22, 396, DateTimeKind.Unspecified).AddTicks(9965), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$bOf8mIlcncVNTdCQ8GFxPu/GEe.jq1hrBqaAc.0M0KUr.YPsh/LHO" });

            migrationBuilder.InsertData(
                table: "LessonEquipments",
                columns: new[] { "Id", "CreatedTime", "EquipmentId", "LastUpdatedTime", "LessonId", "Quantity" },
                values: new object[,]
                {
                    { "0ea1596f-c90c-43a4-ab98-46c28bff058b", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "f67890a1b2c3d4e5f67890a1b2c3d4e5", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "c3d4e5f67890a1b2c3d4e5f67890a1b2", 2 },
                    { "13772874-9fa8-4015-9f15-88286751f87d", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "e5f67890a1b2c3d4e5f67890a1b2c3d4", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "b2c3d4e5f67890a1b2c3d4e5f67890a1", 6 },
                    { "1a54eff4-fb3f-460b-ac1a-c6b1513da2b4", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "7890a1b2c3d4e5f67890a1b2c3d4e5f6", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "b2c3d4e5f67890a1b2c3d4e5f67890a1", 1 },
                    { "1cb8ae5c-9ac0-4435-9178-ec6c2fab5e5d", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "0a1b2c3d4e5f67890a1b2c3d4e5f6789", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "e5f67890a1b2c3d4e5f67890a1b2c3d4", 1 },
                    { "2a27bcf3-dfa6-4473-a1fd-bc9fd5776522", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "a1b2c3d4e5f67890a1b2c3d4e5f67890", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "a1b2c3d4e5f67890a1b2c3d4e5f67890", 2 },
                    { "39a80597-2a3b-4d76-bb0c-9b86a2fb75e7", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "0a1b2c3d4e5f67890a1b2c3d4e5f6789", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "d4e5f67890a1b2c3d4e5f67890a1b2c3", 1 },
                    { "42d21a61-2cb4-45d1-af06-1833ab07eb27", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "c3d4e5f67890a1b2c3d4e5f67890a1b2", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "e5f67890a1b2c3d4e5f67890a1b2c3d4", 1 },
                    { "4315c999-84be-402e-a5d8-61794312725d", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "7890a1b2c3d4e5f67890a1b2c3d4e5f6", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "c3d4e5f67890a1b2c3d4e5f67890a1b2", 1 },
                    { "5c75803a-7992-4029-8c61-b023ad4d2817", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "b2c3d4e5f67890a1b2c3d4e5f67890a1", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "a1b2c3d4e5f67890a1b2c3d4e5f67890", 3 },
                    { "673773c7-4907-4c38-b5f0-36b77bd8d3c4", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "a1b2c3d4e5f67890a1b2c3d4e5f67890", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "e5f67890a1b2c3d4e5f67890a1b2c3d4", 2 },
                    { "68f0ef61-bf18-49d3-8a80-c7a2fa3b9580", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "90a1b2c3d4e5f67890a1b2c3d4e5f678", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "d4e5f67890a1b2c3d4e5f67890a1b2c3", 2 },
                    { "b4792d46-bb29-4818-a877-c5fd5a519571", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "90a1b2c3d4e5f67890a1b2c3d4e5f678", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "c3d4e5f67890a1b2c3d4e5f67890a1b2", 2 },
                    { "c70d780d-3e03-475e-84fa-072e93bdd9d3", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "d4e5f67890a1b2c3d4e5f67890a1b2c3", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "a1b2c3d4e5f67890a1b2c3d4e5f67890", 4 },
                    { "e8425e60-e6d1-401b-90ee-35f92f780e38", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "c3d4e5f67890a1b2c3d4e5f67890a1b2", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "a1b2c3d4e5f67890a1b2c3d4e5f67890", 1 },
                    { "e9aa8c1e-bac5-442f-9d2d-2ca6fada6028", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "890a1b2c3d4e5f67890a1b2c3d4e5f67", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "d4e5f67890a1b2c3d4e5f67890a1b2c3", 3 },
                    { "ed7a2e59-228d-4b28-ae5c-88d279685f9f", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "890a1b2c3d4e5f67890a1b2c3d4e5f67", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "c3d4e5f67890a1b2c3d4e5f67890a1b2", 3 },
                    { "f102119b-755e-4d9f-93ac-b81cd02e63cf", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "d4e5f67890a1b2c3d4e5f67890a1b2c3", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "b2c3d4e5f67890a1b2c3d4e5f67890a1", 4 },
                    { "f1430a6d-0bc4-41be-8db5-c20e6ae56aba", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "f67890a1b2c3d4e5f67890a1b2c3d4e5", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "b2c3d4e5f67890a1b2c3d4e5f67890a1", 2 },
                    { "f34217c6-2c3d-46ad-9cb9-c521225f27aa", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "b2c3d4e5f67890a1b2c3d4e5f67890a1", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "e5f67890a1b2c3d4e5f67890a1b2c3d4", 3 },
                    { "fe4f8280-56d0-4a7b-a7a5-a8a54bd624cd", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "a1b2c3d4e5f67890a1b2c3d4e5f67890", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "d4e5f67890a1b2c3d4e5f67890a1b2c3", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LessonEquipments",
                keyColumn: "Id",
                keyValue: "0ea1596f-c90c-43a4-ab98-46c28bff058b");

            migrationBuilder.DeleteData(
                table: "LessonEquipments",
                keyColumn: "Id",
                keyValue: "13772874-9fa8-4015-9f15-88286751f87d");

            migrationBuilder.DeleteData(
                table: "LessonEquipments",
                keyColumn: "Id",
                keyValue: "1a54eff4-fb3f-460b-ac1a-c6b1513da2b4");

            migrationBuilder.DeleteData(
                table: "LessonEquipments",
                keyColumn: "Id",
                keyValue: "1cb8ae5c-9ac0-4435-9178-ec6c2fab5e5d");

            migrationBuilder.DeleteData(
                table: "LessonEquipments",
                keyColumn: "Id",
                keyValue: "2a27bcf3-dfa6-4473-a1fd-bc9fd5776522");

            migrationBuilder.DeleteData(
                table: "LessonEquipments",
                keyColumn: "Id",
                keyValue: "39a80597-2a3b-4d76-bb0c-9b86a2fb75e7");

            migrationBuilder.DeleteData(
                table: "LessonEquipments",
                keyColumn: "Id",
                keyValue: "42d21a61-2cb4-45d1-af06-1833ab07eb27");

            migrationBuilder.DeleteData(
                table: "LessonEquipments",
                keyColumn: "Id",
                keyValue: "4315c999-84be-402e-a5d8-61794312725d");

            migrationBuilder.DeleteData(
                table: "LessonEquipments",
                keyColumn: "Id",
                keyValue: "5c75803a-7992-4029-8c61-b023ad4d2817");

            migrationBuilder.DeleteData(
                table: "LessonEquipments",
                keyColumn: "Id",
                keyValue: "673773c7-4907-4c38-b5f0-36b77bd8d3c4");

            migrationBuilder.DeleteData(
                table: "LessonEquipments",
                keyColumn: "Id",
                keyValue: "68f0ef61-bf18-49d3-8a80-c7a2fa3b9580");

            migrationBuilder.DeleteData(
                table: "LessonEquipments",
                keyColumn: "Id",
                keyValue: "b4792d46-bb29-4818-a877-c5fd5a519571");

            migrationBuilder.DeleteData(
                table: "LessonEquipments",
                keyColumn: "Id",
                keyValue: "c70d780d-3e03-475e-84fa-072e93bdd9d3");

            migrationBuilder.DeleteData(
                table: "LessonEquipments",
                keyColumn: "Id",
                keyValue: "e8425e60-e6d1-401b-90ee-35f92f780e38");

            migrationBuilder.DeleteData(
                table: "LessonEquipments",
                keyColumn: "Id",
                keyValue: "e9aa8c1e-bac5-442f-9d2d-2ca6fada6028");

            migrationBuilder.DeleteData(
                table: "LessonEquipments",
                keyColumn: "Id",
                keyValue: "ed7a2e59-228d-4b28-ae5c-88d279685f9f");

            migrationBuilder.DeleteData(
                table: "LessonEquipments",
                keyColumn: "Id",
                keyValue: "f102119b-755e-4d9f-93ac-b81cd02e63cf");

            migrationBuilder.DeleteData(
                table: "LessonEquipments",
                keyColumn: "Id",
                keyValue: "f1430a6d-0bc4-41be-8db5-c20e6ae56aba");

            migrationBuilder.DeleteData(
                table: "LessonEquipments",
                keyColumn: "Id",
                keyValue: "f34217c6-2c3d-46ad-9cb9-c521225f27aa");

            migrationBuilder.DeleteData(
                table: "LessonEquipments",
                keyColumn: "Id",
                keyValue: "fe4f8280-56d0-4a7b-a7a5-a8a54bd624cd");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "00786efb729542fa87a19d44fb3cdf79",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 15, 40, 1, 968, DateTimeKind.Unspecified).AddTicks(3534), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 15, 40, 1, 968, DateTimeKind.Unspecified).AddTicks(3534), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$QFejGeTWwEJ.eescLOYsB.GWcNPL8XoIpjzyug62/M.llu7a3fhmG" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "2bf1c6f4a7db4fed825958e6d78e7226",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 15, 40, 1, 855, DateTimeKind.Unspecified).AddTicks(9297), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 15, 40, 1, 855, DateTimeKind.Unspecified).AddTicks(9297), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$0sW8MXFNI4YBKbrEAbNI/ezydgUqyHVcBqw9qkwHpqSCDrFxXYcmq" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "54d3a3e95adc4b38885e43af50e12e42",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 15, 40, 1, 516, DateTimeKind.Unspecified).AddTicks(9407), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 15, 40, 1, 516, DateTimeKind.Unspecified).AddTicks(9407), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$Khz87vDV.islSROf5gNdwecZquGbGvx.X74uyu.9tVF4oH1QNIBeS" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "6144c9fe6b7e4f4294ea469ffb6a90fd",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 15, 40, 1, 400, DateTimeKind.Unspecified).AddTicks(5465), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 15, 40, 1, 400, DateTimeKind.Unspecified).AddTicks(5465), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$TZ3Ta654ZYJs.a.i0XTlhOxUOYZFktF7gYQ52HokjQ0xke9PTqpOu" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "9f7c3e8a4b6d49f19a8d2e3f4c7b5680",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 15, 40, 2, 189, DateTimeKind.Unspecified).AddTicks(9691), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 15, 40, 2, 189, DateTimeKind.Unspecified).AddTicks(9691), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$SfoCfY.4jtUjJlE/MdBXI..GBa3VmHhG9fu97Eqgmjm7aYFLAD/lO" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "a1b2c3d4e5f648a9b0c1d2e3f4a5b6c1",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 15, 40, 3, 414, DateTimeKind.Unspecified).AddTicks(4126), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 15, 40, 3, 414, DateTimeKind.Unspecified).AddTicks(4126), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$2HnBg3SiVt/0Ld2p0sJzzeKDuR6dt84S5VVt2Gc42EpoefRqWLDXy" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "a1b2c3d4e5f648a9b0c1d2e3f4a5b6c7",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 15, 40, 2, 300, DateTimeKind.Unspecified).AddTicks(6023), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 15, 40, 2, 300, DateTimeKind.Unspecified).AddTicks(6023), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$3l2AX2r.rFst2UpbH80erem2Ajwie3o90NAOtaVGo1Eo6D7I.ovIW" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "a5b6c7d8e9f0a1b2c3d4e5f648a9b0c1",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 15, 40, 3, 303, DateTimeKind.Unspecified).AddTicks(5125), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 15, 40, 3, 303, DateTimeKind.Unspecified).AddTicks(5125), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$xW0C/9VA6Al.4hC9a2aDEOP.yCnSAU5i7JlpHvwxMA0b9nUpI51hy" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "a9b0c1d2e3f4a5b6c7d8e9f0a1b2c3d4",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 15, 40, 2, 971, DateTimeKind.Unspecified).AddTicks(2242), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 15, 40, 2, 971, DateTimeKind.Unspecified).AddTicks(2242), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$.JSF405hi.prDxwZrCoWh.51GXZARgVWw4XHni3NtOMDRw83qzQqO" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "b2c3d4e5f648a9b0c1d2e3f4a5b6c1d2",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 15, 40, 3, 525, DateTimeKind.Unspecified).AddTicks(5097), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 15, 40, 3, 525, DateTimeKind.Unspecified).AddTicks(5097), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$4.Y4YEzfuZxr4NKYbvjk0O80.Gg3LrWxgSMthmocs/vDgDrjdUaZq" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "b2c3d4e5f648a9b0c1d2e3f4a5b6c7d8",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 15, 40, 2, 411, DateTimeKind.Unspecified).AddTicks(8912), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 15, 40, 2, 411, DateTimeKind.Unspecified).AddTicks(8912), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$nleSf/Jadb7TMT6VxjSA5ufDkaHkVzv9NXZYTG79176ngyOnBohw2" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "c1d2e3f4a5b6c7d8e9f0a1b2c3d4e5f6",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 15, 40, 3, 81, DateTimeKind.Unspecified).AddTicks(9702), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 15, 40, 3, 81, DateTimeKind.Unspecified).AddTicks(9702), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$GB4tjNvgboE2mJdZTW/1hevShugoy0WlQiJhA7KLd3gpkHbgS55am" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "c3d4e5f648a9b0c1d2e3f4a5b6c1d2e3",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 15, 40, 3, 636, DateTimeKind.Unspecified).AddTicks(2652), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 15, 40, 3, 636, DateTimeKind.Unspecified).AddTicks(2652), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$N/ZjD8qWJvSvivD.sHTulOXYL2mNBjAxwV3v1dwZGagTFRPuw4XNW" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "c3d4e5f648a9b0c1d2e3f4a5b6c7d8e9",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 15, 40, 2, 523, DateTimeKind.Unspecified).AddTicks(7021), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 15, 40, 2, 523, DateTimeKind.Unspecified).AddTicks(7021), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$DIGfJi4ANHbLXVKCoEI4wembTfFoiMf/j71/0beviB/XtGCjJ.JeO" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "d4e5f648a9b0c1d2e3f4a5b6c1d2e3f4",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 15, 40, 3, 749, DateTimeKind.Unspecified).AddTicks(1952), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 15, 40, 3, 749, DateTimeKind.Unspecified).AddTicks(1952), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$/a8ZdkjzWfFzTanLOyk5YeSPZN/a5w5bAFkH5DbT7wGU6.5qqBUK2" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "d4e5f648a9b0c1d2e3f4a5b6c7d8e9f0",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 15, 40, 2, 639, DateTimeKind.Unspecified).AddTicks(729), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 15, 40, 2, 639, DateTimeKind.Unspecified).AddTicks(729), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$qRmgmBh/nKWRuPFIk7aSEuFV7MrF.y226yQV/g84WCJWS1rw/wp8e" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "e3f4a5b6c7d8e9f0a1b2c3d4e5f648a9",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 15, 40, 3, 192, DateTimeKind.Unspecified).AddTicks(8236), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 15, 40, 3, 192, DateTimeKind.Unspecified).AddTicks(8236), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$TmJ.hEzb7F6/nOtXd57Q0unZ8zD8RyeGVmCeDe0SXiVmWgqA1l2qC" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "e5f648a9b0c1d2e3f4a5b6c1d2e3f4a5",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 15, 40, 3, 864, DateTimeKind.Unspecified).AddTicks(8314), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 15, 40, 3, 864, DateTimeKind.Unspecified).AddTicks(8314), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$WkEZyUlh9boUSZowzOHA2.zu1I0yeEte4HZm91Gl7lnkJcj0f97u2" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "e5f648a9b0c1d2e3f4a5b6c7d8e9f0a1",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 15, 40, 2, 750, DateTimeKind.Unspecified).AddTicks(7891), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 15, 40, 2, 750, DateTimeKind.Unspecified).AddTicks(7891), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$x8O5M/1hywy4UZfUfw41qelWDhtXWB3kf3iNkgRbAvhnhXuFo/JaC" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "ea46ce4e457f42dfb18b6347bd4ea1f4",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 15, 40, 1, 742, DateTimeKind.Unspecified).AddTicks(5353), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 15, 40, 1, 742, DateTimeKind.Unspecified).AddTicks(5353), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$tq36XL/pVI2ZO.Cj5JNyKuVSx2CfjWp3b0nceDvHeyzUXUDBEGuDS" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "eaa27cff0c91479087bb22370ffbb6d0",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 15, 40, 2, 79, DateTimeKind.Unspecified).AddTicks(732), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 15, 40, 2, 79, DateTimeKind.Unspecified).AddTicks(732), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$rZu1s7Y53WEVA0Vz5Gk3A.Ooimu7mdAga7B24QtWBbBomykVGtH5a" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "f648a9b0c1d2e3f4a5b6c7d8e9f0a1b2",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 15, 40, 2, 860, DateTimeKind.Unspecified).AddTicks(9625), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 15, 40, 2, 860, DateTimeKind.Unspecified).AddTicks(9625), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$uEuY/OT74KCQBooaZrNy0eDXP5FQgUsT3QhU5dZwjPK82x1n/2IeW" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "fa13bc18b0c54ba0b9886b007f4d8b08",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 15, 40, 1, 631, DateTimeKind.Unspecified).AddTicks(3472), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 15, 40, 1, 631, DateTimeKind.Unspecified).AddTicks(3472), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$AT0iG0hsBwtP9pVmTvDjJebhnvGtaF2hLrdtSX9K6p5dzEKMWldCi" });
        }
    }
}
