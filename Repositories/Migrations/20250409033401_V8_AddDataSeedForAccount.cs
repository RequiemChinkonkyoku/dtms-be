using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class V8_AddDataSeedForAccount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "00786efb729542fa87a19d44fb3cdf79",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 10, 33, 59, 244, DateTimeKind.Unspecified).AddTicks(2493), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 10, 33, 59, 244, DateTimeKind.Unspecified).AddTicks(2493), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$PzM1D4o40oug2JtGYn7QrOfBtJiJKq3/b1vKaRvjcyfy6m5WXq.me" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "2bf1c6f4a7db4fed825958e6d78e7226",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 10, 33, 59, 130, DateTimeKind.Unspecified).AddTicks(5859), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 10, 33, 59, 130, DateTimeKind.Unspecified).AddTicks(5859), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$zDj7/zaWRpPXFGN/ifP/VuPxfHCGZhzdmuYhiTrGuLuOOw7EnpQwq" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "54d3a3e95adc4b38885e43af50e12e42",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 10, 33, 58, 779, DateTimeKind.Unspecified).AddTicks(1868), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 10, 33, 58, 779, DateTimeKind.Unspecified).AddTicks(1868), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$zNaIuIok486y/ZUb5MXSFeKmZzFu9uYaDcJdY/dTIgr9db1/4hosm" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "6144c9fe6b7e4f4294ea469ffb6a90fd",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 10, 33, 58, 667, DateTimeKind.Unspecified).AddTicks(1027), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 10, 33, 58, 667, DateTimeKind.Unspecified).AddTicks(1027), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$WZa5nmzeDEO34KlhdnWedOBHX.GNoYEoiUvW2esDXLEnX3PH8kBIS" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "9f7c3e8a4b6d49f19a8d2e3f4c7b5680",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 10, 33, 59, 467, DateTimeKind.Unspecified).AddTicks(5178), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 10, 33, 59, 467, DateTimeKind.Unspecified).AddTicks(5178), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$bHWlYQ5Qkd7W9YtcZiyMJOmDn6phNa9i/xBSgXFzl4p9ZiwtXJRbC" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "ea46ce4e457f42dfb18b6347bd4ea1f4",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 10, 33, 59, 14, DateTimeKind.Unspecified).AddTicks(2441), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 10, 33, 59, 14, DateTimeKind.Unspecified).AddTicks(2441), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$tQldingmTpTQAHFvZLcNGeL7wIqeeq4.s318vC9ufrbAxwOx5C6yu" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "eaa27cff0c91479087bb22370ffbb6d0",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 10, 33, 59, 355, DateTimeKind.Unspecified).AddTicks(59), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 10, 33, 59, 355, DateTimeKind.Unspecified).AddTicks(59), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$Sp5.LA2wVhwe/bl6Ouy9Vewfa1Nd80wnCGWu5ucDtydUEJJ75mqvi" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "fa13bc18b0c54ba0b9886b007f4d8b08",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 10, 33, 58, 895, DateTimeKind.Unspecified).AddTicks(3213), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 10, 33, 58, 895, DateTimeKind.Unspecified).AddTicks(3213), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$zEys629mpSQBQG1ATX.ZRu0MlC01cd6PEZIKLmV2bkpMKFMQ9lJZ6" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Address", "CreatedTime", "DateOfBirth", "Email", "FullName", "Gender", "ImageUrl", "LastUpdatedTime", "MembershipId", "MembershipPoints", "Password", "PhoneNumber", "RegistrationTime", "RoleId", "Status", "Username" },
                values: new object[,]
                {
                    { "a1b2c3d4e5f648a9b0c1d2e3f4a5b6c7", "123 Trainer Street", new DateTimeOffset(new DateTime(2025, 4, 9, 10, 33, 59, 578, DateTimeKind.Unspecified).AddTicks(4396), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1985, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aaron_Hank@gmail.com", "Aaron Hank", 1, "https://res.cloudinary.com/djy6ydaxz/image/upload/v1744168717/waccatxqnji44dxgwxhf.png", new DateTimeOffset(new DateTime(2025, 4, 9, 10, 33, 59, 578, DateTimeKind.Unspecified).AddTicks(4396), new TimeSpan(0, 7, 0, 0, 0)), "a1b2c3d4e5f67890a1b2c3d4e5f67890", 0, "$2a$11$7UvtuTZLoAfy9SrtJXGVl.CAhyU6gktmdlmsoAMkd.3h725wQCDfO", "0911223345", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "e2f3a4b5c67890d1e2f3a4b5c67890d1", 1, "AaronHank" },
                    { "a5b6c7d8e9f0a1b2c3d4e5f648a9b0c1", "444 Performance Drive", new DateTimeOffset(new DateTime(2025, 4, 9, 10, 34, 0, 578, DateTimeKind.Unspecified).AddTicks(3703), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1979, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clark_Ramsey@gmail.com", "Clark Ramsey", 1, "https://res.cloudinary.com/djy6ydaxz/image/upload/v1744168717/waccatxqnji44dxgwxhf.png", new DateTimeOffset(new DateTime(2025, 4, 9, 10, 34, 0, 578, DateTimeKind.Unspecified).AddTicks(3703), new TimeSpan(0, 7, 0, 0, 0)), "a1b2c3d4e5f67890a1b2c3d4e5f67890", 0, "$2a$11$QCZMNr/qrCx1hSjRGv4NKu37/TJOaiGy6U.pTFyOfYQDcFZ9gKLRC", "0910112233", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f3a4b5c67890d1e2f3a4b5c67890d1e2", 1, "ClarkRamsey" },
                    { "a9b0c1d2e3f4a5b6c7d8e9f0a1b2c3d4", "555 Fitness Plaza", new DateTimeOffset(new DateTime(2025, 4, 9, 10, 34, 0, 244, DateTimeKind.Unspecified).AddTicks(9974), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1978, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Calvin_Jonh@gmail.com", "Calvin John", 2, "https://res.cloudinary.com/djy6ydaxz/image/upload/v1744168717/waccatxqnji44dxgwxhf.png", new DateTimeOffset(new DateTime(2025, 4, 9, 10, 34, 0, 244, DateTimeKind.Unspecified).AddTicks(9974), new TimeSpan(0, 7, 0, 0, 0)), "a1b2c3d4e5f67890a1b2c3d4e5f67890", 0, "$2a$11$W5/gSxf/uuySycEta8rvu.pM5qF34VKL.4j1.nmUX7.vSdio7u6K6", "0977889900", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f3a4b5c67890d1e2f3a4b5c67890d1e2", 1, "CalvinJohn" },
                    { "b2c3d4e5f648a9b0c1d2e3f4a5b6c7d8", "456 Fitness Ave", new DateTimeOffset(new DateTime(2025, 4, 9, 10, 33, 59, 688, DateTimeKind.Unspecified).AddTicks(7957), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1988, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alba_Jessica@gmail.com", "Alba Jessica", 2, "https://res.cloudinary.com/djy6ydaxz/image/upload/v1744168717/waccatxqnji44dxgwxhf.png", new DateTimeOffset(new DateTime(2025, 4, 9, 10, 33, 59, 688, DateTimeKind.Unspecified).AddTicks(7957), new TimeSpan(0, 7, 0, 0, 0)), "a1b2c3d4e5f67890a1b2c3d4e5f67890", 0, "$2a$11$vUYHzX8rY/HB5zx2IR4MweErMf3fWdeNHkIS2JweGs/Jt068eurXy", "0922334456", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "e2f3a4b5c67890d1e2f3a4b5c67890d1", 1, "AlbaJessica" },
                    { "c1d2e3f4a5b6c7d8e9f0a1b2c3d4e5f6", "222 Wellness Way", new DateTimeOffset(new DateTime(2025, 4, 9, 10, 34, 0, 357, DateTimeKind.Unspecified).AddTicks(6368), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1975, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cao_Cao@gmail.com", "Cao Cao", 1, "https://res.cloudinary.com/djy6ydaxz/image/upload/v1744168717/waccatxqnji44dxgwxhf.png", new DateTimeOffset(new DateTime(2025, 4, 9, 10, 34, 0, 357, DateTimeKind.Unspecified).AddTicks(6368), new TimeSpan(0, 7, 0, 0, 0)), "a1b2c3d4e5f67890a1b2c3d4e5f67890", 0, "$2a$11$NTJulEdGDf2HVaIod3./MuAOdMv/3mjkmQIQXPsdInWIgNqp88sr2", "0988990011", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f3a4b5c67890d1e2f3a4b5c67890d1e2", 1, "CaoCao" },
                    { "c3d4e5f648a9b0c1d2e3f4a5b6c7d8e9", "789 Workout Lane", new DateTimeOffset(new DateTime(2025, 4, 9, 10, 33, 59, 799, DateTimeKind.Unspecified).AddTicks(4004), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1982, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Austen_Jane@gmail.com", "Austen Jane", 1, "https://res.cloudinary.com/djy6ydaxz/image/upload/v1744168717/waccatxqnji44dxgwxhf.png", new DateTimeOffset(new DateTime(2025, 4, 9, 10, 33, 59, 799, DateTimeKind.Unspecified).AddTicks(4004), new TimeSpan(0, 7, 0, 0, 0)), "a1b2c3d4e5f67890a1b2c3d4e5f67890", 0, "$2a$11$fSJm8NMdY3zk0dR0FWgtoOXa/zQmXC3d4uWllK9a8Mx0jKCwkGvEm", "0933445567", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "e2f3a4b5c67890d1e2f3a4b5c67890d1", 1, "AustenJane" },
                    { "d4e5f648a9b0c1d2e3f4a5b6c7d8e9f0", "321 Exercise Blvd", new DateTimeOffset(new DateTime(2025, 4, 9, 10, 33, 59, 909, DateTimeKind.Unspecified).AddTicks(9223), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1990, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Austin_Alfred@gmail.com", "Austin Alfred", 2, "https://res.cloudinary.com/djy6ydaxz/image/upload/v1744168717/waccatxqnji44dxgwxhf.png", new DateTimeOffset(new DateTime(2025, 4, 9, 10, 33, 59, 909, DateTimeKind.Unspecified).AddTicks(9223), new TimeSpan(0, 7, 0, 0, 0)), "a1b2c3d4e5f67890a1b2c3d4e5f67890", 0, "$2a$11$SYRu0F4wqY6hetBPUVlXyeUHv/VoOCsTUtTtNCeJSkWl2txTmXL8e", "0944556678", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "e2f3a4b5c67890d1e2f3a4b5c67890d1", 1, "AustinAlfred" },
                    { "e3f4a5b6c7d8e9f0a1b2c3d4e5f648a9", "888 Health Circle", new DateTimeOffset(new DateTime(2025, 4, 9, 10, 34, 0, 467, DateTimeKind.Unspecified).AddTicks(9610), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1982, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Charles_Ray@gmail.com", "Charles Ray", 2, "https://res.cloudinary.com/djy6ydaxz/image/upload/v1744168717/waccatxqnji44dxgwxhf.png", new DateTimeOffset(new DateTime(2025, 4, 9, 10, 34, 0, 467, DateTimeKind.Unspecified).AddTicks(9610), new TimeSpan(0, 7, 0, 0, 0)), "a1b2c3d4e5f67890a1b2c3d4e5f67890", 0, "$2a$11$FeJUuQFvI/BZltjHSlSIe.xVR.3HDBXHmkyG9aJ6egwSea4wFof1a", "0999001122", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f3a4b5c67890d1e2f3a4b5c67890d1e2", 1, "CharlesRay" },
                    { "e5f648a9b0c1d2e3f4a5b6c7d8e9f0a1", "654 Gym Road", new DateTimeOffset(new DateTime(2025, 4, 9, 10, 34, 0, 22, DateTimeKind.Unspecified).AddTicks(1729), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1987, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bach_Richard@gmail.com", "Bach Richard", 1, "https://res.cloudinary.com/djy6ydaxz/image/upload/v1744168717/waccatxqnji44dxgwxhf.png", new DateTimeOffset(new DateTime(2025, 4, 9, 10, 34, 0, 22, DateTimeKind.Unspecified).AddTicks(1729), new TimeSpan(0, 7, 0, 0, 0)), "a1b2c3d4e5f67890a1b2c3d4e5f67890", 0, "$2a$11$Yj0GpeZS/hbwFuK3TKN.xu/ZtcYXNyM6bsxidNSyAnVSywPjajoZ.", "0955667789", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "e2f3a4b5c67890d1e2f3a4b5c67890d1", 1, "BachRichard" },
                    { "f648a9b0c1d2e3f4a5b6c7d8e9f0a1b2", "987 Training Center", new DateTimeOffset(new DateTime(2025, 4, 9, 10, 34, 0, 132, DateTimeKind.Unspecified).AddTicks(7656), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1980, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Buckles_Frank@gmail.com", "Buckles Frank", 1, "https://res.cloudinary.com/djy6ydaxz/image/upload/v1744168717/waccatxqnji44dxgwxhf.png", new DateTimeOffset(new DateTime(2025, 4, 9, 10, 34, 0, 132, DateTimeKind.Unspecified).AddTicks(7656), new TimeSpan(0, 7, 0, 0, 0)), "a1b2c3d4e5f67890a1b2c3d4e5f67890", 0, "$2a$11$2N0QhwAbSVW2qmaktG8Cbu5eapLsbO2QtCdLjgGn0ZetzCV0HT3Si", "0966778899", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f3a4b5c67890d1e2f3a4b5c67890d1e2", 1, "BucklesFrank" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "a1b2c3d4e5f648a9b0c1d2e3f4a5b6c7");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "a5b6c7d8e9f0a1b2c3d4e5f648a9b0c1");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "a9b0c1d2e3f4a5b6c7d8e9f0a1b2c3d4");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "b2c3d4e5f648a9b0c1d2e3f4a5b6c7d8");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "c1d2e3f4a5b6c7d8e9f0a1b2c3d4e5f6");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "c3d4e5f648a9b0c1d2e3f4a5b6c7d8e9");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "d4e5f648a9b0c1d2e3f4a5b6c7d8e9f0");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "e3f4a5b6c7d8e9f0a1b2c3d4e5f648a9");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "e5f648a9b0c1d2e3f4a5b6c7d8e9f0a1");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "f648a9b0c1d2e3f4a5b6c7d8e9f0a1b2");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "00786efb729542fa87a19d44fb3cdf79",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 0, 4, 25, 647, DateTimeKind.Unspecified).AddTicks(6894), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 0, 4, 25, 647, DateTimeKind.Unspecified).AddTicks(6894), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$9ealuJSG0bI5Ui34BZjnZeWfNN0IX/5t.7aPcHWVmtAjL8jzcJSUK" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "2bf1c6f4a7db4fed825958e6d78e7226",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 0, 4, 25, 525, DateTimeKind.Unspecified).AddTicks(4422), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 0, 4, 25, 525, DateTimeKind.Unspecified).AddTicks(4422), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$BhdtUJMpvjcozHwLMGpYOOnIuksi.qPDUg0bfLH5/5/WOsKbWDwRe" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "54d3a3e95adc4b38885e43af50e12e42",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 0, 4, 25, 175, DateTimeKind.Unspecified).AddTicks(3446), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 0, 4, 25, 175, DateTimeKind.Unspecified).AddTicks(3446), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$sOm/ag4kHi3jRlo.VjSug.R69uKAo6BVJEmWvuuKznR1PHIyIyNE2" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "6144c9fe6b7e4f4294ea469ffb6a90fd",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 0, 4, 25, 59, DateTimeKind.Unspecified).AddTicks(5791), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 0, 4, 25, 59, DateTimeKind.Unspecified).AddTicks(5791), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$CLzkfjmpBCOmDXhJjy0d2OoGp0PsNUNYnT.6XZkKhsm0v.c8ofFqi" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "9f7c3e8a4b6d49f19a8d2e3f4c7b5680",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 0, 4, 25, 885, DateTimeKind.Unspecified).AddTicks(7578), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 0, 4, 25, 885, DateTimeKind.Unspecified).AddTicks(7578), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$uxUxJCBm4wY/mmrwTfwbMuUquFTlZACGYQ4EtIqv48ifMhd4iNLbi" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "ea46ce4e457f42dfb18b6347bd4ea1f4",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 0, 4, 25, 407, DateTimeKind.Unspecified).AddTicks(5267), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 0, 4, 25, 407, DateTimeKind.Unspecified).AddTicks(5267), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$fIcjCMGCb7FI67EiEEHUh.cT.Wt0Rez2AftIeWntswBASoUMmBCFa" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "eaa27cff0c91479087bb22370ffbb6d0",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 0, 4, 25, 770, DateTimeKind.Unspecified).AddTicks(1159), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 0, 4, 25, 770, DateTimeKind.Unspecified).AddTicks(1159), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$G76OtxcrGrYa8ieJZ16aqO.y5o8PORaXv5JySDo/dEgvD/aprf5y6" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "fa13bc18b0c54ba0b9886b007f4d8b08",
                columns: new[] { "CreatedTime", "LastUpdatedTime", "Password" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 4, 9, 0, 4, 25, 292, DateTimeKind.Unspecified).AddTicks(5678), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2025, 4, 9, 0, 4, 25, 292, DateTimeKind.Unspecified).AddTicks(5678), new TimeSpan(0, 7, 0, 0, 0)), "$2a$11$681Y0kg0Ak0cM6EZbEgqJeRY3Gj1MnhJVrCrZO1wt6Xc8.XNouKjm" });
        }
    }
}
