using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class V8_AddStatusToAttendanceTbl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "00786efb729542fa87a19d44fb3cdf79",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 8, 20, 30, 1, 893, DateTimeKind.Unspecified).AddTicks(1904), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 8, 20, 30, 1, 893, DateTimeKind.Unspecified).AddTicks(1904), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$OLRWSALpjEKBHbfvFLfFhe9sowdk390w86z.etHrNL818hXMsH94." });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "2bf1c6f4a7db4fed825958e6d78e7226",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 8, 20, 30, 1, 761, DateTimeKind.Unspecified).AddTicks(2170), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 8, 20, 30, 1, 761, DateTimeKind.Unspecified).AddTicks(2170), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$NLemSigXk5bGZr333L9yUeiDca/veaRmWI46qSBJW/fZFqP3t/ICq" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "54d3a3e95adc4b38885e43af50e12e42",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 8, 20, 30, 1, 357, DateTimeKind.Unspecified).AddTicks(9841), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 8, 20, 30, 1, 357, DateTimeKind.Unspecified).AddTicks(9841), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$Kp0FGe3sfOnAebfgjgvPROHhcme3UQNiYNzNyfPUIfma5Th2GdL46" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "6144c9fe6b7e4f4294ea469ffb6a90fd",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 8, 20, 30, 1, 213, DateTimeKind.Unspecified).AddTicks(9539), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 8, 20, 30, 1, 213, DateTimeKind.Unspecified).AddTicks(9539), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$f.oI157DodECAkAp2YGg6.RRVw9Ry9hhgee54W8ttxsytwu.B8SCq" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "9f7c3e8a4b6d49f19a8d2e3f4c7b5680",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 8, 20, 30, 2, 160, DateTimeKind.Unspecified).AddTicks(6089), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 8, 20, 30, 2, 160, DateTimeKind.Unspecified).AddTicks(6089), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$tlHRSRhrC6WIyxkSkskUGOMHCBXiBs2A8.4aF0xNPp1Qnj3rdKGg2" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "ea46ce4e457f42dfb18b6347bd4ea1f4",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 8, 20, 30, 1, 624, DateTimeKind.Unspecified).AddTicks(9663), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 8, 20, 30, 1, 624, DateTimeKind.Unspecified).AddTicks(9663), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$/yVHHJFyz8TjQBA2AJCINOhyENipNMjLMzGaOm45rr3T0mzWZmXD2" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "eaa27cff0c91479087bb22370ffbb6d0",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 8, 20, 30, 2, 22, DateTimeKind.Unspecified).AddTicks(8224), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 8, 20, 30, 2, 22, DateTimeKind.Unspecified).AddTicks(8224), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$t5jbyu25ZCABawgL5vL47eODw6SDkfGZbiLHoAwjSAUUAqt1Ywpt." });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "fa13bc18b0c54ba0b9886b007f4d8b08",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 8, 20, 30, 1, 491, DateTimeKind.Unspecified).AddTicks(2303), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 8, 20, 30, 1, 491, DateTimeKind.Unspecified).AddTicks(2303), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$0kHdh.Odb1Ll/v7m3fca6O.Zbt.oe0LzeXyEGekego9x5cefABxHC" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "00786efb729542fa87a19d44fb3cdf79",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 8, 20, 20, 10, 578, DateTimeKind.Unspecified).AddTicks(9921), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 8, 20, 20, 10, 578, DateTimeKind.Unspecified).AddTicks(9921), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$xEcYUIjEfB.J7GRyH/.XLeIvadYCPBmsJ/G8cx/3Wks3Nh476e33C" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "2bf1c6f4a7db4fed825958e6d78e7226",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 8, 20, 20, 10, 438, DateTimeKind.Unspecified).AddTicks(6063), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 8, 20, 20, 10, 438, DateTimeKind.Unspecified).AddTicks(6063), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$lw9yhk5jEYTm.5Ll3u68NeYjhH2rh49MqyKRmbcURoRX8F8YyBfGm" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "54d3a3e95adc4b38885e43af50e12e42",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 8, 20, 20, 10, 22, DateTimeKind.Unspecified).AddTicks(6724), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 8, 20, 20, 10, 22, DateTimeKind.Unspecified).AddTicks(6724), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$83AMzJHC867olXGRmaj.DOUvyDOYV6pxf/YWjHlYAiNC4Vb2zcRYa" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "6144c9fe6b7e4f4294ea469ffb6a90fd",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 8, 20, 20, 9, 887, DateTimeKind.Unspecified).AddTicks(1119), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 8, 20, 20, 9, 887, DateTimeKind.Unspecified).AddTicks(1119), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$JVkMzXnNqmVkfWzBJMrExu7iRGP6eEcncIu94CPD3qQGjC8FjP/cq" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "9f7c3e8a4b6d49f19a8d2e3f4c7b5680",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 8, 20, 20, 10, 855, DateTimeKind.Unspecified).AddTicks(2360), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 8, 20, 20, 10, 855, DateTimeKind.Unspecified).AddTicks(2360), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$jT4vzPm3dNXXbSGLdRv1zu4wSS37Si3kO.ul77vloM2vEsiO57wVK" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "ea46ce4e457f42dfb18b6347bd4ea1f4",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 8, 20, 20, 10, 297, DateTimeKind.Unspecified).AddTicks(4021), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 8, 20, 20, 10, 297, DateTimeKind.Unspecified).AddTicks(4021), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$K3Yz47eufAiE0Yd.UORuaeYXN8GWP5RwRKEMXQuWWezI0McKsBMSa" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "eaa27cff0c91479087bb22370ffbb6d0",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 8, 20, 20, 10, 715, DateTimeKind.Unspecified).AddTicks(7684), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 8, 20, 20, 10, 715, DateTimeKind.Unspecified).AddTicks(7684), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$SaVh14KrjHtJ3pYcBGBZnu1VfLcmnqI1kEPKaI4ElLENycI6ekTo." });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "fa13bc18b0c54ba0b9886b007f4d8b08",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 8, 20, 20, 10, 159, DateTimeKind.Unspecified).AddTicks(6620), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 8, 20, 20, 10, 159, DateTimeKind.Unspecified).AddTicks(6620), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$ulGNHYXPKBX1odyufa38B.YYYXXm.drMTGKNBhRLzeG5j6feP86g6" });
        }
    }
}
