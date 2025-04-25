using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class V8_AddAttNoteToPretestTbl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "PreTests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "00786efb729542fa87a19d44fb3cdf79",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 25, 12, 13, 8, 272, DateTimeKind.Unspecified).AddTicks(6325), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 25, 12, 13, 8, 272, DateTimeKind.Unspecified).AddTicks(6325), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$jsIq.1Ydj08QXD7hUgBsxeoKIXQ1CjfZLQdDlQWQfMBbo9b2j67he" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "2bf1c6f4a7db4fed825958e6d78e7226",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 25, 12, 13, 8, 154, DateTimeKind.Unspecified).AddTicks(1386), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 25, 12, 13, 8, 154, DateTimeKind.Unspecified).AddTicks(1386), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$a/ne6DRWesVV7weQKOpuCulRLhBtXqh2UWR5mHp9sFjJdTWT9osoe" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "54d3a3e95adc4b38885e43af50e12e42",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 25, 12, 13, 7, 791, DateTimeKind.Unspecified).AddTicks(1573), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 25, 12, 13, 7, 791, DateTimeKind.Unspecified).AddTicks(1573), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$HF7y5FXVGMPTlhGpDwUviubAx8ig.5cQe50RLdCBdAFJGD1VVSPOe" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "6144c9fe6b7e4f4294ea469ffb6a90fd",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 25, 12, 13, 7, 659, DateTimeKind.Unspecified).AddTicks(727), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 25, 12, 13, 7, 659, DateTimeKind.Unspecified).AddTicks(727), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$5SfxUJfHif.eaTcLYbcpqu2cOi0Iod2mZsQtqI6clRPTR5/B37WY6" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "9f7c3e8a4b6d49f19a8d2e3f4c7b5680",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 25, 12, 13, 8, 511, DateTimeKind.Unspecified).AddTicks(8120), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 25, 12, 13, 8, 511, DateTimeKind.Unspecified).AddTicks(8120), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$bXhH4N4UDFbHWBSy6HrwneKQMQ3NgxaUQ4McYJvQmR5amSvGBBJXS" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "a1b2c3d4e5f648a9b0c1d2e3f4a5b6c1",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 25, 12, 13, 9, 863, DateTimeKind.Unspecified).AddTicks(2616), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 25, 12, 13, 9, 863, DateTimeKind.Unspecified).AddTicks(2616), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$/NPiwx6l5JwqZb/E4N1HLeToEQVungwizMW0D4tTT2R5Nso8b/UPS" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "a1b2c3d4e5f648a9b0c1d2e3f4a5b6c7",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 25, 12, 13, 8, 632, DateTimeKind.Unspecified).AddTicks(1423), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 25, 12, 13, 8, 632, DateTimeKind.Unspecified).AddTicks(1423), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$VOvssaEvTaWQ/3aZYvzbU.1roCoOfWECIPyhZv4fA4D9VMF0UCUaC" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "a5b6c7d8e9f0a1b2c3d4e5f648a9b0c1",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 25, 12, 13, 9, 739, DateTimeKind.Unspecified).AddTicks(8212), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 25, 12, 13, 9, 739, DateTimeKind.Unspecified).AddTicks(8212), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$hQX12MzDIfUF10NUhq/fWeoraS/6eJaaphvYeCWU9fongP15lsw/m" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "a9b0c1d2e3f4a5b6c7d8e9f0a1b2c3d4",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 25, 12, 13, 9, 365, DateTimeKind.Unspecified).AddTicks(4195), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 25, 12, 13, 9, 365, DateTimeKind.Unspecified).AddTicks(4195), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$ASEejyoq0vWIcGMQj42JwueOVy4Q8HG6We/Trt1Q6/kOKvot9b01G" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "b2c3d4e5f648a9b0c1d2e3f4a5b6c1d2",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 25, 12, 13, 9, 990, DateTimeKind.Unspecified).AddTicks(2543), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 25, 12, 13, 9, 990, DateTimeKind.Unspecified).AddTicks(2543), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$ikXMUxSyyYQBzFUXjeYRJeXRYFURJHdRLayK8sEoFM/rv1AddXaZ." });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "b2c3d4e5f648a9b0c1d2e3f4a5b6c7d8",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 25, 12, 13, 8, 752, DateTimeKind.Unspecified).AddTicks(3561), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 25, 12, 13, 8, 752, DateTimeKind.Unspecified).AddTicks(3561), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$y0kiKH9psih31HTTOHTt2eHVX3W6eyMuMRbNj7tj0A9jAe3ci5QRG" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "c1d2e3f4a5b6c7d8e9f0a1b2c3d4e5f6",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 25, 12, 13, 9, 484, DateTimeKind.Unspecified).AddTicks(7829), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 25, 12, 13, 9, 484, DateTimeKind.Unspecified).AddTicks(7829), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$BnesJm9mriKBaXnXdsGaV.vBkNeg4QfMtYdGcgKpFsSYVl9qh5kH." });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "c3d4e5f648a9b0c1d2e3f4a5b6c1d2e3",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 25, 12, 13, 10, 110, DateTimeKind.Unspecified).AddTicks(6915), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 25, 12, 13, 10, 110, DateTimeKind.Unspecified).AddTicks(6915), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$oz5.yAtdGfvsRN/tslwqE.58i.HtGCkzpZ/u1E/Q9bwgWCDAk7sai" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "c3d4e5f648a9b0c1d2e3f4a5b6c7d8e9",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 25, 12, 13, 8, 874, DateTimeKind.Unspecified).AddTicks(6154), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 25, 12, 13, 8, 874, DateTimeKind.Unspecified).AddTicks(6154), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$ObGRXWg8Q2mwOfvDdkCb.uvN2MiiLVcwmr8FYhjOWC52imJOdnq/y" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "d4e5f648a9b0c1d2e3f4a5b6c1d2e3f4",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 25, 12, 13, 10, 234, DateTimeKind.Unspecified).AddTicks(695), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 25, 12, 13, 10, 234, DateTimeKind.Unspecified).AddTicks(695), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$i7qfe2W7U8ZEkxkZ2QscDudcmVQNIU.Z17muoyiq4bPL5Dijyqa9q" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "d4e5f648a9b0c1d2e3f4a5b6c7d8e9f0",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 25, 12, 13, 8, 997, DateTimeKind.Unspecified).AddTicks(3524), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 25, 12, 13, 8, 997, DateTimeKind.Unspecified).AddTicks(3524), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$cTvWTMg8n9Sntoifc9wOcOtbFYGe5oKy/w.rSAZlxyvf6kQlhB9QW" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "e3f4a5b6c7d8e9f0a1b2c3d4e5f648a9",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 25, 12, 13, 9, 609, DateTimeKind.Unspecified).AddTicks(7431), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 25, 12, 13, 9, 609, DateTimeKind.Unspecified).AddTicks(7431), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$IRd7hMvDNCz87Idy6LNO6uWCpIADABuw8kzhaeY2D9.radJnAwYFW" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "e5f648a9b0c1d2e3f4a5b6c1d2e3f4a5",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 25, 12, 13, 10, 352, DateTimeKind.Unspecified).AddTicks(7947), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 25, 12, 13, 10, 352, DateTimeKind.Unspecified).AddTicks(7947), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$kSlW354xAKZFtkzmzjMkA.K9DTMHPLukMrs9sHi5DzlUpIQMDzBAC" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "e5f648a9b0c1d2e3f4a5b6c7d8e9f0a1",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 25, 12, 13, 9, 120, DateTimeKind.Unspecified).AddTicks(7419), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 25, 12, 13, 9, 120, DateTimeKind.Unspecified).AddTicks(7419), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$9i1wK1t.Ufa3k3IB2d9k5.djjozQkuJXVNgRNMG11x9fYBtV3ho2K" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "ea46ce4e457f42dfb18b6347bd4ea1f4",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 25, 12, 13, 8, 34, DateTimeKind.Unspecified).AddTicks(7900), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 25, 12, 13, 8, 34, DateTimeKind.Unspecified).AddTicks(7900), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$BHdRivFa9WDHSCGjYd4C7uz3zWuJtF9OfmW5sznjWIrpAUO2FnE8q" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "eaa27cff0c91479087bb22370ffbb6d0",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 25, 12, 13, 8, 392, DateTimeKind.Unspecified).AddTicks(6458), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 25, 12, 13, 8, 392, DateTimeKind.Unspecified).AddTicks(6458), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$4zm/ZEuMmtIzJa97Q8t5xO0SRI5q16gYlUKva31Hcrj95SThClanK" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "f648a9b0c1d2e3f4a5b6c7d8e9f0a1b2",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 25, 12, 13, 9, 244, DateTimeKind.Unspecified).AddTicks(5142), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 25, 12, 13, 9, 244, DateTimeKind.Unspecified).AddTicks(5142), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$FrRpB0nkoGgmyBm6Ow01DesqKn2viPEi4cVE4Lup.tUByKH.SMnbS" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "fa13bc18b0c54ba0b9886b007f4d8b08",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 25, 12, 13, 7, 912, DateTimeKind.Unspecified).AddTicks(415), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 25, 12, 13, 7, 912, DateTimeKind.Unspecified).AddTicks(415), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$V5Be6ZmtVGRcWnIUNldl.uM14c3u4nCHIdq/TJblm5XCFhiZ.ZzGm" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Note",
                table: "PreTests");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "00786efb729542fa87a19d44fb3cdf79",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 18, 20, 58, 44, 707, DateTimeKind.Unspecified).AddTicks(8100), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 18, 20, 58, 44, 707, DateTimeKind.Unspecified).AddTicks(8100), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$i2NIG3deboFOJV4d7zG3K.Rrc4cMLx9.uHay7P7bxDW5ctwZCyEfC" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "2bf1c6f4a7db4fed825958e6d78e7226",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 18, 20, 58, 44, 590, DateTimeKind.Unspecified).AddTicks(9363), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 18, 20, 58, 44, 590, DateTimeKind.Unspecified).AddTicks(9363), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$J1s1bNO/XjfrTagpyAtwEOHZNXlwa4x5lqWPDp1o1YxabV3Ax70du" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "54d3a3e95adc4b38885e43af50e12e42",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 18, 20, 58, 44, 230, DateTimeKind.Unspecified).AddTicks(5683), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 18, 20, 58, 44, 230, DateTimeKind.Unspecified).AddTicks(5683), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$Fcq95nhX3qQiWSb33cHS3uT/zEHEsw8GeSpTuxpsIWQeWpoXgSJPm" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "6144c9fe6b7e4f4294ea469ffb6a90fd",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 18, 20, 58, 44, 110, DateTimeKind.Unspecified).AddTicks(4429), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 18, 20, 58, 44, 110, DateTimeKind.Unspecified).AddTicks(4429), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$mFM2C0nY4bL/piMorSqa4ukAac6Z136qmI3PTkJ8IZq.Jq5/0/Haa" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "9f7c3e8a4b6d49f19a8d2e3f4c7b5680",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 18, 20, 58, 44, 940, DateTimeKind.Unspecified).AddTicks(5070), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 18, 20, 58, 44, 940, DateTimeKind.Unspecified).AddTicks(5070), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$90wzd5QdhKQcBZeSRfuLmOMTnGuXaYB1L2I5y0nbE0nLw0YVDMv8K" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "a1b2c3d4e5f648a9b0c1d2e3f4a5b6c1",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 18, 20, 58, 46, 249, DateTimeKind.Unspecified).AddTicks(8479), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 18, 20, 58, 46, 249, DateTimeKind.Unspecified).AddTicks(8479), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$e52DUNsVFYXQhvplXXZPgOmHCFJt.Gy6ekBbjXD/oGqTYb/uyF9tO" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "a1b2c3d4e5f648a9b0c1d2e3f4a5b6c7",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 18, 20, 58, 45, 56, DateTimeKind.Unspecified).AddTicks(2982), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 18, 20, 58, 45, 56, DateTimeKind.Unspecified).AddTicks(2982), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$6dboUJ4WMkSdu4mkHIjju.asNfZmPHgw7Di/BHa7cLgU..U.PUYx6" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "a5b6c7d8e9f0a1b2c3d4e5f648a9b0c1",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 18, 20, 58, 46, 127, DateTimeKind.Unspecified).AddTicks(9201), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 18, 20, 58, 46, 127, DateTimeKind.Unspecified).AddTicks(9201), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$gy2hsP2HhEGXZJrw1xoCeenwp7AoGxlNoMs424vgEbVowMpyyaXkW" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "a9b0c1d2e3f4a5b6c7d8e9f0a1b2c3d4",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 18, 20, 58, 45, 763, DateTimeKind.Unspecified).AddTicks(1193), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 18, 20, 58, 45, 763, DateTimeKind.Unspecified).AddTicks(1193), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$TlGqGwn2gkBTkO301SecWOr3dWh53Kck8CigzcxsO1q5ICZ9Ytlbi" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "b2c3d4e5f648a9b0c1d2e3f4a5b6c1d2",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 18, 20, 58, 46, 368, DateTimeKind.Unspecified).AddTicks(2986), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 18, 20, 58, 46, 368, DateTimeKind.Unspecified).AddTicks(2986), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$ysIMy0agpmyL7OkJNJ/7YO.1/wAMqKgU6QkK9EuYsKjOIAFiBGTuS" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "b2c3d4e5f648a9b0c1d2e3f4a5b6c7d8",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 18, 20, 58, 45, 175, DateTimeKind.Unspecified).AddTicks(7663), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 18, 20, 58, 45, 175, DateTimeKind.Unspecified).AddTicks(7663), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$HdNpaCPRzF8Wk02tSmy8tOG5ZM44m9FUzlr7dsN.OiIaraRyeogEe" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "c1d2e3f4a5b6c7d8e9f0a1b2c3d4e5f6",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 18, 20, 58, 45, 882, DateTimeKind.Unspecified).AddTicks(3597), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 18, 20, 58, 45, 882, DateTimeKind.Unspecified).AddTicks(3597), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$YW18KeU2dUxCkc0/RlSKOObJJevYt4RuC9ovzl6SwTcEecoMBsdqm" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "c3d4e5f648a9b0c1d2e3f4a5b6c1d2e3",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 18, 20, 58, 46, 484, DateTimeKind.Unspecified).AddTicks(5044), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 18, 20, 58, 46, 484, DateTimeKind.Unspecified).AddTicks(5044), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$9OvZ9dDDMSLUYHZ1/9kI3eEC4Nn8U4mLFekzpMHvDOfHhd52XsREy" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "c3d4e5f648a9b0c1d2e3f4a5b6c7d8e9",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 18, 20, 58, 45, 292, DateTimeKind.Unspecified).AddTicks(5245), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 18, 20, 58, 45, 292, DateTimeKind.Unspecified).AddTicks(5245), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$2v2d1/7g6egZfVDI2EJGZu46CwCkdiSZlS8FeOTNp80suLxyMIhRG" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "d4e5f648a9b0c1d2e3f4a5b6c1d2e3f4",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 18, 20, 58, 46, 603, DateTimeKind.Unspecified).AddTicks(6359), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 18, 20, 58, 46, 603, DateTimeKind.Unspecified).AddTicks(6359), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$tMzVfoP1AMHr.OuAgw2mNeC0e1v9iTX8NCaaxdKYYHHl.UjRTCUfy" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "d4e5f648a9b0c1d2e3f4a5b6c7d8e9f0",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 18, 20, 58, 45, 409, DateTimeKind.Unspecified).AddTicks(9913), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 18, 20, 58, 45, 409, DateTimeKind.Unspecified).AddTicks(9913), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$RiQkkUosIHXpdWL05fAYqerawooSex7qOYxPhD8vdB85kl75JwDWe" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "e3f4a5b6c7d8e9f0a1b2c3d4e5f648a9",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 18, 20, 58, 45, 998, DateTimeKind.Unspecified).AddTicks(2740), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 18, 20, 58, 45, 998, DateTimeKind.Unspecified).AddTicks(2740), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$bEDxajlv24kOoLsQGDn/MuE08FbrB7W8Lc7QK6PxOHmhDmcEpRDIW" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "e5f648a9b0c1d2e3f4a5b6c1d2e3f4a5",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 18, 20, 58, 46, 719, DateTimeKind.Unspecified).AddTicks(3675), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 18, 20, 58, 46, 719, DateTimeKind.Unspecified).AddTicks(3675), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$bWH6N5119b5qusuG1VTvFeHxfy82NdW2D2zDfmu2yA1n3QR41Cj7q" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "e5f648a9b0c1d2e3f4a5b6c7d8e9f0a1",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 18, 20, 58, 45, 525, DateTimeKind.Unspecified).AddTicks(8805), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 18, 20, 58, 45, 525, DateTimeKind.Unspecified).AddTicks(8805), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$SBbbrd8ude5Moz1muMgs5.WC0nzPK1vtIR4Q6uUgPkqmMvvtGmumW" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "ea46ce4e457f42dfb18b6347bd4ea1f4",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 18, 20, 58, 44, 470, DateTimeKind.Unspecified).AddTicks(5268), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 18, 20, 58, 44, 470, DateTimeKind.Unspecified).AddTicks(5268), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$VHfROrEJusfjPrlCPfcI6OEygCtaq/k9rfeKUkJxXHzydI8mHEjSm" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "eaa27cff0c91479087bb22370ffbb6d0",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 18, 20, 58, 44, 824, DateTimeKind.Unspecified).AddTicks(4777), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 18, 20, 58, 44, 824, DateTimeKind.Unspecified).AddTicks(4777), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$FLmnOriWD1fWgMiZoX5Vu.4rphM.GkyC0Oexioapz8dxEUPARai1m" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "f648a9b0c1d2e3f4a5b6c7d8e9f0a1b2",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 18, 20, 58, 45, 645, DateTimeKind.Unspecified).AddTicks(1629), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 18, 20, 58, 45, 645, DateTimeKind.Unspecified).AddTicks(1629), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$4zh2fvbNSMdcbYjX4cvJUuoBBZiLTXTmeMzAtw3dPH516sNX1ZA4y" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "fa13bc18b0c54ba0b9886b007f4d8b08",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 18, 20, 58, 44, 351, DateTimeKind.Unspecified).AddTicks(4227), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 18, 20, 58, 44, 351, DateTimeKind.Unspecified).AddTicks(4227), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$X1dqVzAj505sU4KhUMEvjelbQv0W/HP5/zwYyw9z4zdVXv1fHqrIW" });
        }
    }
}
