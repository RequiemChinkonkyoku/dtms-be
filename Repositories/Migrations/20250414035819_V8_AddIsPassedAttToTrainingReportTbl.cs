using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class V8_AddIsPassedAttToTrainingReportTbl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPassed",
                table: "TrainingReports",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "00786efb729542fa87a19d44fb3cdf79",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 14, 10, 58, 15, 404, DateTimeKind.Unspecified).AddTicks(743), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 14, 10, 58, 15, 404, DateTimeKind.Unspecified).AddTicks(743), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$pEFY/HfLZkf.2oaAGuDsEus97eyTGGPmY53DH41q4Nj/UqF1iyVly" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "2bf1c6f4a7db4fed825958e6d78e7226",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 14, 10, 58, 15, 252, DateTimeKind.Unspecified).AddTicks(6739), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 14, 10, 58, 15, 252, DateTimeKind.Unspecified).AddTicks(6739), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$KFh5oRUGw0OXG7Ol7mqBjO/ysajGeVTAGRFe7FMt71Cm7LmgrXSky" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "54d3a3e95adc4b38885e43af50e12e42",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 14, 10, 58, 14, 776, DateTimeKind.Unspecified).AddTicks(5498), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 14, 10, 58, 14, 776, DateTimeKind.Unspecified).AddTicks(5498), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$GjNWw3rSo1K9rTlbXaD7teCfPs5FYiRW/eD2F/WSE3PH3Z3L35kzK" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "6144c9fe6b7e4f4294ea469ffb6a90fd",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 14, 10, 58, 14, 615, DateTimeKind.Unspecified).AddTicks(1933), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 14, 10, 58, 14, 615, DateTimeKind.Unspecified).AddTicks(1933), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$xFuKOw2q11YIL/AbsMzA4.2vPH8vO5dsWm7na9YmtJIcpUHsJofO2" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "9f7c3e8a4b6d49f19a8d2e3f4c7b5680",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 14, 10, 58, 15, 701, DateTimeKind.Unspecified).AddTicks(9473), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 14, 10, 58, 15, 701, DateTimeKind.Unspecified).AddTicks(9473), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$y9hGnPgBzCfgBvH/3UtmMu21THUC8B75MiWHAM7Ktdn2s3rcAk9j." });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "a1b2c3d4e5f648a9b0c1d2e3f4a5b6c1",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 14, 10, 58, 17, 378, DateTimeKind.Unspecified).AddTicks(4189), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 14, 10, 58, 17, 378, DateTimeKind.Unspecified).AddTicks(4189), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$hBqSsCXj1iEhuAY7JYHbaOBilenabeO0hiTul/vuRujfZebxrnHPq" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "a1b2c3d4e5f648a9b0c1d2e3f4a5b6c7",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 14, 10, 58, 15, 850, DateTimeKind.Unspecified).AddTicks(5159), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 14, 10, 58, 15, 850, DateTimeKind.Unspecified).AddTicks(5159), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$9OWaFpLiaEVtaMJEULL5MuvGxxtWDlHhjt/6.vfoX7ED5oVHUQaby" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "a5b6c7d8e9f0a1b2c3d4e5f648a9b0c1",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 14, 10, 58, 17, 238, DateTimeKind.Unspecified).AddTicks(4250), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 14, 10, 58, 17, 238, DateTimeKind.Unspecified).AddTicks(4250), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$lDOhI3Q23LoiMxrUidTMN.H3S8gRT.tYbCTafwu556TZtGGt5SuoW" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "a9b0c1d2e3f4a5b6c7d8e9f0a1b2c3d4",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 14, 10, 58, 16, 805, DateTimeKind.Unspecified).AddTicks(2516), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 14, 10, 58, 16, 805, DateTimeKind.Unspecified).AddTicks(2516), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$ZmJlPbfFMQTidaoei0RjNueeDrETxku4jHEED/OpyhlSDOdz/PavS" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "b2c3d4e5f648a9b0c1d2e3f4a5b6c1d2",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 14, 10, 58, 17, 519, DateTimeKind.Unspecified).AddTicks(6025), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 14, 10, 58, 17, 519, DateTimeKind.Unspecified).AddTicks(6025), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$ToPEw9DUlUoMVPcN.jTPvOIB4RDuxWLWoQivO9ey/Gh7LcM1eI45i" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "b2c3d4e5f648a9b0c1d2e3f4a5b6c7d8",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 14, 10, 58, 15, 999, DateTimeKind.Unspecified).AddTicks(2983), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 14, 10, 58, 15, 999, DateTimeKind.Unspecified).AddTicks(2983), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$pBw6fHQyGmhHdVJPjfY1U.epy0FplB4nnOk0XoNSvUcG6CQ3M8KLm" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "c1d2e3f4a5b6c7d8e9f0a1b2c3d4e5f6",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 14, 10, 58, 16, 954, DateTimeKind.Unspecified).AddTicks(7303), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 14, 10, 58, 16, 954, DateTimeKind.Unspecified).AddTicks(7303), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$WJP6pGJXDfpz6aOclxascuAN1m2q1ZTnxxiL0mq1rCyptjHjPDpES" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "c3d4e5f648a9b0c1d2e3f4a5b6c1d2e3",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 14, 10, 58, 17, 659, DateTimeKind.Unspecified).AddTicks(1547), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 14, 10, 58, 17, 659, DateTimeKind.Unspecified).AddTicks(1547), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$jUwtEWknHVxGPz4Y8AcSoeey.uSm/ZZfaTHA78/7iESCqpvOZocz6" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "c3d4e5f648a9b0c1d2e3f4a5b6c7d8e9",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 14, 10, 58, 16, 146, DateTimeKind.Unspecified).AddTicks(4223), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 14, 10, 58, 16, 146, DateTimeKind.Unspecified).AddTicks(4223), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$B2Z4DjPOzVEU81jF8tMouefJVy3Ptn0SeGuynhIH2noGOwvmbHPOW" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "d4e5f648a9b0c1d2e3f4a5b6c1d2e3f4",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 14, 10, 58, 17, 801, DateTimeKind.Unspecified).AddTicks(1228), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 14, 10, 58, 17, 801, DateTimeKind.Unspecified).AddTicks(1228), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$.YLZ/JlakQf9MvFTC7Rq3.SH9ZUjXAvs/tYlpjiat0yz0fWRGw5bW" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "d4e5f648a9b0c1d2e3f4a5b6c7d8e9f0",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 14, 10, 58, 16, 296, DateTimeKind.Unspecified).AddTicks(7757), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 14, 10, 58, 16, 296, DateTimeKind.Unspecified).AddTicks(7757), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$jzmn0eM.eFicEs48fojnNOOp.n/vEVrcyK6xSiazCYdHv2tmU.TkO" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "e3f4a5b6c7d8e9f0a1b2c3d4e5f648a9",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 14, 10, 58, 17, 98, DateTimeKind.Unspecified).AddTicks(9250), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 14, 10, 58, 17, 98, DateTimeKind.Unspecified).AddTicks(9250), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$risYvCXeExg/uHUO2rV3GO3UG1mpRePPKOmL1fcS9/7/DGELcN.hO" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "e5f648a9b0c1d2e3f4a5b6c1d2e3f4a5",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 14, 10, 58, 17, 940, DateTimeKind.Unspecified).AddTicks(9832), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 14, 10, 58, 17, 940, DateTimeKind.Unspecified).AddTicks(9832), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$Hwzy0mWRxy3tksqrHdtBzOIThS6ZY740oO0k.YmPfqQKfYz.OBAVe" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "e5f648a9b0c1d2e3f4a5b6c7d8e9f0a1",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 14, 10, 58, 16, 466, DateTimeKind.Unspecified).AddTicks(8531), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 14, 10, 58, 16, 466, DateTimeKind.Unspecified).AddTicks(8531), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$eqLEq90sudzlsztlzs5oLeKhmAtpa/QPqJ6SVej4x7iCueJp4KETe" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "ea46ce4e457f42dfb18b6347bd4ea1f4",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 14, 10, 58, 15, 96, DateTimeKind.Unspecified).AddTicks(7604), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 14, 10, 58, 15, 96, DateTimeKind.Unspecified).AddTicks(7604), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$KMqe3EhT1938uuBM4Q9FWuG5IdVvXNq/O/Exmleh3L6wbLthHrPCi" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "eaa27cff0c91479087bb22370ffbb6d0",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 14, 10, 58, 15, 553, DateTimeKind.Unspecified).AddTicks(3203), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 14, 10, 58, 15, 553, DateTimeKind.Unspecified).AddTicks(3203), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$gPaOjbhARQCrgUiZQbFsjuA7CMTeG0v9Ghr11myL/TETfH39fXsle" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "f648a9b0c1d2e3f4a5b6c7d8e9f0a1b2",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 14, 10, 58, 16, 644, DateTimeKind.Unspecified).AddTicks(3049), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 14, 10, 58, 16, 644, DateTimeKind.Unspecified).AddTicks(3049), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$WIEINST8rXCtDpeSmB1rxu6FoJq5KQvBpBLhtChpVxEXAVAu8Ilya" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "fa13bc18b0c54ba0b9886b007f4d8b08",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 14, 10, 58, 14, 935, DateTimeKind.Unspecified).AddTicks(2659), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 14, 10, 58, 14, 935, DateTimeKind.Unspecified).AddTicks(2659), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$2d1m6PTKx79LzR..mDvpa.xiNLwXQqyB41IpUbcfmtc6MAZsc0VnG" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPassed",
                table: "TrainingReports");

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
        }
    }
}
