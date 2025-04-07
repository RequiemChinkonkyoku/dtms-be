using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class V8_AddQuantityToLessonEquipmentTbl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Slots",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "LessonEquipments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "LessonPrerequisites",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LessonId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrerequisiteLessonId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PrerequisiteLessonId1 = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastUpdatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessonPrerequisites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LessonPrerequisites_Lessons_PrerequisiteLessonId",
                        column: x => x.PrerequisiteLessonId,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LessonPrerequisites_Lessons_PrerequisiteLessonId1",
                        column: x => x.PrerequisiteLessonId1,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "00786efb729542fa87a19d44fb3cdf79",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 7, 16, 39, 20, 90, DateTimeKind.Unspecified).AddTicks(8093), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 7, 16, 39, 20, 90, DateTimeKind.Unspecified).AddTicks(8093), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$rrBtczKD3s7mQ22ggG/wf.vAmH6Jh.owYNW0t4hCpaLFaUIW9uu/G" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "2bf1c6f4a7db4fed825958e6d78e7226",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 7, 16, 39, 19, 969, DateTimeKind.Unspecified).AddTicks(8830), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 7, 16, 39, 19, 969, DateTimeKind.Unspecified).AddTicks(8830), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$F0UJbeoyMebl.wJ0m7BWYuSYpZ6HLXWd3ZLAk2f9jsk3IbHRHuJ0q" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "54d3a3e95adc4b38885e43af50e12e42",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 7, 16, 39, 19, 614, DateTimeKind.Unspecified).AddTicks(7248), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 7, 16, 39, 19, 614, DateTimeKind.Unspecified).AddTicks(7248), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$gII5RiGnPIHDM6QflMKOaukY6EgB47wfxT6b1h65/bRlnQPazpnue" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "6144c9fe6b7e4f4294ea469ffb6a90fd",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 7, 16, 39, 19, 494, DateTimeKind.Unspecified).AddTicks(7448), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 7, 16, 39, 19, 494, DateTimeKind.Unspecified).AddTicks(7448), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$hQPzsn5ND1Ld55H.U64q7uIdB2ixNXqzFJt.9ROXzqV.N1B7T1G.e" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "9f7c3e8a4b6d49f19a8d2e3f4c7b5680",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 7, 16, 39, 20, 324, DateTimeKind.Unspecified).AddTicks(9998), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 7, 16, 39, 20, 324, DateTimeKind.Unspecified).AddTicks(9998), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$7qYqdXs9DTg5BWJ7w17fJuSSDoQHXUZW6oTABjMQbGD4qsct2/rdS" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "ea46ce4e457f42dfb18b6347bd4ea1f4",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 7, 16, 39, 19, 852, DateTimeKind.Unspecified).AddTicks(8829), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 7, 16, 39, 19, 852, DateTimeKind.Unspecified).AddTicks(8829), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$kpKOYloQybUS2Y2SQV.U3.Eo5PkxwcL11Z1Wx3pHV.6AgR8d/y5rC" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "eaa27cff0c91479087bb22370ffbb6d0",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 7, 16, 39, 20, 207, DateTimeKind.Unspecified).AddTicks(6851), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 7, 16, 39, 20, 207, DateTimeKind.Unspecified).AddTicks(6851), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$cG0GZ25koho15iPjGYQgh.10GjsugkWh2U9D0VZkftz78SLRuY80." });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "fa13bc18b0c54ba0b9886b007f4d8b08",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 7, 16, 39, 19, 734, DateTimeKind.Unspecified).AddTicks(1524), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 7, 16, 39, 19, 734, DateTimeKind.Unspecified).AddTicks(1524), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$zWMCsrh/ybIlTaWwJopEhufxV5wG84dOMVQPHNDPerCO4cuBxep/2" });

            migrationBuilder.CreateIndex(
                name: "IX_LessonPrerequisites_PrerequisiteLessonId",
                table: "LessonPrerequisites",
                column: "PrerequisiteLessonId");

            migrationBuilder.CreateIndex(
                name: "IX_LessonPrerequisites_PrerequisiteLessonId1",
                table: "LessonPrerequisites",
                column: "PrerequisiteLessonId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LessonPrerequisites");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Slots");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "LessonEquipments");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "00786efb729542fa87a19d44fb3cdf79",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 5, 10, 48, 2, 479, DateTimeKind.Unspecified).AddTicks(4202), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 5, 10, 48, 2, 479, DateTimeKind.Unspecified).AddTicks(4202), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$Nvq8WXLCzxXxWH3Hd/MeuO0ubQ0al2wi3yTub60K0qYCTxEWde/ye" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "2bf1c6f4a7db4fed825958e6d78e7226",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 5, 10, 48, 2, 356, DateTimeKind.Unspecified).AddTicks(5580), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 5, 10, 48, 2, 356, DateTimeKind.Unspecified).AddTicks(5580), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$ysWvRA/XFLxxxh6iVXuwa.6rMc6N1BHm2M7NZAJmiiaEUAnKzIPUi" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "54d3a3e95adc4b38885e43af50e12e42",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 5, 10, 48, 1, 993, DateTimeKind.Unspecified).AddTicks(5895), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 5, 10, 48, 1, 993, DateTimeKind.Unspecified).AddTicks(5895), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$XnlYxysfOF/OUsylPhRXluAdzD2Ei4wkFxm7k1vDdT/dAcGTTqtFK" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "6144c9fe6b7e4f4294ea469ffb6a90fd",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 5, 10, 48, 1, 868, DateTimeKind.Unspecified).AddTicks(1101), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 5, 10, 48, 1, 868, DateTimeKind.Unspecified).AddTicks(1101), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$.Kd.OKbuZ6x.ZaXPtbZFw.lNgTTasAUUk5y1CI5/Kh95VDcgkus4y" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "9f7c3e8a4b6d49f19a8d2e3f4c7b5680",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 5, 10, 48, 2, 721, DateTimeKind.Unspecified).AddTicks(2630), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 5, 10, 48, 2, 721, DateTimeKind.Unspecified).AddTicks(2630), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$A7GEfnIdsc.8D5ecKBZgdO0MkfghNyJPkvQNvKVbgoZCwjjxAmpcW" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "ea46ce4e457f42dfb18b6347bd4ea1f4",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 5, 10, 48, 2, 239, DateTimeKind.Unspecified).AddTicks(3552), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 5, 10, 48, 2, 239, DateTimeKind.Unspecified).AddTicks(3552), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$h/h663uvsZRsyfrdMRgVmO4KMQayraSTLKHKCDvWlvqFw6QBhnb2m" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "eaa27cff0c91479087bb22370ffbb6d0",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 5, 10, 48, 2, 602, DateTimeKind.Unspecified).AddTicks(6355), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 5, 10, 48, 2, 602, DateTimeKind.Unspecified).AddTicks(6355), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$EczjX9cZfeo89bUdZkYd.ea.tmMtbf4z7QvZHTTDCI/PMFKMGzcjK" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "fa13bc18b0c54ba0b9886b007f4d8b08",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 5, 10, 48, 2, 119, DateTimeKind.Unspecified).AddTicks(9939), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 5, 10, 48, 2, 119, DateTimeKind.Unspecified).AddTicks(9939), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$vJcqOzaPec7Vc.Lez18ooexbAlIPjEYRk/T58sv41iQvpELGY0/LG" });
        }
    }
}
