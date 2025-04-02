using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class V8_UpdatePrerequisiteTblRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Prerequisites_PrerequisiteCourseId",
                table: "Prerequisites");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "00786efb729542fa87a19d44fb3cdf79",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 2, 16, 18, 12, 414, DateTimeKind.Unspecified).AddTicks(4853), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 2, 16, 18, 12, 414, DateTimeKind.Unspecified).AddTicks(4853), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$sNrdyG.RtLkFz2EdpTNxReZVBV2ICThtK2SaL6m3jQ1BmPkYlnoke" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "2bf1c6f4a7db4fed825958e6d78e7226",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 2, 16, 18, 12, 288, DateTimeKind.Unspecified).AddTicks(1031), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 2, 16, 18, 12, 288, DateTimeKind.Unspecified).AddTicks(1031), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$j92c/CqMbQgjJiF4HuhnB.AlQzrFUX3vcTQSxMDBwyK5xKueyhO0q" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "54d3a3e95adc4b38885e43af50e12e42",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 2, 16, 18, 11, 895, DateTimeKind.Unspecified).AddTicks(5084), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 2, 16, 18, 11, 895, DateTimeKind.Unspecified).AddTicks(5084), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$BJT6pMc08yL.NcEbSRAjZuhe0asB73kucsAq9iVEVyvANvNCecYn." });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "6144c9fe6b7e4f4294ea469ffb6a90fd",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 2, 16, 18, 11, 767, DateTimeKind.Unspecified).AddTicks(6747), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 2, 16, 18, 11, 767, DateTimeKind.Unspecified).AddTicks(6747), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$1rqNdefCPwWj.sOW7SSGRey/KjOUfm7UAKTY0WLaOSbJYg1kardwK" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "9f7c3e8a4b6d49f19a8d2e3f4c7b5680",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 2, 16, 18, 12, 667, DateTimeKind.Unspecified).AddTicks(6644), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 2, 16, 18, 12, 667, DateTimeKind.Unspecified).AddTicks(6644), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$XZWTGZFd3p6w58G0IITraOpoZa1NbFq/1iLLWys3oniHNPaKkZIhW" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "ea46ce4e457f42dfb18b6347bd4ea1f4",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 2, 16, 18, 12, 156, DateTimeKind.Unspecified).AddTicks(9750), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 2, 16, 18, 12, 156, DateTimeKind.Unspecified).AddTicks(9750), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$0d/fMRO.d/elIAc3nec/Kei6rucCjjLOgqZu7XA5t.1Hq4q68xPDS" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "eaa27cff0c91479087bb22370ffbb6d0",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 2, 16, 18, 12, 540, DateTimeKind.Unspecified).AddTicks(2829), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 2, 16, 18, 12, 540, DateTimeKind.Unspecified).AddTicks(2829), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$aG0bxFDYIiyWvecdsLzV4u.n1gekGfCekh3WF7SKe/oapRrIxj4Mi" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "fa13bc18b0c54ba0b9886b007f4d8b08",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 2, 16, 18, 12, 29, DateTimeKind.Unspecified).AddTicks(2754), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 2, 16, 18, 12, 29, DateTimeKind.Unspecified).AddTicks(2754), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$HetVUHpFAjmToHxDZZJteucWzIR.MwsH/h3EeeDJFXZ7EVdEwJwTa" });

            migrationBuilder.CreateIndex(
                name: "IX_Prerequisites_PrerequisiteCourseId",
                table: "Prerequisites",
                column: "PrerequisiteCourseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Prerequisites_PrerequisiteCourseId",
                table: "Prerequisites");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "00786efb729542fa87a19d44fb3cdf79",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 31, 10, 28, 25, 273, DateTimeKind.Unspecified).AddTicks(9886), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 31, 10, 28, 25, 273, DateTimeKind.Unspecified).AddTicks(9886), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$ZFOCCbhYqmpZsdtLN0EveuNyEz2GNEe1Czm0mNWsKxneCvHqQOA1y" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "2bf1c6f4a7db4fed825958e6d78e7226",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 31, 10, 28, 25, 152, DateTimeKind.Unspecified).AddTicks(3094), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 31, 10, 28, 25, 152, DateTimeKind.Unspecified).AddTicks(3094), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$Jb1MoaFnP5naBn..NoGj5urRRRXia9SRlvgFL9SWSmCTAWzX9AuH2" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "54d3a3e95adc4b38885e43af50e12e42",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 31, 10, 28, 24, 775, DateTimeKind.Unspecified).AddTicks(5922), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 31, 10, 28, 24, 775, DateTimeKind.Unspecified).AddTicks(5922), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$25czWjYzHSJSUTxNrUAv2.XoL12uFhxd/1gMYBwIV/ezDrQdHdL8W" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "6144c9fe6b7e4f4294ea469ffb6a90fd",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 31, 10, 28, 24, 648, DateTimeKind.Unspecified).AddTicks(8069), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 31, 10, 28, 24, 648, DateTimeKind.Unspecified).AddTicks(8069), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$OVPatAReAEB1blvNH2.bTuhm1y9Yp02LuCF3clSA//wqvbhLDPh4q" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "9f7c3e8a4b6d49f19a8d2e3f4c7b5680",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 31, 10, 28, 25, 513, DateTimeKind.Unspecified).AddTicks(610), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 31, 10, 28, 25, 513, DateTimeKind.Unspecified).AddTicks(610), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$QrttNVl1TxegtADXMFMTLe195sTI9kS8cnzV2HHbzn8Db8WAKVs6K" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "ea46ce4e457f42dfb18b6347bd4ea1f4",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 31, 10, 28, 25, 31, DateTimeKind.Unspecified).AddTicks(5940), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 31, 10, 28, 25, 31, DateTimeKind.Unspecified).AddTicks(5940), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$vHuMJvl8Mn7zbyTeZ8rDKOIhmHvaKQQcQw6VnMghHj3ng59ckNak2" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "eaa27cff0c91479087bb22370ffbb6d0",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 31, 10, 28, 25, 393, DateTimeKind.Unspecified).AddTicks(1500), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 31, 10, 28, 25, 393, DateTimeKind.Unspecified).AddTicks(1500), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$6CtsMVEyf5i3wvTqoPXb5OPrh037SBSeLZdQr3PjpMvb7KLac9n9u" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "fa13bc18b0c54ba0b9886b007f4d8b08",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 31, 10, 28, 24, 909, DateTimeKind.Unspecified).AddTicks(5329), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 31, 10, 28, 24, 909, DateTimeKind.Unspecified).AddTicks(5329), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$OFp2SCW6i14LZ5UH2XorRe2KdqvUVDcy24ZZIhxRbZyWLIKTVOTSe" });

            migrationBuilder.CreateIndex(
                name: "IX_Prerequisites_PrerequisiteCourseId",
                table: "Prerequisites",
                column: "PrerequisiteCourseId",
                unique: true);
        }
    }
}
