using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class V1_ChangeEnrollmentPaymentIdBeNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Enrollments_PaymentId",
                table: "Enrollments");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "122a2367f61d4fc39942401f98c0b091");

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: "3e8b68ca2e274bc1ae0316d7dbbb63a5");

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: "b34ae1ab13a84151a5e76d198f3b73e7");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "229062ca29c3431da81cb19330864ab6");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "5ea53ae1533045098ea3fee913a1f30b");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "d9b9141bfe934bcd8fdea80d80024335");

            migrationBuilder.DeleteData(
                table: "DogDocuments",
                keyColumn: "Id",
                keyValue: "05b7fd53aa39437eb498858be9fe6919");

            migrationBuilder.DeleteData(
                table: "DogDocuments",
                keyColumn: "Id",
                keyValue: "35f9cd689ead4b918d94cc34edef3af1");

            migrationBuilder.DeleteData(
                table: "DogDocuments",
                keyColumn: "Id",
                keyValue: "4d80e995169b446a93aa7abb707ab4b9");

            migrationBuilder.DeleteData(
                table: "DogDocuments",
                keyColumn: "Id",
                keyValue: "4f2f79a7f3144955b01bb99a8a6babc7");

            migrationBuilder.DeleteData(
                table: "DogDocuments",
                keyColumn: "Id",
                keyValue: "6e17b4da4e7a4c44a51be4bb606c66bb");

            migrationBuilder.DeleteData(
                table: "DogDocuments",
                keyColumn: "Id",
                keyValue: "8544b1cc46a142e6a3c3b7ca73ca5981");

            migrationBuilder.DeleteData(
                table: "DogDocuments",
                keyColumn: "Id",
                keyValue: "87e7d0e4ca15471c97cc59791cccc7da");

            migrationBuilder.DeleteData(
                table: "DogDocuments",
                keyColumn: "Id",
                keyValue: "908437d382a540178aec10ff5cfc7551");

            migrationBuilder.DeleteData(
                table: "DogDocuments",
                keyColumn: "Id",
                keyValue: "c5c11b31551640b78030f47e2bad9ba7");

            migrationBuilder.DeleteData(
                table: "DogOwnerships",
                keyColumn: "Id",
                keyValue: "192100f6691c45c0b2fa56943f363c00");

            migrationBuilder.DeleteData(
                table: "DogOwnerships",
                keyColumn: "Id",
                keyValue: "28e4a9c00b5042f5abae533d9cf768ca");

            migrationBuilder.DeleteData(
                table: "DogOwnerships",
                keyColumn: "Id",
                keyValue: "3204f7e935164436926187379dc3fb0c");

            migrationBuilder.DeleteData(
                table: "DogOwnerships",
                keyColumn: "Id",
                keyValue: "4691ec2092ec473ebe3fe69d3635a8f1");

            migrationBuilder.DeleteData(
                table: "DogOwnerships",
                keyColumn: "Id",
                keyValue: "5cbd34b869764514ba6d14c323645446");

            migrationBuilder.DeleteData(
                table: "DogOwnerships",
                keyColumn: "Id",
                keyValue: "769e4a7d585a4b029987be18936a19cf");

            migrationBuilder.DeleteData(
                table: "DogOwnerships",
                keyColumn: "Id",
                keyValue: "b1ead9a570a642eea5c2e8e12dda9435");

            migrationBuilder.DeleteData(
                table: "DogOwnerships",
                keyColumn: "Id",
                keyValue: "b881dad9f0fd435796b66d35e1873728");

            migrationBuilder.DeleteData(
                table: "DogOwnerships",
                keyColumn: "Id",
                keyValue: "fbfe836c4fbb44b3a0d8929f4566f3a0");

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: "21f1aa58123b4e3586b72f91e4dcb8b1");

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: "6750fbed19a54839a338f55350ded3be");

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: "add3ab3c7a024750801e5cc27f6184e5");

            migrationBuilder.DeleteData(
                table: "Memberships",
                keyColumn: "Id",
                keyValue: "383a57689bca49bc8eafcaf6a6ea5223");

            migrationBuilder.DeleteData(
                table: "Memberships",
                keyColumn: "Id",
                keyValue: "de6d8d32ea20416e8977b379af19e1c9");

            migrationBuilder.DeleteData(
                table: "TrainerSkills",
                keyColumn: "Id",
                keyValue: "1db6cc5373774023b23f4664cf1b33a2");

            migrationBuilder.DeleteData(
                table: "TrainerSkills",
                keyColumn: "Id",
                keyValue: "1fda5b771ba0473786ae9cc997d757ae");

            migrationBuilder.DeleteData(
                table: "TrainerSkills",
                keyColumn: "Id",
                keyValue: "a32a002cd5fe4c9493af5fffaba5934a");

            migrationBuilder.DeleteData(
                table: "TrainerSkills",
                keyColumn: "Id",
                keyValue: "c7f958e9660e44c29ba93a4117d3aa8f");

            migrationBuilder.DeleteData(
                table: "TrainerSkills",
                keyColumn: "Id",
                keyValue: "eb10c5eddcb240c3ad2330565ccf7165");

            migrationBuilder.DeleteData(
                table: "TrainerSkills",
                keyColumn: "Id",
                keyValue: "f243e661c40a404ab7f6abbe075337db");

            migrationBuilder.DeleteData(
                table: "TrainerSkills",
                keyColumn: "Id",
                keyValue: "fbb9ab6da5c44555a3ca858c562a84d0");

            migrationBuilder.DeleteData(
                table: "TrainerSkills",
                keyColumn: "Id",
                keyValue: "fc0b8dd7916e489ea35f9f12e68dd0e3");

            migrationBuilder.DeleteData(
                table: "TrainerSpecializations",
                keyColumn: "Id",
                keyValue: "1538a838406245b7b487b9e7965e6c04");

            migrationBuilder.DeleteData(
                table: "TrainerSpecializations",
                keyColumn: "Id",
                keyValue: "36e1fb0384e4475090561557cf5a661c");

            migrationBuilder.DeleteData(
                table: "TrainerSpecializations",
                keyColumn: "Id",
                keyValue: "eb576b22c7b34d66a357f22276826225");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "1d49901920b044a18ec07fd8962fa524");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "29bdbfb25b5940deabffc03f9220384a");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "7f5e6dc5ac3341ecbd9d8ec3447f02fd");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "9642834e791942fb921626f63e861788");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "993e61e00c234f299953104f97b28e8d");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "ce6705ada2414b8c8e24252352ce2be0");

            migrationBuilder.DeleteData(
                table: "DogDocumentTypes",
                keyColumn: "Id",
                keyValue: "1066b59049254284b3ce51e86faa9073");

            migrationBuilder.DeleteData(
                table: "DogDocumentTypes",
                keyColumn: "Id",
                keyValue: "3f50a4d5e2b249b9a537bd1bb570684d");

            migrationBuilder.DeleteData(
                table: "DogDocumentTypes",
                keyColumn: "Id",
                keyValue: "499eeaadf9dc4179ae07f842173075c8");

            migrationBuilder.DeleteData(
                table: "DogDocumentTypes",
                keyColumn: "Id",
                keyValue: "53af93d0b0c84fd9a6c6a4416c09bcf7");

            migrationBuilder.DeleteData(
                table: "DogDocumentTypes",
                keyColumn: "Id",
                keyValue: "78fccf4b8f0046f68083e21398b4ee44");

            migrationBuilder.DeleteData(
                table: "DogDocumentTypes",
                keyColumn: "Id",
                keyValue: "7d40977b7c17477a85cddaca84d62a27");

            migrationBuilder.DeleteData(
                table: "DogDocumentTypes",
                keyColumn: "Id",
                keyValue: "bbb79679653f4a16b2c3fed1dbd07dd2");

            migrationBuilder.DeleteData(
                table: "DogDocumentTypes",
                keyColumn: "Id",
                keyValue: "e45d4bfb9a9845ad8db598e9b2c7eea9");

            migrationBuilder.DeleteData(
                table: "DogDocumentTypes",
                keyColumn: "Id",
                keyValue: "ecf71e62101d4442a60436f7df2c7d1c");

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: "18606b92bd3f452b80ee531b4af16d83");

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: "26845efced4d4e94b85302a2e407f1ee");

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: "40f2d18b4e30437d8d3c014da06593bd");

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: "55fbd19084b3451eb7a78365e25d463c");

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: "90aa65b70d154038b4a44ef9c0f5b622");

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: "d6339b0f956f454782d9757cd8a3a6cb");

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: "de005750c7724e90bb0ddb5dcc24ee72");

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: "ebea772a78294fc4900243bd52427f7c");

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: "ee8136fbdeaa4977b793e6f9f65adf15");

            migrationBuilder.DeleteData(
                table: "EquipmentCategories",
                keyColumn: "Id",
                keyValue: "3c075f36cfb9437080aadb225cb79af2");

            migrationBuilder.DeleteData(
                table: "EquipmentCategories",
                keyColumn: "Id",
                keyValue: "4126947fd3b14b619da67eb89429a5ed");

            migrationBuilder.DeleteData(
                table: "EquipmentCategories",
                keyColumn: "Id",
                keyValue: "811a6c0a30f347aeb78bd1ebe60e3d8b");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8386c80ab733490f9590cd33e7b8693e");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "083e69770573496688be1285b1f1e945");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "1ea762aa323b45fd9110244af37010eb");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "4e133f0a7e114d4289fdef8dfc6258e1");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "4fd46a8b17594280883fca26fdd24e7f");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "ef0fc3df708444359bb0686a236ad1c2");

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: "00033bececfa4e6781c124bf58a3d9df");

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: "4806039abc1e42ac93ec89858a5fe219");

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: "7e565885baea4e85a6c9956008d8793e");

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: "21fe03b22c2b4073830cd0fbd49546d0");

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: "305708254efa4e8d923e8fae6008a489");

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: "392e2bd16f174f7fa41a14216f309aaa");

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: "6f8157e6a2ec4b05b72cb821b452993f");

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: "70e1f2c357db4251a491f0312f66eab2");

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: "7a9e6ae123634532ab66abe5a2372e0e");

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: "8bcc9e0632484b94a2c04c8ed6affd15");

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: "94395769159244a0a7a015d683ccc7b1");

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: "d1ea563a9e784ea7a977e5ef2e9c7908");

            migrationBuilder.DeleteData(
                table: "Memberships",
                keyColumn: "Id",
                keyValue: "9079125b57c24172a6bdbd93e57b773a");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "11636589263b4d02bfc76274a79a7389");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "31fb40f62bfc46d7afa45004bd8afbf7");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "454c38771b314dc8b5740866d50b7e6d");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "91dda1b2faef42148307abd2b5076d2d");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "9919ed061db041439a2408bd9243ac36");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "d756577e393b4547ba0ecbd250b93f10");

            migrationBuilder.DeleteData(
                table: "DogTypes",
                keyColumn: "Id",
                keyValue: "2fbb4148d458490f8070d8dc035aa5dd");

            migrationBuilder.DeleteData(
                table: "DogTypes",
                keyColumn: "Id",
                keyValue: "9bd33d4e6dd648d9b083c4d2c5b09664");

            migrationBuilder.DeleteData(
                table: "DogTypes",
                keyColumn: "Id",
                keyValue: "e665231013f64a98bd327f5f10cb8cb2");

            migrationBuilder.AlterColumn<string>(
                name: "StaffId",
                table: "Enrollments",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "PaymentId",
                table: "Enrollments",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedTime", "Description", "LastUpdatedTime", "Name", "Status" },
                values: new object[,]
                {
                    { "345fa2ab611e4dc387c9bf25af41e6a9", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Addresses problem behaviors and corrective training for dogs.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Behavioral Modification", 1 },
                    { "44a2cc197a614ab3aa93a4c706076394", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Covers fundamental obedience commands and essential skills.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Basic Training", 1 },
                    { "bb54bfa8e5644bef9f3c609f5237f533", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Focuses on advanced obedience and specialized training techniques.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Advanced Training", 1 }
                });

            migrationBuilder.InsertData(
                table: "DogDocumentTypes",
                columns: new[] { "Id", "CreatedTime", "Description", "LastUpdatedTime", "Name" },
                values: new object[,]
                {
                    { "14df76b885d94fc58791bea6579e9b75", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Document containing vaccination history of the dog.", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Vaccination Record" },
                    { "2f3ddc88886344569516a8c28ca8db25", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Document containing the dog's microchip details.", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Microchip Registration" },
                    { "5607931438eb467d87f1de4664e1e2c4", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Legal documents for the adoption of the dog.", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Adoption Papers" },
                    { "694b4222f6f44c798ef302628024ed48", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Official license permitting the dog to be used for breeding.", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Breeding License" },
                    { "9a4a23e4d0ee45399c0cecd117884d10", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Certificate awarded for participation or winning in dog shows.", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Show Competition Certificate" },
                    { "ce6cc50cab6e4125ad4c8ecf118f2710", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Official document proving the dog's lineage and breed.", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Pedigree Certificate" },
                    { "e189ddda0d6b406d890e45b70e685e86", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Document detailing the dog's health insurance policy.", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Health Insurance" },
                    { "f5a6678a34e84eb195148dd2417a52cc", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Certificate proving the dog has completed a training program.", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Training Certificate" },
                    { "f8637d62adbc4ccfb7ca009393807918", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Certification proving the dog is qualified as a therapy dog.", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Therapy Dog Certification" }
                });

            migrationBuilder.InsertData(
                table: "DogTypes",
                columns: new[] { "Id", "CreatedTime", "Description", "LastUpdatedTime", "Name", "Status" },
                values: new object[,]
                {
                    { "6b7882fbc5404bdfa0009b77b046e7c7", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Medium-sized dog breeds", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Medium", 1 },
                    { "8de741cc92a64f379cea87657d6067d8", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Small-sized dog breeds", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Small", 1 },
                    { "acde7ed7484949d18903632891dfb9c7", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Large-sized dog breeds", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Large", 1 }
                });

            migrationBuilder.InsertData(
                table: "EquipmentCategories",
                columns: new[] { "Id", "CreatedTime", "Description", "LastUpdatedTime", "Name", "Status" },
                values: new object[,]
                {
                    { "62b0e81cdbf245868bd96d377c56cda1", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Tools used for dog grooming, including brushes and clippers.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Grooming Equipment", 1 },
                    { "6e3bb6ea334e4e2dab1a9720f9a4a0aa", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Protective gear for dogs, such as harnesses and pads.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Safety Gear", 1 },
                    { "ef43ef70bde9451c974fbc1b4c8a6832", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Equipment used for dog training and obedience exercises.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Training Tools", 1 }
                });

            migrationBuilder.InsertData(
                table: "Memberships",
                columns: new[] { "Id", "CreatedTime", "Description", "DiscountAmount", "LastUpdatedTime", "Name", "RequiredPoints" },
                values: new object[,]
                {
                    { "8a0f1e3944754b42acb05bd518b301c6", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Entry-level membership", 0m, new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Basic", 0 },
                    { "8ee5738e5b8c4ad4989e97da2deb167c", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Premium membership", 10m, new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Gold", 500 },
                    { "d236daf5649b474badefd00538b1726e", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Elite membership", 20m, new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Platinum", 1000 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedTime", "Description", "LastUpdatedTime", "Name", "Status" },
                values: new object[,]
                {
                    { "188c604ae9094fce85e674fce6659f93", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Staff employee member managing operations", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Staff_Employee", 1 },
                    { "2b24f6c45be6409ea5d0766ee511e94b", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Staff manager member managing operations", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Staff_Manager", 1 },
                    { "4f3f5e24b4944644a340220289845af0", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Individual customer who can enroll in courses", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Customer_Individual", 1 },
                    { "7fd97273f51f4186bc9f43eb39205e4e", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Lead trainer responsible for courses and lessons", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Trainer_Lead", 1 },
                    { "92c787c689284631847c4434c0adbe10", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Trainer responsible for courses and lessons", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Trainer_Member", 1 },
                    { "9f7f12b6c79045689f5c222c7112d1d0", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Organizational customer who can enroll in courses", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Customer_Organizational", 1 },
                    { "dfbdc8373d054d09bc629dcbc2525b89", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "System administrator with full access", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Admin", 1 }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "CreatedTime", "Description", "LastUpdatedTime", "Name", "Status" },
                values: new object[,]
                {
                    { "113d9b6c850c4d028afb05c159833bd0", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Training dogs to follow basic commands like sit, stay, and come.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Basic Commands", 1 },
                    { "5440f3e800b64db8af93b376eea31a31", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Addressing and correcting unwanted behaviors in dogs.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Behavioral Correction", 1 },
                    { "5641b5bd5c5c4cae9806ad1291d2db91", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Enhancing a dog's physical abilities and responsiveness through obstacle courses.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Agility Training", 1 },
                    { "ad931be589d34b14babc330447a8b1b3", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Training dogs for guarding and protective behavior.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Protection Training", 1 },
                    { "ca6a868a7b8242b9b914a06083a1686e", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Helping dogs become comfortable around other animals and people.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Socialization", 1 }
                });

            migrationBuilder.InsertData(
                table: "Specializations",
                columns: new[] { "Id", "CreatedTime", "Description", "LastUpdatedTime", "Name" },
                values: new object[,]
                {
                    { "6ea6fbf932f34e7798e045fbb4134eaf", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Helping dogs overcome behavioral issues.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Behavioral Therapy" },
                    { "b08efacd34064a8c899aa004dd1e7a2e", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Basic and advanced obedience training for dogs.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Obedience Training" },
                    { "d6e7c8b072d549d2a7e169ddc9d65bfd", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Training dogs for agility courses and competitions.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Agility Training" }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Address", "CreatedTime", "DateOfBirth", "Email", "FullName", "Gender", "ImageUrl", "LastUpdatedTime", "MembershipId", "MembershipPoints", "Password", "PhoneNumber", "RegistrationTime", "RoleId", "Status", "Username" },
                values: new object[,]
                {
                    { "07b2d4a69f6b4dc99b3f88e946bdcc12", "Customer Individual Address", new DateTimeOffset(new DateTime(2025, 3, 24, 20, 31, 51, 708, DateTimeKind.Unspecified).AddTicks(9641), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1995, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer_individual@gmail.com", "Customer Individual", 2, "empty", new DateTimeOffset(new DateTime(2025, 3, 24, 20, 31, 51, 708, DateTimeKind.Unspecified).AddTicks(9641), new TimeSpan(0, 7, 0, 0, 0)), "8a0f1e3944754b42acb05bd518b301c6", 100, "$2a$11$CxEKrEkED.V8e964uqzfreL9fpXUL2AUBGDBP4.US6UVuTAfFoK4C", "0988112233", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4f3f5e24b4944644a340220289845af0", 1, "customer_individual" },
                    { "0e5d5328b34e4832a9f6361147cec4a5", "Trainer Lead Address", new DateTimeOffset(new DateTime(2025, 3, 24, 20, 31, 51, 569, DateTimeKind.Unspecified).AddTicks(1986), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1983, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "trainer_lead@gmail.com", "Trainer Lead", 1, "empty", new DateTimeOffset(new DateTime(2025, 3, 24, 20, 31, 51, 569, DateTimeKind.Unspecified).AddTicks(1986), new TimeSpan(0, 7, 0, 0, 0)), "8a0f1e3944754b42acb05bd518b301c6", 0, "$2a$11$cvHND5.rJWZlq0zjNSjhAOVIGK0mf9WEDeOJcQ579WZZk.2//zYKi", "0911223344", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7fd97273f51f4186bc9f43eb39205e4e", 1, "trainer_lead" },
                    { "2a6e26654e8b437bb44902abd4aabc11", "Trainer Member Address", new DateTimeOffset(new DateTime(2025, 3, 24, 20, 31, 51, 427, DateTimeKind.Unspecified).AddTicks(4440), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1985, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "trainer_member@gmail.com", "Trainer Member", 1, "empty", new DateTimeOffset(new DateTime(2025, 3, 24, 20, 31, 51, 427, DateTimeKind.Unspecified).AddTicks(4440), new TimeSpan(0, 7, 0, 0, 0)), "8a0f1e3944754b42acb05bd518b301c6", 0, "$2a$11$Mk.NcpBgjjF/C317Cd6qNeSa7o5kvVXi3Gm4NL//I/.XLNvDXc0kC", "0987654321", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "92c787c689284631847c4434c0adbe10", 1, "trainer_member" },
                    { "42976d92772e4163b8ea5b12a278a730", "Admin Address", new DateTimeOffset(new DateTime(2025, 3, 24, 20, 31, 51, 280, DateTimeKind.Unspecified).AddTicks(4862), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", "Admin User", 1, "empty", new DateTimeOffset(new DateTime(2025, 3, 24, 20, 31, 51, 280, DateTimeKind.Unspecified).AddTicks(4862), new TimeSpan(0, 7, 0, 0, 0)), "8a0f1e3944754b42acb05bd518b301c6", 0, "$2a$11$Qhb/OP3V6DN3uN9ixCbDF.eQL5NJrV83Tx2/QjIRPrNdl9iNzDD7W", "0123456789", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "dfbdc8373d054d09bc629dcbc2525b89", 1, "admin" },
                    { "4e5bb244a9a146fd8571d43c41cb9e7d", "Staff Manager Address", new DateTimeOffset(new DateTime(2025, 3, 24, 20, 31, 52, 102, DateTimeKind.Unspecified).AddTicks(972), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1980, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff_manager@gmail.com", "Staff Manager", 1, "empty", new DateTimeOffset(new DateTime(2025, 3, 24, 20, 31, 52, 102, DateTimeKind.Unspecified).AddTicks(972), new TimeSpan(0, 7, 0, 0, 0)), "8a0f1e3944754b42acb05bd518b301c6", 0, "$2a$11$O58W9Tn7OveFQ8B9mQZjMOC8gfCum2fg1inB46qyf9jgQnti.FtJ.", "0955223344", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2b24f6c45be6409ea5d0766ee511e94b", 1, "staff_manager" },
                    { "71d074d4fba0409789bc0be8d1d35fbe", "Staff Employee Address", new DateTimeOffset(new DateTime(2025, 3, 24, 20, 31, 51, 970, DateTimeKind.Unspecified).AddTicks(3034), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1988, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff_employee@gmail.com", "Staff Employee", 1, "empty", new DateTimeOffset(new DateTime(2025, 3, 24, 20, 31, 51, 970, DateTimeKind.Unspecified).AddTicks(3034), new TimeSpan(0, 7, 0, 0, 0)), "8a0f1e3944754b42acb05bd518b301c6", 0, "$2a$11$YQxA40Y7Qy9nH.a6wdpuIeOzSgFO7JNm2HmT3Pq.b.iyMRi97qL.6", "0966332211", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "188c604ae9094fce85e674fce6659f93", 1, "staff_employee" },
                    { "c7f3d381e9c84af1ba663d8fc1643de3", "Customer Organization Address", new DateTimeOffset(new DateTime(2025, 3, 24, 20, 31, 51, 844, DateTimeKind.Unspecified).AddTicks(1177), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1992, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer_organization@gmail.com", "Customer Organization", 2, "empty", new DateTimeOffset(new DateTime(2025, 3, 24, 20, 31, 51, 844, DateTimeKind.Unspecified).AddTicks(1177), new TimeSpan(0, 7, 0, 0, 0)), "8a0f1e3944754b42acb05bd518b301c6", 200, "$2a$11$IhvQDnsMe/ZezqJpMSPSouGFEHDfnoHyV8vpqgxPa5bnieKhT33/y", "0977554433", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9f7f12b6c79045689f5c222c7112d1d0", 1, "customer_organization" }
                });

            migrationBuilder.InsertData(
                table: "DogBreeds",
                columns: new[] { "Id", "CreatedTime", "Description", "DogTypeId", "LastUpdatedTime", "Name", "Status" },
                values: new object[,]
                {
                    { "1479503ca2654f82bd01fb746470b2c8", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A friendly and intelligent large breed.", "acde7ed7484949d18903632891dfb9c7", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Golden Retriever", 1 },
                    { "1bf7320d672844d085398a24f2dd45ae", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A curious and friendly breed known for its great sense of smell.", "6b7882fbc5404bdfa0009b77b046e7c7", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Beagle", 1 },
                    { "1cc5474159884e23b137f071da963986", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A small, muscular dog with a distinctive bat-like ear shape.", "8de741cc92a64f379cea87657d6067d8", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "French Bulldog", 1 },
                    { "6f8afc331e334abcb087192f20ce3b1c", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A highly intelligent and energetic breed.", "6b7882fbc5404bdfa0009b77b046e7c7", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Border Collie", 1 },
                    { "85ca97017702447c884b3cc7d6098c95", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A tiny breed known for its lively personality.", "8de741cc92a64f379cea87657d6067d8", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Chihuahua", 1 },
                    { "96b72a0dba7144c183fb86a64ad07529", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A friendly and intelligent medium-sized breed.", "6b7882fbc5404bdfa0009b77b046e7c7", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Cocker Spaniel", 1 },
                    { "c3048dfc30f64262ad9dcc6be0fc9a0e", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A loyal and protective breed, often used as a guard dog.", "acde7ed7484949d18903632891dfb9c7", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Rottweiler", 1 },
                    { "cb7c47d7a3814e9681ba93aba9843ab9", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A fluffy and energetic small breed.", "8de741cc92a64f379cea87657d6067d8", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Pomeranian", 1 },
                    { "d481d89a45e34941a88ff83a753866fe", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A strong and intelligent breed used in working roles.", "acde7ed7484949d18903632891dfb9c7", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "German Shepherd", 1 }
                });

            migrationBuilder.InsertData(
                table: "Equipments",
                columns: new[] { "Id", "CreatedTime", "Description", "EquipmentCategoryId", "LastUpdatedTime", "Name", "Status" },
                values: new object[,]
                {
                    { "53cf738dc9bd4b0199f0610f4cba3b20", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A brush for maintaining a dog's coat and hygiene.", "62b0e81cdbf245868bd96d377c56cda1", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Grooming Brush", 1 },
                    { "d88efe781cc442868bde56d1197a0857", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A comfortable harness designed for safety and control.", "6e3bb6ea334e4e2dab1a9720f9a4a0aa", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Dog Harness", 1 },
                    { "f0dc4d5f87f64437bfad220514d79c8a", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A clicker used for positive reinforcement training.", "ef43ef70bde9451c974fbc1b4c8a6832", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Training Clicker", 1 }
                });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "Content", "CreatedTime", "ImageUrl", "LastUpdatedTime", "StaffId", "Status", "TimePublished", "Title" },
                values: new object[,]
                {
                    { "1078f91579d642039b1cff180d2c475f", "Training your dog is crucial for a harmonious relationship between pet and owner...", new DateTimeOffset(new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/blog1.jpg", new DateTimeOffset(new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "71d074d4fba0409789bc0be8d1d35fbe", 1, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Importance of Dog Training" },
                    { "c753fa30266f4facb2e0f5aaa02a08c6", "Providing a balanced diet is essential for your dog's overall health and well-being...", new DateTimeOffset(new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/blog2.jpg", new DateTimeOffset(new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "4e5bb244a9a146fd8571d43c41cb9e7d", 1, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Understanding Canine Nutrition" }
                });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "Id", "CreatedTime", "DateOfBirth", "DogBreedId", "Gender", "ImageUrl", "LastUpdatedTime", "Name", "RegistrationTime", "Status" },
                values: new object[,]
                {
                    { "0814372268704f019119b55ddf080fde", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateOnly(2021, 7, 18), "6f8afc331e334abcb087192f20ce3b1c", 1, "https://example.com/dog5.jpg", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Max", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { "195155a83a744a059cf53d56ce8188e3", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateOnly(2020, 8, 22), "cb7c47d7a3814e9681ba93aba9843ab9", 1, "https://example.com/dog2.jpg", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Rocky", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { "1b6224a40dd1426eb216be3066dc033a", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateOnly(2019, 12, 5), "96b72a0dba7144c183fb86a64ad07529", 1, "https://example.com/dog4.jpg", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Charlie", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { "2781dc1acc834735b66ce458763d8243", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateOnly(2021, 5, 15), "85ca97017702447c884b3cc7d6098c95", 0, "https://example.com/dog1.jpg", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Bella", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { "362ab01dda294c20afc11cf8cd9237e6", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateOnly(2019, 9, 14), "d481d89a45e34941a88ff83a753866fe", 1, "https://example.com/dog8.jpg", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Rex", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { "3b1fdfbf9cfe415bb74d004e699d8d6a", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateOnly(2022, 1, 30), "1cc5474159884e23b137f071da963986", 0, "https://example.com/dog3.jpg", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Luna", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { "651eb45e8e51499d93575445d9deeb06", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateOnly(2018, 11, 25), "1479503ca2654f82bd01fb746470b2c8", 1, "https://example.com/dog7.jpg", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Buddy", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { "7fb679549a7d4f8db6ebd80d5ae6ab7a", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateOnly(2021, 3, 8), "c3048dfc30f64262ad9dcc6be0fc9a0e", 0, "https://example.com/dog9.jpg", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Zara", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { "8171ac7cdb3f42bdbfbd15e926a84801", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateOnly(2020, 6, 10), "1bf7320d672844d085398a24f2dd45ae", 0, "https://example.com/dog6.jpg", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Daisy", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });

            migrationBuilder.InsertData(
                table: "TrainerSkills",
                columns: new[] { "Id", "CreatedTime", "LastUpdatedTime", "SkillId", "TrainerId" },
                values: new object[,]
                {
                    { "1484897e5cc94578a2646268cbe36898", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "5440f3e800b64db8af93b376eea31a31", "2a6e26654e8b437bb44902abd4aabc11" },
                    { "480f1f7db1be49a4a2a0c24aa74ea552", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "ad931be589d34b14babc330447a8b1b3", "0e5d5328b34e4832a9f6361147cec4a5" },
                    { "85d974b7faed4eec858eb1cfadfc0f1c", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "5440f3e800b64db8af93b376eea31a31", "0e5d5328b34e4832a9f6361147cec4a5" },
                    { "988db65696e546db89b26223b56131b2", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "ca6a868a7b8242b9b914a06083a1686e", "0e5d5328b34e4832a9f6361147cec4a5" },
                    { "9a47e71423e54f1fbcde815e5c910bab", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "5641b5bd5c5c4cae9806ad1291d2db91", "0e5d5328b34e4832a9f6361147cec4a5" },
                    { "c40fe1f7c9764575bc7c2b6dde7f5fee", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "5641b5bd5c5c4cae9806ad1291d2db91", "2a6e26654e8b437bb44902abd4aabc11" },
                    { "e30157bcf9a946fbbd0bdfe275da1212", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "113d9b6c850c4d028afb05c159833bd0", "2a6e26654e8b437bb44902abd4aabc11" },
                    { "f6be52a744f940a0965384bd849c4aa8", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "113d9b6c850c4d028afb05c159833bd0", "0e5d5328b34e4832a9f6361147cec4a5" }
                });

            migrationBuilder.InsertData(
                table: "TrainerSpecializations",
                columns: new[] { "Id", "CreatedTime", "LastUpdatedTime", "SpecializaionId", "TrainerId" },
                values: new object[,]
                {
                    { "29edf78f2f414c96bce61c1ac1866a07", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "b08efacd34064a8c899aa004dd1e7a2e", "2a6e26654e8b437bb44902abd4aabc11" },
                    { "4be25cbbc90748d6b51eb82b8b39c4fb", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "6ea6fbf932f34e7798e045fbb4134eaf", "0e5d5328b34e4832a9f6361147cec4a5" },
                    { "55c739ef56f94d44b77d60d7028d1566", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "d6e7c8b072d549d2a7e169ddc9d65bfd", "0e5d5328b34e4832a9f6361147cec4a5" }
                });

            migrationBuilder.InsertData(
                table: "DogDocuments",
                columns: new[] { "Id", "CreatedTime", "Description", "DogDocumentTypeId", "DogId", "ImageUrl", "IssueDate", "LastUpdatedTime", "Name", "Status", "UploadTime" },
                values: new object[,]
                {
                    { "02df8de2eae145078b0b256aead171d6", new DateTimeOffset(new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Annual vaccination record for Bella.", "14df76b885d94fc58791bea6579e9b75", "2781dc1acc834735b66ce458763d8243", "https://example.com/documents/vaccination1.jpg", new DateOnly(2023, 1, 10), new DateTimeOffset(new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Vaccination Record", 1, new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "16071aef889c42e79673befd1c31ad98", new DateTimeOffset(new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Certificate for winning Best in Show.", "9a4a23e4d0ee45399c0cecd117884d10", "651eb45e8e51499d93575445d9deeb06", "https://example.com/documents/show1.jpg", new DateOnly(2019, 12, 1), new DateTimeOffset(new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Show Competition Certificate", 1, new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "272a7ffeac9441789d93d55d3295f31f", new DateTimeOffset(new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Microchip registration for Luna.", "2f3ddc88886344569516a8c28ca8db25", "3b1fdfbf9cfe415bb74d004e699d8d6a", "https://example.com/documents/microchip1.jpg", new DateOnly(2022, 2, 15), new DateTimeOffset(new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Microchip Registration", 1, new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "2aea921128c7478b9dc346e79513794c", new DateTimeOffset(new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Pedigree certificate for Rocky.", "ce6cc50cab6e4125ad4c8ecf118f2710", "195155a83a744a059cf53d56ce8188e3", "https://example.com/documents/pedigree1.jpg", new DateOnly(2020, 9, 1), new DateTimeOffset(new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Pedigree Certificate", 1, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "3d0a77818fcc4695b04932d11895666c", new DateTimeOffset(new DateTime(2019, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Breeding license for Rex.", "694b4222f6f44c798ef302628024ed48", "362ab01dda294c20afc11cf8cd9237e6", "https://example.com/documents/breeding1.jpg", new DateOnly(2019, 10, 1), new DateTimeOffset(new DateTime(2019, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Breeding License", 1, new DateTime(2019, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "a019e279f2d44710b8e890ee78513f2b", new DateTimeOffset(new DateTime(2021, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Health insurance policy for Max.", "e189ddda0d6b406d890e45b70e685e86", "0814372268704f019119b55ddf080fde", "https://example.com/documents/insurance1.jpg", new DateOnly(2021, 8, 5), new DateTimeOffset(new DateTime(2021, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Health Insurance", 1, new DateTime(2021, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "e46b02b02ff745988953a52dce64e78e", new DateTimeOffset(new DateTime(2021, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Basic obedience training certificate for Charlie.", "f5a6678a34e84eb195148dd2417a52cc", "1b6224a40dd1426eb216be3066dc033a", "https://example.com/documents/training1.jpg", new DateOnly(2021, 3, 20), new DateTimeOffset(new DateTime(2021, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Training Certificate", 1, new DateTime(2021, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "ea38f6912588441f9632c9e55f8e3e6a", new DateTimeOffset(new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Therapy dog certification for Zara.", "f8637d62adbc4ccfb7ca009393807918", "7fb679549a7d4f8db6ebd80d5ae6ab7a", "https://example.com/documents/therapy1.jpg", new DateOnly(2021, 4, 1), new DateTimeOffset(new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Therapy Dog Certification", 1, new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "f2e7177fba13450dbf5e48fd98bdec12", new DateTimeOffset(new DateTime(2020, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Adoption papers for Daisy.", "5607931438eb467d87f1de4664e1e2c4", "8171ac7cdb3f42bdbfbd15e926a84801", "https://example.com/documents/adoption1.jpg", new DateOnly(2020, 7, 12), new DateTimeOffset(new DateTime(2020, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Adoption Papers", 1, new DateTime(2020, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "DogOwnerships",
                columns: new[] { "Id", "CreatedTime", "CustomerId", "DogId", "FromDate", "LastUpdatedTime", "ToDate" },
                values: new object[,]
                {
                    { "338f683647a54234913a84b29f3e6bfb", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "c7f3d381e9c84af1ba663d8fc1643de3", "3b1fdfbf9cfe415bb74d004e699d8d6a", new DateOnly(2022, 6, 10), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), null },
                    { "53ee4c514e114ab482b16a47bbd5b789", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "c7f3d381e9c84af1ba663d8fc1643de3", "0814372268704f019119b55ddf080fde", new DateOnly(2020, 4, 20), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), null },
                    { "5b8f2ec9cc594b0784d640ea939531bf", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "c7f3d381e9c84af1ba663d8fc1643de3", "1b6224a40dd1426eb216be3066dc033a", new DateOnly(2021, 9, 5), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), null },
                    { "77058a7897ef436cadd5ca452e959d9e", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "c7f3d381e9c84af1ba663d8fc1643de3", "7fb679549a7d4f8db6ebd80d5ae6ab7a", new DateOnly(2023, 7, 22), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), null },
                    { "7fce6db278f54e3e9ff6565fb6311396", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "07b2d4a69f6b4dc99b3f88e946bdcc12", "195155a83a744a059cf53d56ce8188e3", new DateOnly(2023, 3, 15), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), null },
                    { "969df7c918fa426282c9ff6f3963bd09", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "07b2d4a69f6b4dc99b3f88e946bdcc12", "2781dc1acc834735b66ce458763d8243", new DateOnly(2023, 1, 1), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), null },
                    { "9e2c4d9645684c11831579abae9a8b3c", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "c7f3d381e9c84af1ba663d8fc1643de3", "8171ac7cdb3f42bdbfbd15e926a84801", new DateOnly(2022, 8, 12), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), null },
                    { "ba73daa20d524b69ad40bb11d225de39", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "c7f3d381e9c84af1ba663d8fc1643de3", "651eb45e8e51499d93575445d9deeb06", new DateOnly(2023, 2, 14), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), null },
                    { "ddad90625e534d7c86f6e40bf1e6871e", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "c7f3d381e9c84af1ba663d8fc1643de3", "362ab01dda294c20afc11cf8cd9237e6", new DateOnly(2023, 5, 7), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_PaymentId",
                table: "Enrollments",
                column: "PaymentId",
                unique: true,
                filter: "[PaymentId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Enrollments_PaymentId",
                table: "Enrollments");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "42976d92772e4163b8ea5b12a278a730");

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: "1078f91579d642039b1cff180d2c475f");

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: "c753fa30266f4facb2e0f5aaa02a08c6");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "345fa2ab611e4dc387c9bf25af41e6a9");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "44a2cc197a614ab3aa93a4c706076394");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "bb54bfa8e5644bef9f3c609f5237f533");

            migrationBuilder.DeleteData(
                table: "DogDocuments",
                keyColumn: "Id",
                keyValue: "02df8de2eae145078b0b256aead171d6");

            migrationBuilder.DeleteData(
                table: "DogDocuments",
                keyColumn: "Id",
                keyValue: "16071aef889c42e79673befd1c31ad98");

            migrationBuilder.DeleteData(
                table: "DogDocuments",
                keyColumn: "Id",
                keyValue: "272a7ffeac9441789d93d55d3295f31f");

            migrationBuilder.DeleteData(
                table: "DogDocuments",
                keyColumn: "Id",
                keyValue: "2aea921128c7478b9dc346e79513794c");

            migrationBuilder.DeleteData(
                table: "DogDocuments",
                keyColumn: "Id",
                keyValue: "3d0a77818fcc4695b04932d11895666c");

            migrationBuilder.DeleteData(
                table: "DogDocuments",
                keyColumn: "Id",
                keyValue: "a019e279f2d44710b8e890ee78513f2b");

            migrationBuilder.DeleteData(
                table: "DogDocuments",
                keyColumn: "Id",
                keyValue: "e46b02b02ff745988953a52dce64e78e");

            migrationBuilder.DeleteData(
                table: "DogDocuments",
                keyColumn: "Id",
                keyValue: "ea38f6912588441f9632c9e55f8e3e6a");

            migrationBuilder.DeleteData(
                table: "DogDocuments",
                keyColumn: "Id",
                keyValue: "f2e7177fba13450dbf5e48fd98bdec12");

            migrationBuilder.DeleteData(
                table: "DogOwnerships",
                keyColumn: "Id",
                keyValue: "338f683647a54234913a84b29f3e6bfb");

            migrationBuilder.DeleteData(
                table: "DogOwnerships",
                keyColumn: "Id",
                keyValue: "53ee4c514e114ab482b16a47bbd5b789");

            migrationBuilder.DeleteData(
                table: "DogOwnerships",
                keyColumn: "Id",
                keyValue: "5b8f2ec9cc594b0784d640ea939531bf");

            migrationBuilder.DeleteData(
                table: "DogOwnerships",
                keyColumn: "Id",
                keyValue: "77058a7897ef436cadd5ca452e959d9e");

            migrationBuilder.DeleteData(
                table: "DogOwnerships",
                keyColumn: "Id",
                keyValue: "7fce6db278f54e3e9ff6565fb6311396");

            migrationBuilder.DeleteData(
                table: "DogOwnerships",
                keyColumn: "Id",
                keyValue: "969df7c918fa426282c9ff6f3963bd09");

            migrationBuilder.DeleteData(
                table: "DogOwnerships",
                keyColumn: "Id",
                keyValue: "9e2c4d9645684c11831579abae9a8b3c");

            migrationBuilder.DeleteData(
                table: "DogOwnerships",
                keyColumn: "Id",
                keyValue: "ba73daa20d524b69ad40bb11d225de39");

            migrationBuilder.DeleteData(
                table: "DogOwnerships",
                keyColumn: "Id",
                keyValue: "ddad90625e534d7c86f6e40bf1e6871e");

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: "53cf738dc9bd4b0199f0610f4cba3b20");

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: "d88efe781cc442868bde56d1197a0857");

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: "f0dc4d5f87f64437bfad220514d79c8a");

            migrationBuilder.DeleteData(
                table: "Memberships",
                keyColumn: "Id",
                keyValue: "8ee5738e5b8c4ad4989e97da2deb167c");

            migrationBuilder.DeleteData(
                table: "Memberships",
                keyColumn: "Id",
                keyValue: "d236daf5649b474badefd00538b1726e");

            migrationBuilder.DeleteData(
                table: "TrainerSkills",
                keyColumn: "Id",
                keyValue: "1484897e5cc94578a2646268cbe36898");

            migrationBuilder.DeleteData(
                table: "TrainerSkills",
                keyColumn: "Id",
                keyValue: "480f1f7db1be49a4a2a0c24aa74ea552");

            migrationBuilder.DeleteData(
                table: "TrainerSkills",
                keyColumn: "Id",
                keyValue: "85d974b7faed4eec858eb1cfadfc0f1c");

            migrationBuilder.DeleteData(
                table: "TrainerSkills",
                keyColumn: "Id",
                keyValue: "988db65696e546db89b26223b56131b2");

            migrationBuilder.DeleteData(
                table: "TrainerSkills",
                keyColumn: "Id",
                keyValue: "9a47e71423e54f1fbcde815e5c910bab");

            migrationBuilder.DeleteData(
                table: "TrainerSkills",
                keyColumn: "Id",
                keyValue: "c40fe1f7c9764575bc7c2b6dde7f5fee");

            migrationBuilder.DeleteData(
                table: "TrainerSkills",
                keyColumn: "Id",
                keyValue: "e30157bcf9a946fbbd0bdfe275da1212");

            migrationBuilder.DeleteData(
                table: "TrainerSkills",
                keyColumn: "Id",
                keyValue: "f6be52a744f940a0965384bd849c4aa8");

            migrationBuilder.DeleteData(
                table: "TrainerSpecializations",
                keyColumn: "Id",
                keyValue: "29edf78f2f414c96bce61c1ac1866a07");

            migrationBuilder.DeleteData(
                table: "TrainerSpecializations",
                keyColumn: "Id",
                keyValue: "4be25cbbc90748d6b51eb82b8b39c4fb");

            migrationBuilder.DeleteData(
                table: "TrainerSpecializations",
                keyColumn: "Id",
                keyValue: "55c739ef56f94d44b77d60d7028d1566");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "07b2d4a69f6b4dc99b3f88e946bdcc12");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "0e5d5328b34e4832a9f6361147cec4a5");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "2a6e26654e8b437bb44902abd4aabc11");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "4e5bb244a9a146fd8571d43c41cb9e7d");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "71d074d4fba0409789bc0be8d1d35fbe");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "c7f3d381e9c84af1ba663d8fc1643de3");

            migrationBuilder.DeleteData(
                table: "DogDocumentTypes",
                keyColumn: "Id",
                keyValue: "14df76b885d94fc58791bea6579e9b75");

            migrationBuilder.DeleteData(
                table: "DogDocumentTypes",
                keyColumn: "Id",
                keyValue: "2f3ddc88886344569516a8c28ca8db25");

            migrationBuilder.DeleteData(
                table: "DogDocumentTypes",
                keyColumn: "Id",
                keyValue: "5607931438eb467d87f1de4664e1e2c4");

            migrationBuilder.DeleteData(
                table: "DogDocumentTypes",
                keyColumn: "Id",
                keyValue: "694b4222f6f44c798ef302628024ed48");

            migrationBuilder.DeleteData(
                table: "DogDocumentTypes",
                keyColumn: "Id",
                keyValue: "9a4a23e4d0ee45399c0cecd117884d10");

            migrationBuilder.DeleteData(
                table: "DogDocumentTypes",
                keyColumn: "Id",
                keyValue: "ce6cc50cab6e4125ad4c8ecf118f2710");

            migrationBuilder.DeleteData(
                table: "DogDocumentTypes",
                keyColumn: "Id",
                keyValue: "e189ddda0d6b406d890e45b70e685e86");

            migrationBuilder.DeleteData(
                table: "DogDocumentTypes",
                keyColumn: "Id",
                keyValue: "f5a6678a34e84eb195148dd2417a52cc");

            migrationBuilder.DeleteData(
                table: "DogDocumentTypes",
                keyColumn: "Id",
                keyValue: "f8637d62adbc4ccfb7ca009393807918");

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: "0814372268704f019119b55ddf080fde");

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: "195155a83a744a059cf53d56ce8188e3");

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: "1b6224a40dd1426eb216be3066dc033a");

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: "2781dc1acc834735b66ce458763d8243");

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: "362ab01dda294c20afc11cf8cd9237e6");

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: "3b1fdfbf9cfe415bb74d004e699d8d6a");

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: "651eb45e8e51499d93575445d9deeb06");

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: "7fb679549a7d4f8db6ebd80d5ae6ab7a");

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: "8171ac7cdb3f42bdbfbd15e926a84801");

            migrationBuilder.DeleteData(
                table: "EquipmentCategories",
                keyColumn: "Id",
                keyValue: "62b0e81cdbf245868bd96d377c56cda1");

            migrationBuilder.DeleteData(
                table: "EquipmentCategories",
                keyColumn: "Id",
                keyValue: "6e3bb6ea334e4e2dab1a9720f9a4a0aa");

            migrationBuilder.DeleteData(
                table: "EquipmentCategories",
                keyColumn: "Id",
                keyValue: "ef43ef70bde9451c974fbc1b4c8a6832");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "dfbdc8373d054d09bc629dcbc2525b89");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "113d9b6c850c4d028afb05c159833bd0");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "5440f3e800b64db8af93b376eea31a31");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "5641b5bd5c5c4cae9806ad1291d2db91");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "ad931be589d34b14babc330447a8b1b3");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "ca6a868a7b8242b9b914a06083a1686e");

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: "6ea6fbf932f34e7798e045fbb4134eaf");

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: "b08efacd34064a8c899aa004dd1e7a2e");

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: "d6e7c8b072d549d2a7e169ddc9d65bfd");

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: "1479503ca2654f82bd01fb746470b2c8");

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: "1bf7320d672844d085398a24f2dd45ae");

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: "1cc5474159884e23b137f071da963986");

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: "6f8afc331e334abcb087192f20ce3b1c");

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: "85ca97017702447c884b3cc7d6098c95");

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: "96b72a0dba7144c183fb86a64ad07529");

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: "c3048dfc30f64262ad9dcc6be0fc9a0e");

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: "cb7c47d7a3814e9681ba93aba9843ab9");

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: "d481d89a45e34941a88ff83a753866fe");

            migrationBuilder.DeleteData(
                table: "Memberships",
                keyColumn: "Id",
                keyValue: "8a0f1e3944754b42acb05bd518b301c6");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "188c604ae9094fce85e674fce6659f93");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2b24f6c45be6409ea5d0766ee511e94b");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "4f3f5e24b4944644a340220289845af0");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "7fd97273f51f4186bc9f43eb39205e4e");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "92c787c689284631847c4434c0adbe10");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "9f7f12b6c79045689f5c222c7112d1d0");

            migrationBuilder.DeleteData(
                table: "DogTypes",
                keyColumn: "Id",
                keyValue: "6b7882fbc5404bdfa0009b77b046e7c7");

            migrationBuilder.DeleteData(
                table: "DogTypes",
                keyColumn: "Id",
                keyValue: "8de741cc92a64f379cea87657d6067d8");

            migrationBuilder.DeleteData(
                table: "DogTypes",
                keyColumn: "Id",
                keyValue: "acde7ed7484949d18903632891dfb9c7");

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
                name: "PaymentId",
                table: "Enrollments",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedTime", "Description", "LastUpdatedTime", "Name", "Status" },
                values: new object[,]
                {
                    { "229062ca29c3431da81cb19330864ab6", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Focuses on advanced obedience and specialized training techniques.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Advanced Training", 1 },
                    { "5ea53ae1533045098ea3fee913a1f30b", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Covers fundamental obedience commands and essential skills.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Basic Training", 1 },
                    { "d9b9141bfe934bcd8fdea80d80024335", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Addresses problem behaviors and corrective training for dogs.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Behavioral Modification", 1 }
                });

            migrationBuilder.InsertData(
                table: "DogDocumentTypes",
                columns: new[] { "Id", "CreatedTime", "Description", "LastUpdatedTime", "Name" },
                values: new object[,]
                {
                    { "1066b59049254284b3ce51e86faa9073", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Certificate proving the dog has completed a training program.", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Training Certificate" },
                    { "3f50a4d5e2b249b9a537bd1bb570684d", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Legal documents for the adoption of the dog.", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Adoption Papers" },
                    { "499eeaadf9dc4179ae07f842173075c8", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Document detailing the dog's health insurance policy.", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Health Insurance" },
                    { "53af93d0b0c84fd9a6c6a4416c09bcf7", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Certificate awarded for participation or winning in dog shows.", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Show Competition Certificate" },
                    { "78fccf4b8f0046f68083e21398b4ee44", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Certification proving the dog is qualified as a therapy dog.", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Therapy Dog Certification" },
                    { "7d40977b7c17477a85cddaca84d62a27", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Document containing vaccination history of the dog.", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Vaccination Record" },
                    { "bbb79679653f4a16b2c3fed1dbd07dd2", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Document containing the dog's microchip details.", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Microchip Registration" },
                    { "e45d4bfb9a9845ad8db598e9b2c7eea9", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Official document proving the dog's lineage and breed.", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Pedigree Certificate" },
                    { "ecf71e62101d4442a60436f7df2c7d1c", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Official license permitting the dog to be used for breeding.", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Breeding License" }
                });

            migrationBuilder.InsertData(
                table: "DogTypes",
                columns: new[] { "Id", "CreatedTime", "Description", "LastUpdatedTime", "Name", "Status" },
                values: new object[,]
                {
                    { "2fbb4148d458490f8070d8dc035aa5dd", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Small-sized dog breeds", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Small", 1 },
                    { "9bd33d4e6dd648d9b083c4d2c5b09664", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Medium-sized dog breeds", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Medium", 1 },
                    { "e665231013f64a98bd327f5f10cb8cb2", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Large-sized dog breeds", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Large", 1 }
                });

            migrationBuilder.InsertData(
                table: "EquipmentCategories",
                columns: new[] { "Id", "CreatedTime", "Description", "LastUpdatedTime", "Name", "Status" },
                values: new object[,]
                {
                    { "3c075f36cfb9437080aadb225cb79af2", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Protective gear for dogs, such as harnesses and pads.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Safety Gear", 1 },
                    { "4126947fd3b14b619da67eb89429a5ed", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Equipment used for dog training and obedience exercises.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Training Tools", 1 },
                    { "811a6c0a30f347aeb78bd1ebe60e3d8b", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Tools used for dog grooming, including brushes and clippers.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Grooming Equipment", 1 }
                });

            migrationBuilder.InsertData(
                table: "Memberships",
                columns: new[] { "Id", "CreatedTime", "Description", "DiscountAmount", "LastUpdatedTime", "Name", "RequiredPoints" },
                values: new object[,]
                {
                    { "383a57689bca49bc8eafcaf6a6ea5223", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Premium membership", 10m, new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Gold", 500 },
                    { "9079125b57c24172a6bdbd93e57b773a", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Entry-level membership", 0m, new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Basic", 0 },
                    { "de6d8d32ea20416e8977b379af19e1c9", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Elite membership", 20m, new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Platinum", 1000 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedTime", "Description", "LastUpdatedTime", "Name", "Status" },
                values: new object[,]
                {
                    { "11636589263b4d02bfc76274a79a7389", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Individual customer who can enroll in courses", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Customer_Individual", 1 },
                    { "31fb40f62bfc46d7afa45004bd8afbf7", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Trainer responsible for courses and lessons", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Trainer_Member", 1 },
                    { "454c38771b314dc8b5740866d50b7e6d", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Organizational customer who can enroll in courses", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Customer_Organizational", 1 },
                    { "8386c80ab733490f9590cd33e7b8693e", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "System administrator with full access", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Admin", 1 },
                    { "91dda1b2faef42148307abd2b5076d2d", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Lead trainer responsible for courses and lessons", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Trainer_Lead", 1 },
                    { "9919ed061db041439a2408bd9243ac36", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Staff manager member managing operations", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Staff_Manager", 1 },
                    { "d756577e393b4547ba0ecbd250b93f10", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Staff employee member managing operations", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Staff_Employee", 1 }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "CreatedTime", "Description", "LastUpdatedTime", "Name", "Status" },
                values: new object[,]
                {
                    { "083e69770573496688be1285b1f1e945", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Addressing and correcting unwanted behaviors in dogs.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Behavioral Correction", 1 },
                    { "1ea762aa323b45fd9110244af37010eb", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Enhancing a dog's physical abilities and responsiveness through obstacle courses.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Agility Training", 1 },
                    { "4e133f0a7e114d4289fdef8dfc6258e1", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Training dogs to follow basic commands like sit, stay, and come.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Basic Commands", 1 },
                    { "4fd46a8b17594280883fca26fdd24e7f", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Helping dogs become comfortable around other animals and people.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Socialization", 1 },
                    { "ef0fc3df708444359bb0686a236ad1c2", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Training dogs for guarding and protective behavior.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Protection Training", 1 }
                });

            migrationBuilder.InsertData(
                table: "Specializations",
                columns: new[] { "Id", "CreatedTime", "Description", "LastUpdatedTime", "Name" },
                values: new object[,]
                {
                    { "00033bececfa4e6781c124bf58a3d9df", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Helping dogs overcome behavioral issues.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Behavioral Therapy" },
                    { "4806039abc1e42ac93ec89858a5fe219", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Basic and advanced obedience training for dogs.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Obedience Training" },
                    { "7e565885baea4e85a6c9956008d8793e", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Training dogs for agility courses and competitions.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Agility Training" }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Address", "CreatedTime", "DateOfBirth", "Email", "FullName", "Gender", "ImageUrl", "LastUpdatedTime", "MembershipId", "MembershipPoints", "Password", "PhoneNumber", "RegistrationTime", "RoleId", "Status", "Username" },
                values: new object[,]
                {
                    { "122a2367f61d4fc39942401f98c0b091", "Admin Address", new DateTimeOffset(new DateTime(2025, 3, 23, 15, 17, 48, 974, DateTimeKind.Unspecified).AddTicks(4468), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", "Admin User", 1, "empty", new DateTimeOffset(new DateTime(2025, 3, 23, 15, 17, 48, 974, DateTimeKind.Unspecified).AddTicks(4468), new TimeSpan(0, 7, 0, 0, 0)), "9079125b57c24172a6bdbd93e57b773a", 0, "$2a$11$.sGduvrfyXYmSnNkg5SjGeGRJh1bz2/KwqpnlGpGlDLoTxhxMtJpi", "0123456789", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8386c80ab733490f9590cd33e7b8693e", 1, "admin" },
                    { "1d49901920b044a18ec07fd8962fa524", "Staff Employee Address", new DateTimeOffset(new DateTime(2025, 3, 23, 15, 17, 49, 545, DateTimeKind.Unspecified).AddTicks(3077), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1988, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff_employee@gmail.com", "Staff Employee", 1, "empty", new DateTimeOffset(new DateTime(2025, 3, 23, 15, 17, 49, 545, DateTimeKind.Unspecified).AddTicks(3077), new TimeSpan(0, 7, 0, 0, 0)), "9079125b57c24172a6bdbd93e57b773a", 0, "$2a$11$wI0Ms40oG6CahwwW9ptUku53fUQybGR32cUkxj2htjy2cOen30vKm", "0966332211", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "d756577e393b4547ba0ecbd250b93f10", 1, "staff_employee" },
                    { "29bdbfb25b5940deabffc03f9220384a", "Staff Manager Address", new DateTimeOffset(new DateTime(2025, 3, 23, 15, 17, 49, 660, DateTimeKind.Unspecified).AddTicks(8481), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1980, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff_manager@gmail.com", "Staff Manager", 1, "empty", new DateTimeOffset(new DateTime(2025, 3, 23, 15, 17, 49, 660, DateTimeKind.Unspecified).AddTicks(8481), new TimeSpan(0, 7, 0, 0, 0)), "9079125b57c24172a6bdbd93e57b773a", 0, "$2a$11$uVQrEwZWTIaxs1fEo5Ixd.cQhA4y7EdOA4CtbOTYHUuNjkcp7PJVW", "0955223344", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9919ed061db041439a2408bd9243ac36", 1, "staff_manager" },
                    { "7f5e6dc5ac3341ecbd9d8ec3447f02fd", "Trainer Member Address", new DateTimeOffset(new DateTime(2025, 3, 23, 15, 17, 49, 87, DateTimeKind.Unspecified).AddTicks(8656), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1985, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "trainer_member@gmail.com", "Trainer Member", 1, "empty", new DateTimeOffset(new DateTime(2025, 3, 23, 15, 17, 49, 87, DateTimeKind.Unspecified).AddTicks(8656), new TimeSpan(0, 7, 0, 0, 0)), "9079125b57c24172a6bdbd93e57b773a", 0, "$2a$11$B9Pi77WlOW8LGxMMj4vrJeRssjIdUxzTZuwyYuIGEUovTK1ogrRyW", "0987654321", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "31fb40f62bfc46d7afa45004bd8afbf7", 1, "trainer_member" },
                    { "9642834e791942fb921626f63e861788", "Customer Organization Address", new DateTimeOffset(new DateTime(2025, 3, 23, 15, 17, 49, 431, DateTimeKind.Unspecified).AddTicks(3477), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1992, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer_organization@gmail.com", "Customer Organization", 2, "empty", new DateTimeOffset(new DateTime(2025, 3, 23, 15, 17, 49, 431, DateTimeKind.Unspecified).AddTicks(3477), new TimeSpan(0, 7, 0, 0, 0)), "9079125b57c24172a6bdbd93e57b773a", 200, "$2a$11$O9xxu/SkkuvSeNa/Dj5aau6SlenYeSxgWJnAYKFnTJseNU74w0mVy", "0977554433", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "454c38771b314dc8b5740866d50b7e6d", 1, "customer_organization" },
                    { "993e61e00c234f299953104f97b28e8d", "Trainer Lead Address", new DateTimeOffset(new DateTime(2025, 3, 23, 15, 17, 49, 202, DateTimeKind.Unspecified).AddTicks(3844), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1983, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "trainer_lead@gmail.com", "Trainer Lead", 1, "empty", new DateTimeOffset(new DateTime(2025, 3, 23, 15, 17, 49, 202, DateTimeKind.Unspecified).AddTicks(3844), new TimeSpan(0, 7, 0, 0, 0)), "9079125b57c24172a6bdbd93e57b773a", 0, "$2a$11$LgkjjU3JklfyDhmIq8WtleSqHBEF1trfVTq7igCYia2QDVZN0nY7q", "0911223344", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "91dda1b2faef42148307abd2b5076d2d", 1, "trainer_lead" },
                    { "ce6705ada2414b8c8e24252352ce2be0", "Customer Individual Address", new DateTimeOffset(new DateTime(2025, 3, 23, 15, 17, 49, 317, DateTimeKind.Unspecified).AddTicks(5301), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1995, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer_individual@gmail.com", "Customer Individual", 2, "empty", new DateTimeOffset(new DateTime(2025, 3, 23, 15, 17, 49, 317, DateTimeKind.Unspecified).AddTicks(5301), new TimeSpan(0, 7, 0, 0, 0)), "9079125b57c24172a6bdbd93e57b773a", 100, "$2a$11$PwbPKQ6Atk1szpwTcR.eNeWnG2V0YJ.VNbTSmLqf2lSy8s7lVvsXK", "0988112233", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "11636589263b4d02bfc76274a79a7389", 1, "customer_individual" }
                });

            migrationBuilder.InsertData(
                table: "DogBreeds",
                columns: new[] { "Id", "CreatedTime", "Description", "DogTypeId", "LastUpdatedTime", "Name", "Status" },
                values: new object[,]
                {
                    { "21fe03b22c2b4073830cd0fbd49546d0", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A friendly and intelligent medium-sized breed.", "9bd33d4e6dd648d9b083c4d2c5b09664", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Cocker Spaniel", 1 },
                    { "305708254efa4e8d923e8fae6008a489", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A highly intelligent and energetic breed.", "9bd33d4e6dd648d9b083c4d2c5b09664", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Border Collie", 1 },
                    { "392e2bd16f174f7fa41a14216f309aaa", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A curious and friendly breed known for its great sense of smell.", "9bd33d4e6dd648d9b083c4d2c5b09664", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Beagle", 1 },
                    { "6f8157e6a2ec4b05b72cb821b452993f", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A small, muscular dog with a distinctive bat-like ear shape.", "2fbb4148d458490f8070d8dc035aa5dd", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "French Bulldog", 1 },
                    { "70e1f2c357db4251a491f0312f66eab2", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A friendly and intelligent large breed.", "e665231013f64a98bd327f5f10cb8cb2", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Golden Retriever", 1 },
                    { "7a9e6ae123634532ab66abe5a2372e0e", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A strong and intelligent breed used in working roles.", "e665231013f64a98bd327f5f10cb8cb2", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "German Shepherd", 1 },
                    { "8bcc9e0632484b94a2c04c8ed6affd15", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A fluffy and energetic small breed.", "2fbb4148d458490f8070d8dc035aa5dd", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Pomeranian", 1 },
                    { "94395769159244a0a7a015d683ccc7b1", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A loyal and protective breed, often used as a guard dog.", "e665231013f64a98bd327f5f10cb8cb2", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Rottweiler", 1 },
                    { "d1ea563a9e784ea7a977e5ef2e9c7908", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A tiny breed known for its lively personality.", "2fbb4148d458490f8070d8dc035aa5dd", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Chihuahua", 1 }
                });

            migrationBuilder.InsertData(
                table: "Equipments",
                columns: new[] { "Id", "CreatedTime", "Description", "EquipmentCategoryId", "LastUpdatedTime", "Name", "Status" },
                values: new object[,]
                {
                    { "21f1aa58123b4e3586b72f91e4dcb8b1", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A clicker used for positive reinforcement training.", "4126947fd3b14b619da67eb89429a5ed", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Training Clicker", 1 },
                    { "6750fbed19a54839a338f55350ded3be", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A brush for maintaining a dog's coat and hygiene.", "811a6c0a30f347aeb78bd1ebe60e3d8b", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Grooming Brush", 1 },
                    { "add3ab3c7a024750801e5cc27f6184e5", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A comfortable harness designed for safety and control.", "3c075f36cfb9437080aadb225cb79af2", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Dog Harness", 1 }
                });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "Content", "CreatedTime", "ImageUrl", "LastUpdatedTime", "StaffId", "Status", "TimePublished", "Title" },
                values: new object[,]
                {
                    { "3e8b68ca2e274bc1ae0316d7dbbb63a5", "Training your dog is crucial for a harmonious relationship between pet and owner...", new DateTimeOffset(new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/blog1.jpg", new DateTimeOffset(new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "1d49901920b044a18ec07fd8962fa524", 1, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Importance of Dog Training" },
                    { "b34ae1ab13a84151a5e76d198f3b73e7", "Providing a balanced diet is essential for your dog's overall health and well-being...", new DateTimeOffset(new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/blog2.jpg", new DateTimeOffset(new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "29bdbfb25b5940deabffc03f9220384a", 1, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Understanding Canine Nutrition" }
                });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "Id", "CreatedTime", "DateOfBirth", "DogBreedId", "Gender", "ImageUrl", "LastUpdatedTime", "Name", "RegistrationTime", "Status" },
                values: new object[,]
                {
                    { "18606b92bd3f452b80ee531b4af16d83", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateOnly(2019, 12, 5), "21fe03b22c2b4073830cd0fbd49546d0", 1, "https://example.com/dog4.jpg", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Charlie", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { "26845efced4d4e94b85302a2e407f1ee", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateOnly(2019, 9, 14), "7a9e6ae123634532ab66abe5a2372e0e", 1, "https://example.com/dog8.jpg", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Rex", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { "40f2d18b4e30437d8d3c014da06593bd", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateOnly(2021, 7, 18), "305708254efa4e8d923e8fae6008a489", 1, "https://example.com/dog5.jpg", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Max", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { "55fbd19084b3451eb7a78365e25d463c", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateOnly(2021, 3, 8), "94395769159244a0a7a015d683ccc7b1", 0, "https://example.com/dog9.jpg", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Zara", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { "90aa65b70d154038b4a44ef9c0f5b622", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateOnly(2018, 11, 25), "70e1f2c357db4251a491f0312f66eab2", 1, "https://example.com/dog7.jpg", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Buddy", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { "d6339b0f956f454782d9757cd8a3a6cb", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateOnly(2020, 8, 22), "8bcc9e0632484b94a2c04c8ed6affd15", 1, "https://example.com/dog2.jpg", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Rocky", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { "de005750c7724e90bb0ddb5dcc24ee72", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateOnly(2020, 6, 10), "392e2bd16f174f7fa41a14216f309aaa", 0, "https://example.com/dog6.jpg", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Daisy", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { "ebea772a78294fc4900243bd52427f7c", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateOnly(2022, 1, 30), "6f8157e6a2ec4b05b72cb821b452993f", 0, "https://example.com/dog3.jpg", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Luna", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { "ee8136fbdeaa4977b793e6f9f65adf15", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateOnly(2021, 5, 15), "d1ea563a9e784ea7a977e5ef2e9c7908", 0, "https://example.com/dog1.jpg", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Bella", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });

            migrationBuilder.InsertData(
                table: "TrainerSkills",
                columns: new[] { "Id", "CreatedTime", "LastUpdatedTime", "SkillId", "TrainerId" },
                values: new object[,]
                {
                    { "1db6cc5373774023b23f4664cf1b33a2", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "4fd46a8b17594280883fca26fdd24e7f", "993e61e00c234f299953104f97b28e8d" },
                    { "1fda5b771ba0473786ae9cc997d757ae", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "083e69770573496688be1285b1f1e945", "993e61e00c234f299953104f97b28e8d" },
                    { "a32a002cd5fe4c9493af5fffaba5934a", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "1ea762aa323b45fd9110244af37010eb", "7f5e6dc5ac3341ecbd9d8ec3447f02fd" },
                    { "c7f958e9660e44c29ba93a4117d3aa8f", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "1ea762aa323b45fd9110244af37010eb", "993e61e00c234f299953104f97b28e8d" },
                    { "eb10c5eddcb240c3ad2330565ccf7165", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "ef0fc3df708444359bb0686a236ad1c2", "993e61e00c234f299953104f97b28e8d" },
                    { "f243e661c40a404ab7f6abbe075337db", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "4e133f0a7e114d4289fdef8dfc6258e1", "993e61e00c234f299953104f97b28e8d" },
                    { "fbb9ab6da5c44555a3ca858c562a84d0", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "083e69770573496688be1285b1f1e945", "7f5e6dc5ac3341ecbd9d8ec3447f02fd" },
                    { "fc0b8dd7916e489ea35f9f12e68dd0e3", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "4e133f0a7e114d4289fdef8dfc6258e1", "7f5e6dc5ac3341ecbd9d8ec3447f02fd" }
                });

            migrationBuilder.InsertData(
                table: "TrainerSpecializations",
                columns: new[] { "Id", "CreatedTime", "LastUpdatedTime", "SpecializaionId", "TrainerId" },
                values: new object[,]
                {
                    { "1538a838406245b7b487b9e7965e6c04", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "4806039abc1e42ac93ec89858a5fe219", "7f5e6dc5ac3341ecbd9d8ec3447f02fd" },
                    { "36e1fb0384e4475090561557cf5a661c", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "7e565885baea4e85a6c9956008d8793e", "993e61e00c234f299953104f97b28e8d" },
                    { "eb576b22c7b34d66a357f22276826225", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "00033bececfa4e6781c124bf58a3d9df", "993e61e00c234f299953104f97b28e8d" }
                });

            migrationBuilder.InsertData(
                table: "DogDocuments",
                columns: new[] { "Id", "CreatedTime", "Description", "DogDocumentTypeId", "DogId", "ImageUrl", "IssueDate", "LastUpdatedTime", "Name", "Status", "UploadTime" },
                values: new object[,]
                {
                    { "05b7fd53aa39437eb498858be9fe6919", new DateTimeOffset(new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Pedigree certificate for Rocky.", "e45d4bfb9a9845ad8db598e9b2c7eea9", "d6339b0f956f454782d9757cd8a3a6cb", "https://example.com/documents/pedigree1.jpg", new DateOnly(2020, 9, 1), new DateTimeOffset(new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Pedigree Certificate", 1, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "35f9cd689ead4b918d94cc34edef3af1", new DateTimeOffset(new DateTime(2021, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Health insurance policy for Max.", "499eeaadf9dc4179ae07f842173075c8", "40f2d18b4e30437d8d3c014da06593bd", "https://example.com/documents/insurance1.jpg", new DateOnly(2021, 8, 5), new DateTimeOffset(new DateTime(2021, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Health Insurance", 1, new DateTime(2021, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "4d80e995169b446a93aa7abb707ab4b9", new DateTimeOffset(new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Certificate for winning Best in Show.", "53af93d0b0c84fd9a6c6a4416c09bcf7", "90aa65b70d154038b4a44ef9c0f5b622", "https://example.com/documents/show1.jpg", new DateOnly(2019, 12, 1), new DateTimeOffset(new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Show Competition Certificate", 1, new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "4f2f79a7f3144955b01bb99a8a6babc7", new DateTimeOffset(new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Therapy dog certification for Zara.", "78fccf4b8f0046f68083e21398b4ee44", "55fbd19084b3451eb7a78365e25d463c", "https://example.com/documents/therapy1.jpg", new DateOnly(2021, 4, 1), new DateTimeOffset(new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Therapy Dog Certification", 1, new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "6e17b4da4e7a4c44a51be4bb606c66bb", new DateTimeOffset(new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Annual vaccination record for Bella.", "7d40977b7c17477a85cddaca84d62a27", "ee8136fbdeaa4977b793e6f9f65adf15", "https://example.com/documents/vaccination1.jpg", new DateOnly(2023, 1, 10), new DateTimeOffset(new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Vaccination Record", 1, new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "8544b1cc46a142e6a3c3b7ca73ca5981", new DateTimeOffset(new DateTime(2021, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Basic obedience training certificate for Charlie.", "1066b59049254284b3ce51e86faa9073", "18606b92bd3f452b80ee531b4af16d83", "https://example.com/documents/training1.jpg", new DateOnly(2021, 3, 20), new DateTimeOffset(new DateTime(2021, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Training Certificate", 1, new DateTime(2021, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "87e7d0e4ca15471c97cc59791cccc7da", new DateTimeOffset(new DateTime(2019, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Breeding license for Rex.", "ecf71e62101d4442a60436f7df2c7d1c", "26845efced4d4e94b85302a2e407f1ee", "https://example.com/documents/breeding1.jpg", new DateOnly(2019, 10, 1), new DateTimeOffset(new DateTime(2019, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Breeding License", 1, new DateTime(2019, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "908437d382a540178aec10ff5cfc7551", new DateTimeOffset(new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Microchip registration for Luna.", "bbb79679653f4a16b2c3fed1dbd07dd2", "ebea772a78294fc4900243bd52427f7c", "https://example.com/documents/microchip1.jpg", new DateOnly(2022, 2, 15), new DateTimeOffset(new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Microchip Registration", 1, new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "c5c11b31551640b78030f47e2bad9ba7", new DateTimeOffset(new DateTime(2020, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Adoption papers for Daisy.", "3f50a4d5e2b249b9a537bd1bb570684d", "de005750c7724e90bb0ddb5dcc24ee72", "https://example.com/documents/adoption1.jpg", new DateOnly(2020, 7, 12), new DateTimeOffset(new DateTime(2020, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Adoption Papers", 1, new DateTime(2020, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "DogOwnerships",
                columns: new[] { "Id", "CreatedTime", "CustomerId", "DogId", "FromDate", "LastUpdatedTime", "ToDate" },
                values: new object[,]
                {
                    { "192100f6691c45c0b2fa56943f363c00", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "9642834e791942fb921626f63e861788", "55fbd19084b3451eb7a78365e25d463c", new DateOnly(2023, 7, 22), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), null },
                    { "28e4a9c00b5042f5abae533d9cf768ca", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "9642834e791942fb921626f63e861788", "40f2d18b4e30437d8d3c014da06593bd", new DateOnly(2020, 4, 20), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), null },
                    { "3204f7e935164436926187379dc3fb0c", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "ce6705ada2414b8c8e24252352ce2be0", "ee8136fbdeaa4977b793e6f9f65adf15", new DateOnly(2023, 1, 1), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), null },
                    { "4691ec2092ec473ebe3fe69d3635a8f1", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "9642834e791942fb921626f63e861788", "18606b92bd3f452b80ee531b4af16d83", new DateOnly(2021, 9, 5), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), null },
                    { "5cbd34b869764514ba6d14c323645446", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "9642834e791942fb921626f63e861788", "90aa65b70d154038b4a44ef9c0f5b622", new DateOnly(2023, 2, 14), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), null },
                    { "769e4a7d585a4b029987be18936a19cf", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "9642834e791942fb921626f63e861788", "26845efced4d4e94b85302a2e407f1ee", new DateOnly(2023, 5, 7), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), null },
                    { "b1ead9a570a642eea5c2e8e12dda9435", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "ce6705ada2414b8c8e24252352ce2be0", "d6339b0f956f454782d9757cd8a3a6cb", new DateOnly(2023, 3, 15), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), null },
                    { "b881dad9f0fd435796b66d35e1873728", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "9642834e791942fb921626f63e861788", "de005750c7724e90bb0ddb5dcc24ee72", new DateOnly(2022, 8, 12), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), null },
                    { "fbfe836c4fbb44b3a0d8929f4566f3a0", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "9642834e791942fb921626f63e861788", "ebea772a78294fc4900243bd52427f7c", new DateOnly(2022, 6, 10), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_PaymentId",
                table: "Enrollments",
                column: "PaymentId",
                unique: true);
        }
    }
}
