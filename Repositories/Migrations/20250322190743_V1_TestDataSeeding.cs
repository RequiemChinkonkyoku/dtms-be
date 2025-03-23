using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class V1_TestDataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "2a3ca79933754a188ed32f92b0639154");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "6e6c6879bdbd4eda95eabaa0a4deb644");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "70d59276498f49748e451dcf925e7f7a");

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: "8a21643bd65d40e5bf09daa9dd3f4d3d");

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: "dfb0779952e14b6b87cf42821c5b6afd");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "074331c90d924b679540de3604ee8e22");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "7e681e1e54964f89bf5ece80a54d5d91");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "f650d51e96ab4e66ade4d0caab849ad5");

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: "0a925e3eff584e48b84e6b098319687d");

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: "2ff60634dea446c88c159bb87d0de94e");

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: "3afde6508f7b4d63843a1dbe878f4f0b");

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: "40170854e9084344bfec166a3fb7a056");

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: "58a3df2a0b06420cbaecf313278087b8");

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: "6453f1736bba4bee97daae688100f9af");

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: "836367f23920461ca32e9069070c6f53");

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: "c5497915823f45e5a14aff3464317448");

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: "fdecf1eb56094101be41484ed096278f");

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: "88a9e2dc2c0846b495e7191e0f52f83d");

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: "9c925913737b4bc7871872e4b79ecd4f");

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: "b0d3c858893a471a8482912b92d96fb3");

            migrationBuilder.DeleteData(
                table: "Memberships",
                keyColumn: "Id",
                keyValue: "0a98c1872bc744a881a9f61377113dc5");

            migrationBuilder.DeleteData(
                table: "Memberships",
                keyColumn: "Id",
                keyValue: "5ac3f848c7f147748108dede0fcbd253");

            migrationBuilder.DeleteData(
                table: "TrainerSkills",
                keyColumn: "Id",
                keyValue: "065115fa32c14221834dda9e02cd27a5");

            migrationBuilder.DeleteData(
                table: "TrainerSkills",
                keyColumn: "Id",
                keyValue: "28e8f28d9cd84dc3b449c6d80bc82645");

            migrationBuilder.DeleteData(
                table: "TrainerSkills",
                keyColumn: "Id",
                keyValue: "31b913a1445241e6bab8cf0c18f98ec4");

            migrationBuilder.DeleteData(
                table: "TrainerSkills",
                keyColumn: "Id",
                keyValue: "4c969dbb3ad944a191e06d13e977c2b5");

            migrationBuilder.DeleteData(
                table: "TrainerSkills",
                keyColumn: "Id",
                keyValue: "8bae6933ee7f4495a41911966da9531a");

            migrationBuilder.DeleteData(
                table: "TrainerSkills",
                keyColumn: "Id",
                keyValue: "99462620bb464af7861fdb24a979a4ff");

            migrationBuilder.DeleteData(
                table: "TrainerSkills",
                keyColumn: "Id",
                keyValue: "e6598dac50d84ed7be84439a24b8375e");

            migrationBuilder.DeleteData(
                table: "TrainerSkills",
                keyColumn: "Id",
                keyValue: "ed1e3b5ccc8041ba994cdf25e4f85701");

            migrationBuilder.DeleteData(
                table: "TrainerSpecializations",
                keyColumn: "Id",
                keyValue: "52f84238431443879952d07cb1db1cee");

            migrationBuilder.DeleteData(
                table: "TrainerSpecializations",
                keyColumn: "Id",
                keyValue: "b3cf44e6a71e4232b564ae0b605f9e73");

            migrationBuilder.DeleteData(
                table: "TrainerSpecializations",
                keyColumn: "Id",
                keyValue: "ccf81cd58f4542b992ed66fb5ca7c468");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "487ff6733f744e7fb463f798aba71aac");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "b248df6a92fa4ff39f55a5f1adfa4e31");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "e215168a275343f98be776a8fb04f524");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "e2bdbe109e0540038408482d1cdd72bb");

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: "1f101afd44a6447d9064599f96b1e530");

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: "79a3f28be0344a0498a7f7ec03172955");

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: "861e56d5ddef49f2a8ff3360f3fbe0af");

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: "978ea62fbcd4420182442b5b6f741838");

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: "a1dbc666d6d84f368b66374d0d176ef8");

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: "cf311aaa80ff4b519a74a27bf70ff0f0");

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: "d1b97ca81a174f34973b734bbd74c4a4");

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: "dac1b6fecdcb488e87c66ce960ce2389");

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: "f2bfa8e2300240158899d67c2c3f04d6");

            migrationBuilder.DeleteData(
                table: "EquipmentCategories",
                keyColumn: "Id",
                keyValue: "673423aadf624ec08c561f249568f58a");

            migrationBuilder.DeleteData(
                table: "EquipmentCategories",
                keyColumn: "Id",
                keyValue: "6e25b02e093a449c829a88f81cba48fa");

            migrationBuilder.DeleteData(
                table: "EquipmentCategories",
                keyColumn: "Id",
                keyValue: "8d5c841ceade4758bd5c6d396a9c89f9");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "26b6cd4d55ed45e788934ade76b8374f");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "ae835011a12645c493d47bba2c8e3cba");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "f97ad2d96c334c7eb8ce225df47d3386");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "a152748e19044425b795b8e0de086e24");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "a77d03970f4b48f9b7e2e1860540a9cb");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "b43ee6eedc124c50a94a0921576ba6c4");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "bd4f19cf8a3f4ff29c749e9890e41dbe");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "db27bbdd16bf44a8884d9056540ea7a3");

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: "36e86ada472f4bfab00e31fe7357eb00");

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: "bf714bd61fe340baa97552005b14c24b");

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: "c4ecbe1b304444198db056cf56af69b6");

            migrationBuilder.DeleteData(
                table: "DogTypes",
                keyColumn: "Id",
                keyValue: "419c7ef5b7fd4ac4b5de9ba7d1930655");

            migrationBuilder.DeleteData(
                table: "DogTypes",
                keyColumn: "Id",
                keyValue: "81419a91ad0d450d9a4015b3d5c78bdd");

            migrationBuilder.DeleteData(
                table: "DogTypes",
                keyColumn: "Id",
                keyValue: "c8595afa00b942bdbb79f4038e51d965");

            migrationBuilder.DeleteData(
                table: "Memberships",
                keyColumn: "Id",
                keyValue: "1330615bd0db4e11a0f7d1fd648c64fc");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "064d34f00adc409d976242ca37097e0b");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "4f1b5040cc874352876f7d29bc55b653");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "6cc9a86df30c456ea988f27d934dbca9");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "d4c9c0c66ba7420aa5d2300db8f67652");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedTime", "Description", "LastUpdatedTime", "Name", "Status" },
                values: new object[,]
                {
                    { "156552f4dc9942b5bc72a6bae94be821", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Covers fundamental obedience commands and essential skills.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Basic Training", 1 },
                    { "c44beb29575744b68c42cf4f70274a20", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Addresses problem behaviors and corrective training for dogs.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Behavioral Modification", 1 },
                    { "f8cb65025770497e9a61c75501ed6cd3", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Focuses on advanced obedience and specialized training techniques.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Advanced Training", 1 }
                });

            migrationBuilder.InsertData(
                table: "DogTypes",
                columns: new[] { "Id", "CreatedTime", "Description", "LastUpdatedTime", "Name", "Status" },
                values: new object[,]
                {
                    { "165bb59ab7a54afbbce7f87a59e4e59f", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Medium-sized dog breeds", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Medium", 1 },
                    { "290085959b894fd9a5862aaa212c7dad", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Large-sized dog breeds", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Large", 1 },
                    { "7ca915fdd76440358e4c7890a8835f2e", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Small-sized dog breeds", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Small", 1 }
                });

            migrationBuilder.InsertData(
                table: "EquipmentCategories",
                columns: new[] { "Id", "CreatedTime", "Description", "LastUpdatedTime", "Name", "Status" },
                values: new object[,]
                {
                    { "8d3d09a5a8404aca9c0f391ba12cec69", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Equipment used for dog training and obedience exercises.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Training Tools", 1 },
                    { "c5aaa8d1e97445718662ff6193441c28", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Protective gear for dogs, such as harnesses and pads.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Safety Gear", 1 },
                    { "ff877ca6f800408fb7001989c050f9b1", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Tools used for dog grooming, including brushes and clippers.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Grooming Equipment", 1 }
                });

            migrationBuilder.InsertData(
                table: "Memberships",
                columns: new[] { "Id", "CreatedTime", "Description", "DiscountAmount", "LastUpdatedTime", "Name", "RequiredPoints" },
                values: new object[,]
                {
                    { "6a93bc9850404efa9dcd405db6b63579", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Elite membership", 20m, new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Platinum", 1000 },
                    { "8012856c6cc045cea011acf51b60227d", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Entry-level membership", 0m, new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Basic", 0 },
                    { "eb43a56a202a44ae8fd0ebdb958e8b09", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Premium membership", 10m, new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Gold", 500 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedTime", "Description", "LastUpdatedTime", "Name", "Status" },
                values: new object[,]
                {
                    { "0131f2e255b44b969cf5273cde7c3465", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "System administrator with full access", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Admin", 1 },
                    { "30969e33920647e98d7389c719407ae4", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Lead trainer responsible for courses and lessons", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Trainer_Lead", 1 },
                    { "56652ade5adf4ed38d50895ca39ce580", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Organizational customer who can enroll in courses", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Customer_Organizational", 1 },
                    { "8a59b78d40b3477795e0c286b6ea5d41", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Staff manager member managing operations", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Staff_Manager", 1 },
                    { "d76e3c6efa1042ada3847521b61f847f", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Trainer responsible for courses and lessons", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Trainer_Member", 1 },
                    { "db4733fad3a941f4971aa0fec24be2b1", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Staff employee member managing operations", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Staff_Employee", 1 },
                    { "dd17f217736e46f6ab93912f4d4bbe76", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Individual customer who can enroll in courses", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Customer_Individual", 1 }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "CreatedTime", "Description", "LastUpdatedTime", "Name", "Status" },
                values: new object[,]
                {
                    { "2a1563fde6094ac5a12c45d5c09ca68a", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Enhancing a dog's physical abilities and responsiveness through obstacle courses.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Agility Training", 1 },
                    { "69369f008c4b4b8e8213209c4b234352", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Training dogs to follow basic commands like sit, stay, and come.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Basic Commands", 1 },
                    { "932de1bffd1f4c31a9cb483721623a69", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Addressing and correcting unwanted behaviors in dogs.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Behavioral Correction", 1 },
                    { "c384db4b131e468d8b551a3488130d6f", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Helping dogs become comfortable around other animals and people.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Socialization", 1 },
                    { "f69d7033c2cb46a2b5289b24c80dc59a", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Training dogs for guarding and protective behavior.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Protection Training", 1 }
                });

            migrationBuilder.InsertData(
                table: "Specializations",
                columns: new[] { "Id", "CreatedTime", "Description", "LastUpdatedTime", "Name" },
                values: new object[,]
                {
                    { "096afda693f24285b2c3358214bac8a9", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Helping dogs overcome behavioral issues.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Behavioral Therapy" },
                    { "7fe4b583c3854e79ac6e5ea0e28549d9", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Training dogs for agility courses and competitions.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Agility Training" },
                    { "bb199304ef9e47b787a3f5fbd5e49515", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Basic and advanced obedience training for dogs.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Obedience Training" }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Address", "CreatedTime", "DateOfBirth", "Email", "FullName", "Gender", "ImageUrl", "LastUpdatedTime", "MembershipId", "MembershipPoints", "Password", "PhoneNumber", "RegistrationTime", "RoleId", "Status", "Username" },
                values: new object[,]
                {
                    { "00786efb729542fa87a19d44fb3cdf79", "Staff Employee Address", new DateTimeOffset(new DateTime(2025, 3, 23, 2, 7, 42, 345, DateTimeKind.Unspecified).AddTicks(389), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1988, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff_employee@gmail.com", "Staff Employee", 1, "empty", new DateTimeOffset(new DateTime(2025, 3, 23, 2, 7, 42, 345, DateTimeKind.Unspecified).AddTicks(389), new TimeSpan(0, 7, 0, 0, 0)), "8012856c6cc045cea011acf51b60227d", 0, "$2a$11$/jyOMfFh/pZYAUsAGga6Legt1/49dqg34YfYfZjEDBcAU.KDpClMa", "0966332211", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "db4733fad3a941f4971aa0fec24be2b1", 1, "staff_employee" },
                    { "2bf1c6f4a7db4fed825958e6d78e7226", "Customer Organization Address", new DateTimeOffset(new DateTime(2025, 3, 23, 2, 7, 42, 195, DateTimeKind.Unspecified).AddTicks(3918), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1992, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer_organization@gmail.com", "Customer Organization", 2, "empty", new DateTimeOffset(new DateTime(2025, 3, 23, 2, 7, 42, 195, DateTimeKind.Unspecified).AddTicks(3918), new TimeSpan(0, 7, 0, 0, 0)), "8012856c6cc045cea011acf51b60227d", 200, "$2a$11$8/JW7ul9Q5XmM8KTizh6N.IeOOJzgBRqQmGP2Z9vt7VlY2Z1NPTzC", "0977554433", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "56652ade5adf4ed38d50895ca39ce580", 1, "customer_organization" },
                    { "54d3a3e95adc4b38885e43af50e12e42", "Trainer Member Address", new DateTimeOffset(new DateTime(2025, 3, 23, 2, 7, 41, 765, DateTimeKind.Unspecified).AddTicks(7474), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1985, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "trainer_member@gmail.com", "Trainer Member", 1, "empty", new DateTimeOffset(new DateTime(2025, 3, 23, 2, 7, 41, 765, DateTimeKind.Unspecified).AddTicks(7474), new TimeSpan(0, 7, 0, 0, 0)), "8012856c6cc045cea011acf51b60227d", 0, "$2a$11$G0MhnmWlChfwRsw9xAPWzOTKvaxJ22J8iKwu9AGDSGm9Pmejl2ErK", "0987654321", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "d76e3c6efa1042ada3847521b61f847f", 1, "trainer_member" },
                    { "6144c9fe6b7e4f4294ea469ffb6a90fd", "Admin Address", new DateTimeOffset(new DateTime(2025, 3, 23, 2, 7, 41, 620, DateTimeKind.Unspecified).AddTicks(1197), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", "Admin User", 1, "empty", new DateTimeOffset(new DateTime(2025, 3, 23, 2, 7, 41, 620, DateTimeKind.Unspecified).AddTicks(1197), new TimeSpan(0, 7, 0, 0, 0)), "8012856c6cc045cea011acf51b60227d", 0, "$2a$11$m1IMbmUlxt/g9T3kyhT2hO6Wkemqx8uA1mpak5Yl9Vmu9qbMsy8m2", "0123456789", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0131f2e255b44b969cf5273cde7c3465", 1, "admin" },
                    { "ea46ce4e457f42dfb18b6347bd4ea1f4", "Customer Individual Address", new DateTimeOffset(new DateTime(2025, 3, 23, 2, 7, 42, 49, DateTimeKind.Unspecified).AddTicks(7348), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1995, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer_individual@gmail.com", "Customer Individual", 2, "empty", new DateTimeOffset(new DateTime(2025, 3, 23, 2, 7, 42, 49, DateTimeKind.Unspecified).AddTicks(7348), new TimeSpan(0, 7, 0, 0, 0)), "8012856c6cc045cea011acf51b60227d", 100, "$2a$11$CI7wNVkoPee7GoZ.6i/sU.AIXirqrlE1JDY4CpvFqsY.uwQwCNArm", "0988112233", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "dd17f217736e46f6ab93912f4d4bbe76", 1, "customer_individual" },
                    { "eaa27cff0c91479087bb22370ffbb6d0", "Staff Manager Address", new DateTimeOffset(new DateTime(2025, 3, 23, 2, 7, 42, 488, DateTimeKind.Unspecified).AddTicks(3179), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1980, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff_manager@gmail.com", "Staff Manager", 1, "empty", new DateTimeOffset(new DateTime(2025, 3, 23, 2, 7, 42, 488, DateTimeKind.Unspecified).AddTicks(3179), new TimeSpan(0, 7, 0, 0, 0)), "8012856c6cc045cea011acf51b60227d", 0, "$2a$11$4YNs63B7rHpslhbQPptxAehjnUXNLN/c0B4okVwhmqTksiCiYdp3O", "0955223344", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8a59b78d40b3477795e0c286b6ea5d41", 1, "staff_manager" },
                    { "fa13bc18b0c54ba0b9886b007f4d8b08", "Trainer Lead Address", new DateTimeOffset(new DateTime(2025, 3, 23, 2, 7, 41, 904, DateTimeKind.Unspecified).AddTicks(3463), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1983, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "trainer_lead@gmail.com", "Trainer Lead", 1, "empty", new DateTimeOffset(new DateTime(2025, 3, 23, 2, 7, 41, 904, DateTimeKind.Unspecified).AddTicks(3463), new TimeSpan(0, 7, 0, 0, 0)), "8012856c6cc045cea011acf51b60227d", 0, "$2a$11$0/pfd/mARoMOwxMNmtKljefgc6qei0bos1.WuU/Kjf0Dh3oKxz8oC", "0911223344", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "30969e33920647e98d7389c719407ae4", 1, "trainer_lead" }
                });

            migrationBuilder.InsertData(
                table: "DogBreeds",
                columns: new[] { "Id", "CreatedTime", "Description", "DogTypeId", "LastUpdatedTime", "Name", "Status" },
                values: new object[,]
                {
                    { "4bee6ab4f7f841d69bacedcfd25c8d07", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A friendly and intelligent medium-sized breed.", "165bb59ab7a54afbbce7f87a59e4e59f", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Cocker Spaniel", 1 },
                    { "57e3821db9464da1a52b20c1bc33d68e", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A loyal and protective breed, often used as a guard dog.", "290085959b894fd9a5862aaa212c7dad", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Rottweiler", 1 },
                    { "7afb0c3a253c4f52b2c9c197ee316db1", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A curious and friendly breed known for its great sense of smell.", "165bb59ab7a54afbbce7f87a59e4e59f", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Beagle", 1 },
                    { "aab0b6e304af466d955a035fb1316c94", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A fluffy and energetic small breed.", "7ca915fdd76440358e4c7890a8835f2e", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Pomeranian", 1 },
                    { "ad463f17bd7746d9b6831e97d865fa1d", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A friendly and intelligent large breed.", "290085959b894fd9a5862aaa212c7dad", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Golden Retriever", 1 },
                    { "c128c6bdc5e0416c81578b5523f897ff", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A small, muscular dog with a distinctive bat-like ear shape.", "7ca915fdd76440358e4c7890a8835f2e", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "French Bulldog", 1 },
                    { "d49ed755a16b482aa894e52d8c976bde", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A strong and intelligent breed used in working roles.", "290085959b894fd9a5862aaa212c7dad", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "German Shepherd", 1 },
                    { "d60d3e9afb724ec0b36dc52d3bb6bd64", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A tiny breed known for its lively personality.", "7ca915fdd76440358e4c7890a8835f2e", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Chihuahua", 1 },
                    { "f8c917e1e56f41389122c5c8dfa869c3", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A highly intelligent and energetic breed.", "165bb59ab7a54afbbce7f87a59e4e59f", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Border Collie", 1 }
                });

            migrationBuilder.InsertData(
                table: "Equipments",
                columns: new[] { "Id", "CreatedTime", "Description", "EquipmentCategoryId", "LastUpdatedTime", "Name", "Status" },
                values: new object[,]
                {
                    { "26a6940dc1de411bac923654991eb90d", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A comfortable harness designed for safety and control.", "c5aaa8d1e97445718662ff6193441c28", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Dog Harness", 1 },
                    { "2c736d4396d0403483651149e8a28262", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A brush for maintaining a dog's coat and hygiene.", "ff877ca6f800408fb7001989c050f9b1", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Grooming Brush", 1 },
                    { "8360514335034d07a43a34455ce8a238", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A clicker used for positive reinforcement training.", "8d3d09a5a8404aca9c0f391ba12cec69", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Training Clicker", 1 }
                });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "Content", "CreatedTime", "ImageUrl", "LastUpdatedTime", "StaffId", "Status", "TimePublished", "Title" },
                values: new object[,]
                {
                    { "57f1808014f741c79e2791dea717d760", "Training your dog is crucial for a harmonious relationship between pet and owner...", new DateTimeOffset(new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/blog1.jpg", new DateTimeOffset(new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "00786efb729542fa87a19d44fb3cdf79", 1, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Importance of Dog Training" },
                    { "fc97a573f1224b93b73ddce3eebd4095", "Providing a balanced diet is essential for your dog's overall health and well-being...", new DateTimeOffset(new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/blog2.jpg", new DateTimeOffset(new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "eaa27cff0c91479087bb22370ffbb6d0", 1, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Understanding Canine Nutrition" }
                });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "Id", "CreatedTime", "DateOfBirth", "DogBreedId", "Gender", "ImageUrl", "LastUpdatedTime", "Name", "RegistrationTime", "Status" },
                values: new object[,]
                {
                    { "2ea60c66720d4571833911be746470a8", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateOnly(2022, 1, 30), "c128c6bdc5e0416c81578b5523f897ff", 0, "https://example.com/dog3.jpg", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Luna", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { "468c7f90cef546d1a336b133ce986031", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateOnly(2018, 11, 25), "ad463f17bd7746d9b6831e97d865fa1d", 1, "https://example.com/dog7.jpg", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Buddy", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { "4e763c98bfd940168bfcc8bbcaa36f92", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateOnly(2020, 6, 10), "7afb0c3a253c4f52b2c9c197ee316db1", 0, "https://example.com/dog6.jpg", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Daisy", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { "8487615b64754cc2be8401202ffad21e", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateOnly(2019, 12, 5), "4bee6ab4f7f841d69bacedcfd25c8d07", 1, "https://example.com/dog4.jpg", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Charlie", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { "bbf004a7a5c24d1b989bc7110a5c56c3", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateOnly(2021, 5, 15), "d60d3e9afb724ec0b36dc52d3bb6bd64", 0, "https://example.com/dog1.jpg", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Bella", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { "dc8c01d14f87485e910eb153d90d432c", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateOnly(2019, 9, 14), "d49ed755a16b482aa894e52d8c976bde", 1, "https://example.com/dog8.jpg", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Rex", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { "e28448d9b78a4098a300783838d4bc15", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateOnly(2021, 7, 18), "f8c917e1e56f41389122c5c8dfa869c3", 1, "https://example.com/dog5.jpg", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Max", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { "f153eb7f29934c30908c68fc668e01d7", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateOnly(2021, 3, 8), "57e3821db9464da1a52b20c1bc33d68e", 0, "https://example.com/dog9.jpg", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Zara", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { "fe7077791778468984040eeec2ae731e", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateOnly(2020, 8, 22), "aab0b6e304af466d955a035fb1316c94", 1, "https://example.com/dog2.jpg", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Rocky", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });

            migrationBuilder.InsertData(
                table: "TrainerSkills",
                columns: new[] { "Id", "CreatedTime", "LastUpdatedTime", "SkillId", "TrainerId" },
                values: new object[,]
                {
                    { "07cd73db65c14f00b62b2989dd01bcfa", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "2a1563fde6094ac5a12c45d5c09ca68a", "fa13bc18b0c54ba0b9886b007f4d8b08" },
                    { "3cc36201c3e449669b2e84044da18359", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "f69d7033c2cb46a2b5289b24c80dc59a", "fa13bc18b0c54ba0b9886b007f4d8b08" },
                    { "4a526fcfd23b49138cd6cd6542b8ee19", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "2a1563fde6094ac5a12c45d5c09ca68a", "54d3a3e95adc4b38885e43af50e12e42" },
                    { "80f4108f20594220a14ced11a970da83", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "69369f008c4b4b8e8213209c4b234352", "fa13bc18b0c54ba0b9886b007f4d8b08" },
                    { "95006cb2706e40a88ffc6442cc726f5a", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "69369f008c4b4b8e8213209c4b234352", "54d3a3e95adc4b38885e43af50e12e42" },
                    { "9ffc2d246d5c442499a672b89090b5ca", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "c384db4b131e468d8b551a3488130d6f", "fa13bc18b0c54ba0b9886b007f4d8b08" },
                    { "ac25363902ad4ee28e4e72d74dad4962", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "932de1bffd1f4c31a9cb483721623a69", "fa13bc18b0c54ba0b9886b007f4d8b08" },
                    { "cfa197bf60154ac5ba1aa610e0969cb9", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "932de1bffd1f4c31a9cb483721623a69", "54d3a3e95adc4b38885e43af50e12e42" }
                });

            migrationBuilder.InsertData(
                table: "TrainerSpecializations",
                columns: new[] { "Id", "CreatedTime", "LastUpdatedTime", "SpecializaionId", "TrainerId" },
                values: new object[,]
                {
                    { "1057b0502a944acaaf493ae342d7c253", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "7fe4b583c3854e79ac6e5ea0e28549d9", "fa13bc18b0c54ba0b9886b007f4d8b08" },
                    { "6072538bcfd647a794dc6e0bba50c2cd", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "bb199304ef9e47b787a3f5fbd5e49515", "54d3a3e95adc4b38885e43af50e12e42" },
                    { "68b1786bfa3a4863a3185f2e56b0e44c", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "096afda693f24285b2c3358214bac8a9", "fa13bc18b0c54ba0b9886b007f4d8b08" }
                });

            migrationBuilder.InsertData(
                table: "DogOwnerships",
                columns: new[] { "Id", "CreatedTime", "CustomerId", "DogId", "FromDate", "LastUpdatedTime", "ToDate" },
                values: new object[,]
                {
                    { "13ddd89665b249bc99c01b290c5fb596", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "2bf1c6f4a7db4fed825958e6d78e7226", "4e763c98bfd940168bfcc8bbcaa36f92", new DateOnly(2022, 8, 12), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), null },
                    { "34bf2da66c1c438fb6ea023988f607db", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "2bf1c6f4a7db4fed825958e6d78e7226", "e28448d9b78a4098a300783838d4bc15", new DateOnly(2020, 4, 20), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), null },
                    { "6952cd89ec7f4861aed0b7c80004652c", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "ea46ce4e457f42dfb18b6347bd4ea1f4", "fe7077791778468984040eeec2ae731e", new DateOnly(2023, 3, 15), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), null },
                    { "a738f67c534e41a58f4e000832a032cb", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "ea46ce4e457f42dfb18b6347bd4ea1f4", "bbf004a7a5c24d1b989bc7110a5c56c3", new DateOnly(2023, 1, 1), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), null },
                    { "cbfaa4b1ee324f78a215263b0a89d5df", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "2bf1c6f4a7db4fed825958e6d78e7226", "f153eb7f29934c30908c68fc668e01d7", new DateOnly(2023, 7, 22), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), null },
                    { "d0222688ae5242b49d5003246f4b241a", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "2bf1c6f4a7db4fed825958e6d78e7226", "dc8c01d14f87485e910eb153d90d432c", new DateOnly(2023, 5, 7), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), null },
                    { "ddbd5f8e4c9340dc8ebfaab25deac181", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "2bf1c6f4a7db4fed825958e6d78e7226", "2ea60c66720d4571833911be746470a8", new DateOnly(2022, 6, 10), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), null },
                    { "f0d54ea2b94b4f8bb70b2c2d02bea6ef", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "2bf1c6f4a7db4fed825958e6d78e7226", "8487615b64754cc2be8401202ffad21e", new DateOnly(2021, 9, 5), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), null },
                    { "f30e6700a29e4bad89738697ebc1cdca", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "2bf1c6f4a7db4fed825958e6d78e7226", "468c7f90cef546d1a336b133ce986031", new DateOnly(2023, 2, 14), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "6144c9fe6b7e4f4294ea469ffb6a90fd");

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: "57f1808014f741c79e2791dea717d760");

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: "fc97a573f1224b93b73ddce3eebd4095");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "156552f4dc9942b5bc72a6bae94be821");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "c44beb29575744b68c42cf4f70274a20");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "f8cb65025770497e9a61c75501ed6cd3");

            migrationBuilder.DeleteData(
                table: "DogOwnerships",
                keyColumn: "Id",
                keyValue: "13ddd89665b249bc99c01b290c5fb596");

            migrationBuilder.DeleteData(
                table: "DogOwnerships",
                keyColumn: "Id",
                keyValue: "34bf2da66c1c438fb6ea023988f607db");

            migrationBuilder.DeleteData(
                table: "DogOwnerships",
                keyColumn: "Id",
                keyValue: "6952cd89ec7f4861aed0b7c80004652c");

            migrationBuilder.DeleteData(
                table: "DogOwnerships",
                keyColumn: "Id",
                keyValue: "a738f67c534e41a58f4e000832a032cb");

            migrationBuilder.DeleteData(
                table: "DogOwnerships",
                keyColumn: "Id",
                keyValue: "cbfaa4b1ee324f78a215263b0a89d5df");

            migrationBuilder.DeleteData(
                table: "DogOwnerships",
                keyColumn: "Id",
                keyValue: "d0222688ae5242b49d5003246f4b241a");

            migrationBuilder.DeleteData(
                table: "DogOwnerships",
                keyColumn: "Id",
                keyValue: "ddbd5f8e4c9340dc8ebfaab25deac181");

            migrationBuilder.DeleteData(
                table: "DogOwnerships",
                keyColumn: "Id",
                keyValue: "f0d54ea2b94b4f8bb70b2c2d02bea6ef");

            migrationBuilder.DeleteData(
                table: "DogOwnerships",
                keyColumn: "Id",
                keyValue: "f30e6700a29e4bad89738697ebc1cdca");

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: "26a6940dc1de411bac923654991eb90d");

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: "2c736d4396d0403483651149e8a28262");

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: "8360514335034d07a43a34455ce8a238");

            migrationBuilder.DeleteData(
                table: "Memberships",
                keyColumn: "Id",
                keyValue: "6a93bc9850404efa9dcd405db6b63579");

            migrationBuilder.DeleteData(
                table: "Memberships",
                keyColumn: "Id",
                keyValue: "eb43a56a202a44ae8fd0ebdb958e8b09");

            migrationBuilder.DeleteData(
                table: "TrainerSkills",
                keyColumn: "Id",
                keyValue: "07cd73db65c14f00b62b2989dd01bcfa");

            migrationBuilder.DeleteData(
                table: "TrainerSkills",
                keyColumn: "Id",
                keyValue: "3cc36201c3e449669b2e84044da18359");

            migrationBuilder.DeleteData(
                table: "TrainerSkills",
                keyColumn: "Id",
                keyValue: "4a526fcfd23b49138cd6cd6542b8ee19");

            migrationBuilder.DeleteData(
                table: "TrainerSkills",
                keyColumn: "Id",
                keyValue: "80f4108f20594220a14ced11a970da83");

            migrationBuilder.DeleteData(
                table: "TrainerSkills",
                keyColumn: "Id",
                keyValue: "95006cb2706e40a88ffc6442cc726f5a");

            migrationBuilder.DeleteData(
                table: "TrainerSkills",
                keyColumn: "Id",
                keyValue: "9ffc2d246d5c442499a672b89090b5ca");

            migrationBuilder.DeleteData(
                table: "TrainerSkills",
                keyColumn: "Id",
                keyValue: "ac25363902ad4ee28e4e72d74dad4962");

            migrationBuilder.DeleteData(
                table: "TrainerSkills",
                keyColumn: "Id",
                keyValue: "cfa197bf60154ac5ba1aa610e0969cb9");

            migrationBuilder.DeleteData(
                table: "TrainerSpecializations",
                keyColumn: "Id",
                keyValue: "1057b0502a944acaaf493ae342d7c253");

            migrationBuilder.DeleteData(
                table: "TrainerSpecializations",
                keyColumn: "Id",
                keyValue: "6072538bcfd647a794dc6e0bba50c2cd");

            migrationBuilder.DeleteData(
                table: "TrainerSpecializations",
                keyColumn: "Id",
                keyValue: "68b1786bfa3a4863a3185f2e56b0e44c");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "00786efb729542fa87a19d44fb3cdf79");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "2bf1c6f4a7db4fed825958e6d78e7226");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "54d3a3e95adc4b38885e43af50e12e42");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "ea46ce4e457f42dfb18b6347bd4ea1f4");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "eaa27cff0c91479087bb22370ffbb6d0");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "fa13bc18b0c54ba0b9886b007f4d8b08");

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: "2ea60c66720d4571833911be746470a8");

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: "468c7f90cef546d1a336b133ce986031");

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: "4e763c98bfd940168bfcc8bbcaa36f92");

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: "8487615b64754cc2be8401202ffad21e");

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: "bbf004a7a5c24d1b989bc7110a5c56c3");

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: "dc8c01d14f87485e910eb153d90d432c");

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: "e28448d9b78a4098a300783838d4bc15");

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: "f153eb7f29934c30908c68fc668e01d7");

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: "fe7077791778468984040eeec2ae731e");

            migrationBuilder.DeleteData(
                table: "EquipmentCategories",
                keyColumn: "Id",
                keyValue: "8d3d09a5a8404aca9c0f391ba12cec69");

            migrationBuilder.DeleteData(
                table: "EquipmentCategories",
                keyColumn: "Id",
                keyValue: "c5aaa8d1e97445718662ff6193441c28");

            migrationBuilder.DeleteData(
                table: "EquipmentCategories",
                keyColumn: "Id",
                keyValue: "ff877ca6f800408fb7001989c050f9b1");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "0131f2e255b44b969cf5273cde7c3465");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "2a1563fde6094ac5a12c45d5c09ca68a");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "69369f008c4b4b8e8213209c4b234352");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "932de1bffd1f4c31a9cb483721623a69");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "c384db4b131e468d8b551a3488130d6f");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "f69d7033c2cb46a2b5289b24c80dc59a");

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: "096afda693f24285b2c3358214bac8a9");

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: "7fe4b583c3854e79ac6e5ea0e28549d9");

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: "bb199304ef9e47b787a3f5fbd5e49515");

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: "4bee6ab4f7f841d69bacedcfd25c8d07");

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: "57e3821db9464da1a52b20c1bc33d68e");

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: "7afb0c3a253c4f52b2c9c197ee316db1");

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: "aab0b6e304af466d955a035fb1316c94");

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: "ad463f17bd7746d9b6831e97d865fa1d");

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: "c128c6bdc5e0416c81578b5523f897ff");

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: "d49ed755a16b482aa894e52d8c976bde");

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: "d60d3e9afb724ec0b36dc52d3bb6bd64");

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: "f8c917e1e56f41389122c5c8dfa869c3");

            migrationBuilder.DeleteData(
                table: "Memberships",
                keyColumn: "Id",
                keyValue: "8012856c6cc045cea011acf51b60227d");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "30969e33920647e98d7389c719407ae4");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "56652ade5adf4ed38d50895ca39ce580");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8a59b78d40b3477795e0c286b6ea5d41");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "d76e3c6efa1042ada3847521b61f847f");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "db4733fad3a941f4971aa0fec24be2b1");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "dd17f217736e46f6ab93912f4d4bbe76");

            migrationBuilder.DeleteData(
                table: "DogTypes",
                keyColumn: "Id",
                keyValue: "165bb59ab7a54afbbce7f87a59e4e59f");

            migrationBuilder.DeleteData(
                table: "DogTypes",
                keyColumn: "Id",
                keyValue: "290085959b894fd9a5862aaa212c7dad");

            migrationBuilder.DeleteData(
                table: "DogTypes",
                keyColumn: "Id",
                keyValue: "7ca915fdd76440358e4c7890a8835f2e");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedTime", "Description", "LastUpdatedTime", "Name", "Status" },
                values: new object[,]
                {
                    { "074331c90d924b679540de3604ee8e22", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Covers fundamental obedience commands and essential skills.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Basic Training", 1 },
                    { "7e681e1e54964f89bf5ece80a54d5d91", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Focuses on advanced obedience and specialized training techniques.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Advanced Training", 1 },
                    { "f650d51e96ab4e66ade4d0caab849ad5", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Addresses problem behaviors and corrective training for dogs.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Behavioral Modification", 1 }
                });

            migrationBuilder.InsertData(
                table: "DogTypes",
                columns: new[] { "Id", "CreatedTime", "Description", "LastUpdatedTime", "Name", "Status" },
                values: new object[,]
                {
                    { "419c7ef5b7fd4ac4b5de9ba7d1930655", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Small-sized dog breeds", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Small", 1 },
                    { "81419a91ad0d450d9a4015b3d5c78bdd", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Large-sized dog breeds", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Large", 1 },
                    { "c8595afa00b942bdbb79f4038e51d965", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Medium-sized dog breeds", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Medium", 1 }
                });

            migrationBuilder.InsertData(
                table: "EquipmentCategories",
                columns: new[] { "Id", "CreatedTime", "Description", "LastUpdatedTime", "Name", "Status" },
                values: new object[,]
                {
                    { "673423aadf624ec08c561f249568f58a", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Tools used for dog grooming, including brushes and clippers.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Grooming Equipment", 1 },
                    { "6e25b02e093a449c829a88f81cba48fa", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Equipment used for dog training and obedience exercises.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Training Tools", 1 },
                    { "8d5c841ceade4758bd5c6d396a9c89f9", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Protective gear for dogs, such as harnesses and pads.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Safety Gear", 1 }
                });

            migrationBuilder.InsertData(
                table: "Memberships",
                columns: new[] { "Id", "CreatedTime", "Description", "DiscountAmount", "LastUpdatedTime", "Name", "RequiredPoints" },
                values: new object[,]
                {
                    { "0a98c1872bc744a881a9f61377113dc5", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Elite membership", 20m, new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Platinum", 1000 },
                    { "1330615bd0db4e11a0f7d1fd648c64fc", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Entry-level membership", 0m, new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Basic", 0 },
                    { "5ac3f848c7f147748108dede0fcbd253", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Premium membership", 10m, new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Gold", 500 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedTime", "Description", "LastUpdatedTime", "Name", "Status" },
                values: new object[,]
                {
                    { "064d34f00adc409d976242ca37097e0b", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Lead trainer responsible for courses and lessons", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Trainer_Lead", 1 },
                    { "26b6cd4d55ed45e788934ade76b8374f", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Individual customer who can enroll in courses", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Customer_Individual", 1 },
                    { "4f1b5040cc874352876f7d29bc55b653", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Trainer responsible for courses and lessons", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Trainer_Member", 1 },
                    { "6cc9a86df30c456ea988f27d934dbca9", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Staff manager member managing operations", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Staff_Manager", 1 },
                    { "ae835011a12645c493d47bba2c8e3cba", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "System administrator with full access", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Admin", 1 },
                    { "d4c9c0c66ba7420aa5d2300db8f67652", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Staff employee member managing operations", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Staff_Employee", 1 },
                    { "f97ad2d96c334c7eb8ce225df47d3386", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Organizational customer who can enroll in courses", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Customer_Organizational", 1 }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "CreatedTime", "Description", "LastUpdatedTime", "Name", "Status" },
                values: new object[,]
                {
                    { "a152748e19044425b795b8e0de086e24", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Training dogs to follow basic commands like sit, stay, and come.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Basic Commands", 1 },
                    { "a77d03970f4b48f9b7e2e1860540a9cb", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Training dogs for guarding and protective behavior.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Protection Training", 1 },
                    { "b43ee6eedc124c50a94a0921576ba6c4", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Enhancing a dog's physical abilities and responsiveness through obstacle courses.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Agility Training", 1 },
                    { "bd4f19cf8a3f4ff29c749e9890e41dbe", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Addressing and correcting unwanted behaviors in dogs.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Behavioral Correction", 1 },
                    { "db27bbdd16bf44a8884d9056540ea7a3", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Helping dogs become comfortable around other animals and people.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Socialization", 1 }
                });

            migrationBuilder.InsertData(
                table: "Specializations",
                columns: new[] { "Id", "CreatedTime", "Description", "LastUpdatedTime", "Name" },
                values: new object[,]
                {
                    { "36e86ada472f4bfab00e31fe7357eb00", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Helping dogs overcome behavioral issues.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Behavioral Therapy" },
                    { "bf714bd61fe340baa97552005b14c24b", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Basic and advanced obedience training for dogs.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Obedience Training" },
                    { "c4ecbe1b304444198db056cf56af69b6", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Training dogs for agility courses and competitions.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Agility Training" }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Address", "CreatedTime", "DateOfBirth", "Email", "FullName", "Gender", "ImageUrl", "LastUpdatedTime", "MembershipId", "MembershipPoints", "Password", "PhoneNumber", "RegistrationTime", "RoleId", "Status", "Username" },
                values: new object[,]
                {
                    { "2a3ca79933754a188ed32f92b0639154", "Customer Individual Address", new DateTimeOffset(new DateTime(2025, 3, 23, 2, 6, 12, 433, DateTimeKind.Unspecified).AddTicks(1779), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1995, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer_individual@gmail.com", "Customer Individual", 2, "empty", new DateTimeOffset(new DateTime(2025, 3, 23, 2, 6, 12, 433, DateTimeKind.Unspecified).AddTicks(1779), new TimeSpan(0, 7, 0, 0, 0)), "1330615bd0db4e11a0f7d1fd648c64fc", 100, "$2a$11$Huc7Fb2z4go8W1NLLObCr.N3clCRPfB4bpxCskwDjZFgXVG3.Xe36", "0988112233", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "26b6cd4d55ed45e788934ade76b8374f", 1, "customer_individual" },
                    { "487ff6733f744e7fb463f798aba71aac", "Staff Employee Address", new DateTimeOffset(new DateTime(2025, 3, 23, 2, 6, 12, 720, DateTimeKind.Unspecified).AddTicks(6148), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1988, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff_employee@gmail.com", "Staff Employee", 1, "empty", new DateTimeOffset(new DateTime(2025, 3, 23, 2, 6, 12, 720, DateTimeKind.Unspecified).AddTicks(6148), new TimeSpan(0, 7, 0, 0, 0)), "1330615bd0db4e11a0f7d1fd648c64fc", 0, "$2a$11$wJnJOXs6fLpzX9VAG3PtOeHI0DzsstudIwGnJlBBcVCh9nV6m2voq", "0966332211", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "d4c9c0c66ba7420aa5d2300db8f67652", 1, "staff_employee" },
                    { "6e6c6879bdbd4eda95eabaa0a4deb644", "Admin Address", new DateTimeOffset(new DateTime(2025, 3, 23, 2, 6, 11, 982, DateTimeKind.Unspecified).AddTicks(1465), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", "Admin User", 1, "empty", new DateTimeOffset(new DateTime(2025, 3, 23, 2, 6, 11, 982, DateTimeKind.Unspecified).AddTicks(1465), new TimeSpan(0, 7, 0, 0, 0)), "1330615bd0db4e11a0f7d1fd648c64fc", 0, "$2a$11$15jySX2twAMVH1rf5QlaluU7XUpUUCHVAewxbfJgca10YYdAg0PTu", "0123456789", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ae835011a12645c493d47bba2c8e3cba", 1, "admin" },
                    { "70d59276498f49748e451dcf925e7f7a", "Customer Organization Address", new DateTimeOffset(new DateTime(2025, 3, 23, 2, 6, 12, 583, DateTimeKind.Unspecified).AddTicks(7105), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1992, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer_organization@gmail.com", "Customer Organization", 2, "empty", new DateTimeOffset(new DateTime(2025, 3, 23, 2, 6, 12, 583, DateTimeKind.Unspecified).AddTicks(7105), new TimeSpan(0, 7, 0, 0, 0)), "1330615bd0db4e11a0f7d1fd648c64fc", 200, "$2a$11$O2Sfor369LIkFO6j19R8.uK7HLl4Pj4ZRATLzN9T8nqrw/kYmR572", "0977554433", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f97ad2d96c334c7eb8ce225df47d3386", 1, "customer_organization" },
                    { "b248df6a92fa4ff39f55a5f1adfa4e31", "Trainer Lead Address", new DateTimeOffset(new DateTime(2025, 3, 23, 2, 6, 12, 280, DateTimeKind.Unspecified).AddTicks(9724), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1983, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "trainer_lead@gmail.com", "Trainer Lead", 1, "empty", new DateTimeOffset(new DateTime(2025, 3, 23, 2, 6, 12, 280, DateTimeKind.Unspecified).AddTicks(9724), new TimeSpan(0, 7, 0, 0, 0)), "1330615bd0db4e11a0f7d1fd648c64fc", 0, "$2a$11$iJq5pAeas99IkII.3Vb8pePBJYzFGooyZQG3Ei45WPAdy1dLTKg7C", "0911223344", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "064d34f00adc409d976242ca37097e0b", 1, "trainer_lead" },
                    { "e215168a275343f98be776a8fb04f524", "Staff Manager Address", new DateTimeOffset(new DateTime(2025, 3, 23, 2, 6, 12, 866, DateTimeKind.Unspecified).AddTicks(404), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1980, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff_manager@gmail.com", "Staff Manager", 1, "empty", new DateTimeOffset(new DateTime(2025, 3, 23, 2, 6, 12, 866, DateTimeKind.Unspecified).AddTicks(404), new TimeSpan(0, 7, 0, 0, 0)), "1330615bd0db4e11a0f7d1fd648c64fc", 0, "$2a$11$uDCvURthosrPFtqPARAL0OB2RyYFW9n3ZDqhIJtQOstba4hZI0JjG", "0955223344", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6cc9a86df30c456ea988f27d934dbca9", 1, "staff_manager" },
                    { "e2bdbe109e0540038408482d1cdd72bb", "Trainer Member Address", new DateTimeOffset(new DateTime(2025, 3, 23, 2, 6, 12, 123, DateTimeKind.Unspecified).AddTicks(9510), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1985, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "trainer_member@gmail.com", "Trainer Member", 1, "empty", new DateTimeOffset(new DateTime(2025, 3, 23, 2, 6, 12, 123, DateTimeKind.Unspecified).AddTicks(9510), new TimeSpan(0, 7, 0, 0, 0)), "1330615bd0db4e11a0f7d1fd648c64fc", 0, "$2a$11$QnDdd3/1d/i4twLEB/xaou63IS59yP8aQ2D7O/Y0jplqnMLhK/6Wm", "0987654321", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4f1b5040cc874352876f7d29bc55b653", 1, "trainer_member" }
                });

            migrationBuilder.InsertData(
                table: "DogBreeds",
                columns: new[] { "Id", "CreatedTime", "Description", "DogTypeId", "LastUpdatedTime", "Name", "Status" },
                values: new object[,]
                {
                    { "1f101afd44a6447d9064599f96b1e530", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A friendly and intelligent medium-sized breed.", "c8595afa00b942bdbb79f4038e51d965", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Cocker Spaniel", 1 },
                    { "79a3f28be0344a0498a7f7ec03172955", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A fluffy and energetic small breed.", "419c7ef5b7fd4ac4b5de9ba7d1930655", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Pomeranian", 1 },
                    { "861e56d5ddef49f2a8ff3360f3fbe0af", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A friendly and intelligent large breed.", "81419a91ad0d450d9a4015b3d5c78bdd", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Golden Retriever", 1 },
                    { "978ea62fbcd4420182442b5b6f741838", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A loyal and protective breed, often used as a guard dog.", "81419a91ad0d450d9a4015b3d5c78bdd", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Rottweiler", 1 },
                    { "a1dbc666d6d84f368b66374d0d176ef8", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A small, muscular dog with a distinctive bat-like ear shape.", "419c7ef5b7fd4ac4b5de9ba7d1930655", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "French Bulldog", 1 },
                    { "cf311aaa80ff4b519a74a27bf70ff0f0", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A tiny breed known for its lively personality.", "419c7ef5b7fd4ac4b5de9ba7d1930655", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Chihuahua", 1 },
                    { "d1b97ca81a174f34973b734bbd74c4a4", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A strong and intelligent breed used in working roles.", "81419a91ad0d450d9a4015b3d5c78bdd", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "German Shepherd", 1 },
                    { "dac1b6fecdcb488e87c66ce960ce2389", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A curious and friendly breed known for its great sense of smell.", "c8595afa00b942bdbb79f4038e51d965", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Beagle", 1 },
                    { "f2bfa8e2300240158899d67c2c3f04d6", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A highly intelligent and energetic breed.", "c8595afa00b942bdbb79f4038e51d965", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Border Collie", 1 }
                });

            migrationBuilder.InsertData(
                table: "Equipments",
                columns: new[] { "Id", "CreatedTime", "Description", "EquipmentCategoryId", "LastUpdatedTime", "Name", "Status" },
                values: new object[,]
                {
                    { "88a9e2dc2c0846b495e7191e0f52f83d", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A brush for maintaining a dog's coat and hygiene.", "673423aadf624ec08c561f249568f58a", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Grooming Brush", 1 },
                    { "9c925913737b4bc7871872e4b79ecd4f", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A clicker used for positive reinforcement training.", "6e25b02e093a449c829a88f81cba48fa", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Training Clicker", 1 },
                    { "b0d3c858893a471a8482912b92d96fb3", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A comfortable harness designed for safety and control.", "8d5c841ceade4758bd5c6d396a9c89f9", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Dog Harness", 1 }
                });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "Content", "CreatedTime", "ImageUrl", "LastUpdatedTime", "StaffId", "Status", "TimePublished", "Title" },
                values: new object[,]
                {
                    { "8a21643bd65d40e5bf09daa9dd3f4d3d", "Training your dog is crucial for a harmonious relationship between pet and owner...", new DateTimeOffset(new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/blog1.jpg", new DateTimeOffset(new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "487ff6733f744e7fb463f798aba71aac", 1, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Importance of Dog Training" },
                    { "dfb0779952e14b6b87cf42821c5b6afd", "Providing a balanced diet is essential for your dog's overall health and well-being...", new DateTimeOffset(new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/blog2.jpg", new DateTimeOffset(new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "e215168a275343f98be776a8fb04f524", 1, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Understanding Canine Nutrition" }
                });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "Id", "CreatedTime", "DateOfBirth", "DogBreedId", "Gender", "ImageUrl", "LastUpdatedTime", "Name", "RegistrationTime", "Status" },
                values: new object[,]
                {
                    { "0a925e3eff584e48b84e6b098319687d", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateOnly(2021, 7, 18), "f2bfa8e2300240158899d67c2c3f04d6", 1, "https://example.com/dog5.jpg", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Max", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { "2ff60634dea446c88c159bb87d0de94e", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateOnly(2019, 9, 14), "d1b97ca81a174f34973b734bbd74c4a4", 1, "https://example.com/dog8.jpg", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Rex", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { "3afde6508f7b4d63843a1dbe878f4f0b", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateOnly(2020, 8, 22), "79a3f28be0344a0498a7f7ec03172955", 1, "https://example.com/dog2.jpg", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Rocky", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { "40170854e9084344bfec166a3fb7a056", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateOnly(2022, 1, 30), "a1dbc666d6d84f368b66374d0d176ef8", 0, "https://example.com/dog3.jpg", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Luna", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { "58a3df2a0b06420cbaecf313278087b8", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateOnly(2021, 3, 8), "978ea62fbcd4420182442b5b6f741838", 0, "https://example.com/dog9.jpg", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Zara", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { "6453f1736bba4bee97daae688100f9af", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateOnly(2020, 6, 10), "dac1b6fecdcb488e87c66ce960ce2389", 0, "https://example.com/dog6.jpg", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Daisy", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { "836367f23920461ca32e9069070c6f53", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateOnly(2019, 12, 5), "1f101afd44a6447d9064599f96b1e530", 1, "https://example.com/dog4.jpg", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Charlie", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { "c5497915823f45e5a14aff3464317448", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateOnly(2021, 5, 15), "cf311aaa80ff4b519a74a27bf70ff0f0", 0, "https://example.com/dog1.jpg", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Bella", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { "fdecf1eb56094101be41484ed096278f", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateOnly(2018, 11, 25), "861e56d5ddef49f2a8ff3360f3fbe0af", 1, "https://example.com/dog7.jpg", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Buddy", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });

            migrationBuilder.InsertData(
                table: "TrainerSkills",
                columns: new[] { "Id", "CreatedTime", "LastUpdatedTime", "SkillId", "TrainerId" },
                values: new object[,]
                {
                    { "065115fa32c14221834dda9e02cd27a5", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "a152748e19044425b795b8e0de086e24", "b248df6a92fa4ff39f55a5f1adfa4e31" },
                    { "28e8f28d9cd84dc3b449c6d80bc82645", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "b43ee6eedc124c50a94a0921576ba6c4", "e2bdbe109e0540038408482d1cdd72bb" },
                    { "31b913a1445241e6bab8cf0c18f98ec4", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "bd4f19cf8a3f4ff29c749e9890e41dbe", "b248df6a92fa4ff39f55a5f1adfa4e31" },
                    { "4c969dbb3ad944a191e06d13e977c2b5", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "b43ee6eedc124c50a94a0921576ba6c4", "b248df6a92fa4ff39f55a5f1adfa4e31" },
                    { "8bae6933ee7f4495a41911966da9531a", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "db27bbdd16bf44a8884d9056540ea7a3", "b248df6a92fa4ff39f55a5f1adfa4e31" },
                    { "99462620bb464af7861fdb24a979a4ff", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "bd4f19cf8a3f4ff29c749e9890e41dbe", "e2bdbe109e0540038408482d1cdd72bb" },
                    { "e6598dac50d84ed7be84439a24b8375e", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "a152748e19044425b795b8e0de086e24", "e2bdbe109e0540038408482d1cdd72bb" },
                    { "ed1e3b5ccc8041ba994cdf25e4f85701", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "a77d03970f4b48f9b7e2e1860540a9cb", "b248df6a92fa4ff39f55a5f1adfa4e31" }
                });

            migrationBuilder.InsertData(
                table: "TrainerSpecializations",
                columns: new[] { "Id", "CreatedTime", "LastUpdatedTime", "SpecializaionId", "TrainerId" },
                values: new object[,]
                {
                    { "52f84238431443879952d07cb1db1cee", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "c4ecbe1b304444198db056cf56af69b6", "b248df6a92fa4ff39f55a5f1adfa4e31" },
                    { "b3cf44e6a71e4232b564ae0b605f9e73", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "bf714bd61fe340baa97552005b14c24b", "e2bdbe109e0540038408482d1cdd72bb" },
                    { "ccf81cd58f4542b992ed66fb5ca7c468", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "36e86ada472f4bfab00e31fe7357eb00", "b248df6a92fa4ff39f55a5f1adfa4e31" }
                });
        }
    }
}
