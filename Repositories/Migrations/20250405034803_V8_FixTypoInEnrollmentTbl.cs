using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class V8_FixTypoInEnrollmentTbl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RequiedNightStay",
                table: "Enrollments",
                newName: "RequiredNightStay");

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

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "a2b3c4d5e67890a1b2c3d4e5f67890f1",
                column: "ImageUrl",
                value: "https://res.cloudinary.com/djy6ydaxz/image/upload/v1740296265/inloikxoyxcakdmakrrk.jpg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "b3c4d5e67890a1b2c3d4e5f67890f1a2",
                column: "ImageUrl",
                value: "https://res.cloudinary.com/djy6ydaxz/image/upload/v1740296300/vozosvu7c92d3gbz9xmp.jpg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c4d5e67890a1b2c3d4e5f67890f1a2b3",
                column: "ImageUrl",
                value: "https://res.cloudinary.com/djy6ydaxz/image/upload/v1740296126/k8lymjfwzbenlvfyt0ev.jpg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "d5e67890a1b2c3d4e5f67890f1a2b3c4",
                column: "ImageUrl",
                value: "https://res.cloudinary.com/djy6ydaxz/image/upload/v1740296126/k8lymjfwzbenlvfyt0ev.jpg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "f1a2b3c4d5e67890a1b2c3d4e5f67890",
                column: "ImageUrl",
                value: "https://res.cloudinary.com/djy6ydaxz/image/upload/v1740296214/wgpr6pg1jvkwrib4a1op.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RequiredNightStay",
                table: "Enrollments",
                newName: "RequiedNightStay");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "00786efb729542fa87a19d44fb3cdf79",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 2, 20, 12, 29, 141, DateTimeKind.Unspecified).AddTicks(9052), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 2, 20, 12, 29, 141, DateTimeKind.Unspecified).AddTicks(9052), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$sw/PYHHS5jFOJ0mVlRDvb.4yPjyZwfFr9Lh3og1l9pipkfzgq8FFm" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "2bf1c6f4a7db4fed825958e6d78e7226",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 2, 20, 12, 29, 17, DateTimeKind.Unspecified).AddTicks(9271), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 2, 20, 12, 29, 17, DateTimeKind.Unspecified).AddTicks(9271), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$gcuSCahBtxCQwnC0uyyAVOEf65xT2P1vY.wAWZB2L.LjEsyt0Rb4K" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "54d3a3e95adc4b38885e43af50e12e42",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 2, 20, 12, 28, 659, DateTimeKind.Unspecified).AddTicks(645), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 2, 20, 12, 28, 659, DateTimeKind.Unspecified).AddTicks(645), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$OKIaiuv0VZttwVpHKvqBneDVDfrWwlza5U4U5YCb3XQDh.eytGuAW" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "6144c9fe6b7e4f4294ea469ffb6a90fd",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 2, 20, 12, 28, 537, DateTimeKind.Unspecified).AddTicks(5939), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 2, 20, 12, 28, 537, DateTimeKind.Unspecified).AddTicks(5939), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$pJCbs7kNLoO4qE4gRz.IbujvFC5yFx3kCPn5FntA8JO5DV0Tt8D66" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "9f7c3e8a4b6d49f19a8d2e3f4c7b5680",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 2, 20, 12, 29, 383, DateTimeKind.Unspecified).AddTicks(8607), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 2, 20, 12, 29, 383, DateTimeKind.Unspecified).AddTicks(8607), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$2ehamM.z4VfeRuxS6UVZ4ec9TbO4F3o6Z7NPlm3HIUBoVxUTdAAFa" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "ea46ce4e457f42dfb18b6347bd4ea1f4",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 2, 20, 12, 28, 896, DateTimeKind.Unspecified).AddTicks(9566), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 2, 20, 12, 28, 896, DateTimeKind.Unspecified).AddTicks(9566), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$rHJuU.Y5/RB8iM2pH.Qf6.Gz/g7xZFT0KSFxb.imnYXvzeY59/UbO" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "eaa27cff0c91479087bb22370ffbb6d0",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 2, 20, 12, 29, 265, DateTimeKind.Unspecified).AddTicks(830), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 2, 20, 12, 29, 265, DateTimeKind.Unspecified).AddTicks(830), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$uC9nbtbTDJMC9Ld87iknDOTbX5992StNTSJ3wpD8K/zlDg/7Ad8W2" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "fa13bc18b0c54ba0b9886b007f4d8b08",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 2, 20, 12, 28, 779, DateTimeKind.Unspecified).AddTicks(175), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 2, 20, 12, 28, 779, DateTimeKind.Unspecified).AddTicks(175), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$tP4RV/TP29EeTNRk1d7LfeJcKGCJZ/oARRoeWP8jNGrD/Acmdqzou" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "a2b3c4d5e67890a1b2c3d4e5f67890f1",
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "b3c4d5e67890a1b2c3d4e5f67890f1a2",
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c4d5e67890a1b2c3d4e5f67890f1a2b3",
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "d5e67890a1b2c3d4e5f67890f1a2b3c4",
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "f1a2b3c4d5e67890a1b2c3d4e5f67890",
                column: "ImageUrl",
                value: "");
        }
    }
}
