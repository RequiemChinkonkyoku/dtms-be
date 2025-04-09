using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class V8_FixLessonPrerequisiteRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LessonPrerequisites_Lessons_PrerequisiteLessonId1",
                table: "LessonPrerequisites");

            migrationBuilder.DropIndex(
                name: "IX_LessonPrerequisites_PrerequisiteLessonId1",
                table: "LessonPrerequisites");

            migrationBuilder.DropColumn(
                name: "PrerequisiteLessonId1",
                table: "LessonPrerequisites");

            migrationBuilder.AlterColumn<string>(
                name: "LessonId",
                table: "LessonPrerequisites",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "00786efb729542fa87a19d44fb3cdf79",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 14, 34, 59, 553, DateTimeKind.Unspecified).AddTicks(1613), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 14, 34, 59, 553, DateTimeKind.Unspecified).AddTicks(1613), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$6DDyo.63qkSGFCgWWCjIQeOQ78aQX9aLyKPxjj4laa2cJTYGeUQ0a" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "2bf1c6f4a7db4fed825958e6d78e7226",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 14, 34, 59, 436, DateTimeKind.Unspecified).AddTicks(3343), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 14, 34, 59, 436, DateTimeKind.Unspecified).AddTicks(3343), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$/KrymHOwFvdlue.HhV/9OuLXae/RphsNB1fGr/KTg88FoCqWmTpjG" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "54d3a3e95adc4b38885e43af50e12e42",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 14, 34, 59, 80, DateTimeKind.Unspecified).AddTicks(6850), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 14, 34, 59, 80, DateTimeKind.Unspecified).AddTicks(6850), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$OW58n7lN/mNK6PixGGN4ZudCnYQtgCo2QWwQFDK1e4c2HdRpXxvxa" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "6144c9fe6b7e4f4294ea469ffb6a90fd",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 14, 34, 58, 955, DateTimeKind.Unspecified).AddTicks(8783), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 14, 34, 58, 955, DateTimeKind.Unspecified).AddTicks(8783), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$LsEP5ZYB8XyV2lbturbXfeuwSLE60adEsFZB1.SUDc.QtTa68IXuO" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "9f7c3e8a4b6d49f19a8d2e3f4c7b5680",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 14, 34, 59, 789, DateTimeKind.Unspecified).AddTicks(7321), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 14, 34, 59, 789, DateTimeKind.Unspecified).AddTicks(7321), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$yBAeklMV0LXfFt1i0Db8r.ULmPqrVZzf/ijqxsnsaZ1nC1EtoSNyG" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "a1b2c3d4e5f648a9b0c1d2e3f4a5b6c1",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 14, 35, 1, 115, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 14, 35, 1, 115, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$yUBmr/.Pb9hp8.DaK8Q1Bu/Ul1NMHaD0AOEzFcyP7SS737A1iPMGi" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "a1b2c3d4e5f648a9b0c1d2e3f4a5b6c7",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 14, 34, 59, 914, DateTimeKind.Unspecified).AddTicks(9382), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 14, 34, 59, 914, DateTimeKind.Unspecified).AddTicks(9382), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$CWtwpCbe7VD9Chkm.nZasunM9MOXoftqER7F5XF2KZruv14bYf0HC" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "a5b6c7d8e9f0a1b2c3d4e5f648a9b0c1",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 14, 35, 1, 0, DateTimeKind.Unspecified).AddTicks(5250), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 14, 35, 1, 0, DateTimeKind.Unspecified).AddTicks(5250), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$4jCSIr/Zz30YkZmGJTkjce24PsNRKKVl3McUwVgLgFTMXnBVKyQaC" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "a9b0c1d2e3f4a5b6c7d8e9f0a1b2c3d4",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 14, 35, 0, 641, DateTimeKind.Unspecified).AddTicks(1168), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 14, 35, 0, 641, DateTimeKind.Unspecified).AddTicks(1168), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$w4GC4Y1kTuBHHlfb.6OSbeRScNE4XmxCAYvpZDQsMfGBRggEmAFHS" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "b2c3d4e5f648a9b0c1d2e3f4a5b6c1d2",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 14, 35, 1, 236, DateTimeKind.Unspecified).AddTicks(8234), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 14, 35, 1, 236, DateTimeKind.Unspecified).AddTicks(8234), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$EgCmoVhortYXEd.dS8KEOetDKLrvQdKP8niuzfdK6KCOL.1.c24O6" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "b2c3d4e5f648a9b0c1d2e3f4a5b6c7d8",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 14, 35, 0, 33, DateTimeKind.Unspecified).AddTicks(9734), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 14, 35, 0, 33, DateTimeKind.Unspecified).AddTicks(9734), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$lqSxvoHGj6/dGTk8KIt9sOs5esyByII0Uy63tLwXi03aUxv5nubR6" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "c1d2e3f4a5b6c7d8e9f0a1b2c3d4e5f6",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 14, 35, 0, 759, DateTimeKind.Unspecified).AddTicks(3711), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 14, 35, 0, 759, DateTimeKind.Unspecified).AddTicks(3711), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$IKnmcqohgYEO69A1nloEt.SJpsNl8i3wqXxYtGvVguC3u.RUBxDMG" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "c3d4e5f648a9b0c1d2e3f4a5b6c1d2e3",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 14, 35, 1, 353, DateTimeKind.Unspecified).AddTicks(2078), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 14, 35, 1, 353, DateTimeKind.Unspecified).AddTicks(2078), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$MUbjeiJdMGDpWGc0qovNq.CgvKoU1FlegKmMXC5CnOZck6QZpF41i" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "c3d4e5f648a9b0c1d2e3f4a5b6c7d8e9",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 14, 35, 0, 152, DateTimeKind.Unspecified).AddTicks(2721), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 14, 35, 0, 152, DateTimeKind.Unspecified).AddTicks(2721), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$b/Agn0.cfBrphkXmSXr1heVG/6YT08NsnUVvCmOwB8nrv24ObBi9O" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "d4e5f648a9b0c1d2e3f4a5b6c1d2e3f4",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 14, 35, 1, 470, DateTimeKind.Unspecified).AddTicks(8576), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 14, 35, 1, 470, DateTimeKind.Unspecified).AddTicks(8576), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$QgmXwTBSWGFWF8HBTdlIw.SLL2Y7ZARTr9qP42GF5DITmC5fRjN/W" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "d4e5f648a9b0c1d2e3f4a5b6c7d8e9f0",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 14, 35, 0, 268, DateTimeKind.Unspecified).AddTicks(3705), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 14, 35, 0, 268, DateTimeKind.Unspecified).AddTicks(3705), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$HgsdNK7q4ebCmtgVxICRmezz1j6mRDvoZIOf/I.OxkrxEGys6748K" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "e3f4a5b6c7d8e9f0a1b2c3d4e5f648a9",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 14, 35, 0, 880, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 14, 35, 0, 880, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$8bM8hUZ7A57Ru4NurLx6ieAuCfH37cwZ/TXtTRitB09JW5RIoPHAu" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "e5f648a9b0c1d2e3f4a5b6c1d2e3f4a5",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 14, 35, 1, 591, DateTimeKind.Unspecified).AddTicks(2825), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 14, 35, 1, 591, DateTimeKind.Unspecified).AddTicks(2825), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$A5QwahLJ4xiPr7btOAMGWOQC9SdG/IMseK9t61pvjNkYy99tduUQa" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "e5f648a9b0c1d2e3f4a5b6c7d8e9f0a1",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 14, 35, 0, 390, DateTimeKind.Unspecified).AddTicks(4991), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 14, 35, 0, 390, DateTimeKind.Unspecified).AddTicks(4991), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$RKKYE6bApYqyli.zL0QMKeiB0gw6uLy9XipADOSx7LSNS3ZexOeM2" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "ea46ce4e457f42dfb18b6347bd4ea1f4",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 14, 34, 59, 318, DateTimeKind.Unspecified).AddTicks(498), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 14, 34, 59, 318, DateTimeKind.Unspecified).AddTicks(498), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$6sXk06irCmZD8FSYsirO8e9FK.hLMl0el0DrwayJ5TCQe5XkCPS.S" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "eaa27cff0c91479087bb22370ffbb6d0",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 14, 34, 59, 671, DateTimeKind.Unspecified).AddTicks(7183), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 14, 34, 59, 671, DateTimeKind.Unspecified).AddTicks(7183), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$hWh2etRpot/TTLen3p9XFe3I5U4FHczKrCifDLX3j0cuUsMPk7NGm" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "f648a9b0c1d2e3f4a5b6c7d8e9f0a1b2",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 14, 35, 0, 508, DateTimeKind.Unspecified).AddTicks(8301), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 14, 35, 0, 508, DateTimeKind.Unspecified).AddTicks(8301), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$8cYO3kIpR.zb/ghivF6SguRKrIUMXjY.Qtx.KqdbQ/WGszMuXIvam" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "fa13bc18b0c54ba0b9886b007f4d8b08",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 14, 34, 59, 201, DateTimeKind.Unspecified).AddTicks(4617), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 14, 34, 59, 201, DateTimeKind.Unspecified).AddTicks(4617), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$jnE8F/f2PtVuTi23tR2q9.BatQPw.VlO26hV/MhXFC5tc2wKuG7j6" });

            migrationBuilder.CreateIndex(
                name: "IX_LessonPrerequisites_LessonId",
                table: "LessonPrerequisites",
                column: "LessonId");

            migrationBuilder.AddForeignKey(
                name: "FK_LessonPrerequisites_Lessons_LessonId",
                table: "LessonPrerequisites",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LessonPrerequisites_Lessons_LessonId",
                table: "LessonPrerequisites");

            migrationBuilder.DropIndex(
                name: "IX_LessonPrerequisites_LessonId",
                table: "LessonPrerequisites");

            migrationBuilder.AlterColumn<string>(
                name: "LessonId",
                table: "LessonPrerequisites",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "PrerequisiteLessonId1",
                table: "LessonPrerequisites",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "00786efb729542fa87a19d44fb3cdf79",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 11, 0, 41, 486, DateTimeKind.Unspecified).AddTicks(6969), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 11, 0, 41, 486, DateTimeKind.Unspecified).AddTicks(6969), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$sL/8D.Q28lPwo4kCxpC9R.jp7x399wQTcFCAmxWQr4RpZxrneT7Ii" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "2bf1c6f4a7db4fed825958e6d78e7226",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 11, 0, 41, 373, DateTimeKind.Unspecified).AddTicks(5078), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 11, 0, 41, 373, DateTimeKind.Unspecified).AddTicks(5078), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$mdagHAF/vjBrBZ6pkbK5beL6P9EwbOWf6eT8xPLIfcbFtmZzU/QLi" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "54d3a3e95adc4b38885e43af50e12e42",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 11, 0, 41, 33, DateTimeKind.Unspecified).AddTicks(633), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 11, 0, 41, 33, DateTimeKind.Unspecified).AddTicks(633), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$xJtpIq8csmi.e0jImLl2hOcikqUeVMxFBTRefm4xGOuUZ.GIrzKBW" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "6144c9fe6b7e4f4294ea469ffb6a90fd",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 11, 0, 40, 919, DateTimeKind.Unspecified).AddTicks(2034), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 11, 0, 40, 919, DateTimeKind.Unspecified).AddTicks(2034), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$4cr5nwwAMqg5AOfXmvxQy.A/BqSB/eYHiisQDySaz0Fbi880x8hRW" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "9f7c3e8a4b6d49f19a8d2e3f4c7b5680",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 11, 0, 41, 708, DateTimeKind.Unspecified).AddTicks(8759), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 11, 0, 41, 708, DateTimeKind.Unspecified).AddTicks(8759), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$Iok7WboE4fuvZmzv92ADsul50VxoG32215EPgdVEgkfdRBg1Sfm6C" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "a1b2c3d4e5f648a9b0c1d2e3f4a5b6c1",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 11, 0, 42, 949, DateTimeKind.Unspecified).AddTicks(1306), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 11, 0, 42, 949, DateTimeKind.Unspecified).AddTicks(1306), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$N/qVO/NDzLB/PwBXCVOXNeg9fP.UqeyseL1uJSn38JMSlnagYlv0." });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "a1b2c3d4e5f648a9b0c1d2e3f4a5b6c7",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 11, 0, 41, 823, DateTimeKind.Unspecified).AddTicks(9755), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 11, 0, 41, 823, DateTimeKind.Unspecified).AddTicks(9755), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$2lMhCUEPRIGGi9io84PuB.KWeDd2AviAv6nT6bcu4Qflb6gizK1Ie" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "a5b6c7d8e9f0a1b2c3d4e5f648a9b0c1",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 11, 0, 42, 823, DateTimeKind.Unspecified).AddTicks(1274), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 11, 0, 42, 823, DateTimeKind.Unspecified).AddTicks(1274), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$QcX4rEE3X.v7Tm0F3xOBxuOrdxvCMJ/4HUhN2BCghdOL1nEhnL3hS" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "a9b0c1d2e3f4a5b6c7d8e9f0a1b2c3d4",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 11, 0, 42, 491, DateTimeKind.Unspecified).AddTicks(2482), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 11, 0, 42, 491, DateTimeKind.Unspecified).AddTicks(2482), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$zeApbQM5p.0y2lzwnAFkUO0WYlXsAaT7qkm4INqJR2eDgdqwBcE5u" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "b2c3d4e5f648a9b0c1d2e3f4a5b6c1d2",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 11, 0, 43, 63, DateTimeKind.Unspecified).AddTicks(1043), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 11, 0, 43, 63, DateTimeKind.Unspecified).AddTicks(1043), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$r8JOpZcLP22UPPLUBM/4Wu2nkDHCwmyzMB/dk/.8twrFRCdi5PydW" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "b2c3d4e5f648a9b0c1d2e3f4a5b6c7d8",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 11, 0, 41, 937, DateTimeKind.Unspecified).AddTicks(3991), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 11, 0, 41, 937, DateTimeKind.Unspecified).AddTicks(3991), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$mMIm8hK4.VYItYr3yqQ/oOucMCUr2nVNEGaN0TYe51Sv7UWA/sbau" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "c1d2e3f4a5b6c7d8e9f0a1b2c3d4e5f6",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 11, 0, 42, 601, DateTimeKind.Unspecified).AddTicks(8436), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 11, 0, 42, 601, DateTimeKind.Unspecified).AddTicks(8436), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$2HeR7dOEhOz3JEnLp9LUE.vyBSDkcTJh8n9VSc8q9X6hy133nmwvu" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "c3d4e5f648a9b0c1d2e3f4a5b6c1d2e3",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 11, 0, 43, 173, DateTimeKind.Unspecified).AddTicks(9806), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 11, 0, 43, 173, DateTimeKind.Unspecified).AddTicks(9806), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$S5HloBbo54FYcm0bkoXQY.jx4ExgmBVWmyvGXhYkH9Q5gMS20Gjkq" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "c3d4e5f648a9b0c1d2e3f4a5b6c7d8e9",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 11, 0, 42, 47, DateTimeKind.Unspecified).AddTicks(9546), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 11, 0, 42, 47, DateTimeKind.Unspecified).AddTicks(9546), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$jeduT2B4FVSJy5WL/jst2OdFRYOXuHKVlH2BJMgsbkVs29/NYCXOO" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "d4e5f648a9b0c1d2e3f4a5b6c1d2e3f4",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 11, 0, 43, 285, DateTimeKind.Unspecified).AddTicks(1022), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 11, 0, 43, 285, DateTimeKind.Unspecified).AddTicks(1022), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$ATqKo5EaLBzPpTyJIOQqq.cS/CoKgVyMJIp/vIKEKRBSKV1hKEiOq" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "d4e5f648a9b0c1d2e3f4a5b6c7d8e9f0",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 11, 0, 42, 158, DateTimeKind.Unspecified).AddTicks(7968), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 11, 0, 42, 158, DateTimeKind.Unspecified).AddTicks(7968), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$o9JKWbdlTFjPIw3Qs9FbBeXNtsYpsM5qaBbRn14IhexlWrJR6PXge" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "e3f4a5b6c7d8e9f0a1b2c3d4e5f648a9",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 11, 0, 42, 712, DateTimeKind.Unspecified).AddTicks(810), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 11, 0, 42, 712, DateTimeKind.Unspecified).AddTicks(810), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$/X7.hL2LPBKVa0H2xvMS6OLP4rftWzVH3VnRsA13P6GTNCG2GcKGi" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "e5f648a9b0c1d2e3f4a5b6c1d2e3f4a5",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 11, 0, 43, 398, DateTimeKind.Unspecified).AddTicks(8083), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 11, 0, 43, 398, DateTimeKind.Unspecified).AddTicks(8083), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$1luaPgwCHes4xaMB3YUNOuXoc6bRY8XrzdqvjCPPieWUd3yMEzN.O" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "e5f648a9b0c1d2e3f4a5b6c7d8e9f0a1",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 11, 0, 42, 270, DateTimeKind.Unspecified).AddTicks(1205), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 11, 0, 42, 270, DateTimeKind.Unspecified).AddTicks(1205), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$Zx/gHzSJwj1adtq.6mZHEegPH9GLjGIqSSJ6/BYtqHUzTzUxXKRjO" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "ea46ce4e457f42dfb18b6347bd4ea1f4",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 11, 0, 41, 259, DateTimeKind.Unspecified).AddTicks(6411), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 11, 0, 41, 259, DateTimeKind.Unspecified).AddTicks(6411), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$KFJUWTDg0GdVkwCy1PqruOyoSFJWlp//5AFwAntIHzLxb0J4nf1AW" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "eaa27cff0c91479087bb22370ffbb6d0",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 11, 0, 41, 597, DateTimeKind.Unspecified).AddTicks(5490), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 11, 0, 41, 597, DateTimeKind.Unspecified).AddTicks(5490), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$4pHwWQmJiMqAiGI2ohL/B.aV2vWOD9NQ/cAAVHAz76YDHqzYz03ZG" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "f648a9b0c1d2e3f4a5b6c7d8e9f0a1b2",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 11, 0, 42, 380, DateTimeKind.Unspecified).AddTicks(6813), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 11, 0, 42, 380, DateTimeKind.Unspecified).AddTicks(6813), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$hla9qSMQo1xxTIbAX2ERQegPyEU.T9egzzEtqLpX3UwnDyRlKjLzS" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "fa13bc18b0c54ba0b9886b007f4d8b08",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 11, 0, 41, 146, DateTimeKind.Unspecified).AddTicks(3966), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 11, 0, 41, 146, DateTimeKind.Unspecified).AddTicks(3966), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$c/VVGDv9i6FXSu5titUvZuG1phGeJBSY0RY/A8ZfJ1B8.qVLnVKmu" });

            migrationBuilder.CreateIndex(
                name: "IX_LessonPrerequisites_PrerequisiteLessonId1",
                table: "LessonPrerequisites",
                column: "PrerequisiteLessonId1");

            migrationBuilder.AddForeignKey(
                name: "FK_LessonPrerequisites_Lessons_PrerequisiteLessonId1",
                table: "LessonPrerequisites",
                column: "PrerequisiteLessonId1",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
