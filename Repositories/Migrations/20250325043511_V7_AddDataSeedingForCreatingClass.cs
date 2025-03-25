using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class V7_AddDataSeedingForCreatingClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Payments_PaymentId",
                table: "Enrollments");

            migrationBuilder.DropIndex(
                name: "IX_Enrollments_PaymentId",
                table: "Enrollments");

            migrationBuilder.DropColumn(
                name: "PaymentId",
                table: "Enrollments");

            migrationBuilder.AlterColumn<string>(
                name: "EnrollmentId",
                table: "Payments",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "StaffId",
                table: "Enrollments",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "CageId",
                table: "Enrollments",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "00786efb729542fa87a19d44fb3cdf79",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 25, 11, 35, 10, 313, DateTimeKind.Unspecified).AddTicks(8155), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 25, 11, 35, 10, 313, DateTimeKind.Unspecified).AddTicks(8155), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$SaIKPhiowhcSBKBzHzxc3ut6IJIB6p.ljorcLkEpDInrinIspHYua" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "2bf1c6f4a7db4fed825958e6d78e7226",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 25, 11, 35, 10, 187, DateTimeKind.Unspecified).AddTicks(4603), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 25, 11, 35, 10, 187, DateTimeKind.Unspecified).AddTicks(4603), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$cYuFWGvd8KqMtI6Oq1ySUOiMOLgyIxqr7t.J92N.UjrN84gBjI4ba" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "54d3a3e95adc4b38885e43af50e12e42",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 25, 11, 35, 9, 816, DateTimeKind.Unspecified).AddTicks(5511), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 25, 11, 35, 9, 816, DateTimeKind.Unspecified).AddTicks(5511), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$3G1OiWWfGBnt3tFgxxAkv.I6AHemWrVIgs/SvYmms3S7t0p57Mzoa" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "6144c9fe6b7e4f4294ea469ffb6a90fd",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 25, 11, 35, 9, 693, DateTimeKind.Unspecified).AddTicks(6199), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 25, 11, 35, 9, 693, DateTimeKind.Unspecified).AddTicks(6199), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$0hO0G2zN.U804M1ULj8.UuZ0tkDuBgsIL5RYLztxn7jA38MaWTngS" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "9f7c3e8a4b6d49f19a8d2e3f4c7b5680",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 25, 11, 35, 10, 554, DateTimeKind.Unspecified).AddTicks(9115), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 25, 11, 35, 10, 554, DateTimeKind.Unspecified).AddTicks(9115), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$oLsrJXG5.XRj6FAi/ZOujuJKYzAxb5R8k4TEHCXwliCj4Rz8VZ2pG" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "ea46ce4e457f42dfb18b6347bd4ea1f4",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 25, 11, 35, 10, 66, DateTimeKind.Unspecified).AddTicks(1538), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 25, 11, 35, 10, 66, DateTimeKind.Unspecified).AddTicks(1538), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$m3enOLpd8uIPswtziEtZje3jLs1ufqsmZjA7Dtqp0FIdKiRuqCCo6" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "eaa27cff0c91479087bb22370ffbb6d0",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 25, 11, 35, 10, 436, DateTimeKind.Unspecified).AddTicks(502), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 25, 11, 35, 10, 436, DateTimeKind.Unspecified).AddTicks(502), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$t1OshNpQeKs.SL1jBKOWzuCuCX6kKmRYqRgaUV1nuihaEkYpMvnsG" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "fa13bc18b0c54ba0b9886b007f4d8b08",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 25, 11, 35, 9, 944, DateTimeKind.Unspecified).AddTicks(28), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 25, 11, 35, 9, 944, DateTimeKind.Unspecified).AddTicks(28), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$0LP8yajwsKnfXJ7uD8uMeeBnhRDk9mb22vhRb/uqaiW89zFupt2cu" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CategoryId", "Complexity", "CreatedTime", "CreatedTrainerId", "DaysPerWeek", "Description", "DurationInWeeks", "ImageUrl", "LastUpdatedTime", "MaxDogs", "MaxTrainers", "MinDogs", "MinTrainers", "Name", "Price", "SlotsPerDay", "Status" },
                values: new object[,]
                {
                    { "a2b3c4d5e67890a1b2c3d4e5f67890f1", "156552f4dc9942b5bc72a6bae94be821", 1, new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "54d3a3e95adc4b38885e43af50e12e42", 1, "Improve agility", 2, "", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), 4, 2, 1, 1, "Agility Course", 100m, 1, 1 },
                    { "b3c4d5e67890a1b2c3d4e5f67890f1a2", "c44beb29575744b68c42cf4f70274a20", 1, new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "54d3a3e95adc4b38885e43af50e12e42", 1, "Correct bad behaviors", 2, "", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), 4, 2, 1, 1, "Behavioral Correction Course", 100m, 1, 1 },
                    { "c4d5e67890a1b2c3d4e5f67890f1a2b3", "156552f4dc9942b5bc72a6bae94be821", 1, new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "54d3a3e95adc4b38885e43af50e12e42", 1, "Improve socializing skill", 2, "", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), 4, 2, 1, 1, "Socialization Course", 100m, 1, 1 },
                    { "d5e67890a1b2c3d4e5f67890f1a2b3c4", "f8cb65025770497e9a61c75501ed6cd3", 1, new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "54d3a3e95adc4b38885e43af50e12e42", 1, "Traing for protection", 3, "", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), 4, 2, 1, 1, "Protection Trainging Course", 100m, 1, 1 },
                    { "f1a2b3c4d5e67890a1b2c3d4e5f67890", "156552f4dc9942b5bc72a6bae94be821", 1, new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "54d3a3e95adc4b38885e43af50e12e42", 1, "For basic training", 1, "", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), 4, 2, 1, 1, "Basic Course", 100m, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CreatedTime", "Description", "Duration", "Environment", "LastUpdatedTime", "LessonTitle", "Notes", "Objective", "SkillId", "Status" },
                values: new object[,]
                {
                    { "a1b2c3d4e5f67890a1b2c3d4e5f67890", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Obedience basics", 1, "Indoor", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Basic Training", "Sit, stay, come", "Good behavior", "1a2b3c4d5e6f78901a2b3c4d5e6f7890", 1 },
                    { "b2c3d4e5f67890a1b2c3d4e5f67890a1", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Speed & coordination", 2, "Outdoor", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Agility", "Jumping, weaving", "Improve agility", "2b3c4d5e6f78901a2b3c4d5e6f78901a", 1 },
                    { "c3d4e5f67890a1b2c3d4e5f67890a1b2", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Correct bad habits", 3, "Indoor", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Behavioral Fixes", "Reduce aggression", "Better discipline", "3c4d5e6f78901a2b3c4d5e6f78901a2b", 1 },
                    { "d4e5f67890a1b2c3d4e5f67890a1b2c3", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Interact with dogs", 2, "Outdoor", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Socialization", "Playgroups, exposure", "Friendly behavior", "4d5e6f78901a2b3c4d5e6f78901a2b3c", 1 },
                    { "e5f67890a1b2c3d4e5f67890a1b2c3d4", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Guard dog skills", 3, "Outdoor", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Protection Training", "Barking, alerting", "Security readiness", "5e6f78901a2b3c4d5e6f78901a2b3c4d", 1 }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "CreatedTime", "EndTime", "LastUpdatedTime", "StartTime" },
                values: new object[,]
                {
                    { "1a2b3c4d5e6f7890a1b2c3d4e5f6a7b8", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new TimeOnly(9, 0, 0), new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new TimeOnly(8, 0, 0) },
                    { "2b3c4d5e6f7a8b9c0d1e2f3a4b5c6d7e", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new TimeOnly(10, 0, 0), new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new TimeOnly(9, 0, 0) },
                    { "3c4d5e6f7a8b9c0d1e2f3a4b5c6d7e8f", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new TimeOnly(11, 0, 0), new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new TimeOnly(10, 0, 0) },
                    { "4d5e6f7a8b9c0d1e2f3a4b5c6d7e8f9a", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new TimeOnly(12, 0, 0), new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new TimeOnly(11, 0, 0) },
                    { "5e6f7a8b9c0d1e2f3a4b5c6d7e8f9a0b", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new TimeOnly(13, 0, 0), new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new TimeOnly(12, 0, 0) },
                    { "6f7a8b9c0d1e2f3a4b5c6d7e8f9a0b1c", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new TimeOnly(14, 0, 0), new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new TimeOnly(13, 0, 0) },
                    { "7a8b9c0d1e2f3a4b5c6d7e8f9a0b1c2d", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new TimeOnly(15, 0, 0), new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new TimeOnly(14, 0, 0) },
                    { "8b9c0d1e2f3a4b5c6d7e8f9a0b1c2d3e", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new TimeOnly(16, 0, 0), new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new TimeOnly(15, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "Certificates",
                columns: new[] { "Id", "CourseId", "CreatedTime", "Description", "LastUpdatedTime", "Name", "Status" },
                values: new object[,]
                {
                    { "a2b3c4d5e67890a1b2c3d4e5f67890f1", "a2b3c4d5e67890a1b2c3d4e5f67890f1", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Cert for agility course", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Agility Course Certificate", 1 },
                    { "b3c4d5e67890a1b2c3d4e5f67890f1a2", "b3c4d5e67890a1b2c3d4e5f67890f1a2", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Cert for bahvioural course", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Behavioural Course Certificate", 1 },
                    { "c4d5e67890a1b2c3d4e5f67890f1a2b3", "c4d5e67890a1b2c3d4e5f67890f1a2b3", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Cert for socialization course", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Socialization Course Certificate", 1 },
                    { "d5e67890a1b2c3d4e5f67890f1a2b3c4", "d5e67890a1b2c3d4e5f67890f1a2b3c4", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Cert for protection course", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Protection Course Certificate", 1 },
                    { "f1a2b3c4d5e67890a1b2c3d4e5f67890", "f1a2b3c4d5e67890a1b2c3d4e5f67890", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Cert for basic course", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Basic Course Certificate", 1 }
                });

            migrationBuilder.InsertData(
                table: "CourseDogs",
                columns: new[] { "Id", "CourseId", "CreatedTime", "DogBreedId", "LastUpdatedTime", "Status" },
                values: new object[,]
                {
                    { "678b90e1f2a3b4c5d678f890a12b3c45d", "c4d5e67890a1b2c3d4e5f67890f1a2b3", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "bb57a3e3cd2048e88e02f5b87a935a62", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), 1 },
                    { "789c01e1f2a3b4c5d678f890a12b3c45d6", "d5e67890a1b2c3d4e5f67890f1a2b3c4", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "bb57a3e3cd2048e88e02f5b87a935a62", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), 1 },
                    { "890d12e1f2a3b4c5d678f890a12b3c45d6", "d5e67890a1b2c3d4e5f67890f1a2b3c4", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "f3c7da2e95764c47be56aeb742ecf3b1", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), 1 },
                    { "901a2b3c4d5e67890e1f2a3b4c5d678f8", "b3c4d5e67890a1b2c3d4e5f67890f1a2", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "f3c7da2e95764c47be56aeb742ecf3b1", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), 1 },
                    { "901e23e1f2a3b4c5d678f890a12b3c45d6", "d5e67890a1b2c3d4e5f67890f1a2b3c4", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "0d4f1f5a2b4a45d699cf43a66f5b8b22", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), 1 },
                    { "a12b3c4d5e67890e1f2a3b4c5d678f890", "b3c4d5e67890a1b2c3d4e5f67890f1a2", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "0d4f1f5a2b4a45d699cf43a66f5b8b22", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), 1 },
                    { "a12f34e1f2a3b4c5d678f890a12b3c45d6", "d5e67890a1b2c3d4e5f67890f1a2b3c4", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "1a5c9e4f7d884cf2a3f99e26c7b5a081", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), 1 },
                    { "a3b4c5d67890a1b2c3d4e5f67890e1f2", "f1a2b3c4d5e67890a1b2c3d4e5f67890", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "bb57a3e3cd2048e88e02f5b87a935a62", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), 1 },
                    { "b23c4d5e67890e1f2a3b4c5d678f890a1", "b3c4d5e67890a1b2c3d4e5f67890f1a2", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "1a5c9e4f7d884cf2a3f99e26c7b5a081", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), 1 },
                    { "b4c5d67890a1b2c3d4e5f67890e1f2a3", "f1a2b3c4d5e67890a1b2c3d4e5f67890", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "f3c7da2e95764c47be56aeb742ecf3b1", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), 1 },
                    { "c34d5e67890e1f2a3b4c5d678f890a12b", "b3c4d5e67890a1b2c3d4e5f67890f1a2", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "bb57a3e3cd2048e88e02f5b87a935a62", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), 1 },
                    { "c5d67890a1b2c3d4e5f67890e1f2a3b4", "a2b3c4d5e67890a1b2c3d4e5f67890f1", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "bb57a3e3cd2048e88e02f5b87a935a62", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), 1 },
                    { "d45e67890e1f2a3b4c5d678f890a12b3c", "c4d5e67890a1b2c3d4e5f67890f1a2b3", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "4bee6ab4f7f841d69bacedcfd25c8d07", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), 1 },
                    { "d67890a1b2c3d4e5f67890e1f2a3b4c5", "a2b3c4d5e67890a1b2c3d4e5f67890f1", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "c1a3ebdb3bfa44cc81f3a1f6205f8b64", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), 1 },
                    { "e1f2a3b4c5d67890a1b2c3d4e5f67890", "f1a2b3c4d5e67890a1b2c3d4e5f67890", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "4bee6ab4f7f841d69bacedcfd25c8d07", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), 1 },
                    { "e56f7890e1f2a3b4c5d678f890a12b3c4", "c4d5e67890a1b2c3d4e5f67890f1a2b3", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "e478aa3ff61d4b6f88d3b3e3a7f47b14", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), 1 },
                    { "e7890a1b2c3d4e5f67890e1f2a3b4c5d6", "a2b3c4d5e67890a1b2c3d4e5f67890f1", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "df76e3ed02444a61ad1efba0a5b75f06", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), 1 },
                    { "f2a3b4c5d67890a1b2c3d4e5f67890e1", "f1a2b3c4d5e67890a1b2c3d4e5f67890", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "a8f5f1675aaf4d1b8f7c8d924d3c3c4b", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), 1 },
                    { "f67a890e1f2a3b4c5d678f890a12b3c45", "c4d5e67890a1b2c3d4e5f67890f1a2b3", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "a8f5f1675aaf4d1b8f7c8d924d3c3c4b", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), 1 },
                    { "f890a1b2c3d4e5f67890e1f2a3b4c5d67", "a2b3c4d5e67890a1b2c3d4e5f67890f1", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "e478aa3ff61d4b6f88d3b3e3a7f47b14", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), 1 }
                });

            migrationBuilder.InsertData(
                table: "CourseLessons",
                columns: new[] { "Id", "CourseId", "CreatedTime", "LastUpdatedTime", "LessonId", "Status" },
                values: new object[,]
                {
                    { "a3b4c5d67890a1b2c3d4e5f67890e1f2", "b3c4d5e67890a1b2c3d4e5f67890f1a2", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "c3d4e5f67890a1b2c3d4e5f67890a1b2", 1 },
                    { "b4c5d67890a1b2c3d4e5f67890e1f2a3", "c4d5e67890a1b2c3d4e5f67890f1a2b3", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "d4e5f67890a1b2c3d4e5f67890a1b2c3", 1 },
                    { "c5d67890a1b2c3d4e5f67890e1f2a3b4", "d5e67890a1b2c3d4e5f67890f1a2b3c4", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "e5f67890a1b2c3d4e5f67890a1b2c3d4", 1 },
                    { "e1f2a3b4c5d67890a1b2c3d4e5f67890", "f1a2b3c4d5e67890a1b2c3d4e5f67890", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "a1b2c3d4e5f67890a1b2c3d4e5f67890", 1 },
                    { "f2a3b4c5d67890a1b2c3d4e5f67890e1", "a2b3c4d5e67890a1b2c3d4e5f67890f1", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "b2c3d4e5f67890a1b2c3d4e5f67890a1", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Payments_EnrollmentId",
                table: "Payments",
                column: "EnrollmentId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Enrollments_EnrollmentId",
                table: "Payments",
                column: "EnrollmentId",
                principalTable: "Enrollments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Enrollments_EnrollmentId",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Payments_EnrollmentId",
                table: "Payments");

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "a2b3c4d5e67890a1b2c3d4e5f67890f1");

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "b3c4d5e67890a1b2c3d4e5f67890f1a2");

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "c4d5e67890a1b2c3d4e5f67890f1a2b3");

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "d5e67890a1b2c3d4e5f67890f1a2b3c4");

            migrationBuilder.DeleteData(
                table: "Certificates",
                keyColumn: "Id",
                keyValue: "f1a2b3c4d5e67890a1b2c3d4e5f67890");

            migrationBuilder.DeleteData(
                table: "CourseDogs",
                keyColumn: "Id",
                keyValue: "678b90e1f2a3b4c5d678f890a12b3c45d");

            migrationBuilder.DeleteData(
                table: "CourseDogs",
                keyColumn: "Id",
                keyValue: "789c01e1f2a3b4c5d678f890a12b3c45d6");

            migrationBuilder.DeleteData(
                table: "CourseDogs",
                keyColumn: "Id",
                keyValue: "890d12e1f2a3b4c5d678f890a12b3c45d6");

            migrationBuilder.DeleteData(
                table: "CourseDogs",
                keyColumn: "Id",
                keyValue: "901a2b3c4d5e67890e1f2a3b4c5d678f8");

            migrationBuilder.DeleteData(
                table: "CourseDogs",
                keyColumn: "Id",
                keyValue: "901e23e1f2a3b4c5d678f890a12b3c45d6");

            migrationBuilder.DeleteData(
                table: "CourseDogs",
                keyColumn: "Id",
                keyValue: "a12b3c4d5e67890e1f2a3b4c5d678f890");

            migrationBuilder.DeleteData(
                table: "CourseDogs",
                keyColumn: "Id",
                keyValue: "a12f34e1f2a3b4c5d678f890a12b3c45d6");

            migrationBuilder.DeleteData(
                table: "CourseDogs",
                keyColumn: "Id",
                keyValue: "a3b4c5d67890a1b2c3d4e5f67890e1f2");

            migrationBuilder.DeleteData(
                table: "CourseDogs",
                keyColumn: "Id",
                keyValue: "b23c4d5e67890e1f2a3b4c5d678f890a1");

            migrationBuilder.DeleteData(
                table: "CourseDogs",
                keyColumn: "Id",
                keyValue: "b4c5d67890a1b2c3d4e5f67890e1f2a3");

            migrationBuilder.DeleteData(
                table: "CourseDogs",
                keyColumn: "Id",
                keyValue: "c34d5e67890e1f2a3b4c5d678f890a12b");

            migrationBuilder.DeleteData(
                table: "CourseDogs",
                keyColumn: "Id",
                keyValue: "c5d67890a1b2c3d4e5f67890e1f2a3b4");

            migrationBuilder.DeleteData(
                table: "CourseDogs",
                keyColumn: "Id",
                keyValue: "d45e67890e1f2a3b4c5d678f890a12b3c");

            migrationBuilder.DeleteData(
                table: "CourseDogs",
                keyColumn: "Id",
                keyValue: "d67890a1b2c3d4e5f67890e1f2a3b4c5");

            migrationBuilder.DeleteData(
                table: "CourseDogs",
                keyColumn: "Id",
                keyValue: "e1f2a3b4c5d67890a1b2c3d4e5f67890");

            migrationBuilder.DeleteData(
                table: "CourseDogs",
                keyColumn: "Id",
                keyValue: "e56f7890e1f2a3b4c5d678f890a12b3c4");

            migrationBuilder.DeleteData(
                table: "CourseDogs",
                keyColumn: "Id",
                keyValue: "e7890a1b2c3d4e5f67890e1f2a3b4c5d6");

            migrationBuilder.DeleteData(
                table: "CourseDogs",
                keyColumn: "Id",
                keyValue: "f2a3b4c5d67890a1b2c3d4e5f67890e1");

            migrationBuilder.DeleteData(
                table: "CourseDogs",
                keyColumn: "Id",
                keyValue: "f67a890e1f2a3b4c5d678f890a12b3c45");

            migrationBuilder.DeleteData(
                table: "CourseDogs",
                keyColumn: "Id",
                keyValue: "f890a1b2c3d4e5f67890e1f2a3b4c5d67");

            migrationBuilder.DeleteData(
                table: "CourseLessons",
                keyColumn: "Id",
                keyValue: "a3b4c5d67890a1b2c3d4e5f67890e1f2");

            migrationBuilder.DeleteData(
                table: "CourseLessons",
                keyColumn: "Id",
                keyValue: "b4c5d67890a1b2c3d4e5f67890e1f2a3");

            migrationBuilder.DeleteData(
                table: "CourseLessons",
                keyColumn: "Id",
                keyValue: "c5d67890a1b2c3d4e5f67890e1f2a3b4");

            migrationBuilder.DeleteData(
                table: "CourseLessons",
                keyColumn: "Id",
                keyValue: "e1f2a3b4c5d67890a1b2c3d4e5f67890");

            migrationBuilder.DeleteData(
                table: "CourseLessons",
                keyColumn: "Id",
                keyValue: "f2a3b4c5d67890a1b2c3d4e5f67890e1");

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: "1a2b3c4d5e6f7890a1b2c3d4e5f6a7b8");

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: "2b3c4d5e6f7a8b9c0d1e2f3a4b5c6d7e");

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: "3c4d5e6f7a8b9c0d1e2f3a4b5c6d7e8f");

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: "4d5e6f7a8b9c0d1e2f3a4b5c6d7e8f9a");

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

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "a2b3c4d5e67890a1b2c3d4e5f67890f1");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "b3c4d5e67890a1b2c3d4e5f67890f1a2");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c4d5e67890a1b2c3d4e5f67890f1a2b3");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "d5e67890a1b2c3d4e5f67890f1a2b3c4");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "f1a2b3c4d5e67890a1b2c3d4e5f67890");

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: "a1b2c3d4e5f67890a1b2c3d4e5f67890");

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: "b2c3d4e5f67890a1b2c3d4e5f67890a1");

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: "c3d4e5f67890a1b2c3d4e5f67890a1b2");

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: "d4e5f67890a1b2c3d4e5f67890a1b2c3");

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: "e5f67890a1b2c3d4e5f67890a1b2c3d4");

            migrationBuilder.AlterColumn<string>(
                name: "EnrollmentId",
                table: "Payments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "StaffId",
                table: "Enrollments",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CageId",
                table: "Enrollments",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PaymentId",
                table: "Enrollments",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

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
                keyValue: "9f7c3e8a4b6d49f19a8d2e3f4c7b5680",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 3, 25, 9, 9, 7, 10, DateTimeKind.Unspecified).AddTicks(1951), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 3, 25, 9, 9, 7, 10, DateTimeKind.Unspecified).AddTicks(1951), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$twWzNjBLtHto7Nez3tj9nuqQ75h1w03VCDnKrZpuvETRtmyzJQdC2" });

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

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_PaymentId",
                table: "Enrollments",
                column: "PaymentId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Payments_PaymentId",
                table: "Enrollments",
                column: "PaymentId",
                principalTable: "Payments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
