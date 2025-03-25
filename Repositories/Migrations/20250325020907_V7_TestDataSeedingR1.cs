using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class V7_TestDataSeedingR1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "00786efb729542fa87a19d44fb3cdf79",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 25, 9, 9, 6, 753, DateTimeKind.Unspecified).AddTicks(6053), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 25, 9, 9, 6, 753, DateTimeKind.Unspecified).AddTicks(6053), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$lLGIcgI5fkXF1MTB92tLqO/.9vCPgk0dd5SiebE9Kh.KB0gFS5Afi" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "2bf1c6f4a7db4fed825958e6d78e7226",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 25, 9, 9, 6, 622, DateTimeKind.Unspecified).AddTicks(7815), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 25, 9, 9, 6, 622, DateTimeKind.Unspecified).AddTicks(7815), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$Jq2uVZgtDSoKdO8ozXRD9.n9g8b8VTTuY1h29wh3MIttCd1bTxrQS" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "54d3a3e95adc4b38885e43af50e12e42",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 25, 9, 9, 6, 230, DateTimeKind.Unspecified).AddTicks(4244), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 25, 9, 9, 6, 230, DateTimeKind.Unspecified).AddTicks(4244), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$FkZKWoxkNsOBuMYWf3i8Gun6wXcXqsUA5Z52W.rHtWwaREiwpqKsq" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "6144c9fe6b7e4f4294ea469ffb6a90fd",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 25, 9, 9, 6, 91, DateTimeKind.Unspecified).AddTicks(6717), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 25, 9, 9, 6, 91, DateTimeKind.Unspecified).AddTicks(6717), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$t0MzlH8QOb9l5v6Ztl8xHeP.MYE8ObYw.GD12pqIyBuC7vll3Sn46" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "ea46ce4e457f42dfb18b6347bd4ea1f4",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 25, 9, 9, 6, 492, DateTimeKind.Unspecified).AddTicks(2655), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 25, 9, 9, 6, 492, DateTimeKind.Unspecified).AddTicks(2655), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$9BEN8NZjXk8Nxea8sZXxEuF69VcpLOBgP9GaIgdqHLNm4m37mmwtO" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "eaa27cff0c91479087bb22370ffbb6d0",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 25, 9, 9, 6, 881, DateTimeKind.Unspecified).AddTicks(966), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 25, 9, 9, 6, 881, DateTimeKind.Unspecified).AddTicks(966), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$f3rnipgdxBs2rri5OyuhVeGOw5xo2hpJyH1VMZ7CtRYbA3uq0CZfC" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "fa13bc18b0c54ba0b9886b007f4d8b08",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 25, 9, 9, 6, 362, DateTimeKind.Unspecified).AddTicks(3368), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 25, 9, 9, 6, 362, DateTimeKind.Unspecified).AddTicks(3368), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$2WtS3kvBPAAUh28152uGXejdC4f4cocLSNeEjPApIg8f3Sj110mi6" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Address", "CreatedTime", "DateOfBirth", "Email", "FullName", "Gender", "ImageUrl", "LastUpdatedTime", "MembershipId", "MembershipPoints", "Password", "PhoneNumber", "RegistrationTime", "RoleId", "Status", "Username" },
                values: new object[] { "9f7c3e8a4b6d49f19a8d2e3f4c7b5680", "Test Address", new DateTimeOffset(new DateTime(2025, 3, 25, 9, 9, 7, 10, DateTimeKind.Unspecified).AddTicks(1951), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@gmail.com", "Test User", 1, "empty", new DateTimeOffset(new DateTime(2025, 3, 25, 9, 9, 7, 10, DateTimeKind.Unspecified).AddTicks(1951), new TimeSpan(0, 7, 0, 0, 0)), "a1b2c3d4e5f67890a1b2c3d4e5f67890", 0, "$2a$11$twWzNjBLtHto7Nez3tj9nuqQ75h1w03VCDnKrZpuvETRtmyzJQdC2", "0123456789", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "a4b5c67890d1e2f3a4b5c67890d1e2f3", 1, "test" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "9f7c3e8a4b6d49f19a8d2e3f4c7b5680");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "00786efb729542fa87a19d44fb3cdf79",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 25, 9, 6, 31, 217, DateTimeKind.Unspecified).AddTicks(794), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 25, 9, 6, 31, 217, DateTimeKind.Unspecified).AddTicks(794), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$q2TNbbklWQqVGkpcAD021OMO35z9tuPaOAwrbMWlg1wpMuXBnh/Wu" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "2bf1c6f4a7db4fed825958e6d78e7226",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 25, 9, 6, 31, 75, DateTimeKind.Unspecified).AddTicks(4782), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 25, 9, 6, 31, 75, DateTimeKind.Unspecified).AddTicks(4782), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$.IFG/YXI6oxzYjj0QDB/jOMNP0/DuvmnHO8/KIUeLca7tdnwlSwwu" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "54d3a3e95adc4b38885e43af50e12e42",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 25, 9, 6, 30, 644, DateTimeKind.Unspecified).AddTicks(1043), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 25, 9, 6, 30, 644, DateTimeKind.Unspecified).AddTicks(1043), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$AC0H8O9EsWpf4Ar0dKc0X.7QQ7tZA8EiPM9X.xn0f8SnORdgvx8y6" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "6144c9fe6b7e4f4294ea469ffb6a90fd",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 25, 9, 6, 30, 505, DateTimeKind.Unspecified).AddTicks(5037), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 25, 9, 6, 30, 505, DateTimeKind.Unspecified).AddTicks(5037), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$sr8HWMkWFOCngFPIJiR9r.unx/iCRxs5.8B6lv/IPGiWJXpDLnU9S" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "ea46ce4e457f42dfb18b6347bd4ea1f4",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 25, 9, 6, 30, 929, DateTimeKind.Unspecified).AddTicks(3610), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 25, 9, 6, 30, 929, DateTimeKind.Unspecified).AddTicks(3610), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$mi3C97OnVi3ZfRWOJnM2SOAhKWkf9QepuA9bRhHVfi41z5eRllrs2" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "eaa27cff0c91479087bb22370ffbb6d0",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 25, 9, 6, 31, 352, DateTimeKind.Unspecified).AddTicks(1564), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 25, 9, 6, 31, 352, DateTimeKind.Unspecified).AddTicks(1564), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$maKCMtTh5It5rW9M4Jst9uKHI9EO7Md1o62CuReRWt5Bh9cFYjxsS" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "fa13bc18b0c54ba0b9886b007f4d8b08",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 25, 9, 6, 30, 783, DateTimeKind.Unspecified).AddTicks(1149), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 25, 9, 6, 30, 783, DateTimeKind.Unspecified).AddTicks(1149), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$jh3FfuUM1LhlM2dErIj3leRLTV9n6SpSNbKWI..CR/u2qIIk4XkqC" });
        }
    }
}
