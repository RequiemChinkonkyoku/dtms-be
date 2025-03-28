using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class V8_UpdateSeedingDataForTblCourseSchedule : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: "5e6f7a8b9c0d1e2f3a4b5c6d7e8f9a0b");

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: "6f7a8b9c0d1e2f3a4b5c6d7e8f9a0b1c");

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: "7a8b9c0d1e2f3a4b5c6d7e8f9a0b1c2d");

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: "8b9c0d1e2f3a4b5c6d7e8f9a0b1c2d3e");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "00786efb729542fa87a19d44fb3cdf79",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 27, 21, 19, 40, 508, DateTimeKind.Unspecified).AddTicks(6662), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 27, 21, 19, 40, 508, DateTimeKind.Unspecified).AddTicks(6662), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$ZmNmC4sObQxUZh0/Y9ilYulAm0LfbY8BqpsGOJI0fZKKRRComeJ0C" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "2bf1c6f4a7db4fed825958e6d78e7226",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 27, 21, 19, 40, 392, DateTimeKind.Unspecified).AddTicks(1), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 27, 21, 19, 40, 392, DateTimeKind.Unspecified).AddTicks(1), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$iBy3iA5Tw.ix6OwNHhZgwuBiUlrgJYj90edm3erp6VMS9yIY/xkbq" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "54d3a3e95adc4b38885e43af50e12e42",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 27, 21, 19, 40, 39, DateTimeKind.Unspecified).AddTicks(2574), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 27, 21, 19, 40, 39, DateTimeKind.Unspecified).AddTicks(2574), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$x2.zb.5FhI3NDxSHwNvNqezn4eHUD9zkaknIbMXYZPzTTZYxE0qn2" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "6144c9fe6b7e4f4294ea469ffb6a90fd",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 27, 21, 19, 39, 921, DateTimeKind.Unspecified).AddTicks(3687), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 27, 21, 19, 39, 921, DateTimeKind.Unspecified).AddTicks(3687), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$MsJ/63Sk11RfohJ73WZq4ufnJKQt2mPsNCwGQwsdXDkYl/bYkfp36" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "9f7c3e8a4b6d49f19a8d2e3f4c7b5680",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 27, 21, 19, 40, 741, DateTimeKind.Unspecified).AddTicks(1303), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 27, 21, 19, 40, 741, DateTimeKind.Unspecified).AddTicks(1303), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$W6yUb/ugZeDp/fGkrJLbcuOqonT35S.gIfOg6E6zINfgHki0WsDtq" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "ea46ce4e457f42dfb18b6347bd4ea1f4",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 27, 21, 19, 40, 274, DateTimeKind.Unspecified).AddTicks(4407), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 27, 21, 19, 40, 274, DateTimeKind.Unspecified).AddTicks(4407), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$ZNsG.efFQpQ3Z928MIKBAuQGGxFkaHOtOQv528yYH.CmIkFeNer.K" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "eaa27cff0c91479087bb22370ffbb6d0",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 27, 21, 19, 40, 624, DateTimeKind.Unspecified).AddTicks(3954), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 27, 21, 19, 40, 624, DateTimeKind.Unspecified).AddTicks(3954), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$nGtFVOf85DjIfPfMK8ckou48jfAfAb/TAd85WgpJui1cOKtYb0u/W" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "fa13bc18b0c54ba0b9886b007f4d8b08",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 27, 21, 19, 40, 157, DateTimeKind.Unspecified).AddTicks(7418), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 27, 21, 19, 40, 157, DateTimeKind.Unspecified).AddTicks(7418), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$m5xmZ9n4sADqbhGi6l9YH.uGLtGZrwZFfPAU.nA/j1IF2./FXEqiG" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "a2b3c4d5e67890a1b2c3d4e5f67890f1",
                column: "Price",
                value: 100000m);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "b3c4d5e67890a1b2c3d4e5f67890f1a2",
                column: "Price",
                value: 100000m);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c4d5e67890a1b2c3d4e5f67890f1a2b3",
                column: "Price",
                value: 100000m);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "d5e67890a1b2c3d4e5f67890f1a2b3c4",
                column: "Price",
                value: 100000m);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "f1a2b3c4d5e67890a1b2c3d4e5f67890",
                column: "Price",
                value: 100000m);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: "1a2b3c4d5e6f7890a1b2c3d4e5f6a7b8",
                column: "EndTime",
                value: new TimeOnly(10, 0, 0));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: "2b3c4d5e6f7a8b9c0d1e2f3a4b5c6d7e",
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeOnly(12, 0, 0), new TimeOnly(10, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: "3c4d5e6f7a8b9c0d1e2f3a4b5c6d7e8f",
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeOnly(15, 0, 0), new TimeOnly(13, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: "4d5e6f7a8b9c0d1e2f3a4b5c6d7e8f9a",
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeOnly(17, 0, 0), new TimeOnly(15, 0, 0) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "00786efb729542fa87a19d44fb3cdf79",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 27, 21, 12, 57, 77, DateTimeKind.Unspecified).AddTicks(6536), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 27, 21, 12, 57, 77, DateTimeKind.Unspecified).AddTicks(6536), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$wcW79.0oqKjrIo3OAgL3hO4mVR5gebG9zzQl0kv0KXMpzB/6alU92" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "2bf1c6f4a7db4fed825958e6d78e7226",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 27, 21, 12, 56, 951, DateTimeKind.Unspecified).AddTicks(7849), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 27, 21, 12, 56, 951, DateTimeKind.Unspecified).AddTicks(7849), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$bOj9p1uvLXwQP8Bq3GFwbejhRcZZZyaXyDZsrvk.XPPj4nQy69EEa" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "54d3a3e95adc4b38885e43af50e12e42",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 27, 21, 12, 56, 588, DateTimeKind.Unspecified).AddTicks(9970), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 27, 21, 12, 56, 588, DateTimeKind.Unspecified).AddTicks(9970), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$KcF5szlSIsx0jPrfpXGf2.tP0zOFIlQK6dr1PbTKjZ3HwSAFTQg2C" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "6144c9fe6b7e4f4294ea469ffb6a90fd",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 27, 21, 12, 56, 458, DateTimeKind.Unspecified).AddTicks(670), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 27, 21, 12, 56, 458, DateTimeKind.Unspecified).AddTicks(670), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$JgCWKIedQziTX8iKv6cDo.8UgJZMt2T.Aq5WSvs3/p8e10xutPXti" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "9f7c3e8a4b6d49f19a8d2e3f4c7b5680",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 27, 21, 12, 57, 346, DateTimeKind.Unspecified).AddTicks(2281), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 27, 21, 12, 57, 346, DateTimeKind.Unspecified).AddTicks(2281), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$OGwnzAZrdcjiACR3MuWaNuvcDzLfmgAbBYl/YRafBToEK1s3VBxtC" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "ea46ce4e457f42dfb18b6347bd4ea1f4",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 27, 21, 12, 56, 831, DateTimeKind.Unspecified).AddTicks(1490), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 27, 21, 12, 56, 831, DateTimeKind.Unspecified).AddTicks(1490), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$iBz0is27aW2MJvN1aUiI2u7cF9toxL7QjGERKsJ33Tsz9MEeeLaaK" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "eaa27cff0c91479087bb22370ffbb6d0",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 27, 21, 12, 57, 206, DateTimeKind.Unspecified).AddTicks(3309), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 27, 21, 12, 57, 206, DateTimeKind.Unspecified).AddTicks(3309), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$v/X/YMoDp6aqaSt1Te8mB.LDtTJFt.nsEw7cPZ5NpVY9NKUknGPAe" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "fa13bc18b0c54ba0b9886b007f4d8b08",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 27, 21, 12, 56, 707, DateTimeKind.Unspecified).AddTicks(3523), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 27, 21, 12, 56, 707, DateTimeKind.Unspecified).AddTicks(3523), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$nHqJMumgrALMmjL3v8Lo.O/XTEB1WhZ2R1sDA.XWPkZNdBhkwlHZO" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "a2b3c4d5e67890a1b2c3d4e5f67890f1",
                column: "Price",
                value: 100m);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "b3c4d5e67890a1b2c3d4e5f67890f1a2",
                column: "Price",
                value: 100m);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c4d5e67890a1b2c3d4e5f67890f1a2b3",
                column: "Price",
                value: 100m);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "d5e67890a1b2c3d4e5f67890f1a2b3c4",
                column: "Price",
                value: 100m);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "f1a2b3c4d5e67890a1b2c3d4e5f67890",
                column: "Price",
                value: 100m);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: "1a2b3c4d5e6f7890a1b2c3d4e5f6a7b8",
                column: "EndTime",
                value: new TimeOnly(9, 0, 0));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: "2b3c4d5e6f7a8b9c0d1e2f3a4b5c6d7e",
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeOnly(10, 0, 0), new TimeOnly(9, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: "3c4d5e6f7a8b9c0d1e2f3a4b5c6d7e8f",
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeOnly(11, 0, 0), new TimeOnly(10, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: "4d5e6f7a8b9c0d1e2f3a4b5c6d7e8f9a",
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new TimeOnly(12, 0, 0), new TimeOnly(11, 0, 0) });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "CreatedTime", "EndTime", "LastUpdatedTime", "StartTime" },
                values: new object[,]
                {
                    { "5e6f7a8b9c0d1e2f3a4b5c6d7e8f9a0b", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new TimeOnly(13, 0, 0), new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new TimeOnly(12, 0, 0) },
                    { "6f7a8b9c0d1e2f3a4b5c6d7e8f9a0b1c", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new TimeOnly(14, 0, 0), new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new TimeOnly(13, 0, 0) },
                    { "7a8b9c0d1e2f3a4b5c6d7e8f9a0b1c2d", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new TimeOnly(15, 0, 0), new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new TimeOnly(14, 0, 0) },
                    { "8b9c0d1e2f3a4b5c6d7e8f9a0b1c2d3e", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new TimeOnly(16, 0, 0), new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new TimeOnly(15, 0, 0) }
                });
        }
    }
}
