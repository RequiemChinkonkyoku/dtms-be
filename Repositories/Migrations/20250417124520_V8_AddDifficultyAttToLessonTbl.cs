using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class V8_AddDifficultyAttToLessonTbl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Difficulty",
                table: "Lessons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "00786efb729542fa87a19d44fb3cdf79",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 17, 19, 45, 16, 678, DateTimeKind.Unspecified).AddTicks(9227), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 17, 19, 45, 16, 678, DateTimeKind.Unspecified).AddTicks(9227), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$NVbBkZtdoJ9e646zjja2PeIqfpwa7OdKRa3vZiGIOgvgO5jT4exNe" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "2bf1c6f4a7db4fed825958e6d78e7226",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 17, 19, 45, 16, 559, DateTimeKind.Unspecified).AddTicks(299), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 17, 19, 45, 16, 559, DateTimeKind.Unspecified).AddTicks(299), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$cVZv8tMicHYHKh3rjznlmuTR1LT3LpxrLjXOjekw6hp9lYY1ly/W6" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "54d3a3e95adc4b38885e43af50e12e42",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 17, 19, 45, 16, 196, DateTimeKind.Unspecified).AddTicks(5282), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 17, 19, 45, 16, 196, DateTimeKind.Unspecified).AddTicks(5282), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$BjmdDtlZcbYcm.R8IrPh8eF3AHbSkaJ94geYFKaf3wtyekobKnqMe" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "6144c9fe6b7e4f4294ea469ffb6a90fd",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 17, 19, 45, 16, 71, DateTimeKind.Unspecified).AddTicks(4872), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 17, 19, 45, 16, 71, DateTimeKind.Unspecified).AddTicks(4872), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$7kZA5rD4Q9IwLCihu5WNU.5P3I4eK/ygwMKqg71Zd1Isc56Cj137K" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "9f7c3e8a4b6d49f19a8d2e3f4c7b5680",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 17, 19, 45, 16, 921, DateTimeKind.Unspecified).AddTicks(4498), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 17, 19, 45, 16, 921, DateTimeKind.Unspecified).AddTicks(4498), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$Q3Me0llbiORKYBF/OczmO.GvCTZBSPlvGzu3RW1XipIngcIcDH7R6" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "a1b2c3d4e5f648a9b0c1d2e3f4a5b6c1",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 17, 19, 45, 18, 243, DateTimeKind.Unspecified).AddTicks(348), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 17, 19, 45, 18, 243, DateTimeKind.Unspecified).AddTicks(348), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$kizmAJamFEg1k8TiWfpHiuESHrHUybXtcmWBTZ6IbFHfcFokR0olS" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "a1b2c3d4e5f648a9b0c1d2e3f4a5b6c7",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 17, 19, 45, 17, 41, DateTimeKind.Unspecified).AddTicks(6450), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 17, 19, 45, 17, 41, DateTimeKind.Unspecified).AddTicks(6450), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$Hg.Og/fiR7QEgWb9nlGQGu.oInN3lKsBKqG3kFK054FvoiUEMspHe" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "a5b6c7d8e9f0a1b2c3d4e5f648a9b0c1",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 17, 19, 45, 18, 123, DateTimeKind.Unspecified).AddTicks(5603), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 17, 19, 45, 18, 123, DateTimeKind.Unspecified).AddTicks(5603), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$gVRg3JFDnBg99v4XGI5XBuwlgoCD1XuFIP2lqXhe6RU9k9u7nagJ2" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "a9b0c1d2e3f4a5b6c7d8e9f0a1b2c3d4",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 17, 19, 45, 17, 763, DateTimeKind.Unspecified).AddTicks(4560), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 17, 19, 45, 17, 763, DateTimeKind.Unspecified).AddTicks(4560), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$wcb3pM3eAIRLqqifBnFkKebNqXNFM/QcCazYLK9jDzZsJ1r.wBY5m" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "b2c3d4e5f648a9b0c1d2e3f4a5b6c1d2",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 17, 19, 45, 18, 363, DateTimeKind.Unspecified).AddTicks(3057), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 17, 19, 45, 18, 363, DateTimeKind.Unspecified).AddTicks(3057), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$Rv.O.aj3q.qdbmG34MVAa.jBzw2JDrnGz6eV6tREMw1BCwZ3cktdG" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "b2c3d4e5f648a9b0c1d2e3f4a5b6c7d8",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 17, 19, 45, 17, 161, DateTimeKind.Unspecified).AddTicks(1815), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 17, 19, 45, 17, 161, DateTimeKind.Unspecified).AddTicks(1815), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$iEBk1rq4ackj2L6JOeGcZuODckeMp21aBItRrTBIkMifCm0OK6Jpm" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "c1d2e3f4a5b6c7d8e9f0a1b2c3d4e5f6",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 17, 19, 45, 17, 882, DateTimeKind.Unspecified).AddTicks(284), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 17, 19, 45, 17, 882, DateTimeKind.Unspecified).AddTicks(284), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$xNVJ71fnfNnMorwPuYQtLuEzsHHru4yzcOWHrlMNXlUvXP9ieSkMO" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "c3d4e5f648a9b0c1d2e3f4a5b6c1d2e3",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 17, 19, 45, 18, 482, DateTimeKind.Unspecified).AddTicks(5768), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 17, 19, 45, 18, 482, DateTimeKind.Unspecified).AddTicks(5768), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$l4H20wVdRKX8Zo.gWDXjbuNpYSs63XtpKY3z678McKYMub3KMlm5e" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "c3d4e5f648a9b0c1d2e3f4a5b6c7d8e9",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 17, 19, 45, 17, 279, DateTimeKind.Unspecified).AddTicks(9600), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 17, 19, 45, 17, 279, DateTimeKind.Unspecified).AddTicks(9600), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$Yel6369A.r.T3B6sXs0uzO0IwH0y0X4Gpqb9siSq5.g6xVR009REm" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "d4e5f648a9b0c1d2e3f4a5b6c1d2e3f4",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 17, 19, 45, 18, 604, DateTimeKind.Unspecified).AddTicks(7765), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 17, 19, 45, 18, 604, DateTimeKind.Unspecified).AddTicks(7765), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$LymZNupLPiuN4bIa3uhU0uszWBcCEC7zce.YWpWz8VJsWKZvlE91O" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "d4e5f648a9b0c1d2e3f4a5b6c7d8e9f0",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 17, 19, 45, 17, 399, DateTimeKind.Unspecified).AddTicks(854), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 17, 19, 45, 17, 399, DateTimeKind.Unspecified).AddTicks(854), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$9Nwqb5dbiCvp26MeUHGYmuYXxfX261iTTUGSw7iJ5CaezwnVFQ66a" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "e3f4a5b6c7d8e9f0a1b2c3d4e5f648a9",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 17, 19, 45, 18, 2, DateTimeKind.Unspecified).AddTicks(8392), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 17, 19, 45, 18, 2, DateTimeKind.Unspecified).AddTicks(8392), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$P9tKvbm/AqsBHsxf1tOUbuMBh2OTZ1a1CjJ0sjgcdvY8elhBFCjRq" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "e5f648a9b0c1d2e3f4a5b6c1d2e3f4a5",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 17, 19, 45, 18, 726, DateTimeKind.Unspecified).AddTicks(1387), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 17, 19, 45, 18, 726, DateTimeKind.Unspecified).AddTicks(1387), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$G8eSwvrw4xDxOpcOENtfzet5HgaYSCPeSsvWBVRdCzzCdVhC6f45y" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "e5f648a9b0c1d2e3f4a5b6c7d8e9f0a1",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 17, 19, 45, 17, 517, DateTimeKind.Unspecified).AddTicks(9275), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 17, 19, 45, 17, 517, DateTimeKind.Unspecified).AddTicks(9275), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$q6PKiqYlw3Nj9jVSzfYmkOYIyg3wJZHRoD6bhcYUc.KTvU4A1C.TC" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "ea46ce4e457f42dfb18b6347bd4ea1f4",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 17, 19, 45, 16, 439, DateTimeKind.Unspecified).AddTicks(631), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 17, 19, 45, 16, 439, DateTimeKind.Unspecified).AddTicks(631), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$QDzdRwvDLode0Nz1e1DXgey9pNSS7LJuFR5HwTGUy5jYEMRmVxDLK" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "eaa27cff0c91479087bb22370ffbb6d0",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 17, 19, 45, 16, 802, DateTimeKind.Unspecified).AddTicks(1611), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 17, 19, 45, 16, 802, DateTimeKind.Unspecified).AddTicks(1611), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$w4eC.9JZ6TmUqvhxy8Ng1ODri4bLP77riraPpE4xdPXVVV2.6jqvK" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "f648a9b0c1d2e3f4a5b6c7d8e9f0a1b2",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 17, 19, 45, 17, 639, DateTimeKind.Unspecified).AddTicks(8998), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 17, 19, 45, 17, 639, DateTimeKind.Unspecified).AddTicks(8998), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$VzfPA1RcbKloGYijX2CxUO/gFT2svbp.W.j9u26KeAvtQywuPH1i." });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "fa13bc18b0c54ba0b9886b007f4d8b08",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 17, 19, 45, 16, 319, DateTimeKind.Unspecified).AddTicks(829), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 17, 19, 45, 16, 319, DateTimeKind.Unspecified).AddTicks(829), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$UPZeG53k1hYJ5m46Lc0zeOgfle8ZEvzrTsNr9/ISEg7PpwQxJoO2O" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: "a1b2c3d4e5f67890a1b2c3d4e5f67890",
                column: "Difficulty",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: "b2c3d4e5f67890a1b2c3d4e5f67890a1",
                column: "Difficulty",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: "c3d4e5f67890a1b2c3d4e5f67890a1b2",
                column: "Difficulty",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: "d4e5f67890a1b2c3d4e5f67890a1b2c3",
                column: "Difficulty",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: "e5f67890a1b2c3d4e5f67890a1b2c3d4",
                column: "Difficulty",
                value: 5);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Difficulty",
                table: "Lessons");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "00786efb729542fa87a19d44fb3cdf79",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 15, 10, 9, 42, 998, DateTimeKind.Unspecified).AddTicks(2918), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 15, 10, 9, 42, 998, DateTimeKind.Unspecified).AddTicks(2918), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$.rZ.gBNSC0U7tZtBOuR1ZOfg2ICVWTpKRytqyILQmEWYOaqd5Ut8K" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "2bf1c6f4a7db4fed825958e6d78e7226",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 15, 10, 9, 42, 859, DateTimeKind.Unspecified).AddTicks(6574), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 15, 10, 9, 42, 859, DateTimeKind.Unspecified).AddTicks(6574), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$bulyqqi/yfnWly4LUgAD3euJvWdUKnEMJNPWPn7W.vhYV9/WhVNcm" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "54d3a3e95adc4b38885e43af50e12e42",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 15, 10, 9, 42, 457, DateTimeKind.Unspecified).AddTicks(6737), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 15, 10, 9, 42, 457, DateTimeKind.Unspecified).AddTicks(6737), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$/bEMhBosfabI9a4KavFXo.HxG.S8Ybc8eYoLnlAMrvgFIjdF8cdOa" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "6144c9fe6b7e4f4294ea469ffb6a90fd",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 15, 10, 9, 42, 322, DateTimeKind.Unspecified).AddTicks(3343), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 15, 10, 9, 42, 322, DateTimeKind.Unspecified).AddTicks(3343), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$66RpvDevsP81eRwh2UzDT.GorxxxrGKnBO.2w0UN.RupXH.4Pzx8u" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "9f7c3e8a4b6d49f19a8d2e3f4c7b5680",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 15, 10, 9, 43, 267, DateTimeKind.Unspecified).AddTicks(6184), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 15, 10, 9, 43, 267, DateTimeKind.Unspecified).AddTicks(6184), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$uWX.dfR.y9BC8NEvHCH3L.AK3Max8PSwUgqp7L72MvD41c1S7DDMC" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "a1b2c3d4e5f648a9b0c1d2e3f4a5b6c1",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 15, 10, 9, 44, 726, DateTimeKind.Unspecified).AddTicks(9151), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 15, 10, 9, 44, 726, DateTimeKind.Unspecified).AddTicks(9151), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$/mrUoFgQBlcbgSzOAlmSC.9W0wXFQDaHNAj8YmAJWDUtyxZY/Xf7G" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "a1b2c3d4e5f648a9b0c1d2e3f4a5b6c7",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 15, 10, 9, 43, 401, DateTimeKind.Unspecified).AddTicks(581), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 15, 10, 9, 43, 401, DateTimeKind.Unspecified).AddTicks(581), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$TxqIgm48.4ZoFF8Qb5vab.rqTxaM.emvNjfuwQwdNw1QwKHJW0EMi" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "a5b6c7d8e9f0a1b2c3d4e5f648a9b0c1",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 15, 10, 9, 44, 595, DateTimeKind.Unspecified).AddTicks(1497), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 15, 10, 9, 44, 595, DateTimeKind.Unspecified).AddTicks(1497), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$LKMG3Qz4lp6AJ2rnn2D2nOXezOmMSYAFsQWV8ml6wuqxyLkofylOi" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "a9b0c1d2e3f4a5b6c7d8e9f0a1b2c3d4",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 15, 10, 9, 44, 201, DateTimeKind.Unspecified).AddTicks(6684), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 15, 10, 9, 44, 201, DateTimeKind.Unspecified).AddTicks(6684), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$.cw0e8fGDrLE3hXGN/FMfeLkE2LaI.AoZJ.0rMjG0aLOMalIqkvY2" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "b2c3d4e5f648a9b0c1d2e3f4a5b6c1d2",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 15, 10, 9, 44, 856, DateTimeKind.Unspecified).AddTicks(7422), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 15, 10, 9, 44, 856, DateTimeKind.Unspecified).AddTicks(7422), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$MUflrAQnFu5tm6fLY0JOY.o3Fo4yjf.1ByA0QA/i9omZUleNdh70." });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "b2c3d4e5f648a9b0c1d2e3f4a5b6c7d8",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 15, 10, 9, 43, 532, DateTimeKind.Unspecified).AddTicks(714), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 15, 10, 9, 43, 532, DateTimeKind.Unspecified).AddTicks(714), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$Erj4bUlWixG0LCwm4qdgJ.u8q1y7BwJZtkEqZqAhLKhmYuESC9zUu" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "c1d2e3f4a5b6c7d8e9f0a1b2c3d4e5f6",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 15, 10, 9, 44, 331, DateTimeKind.Unspecified).AddTicks(2022), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 15, 10, 9, 44, 331, DateTimeKind.Unspecified).AddTicks(2022), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$ezTqQu47M2D4p7cUMI3NHOiHRIjnJLphEZAPZalF6CPFnfw5h2IPC" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "c3d4e5f648a9b0c1d2e3f4a5b6c1d2e3",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 15, 10, 9, 44, 992, DateTimeKind.Unspecified).AddTicks(5505), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 15, 10, 9, 44, 992, DateTimeKind.Unspecified).AddTicks(5505), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$P9OCr08iWtuJ0VVJlRNgWeQNkbUAZ5V.LdjnyXfbQavWu4lEw4Fzu" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "c3d4e5f648a9b0c1d2e3f4a5b6c7d8e9",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 15, 10, 9, 43, 667, DateTimeKind.Unspecified).AddTicks(1380), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 15, 10, 9, 43, 667, DateTimeKind.Unspecified).AddTicks(1380), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$t3o/s2rm6wgw.MloJVd2P.Gcar1SbInLy.c4FUm4UINM0dXXSJxQW" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "d4e5f648a9b0c1d2e3f4a5b6c1d2e3f4",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 15, 10, 9, 45, 121, DateTimeKind.Unspecified).AddTicks(4082), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 15, 10, 9, 45, 121, DateTimeKind.Unspecified).AddTicks(4082), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$4u5zjUMk046/j3PYsesQ/.uRQLZjjLYp/WxzmP4z2wqzRKwgARwsO" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "d4e5f648a9b0c1d2e3f4a5b6c7d8e9f0",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 15, 10, 9, 43, 795, DateTimeKind.Unspecified).AddTicks(2876), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 15, 10, 9, 43, 795, DateTimeKind.Unspecified).AddTicks(2876), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$kzd1xuTR0I1dJHhCyFbd1.kC08hHi.CZiPqROjuV09xXfbDMk3gTO" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "e3f4a5b6c7d8e9f0a1b2c3d4e5f648a9",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 15, 10, 9, 44, 464, DateTimeKind.Unspecified).AddTicks(5149), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 15, 10, 9, 44, 464, DateTimeKind.Unspecified).AddTicks(5149), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$g3m0lzjFNYzogiapGLUlG.Sj3oHe/VFfh.EeBaf5oKenYj6nWQJdi" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "e5f648a9b0c1d2e3f4a5b6c1d2e3f4a5",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 15, 10, 9, 45, 265, DateTimeKind.Unspecified).AddTicks(2084), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 15, 10, 9, 45, 265, DateTimeKind.Unspecified).AddTicks(2084), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$5exJWVLpNoVtbrboZVwGcewCjK9tMkyMzeGSAc6M32rIg6IIbZF46" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "e5f648a9b0c1d2e3f4a5b6c7d8e9f0a1",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 15, 10, 9, 43, 927, DateTimeKind.Unspecified).AddTicks(3863), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 15, 10, 9, 43, 927, DateTimeKind.Unspecified).AddTicks(3863), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$QOoi0VxrxxQ0OoMfcXUmh.6SXYPg2eaOPGrao9RcExIVdCgI9CRCa" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "ea46ce4e457f42dfb18b6347bd4ea1f4",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 15, 10, 9, 42, 722, DateTimeKind.Unspecified).AddTicks(1939), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 15, 10, 9, 42, 722, DateTimeKind.Unspecified).AddTicks(1939), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$DbxhZ2aZsJ7.E8s58RtETOy7T52t5L6D8VK8hvtV5GzcUnvFfQCHy" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "eaa27cff0c91479087bb22370ffbb6d0",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 15, 10, 9, 43, 137, DateTimeKind.Unspecified).AddTicks(998), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 15, 10, 9, 43, 137, DateTimeKind.Unspecified).AddTicks(998), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$wZmf7DL87OQ17.dPaTOeS..8ekIphG/oU4z.YebOaJENxR8RBcn82" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "f648a9b0c1d2e3f4a5b6c7d8e9f0a1b2",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 15, 10, 9, 44, 65, DateTimeKind.Unspecified).AddTicks(7537), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 15, 10, 9, 44, 65, DateTimeKind.Unspecified).AddTicks(7537), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$ud8og15DE1F957pzrSzPIe322iqMiNKL5u5pHs34aOptBWLqfBqt." });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "fa13bc18b0c54ba0b9886b007f4d8b08",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 15, 10, 9, 42, 588, DateTimeKind.Unspecified).AddTicks(6797), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 15, 10, 9, 42, 588, DateTimeKind.Unspecified).AddTicks(6797), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$fQ2Eb4buSnINt0VrL/wUPehVo/yG.1jInysfrZQnKOnTc93xrrwz." });
        }
    }
}
