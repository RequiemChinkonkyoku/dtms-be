using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class DataSeedingForDocument : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "8d3e15f1cba34bb188544eafa1e8f952", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Covers fundamental obedience commands and essential skills.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Basic Training", 1 },
                    { "d40034d06b7e4f7db33aa7f7655b546e", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Addresses problem behaviors and corrective training for dogs.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Behavioral Modification", 1 },
                    { "e534e655f8d2443fa3c68f26bac2033b", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Focuses on advanced obedience and specialized training techniques.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Advanced Training", 1 }
                });

            migrationBuilder.InsertData(
                table: "DogTypes",
                columns: new[] { "Id", "CreatedTime", "Description", "LastUpdatedTime", "Name", "Status" },
                values: new object[,]
                {
                    { "38e4bde4713b44c7857c238faee8b17e", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Large-sized dog breeds", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Large", 1 },
                    { "e4d84a1b04564b1eac93686da5ed3891", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Medium-sized dog breeds", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Medium", 1 },
                    { "fe95dc1803a945a68a16368ee20bb11c", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Small-sized dog breeds", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Small", 1 }
                });

            migrationBuilder.InsertData(
                table: "EquipmentCategories",
                columns: new[] { "Id", "CreatedTime", "Description", "LastUpdatedTime", "Name", "Status" },
                values: new object[,]
                {
                    { "0da87b4d397c4b5cb74b3ab186c8b985", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Equipment used for dog training and obedience exercises.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Training Tools", 1 },
                    { "505bc7e58be54b72b1634084772bed35", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Tools used for dog grooming, including brushes and clippers.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Grooming Equipment", 1 },
                    { "95078837cecb4bc3b11acfcb18c57bdf", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Protective gear for dogs, such as harnesses and pads.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Safety Gear", 1 }
                });

            migrationBuilder.InsertData(
                table: "Memberships",
                columns: new[] { "Id", "CreatedTime", "Description", "DiscountAmount", "LastUpdatedTime", "Name", "RequiredPoints" },
                values: new object[,]
                {
                    { "01d9059a2bae4ffe949d5b6d79bab8f8", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Premium membership", 10m, new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Gold", 500 },
                    { "28f472bccf5544d29d47ce5223797e21", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Entry-level membership", 0m, new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Basic", 0 },
                    { "85ab8cfa4658442abd31fd66da960d4d", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Elite membership", 20m, new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Platinum", 1000 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedTime", "Description", "LastUpdatedTime", "Name", "Status" },
                values: new object[,]
                {
                    { "03912efa2c7f4586bb32b6b8dfdc9826", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Organizational customer who can enroll in courses", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Customer_Organizational", 1 },
                    { "1005e54c31f249ef8a7337d77f92f06a", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Staff manager member managing operations", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Staff_Manager", 1 },
                    { "830225e9ca4541419b82c76e5ce670b7", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Staff employee member managing operations", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Staff_Employee", 1 },
                    { "a364df780be740ae9c2e4f4d8c1bcf06", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Individual customer who can enroll in courses", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Customer_Individual", 1 },
                    { "afe7f0fbabd04cddbd77b2c78dcfeff0", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "System administrator with full access", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Admin", 1 },
                    { "e507e39010454782b947a9850e903471", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Lead trainer responsible for courses and lessons", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Trainer_Lead", 1 },
                    { "ee741db0d7294aceaa9c361dab1a253a", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Trainer responsible for courses and lessons", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Trainer_Member", 1 }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "CreatedTime", "Description", "LastUpdatedTime", "Name", "Status" },
                values: new object[,]
                {
                    { "24aee1f8ad8d4d76b6ab9898e1733b57", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Addressing and correcting unwanted behaviors in dogs.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Behavioral Correction", 1 },
                    { "5127126e02684789bace61adc31d270d", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Training dogs to follow basic commands like sit, stay, and come.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Basic Commands", 1 },
                    { "56e479f7881b4baf840c69db1dc69154", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Enhancing a dog's physical abilities and responsiveness through obstacle courses.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Agility Training", 1 },
                    { "bee87c802fb84f749ee1b9544177ca6f", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Training dogs for guarding and protective behavior.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Protection Training", 1 },
                    { "fc6c1be2372d4622bdd131ae1bc86a55", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Helping dogs become comfortable around other animals and people.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Socialization", 1 }
                });

            migrationBuilder.InsertData(
                table: "Specializations",
                columns: new[] { "Id", "CreatedTime", "Description", "LastUpdatedTime", "Name" },
                values: new object[,]
                {
                    { "4016bc5d36bb44f3a0ce8c56d8863441", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Helping dogs overcome behavioral issues.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Behavioral Therapy" },
                    { "558b3f6bd6144abfb2fa642635050d21", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Basic and advanced obedience training for dogs.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Obedience Training" },
                    { "8e5070597a5f4069967fb4dc1d696237", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Training dogs for agility courses and competitions.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Agility Training" }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Address", "CreatedTime", "DateOfBirth", "Email", "FullName", "Gender", "ImageUrl", "LastUpdatedTime", "MembershipId", "MembershipPoints", "Password", "PhoneNumber", "RegistrationTime", "RoleId", "Status", "Username" },
                values: new object[,]
                {
                    { "23c1a3c8753d4d349a4b378c5dfe99a5", "Trainer Lead Address", new DateTimeOffset(new DateTime(2025, 3, 23, 9, 33, 51, 942, DateTimeKind.Unspecified).AddTicks(1310), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1983, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "trainer_lead@gmail.com", "Trainer Lead", 1, "empty", new DateTimeOffset(new DateTime(2025, 3, 23, 9, 33, 51, 942, DateTimeKind.Unspecified).AddTicks(1310), new TimeSpan(0, 7, 0, 0, 0)), "28f472bccf5544d29d47ce5223797e21", 0, "$2a$11$8ruAIahZunr19n5U9rtvFeqmrYS6L33tyZ7x/w8iGgcNFTwB8mHdi", "0911223344", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "e507e39010454782b947a9850e903471", 1, "trainer_lead" },
                    { "35f3ac27b17a4295a337b78341807c6a", "Staff Manager Address", new DateTimeOffset(new DateTime(2025, 3, 23, 9, 33, 52, 395, DateTimeKind.Unspecified).AddTicks(9368), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1980, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff_manager@gmail.com", "Staff Manager", 1, "empty", new DateTimeOffset(new DateTime(2025, 3, 23, 9, 33, 52, 395, DateTimeKind.Unspecified).AddTicks(9368), new TimeSpan(0, 7, 0, 0, 0)), "28f472bccf5544d29d47ce5223797e21", 0, "$2a$11$wbAW2cxQ9kDtCyu2ucKituCHyuWMe.6Hp.WH3K2XeSrLVRWvv5mmK", "0955223344", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1005e54c31f249ef8a7337d77f92f06a", 1, "staff_manager" },
                    { "3787a33421be4310ac5eb1ab8d697fbf", "Admin Address", new DateTimeOffset(new DateTime(2025, 3, 23, 9, 33, 51, 710, DateTimeKind.Unspecified).AddTicks(1370), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", "Admin User", 1, "empty", new DateTimeOffset(new DateTime(2025, 3, 23, 9, 33, 51, 710, DateTimeKind.Unspecified).AddTicks(1370), new TimeSpan(0, 7, 0, 0, 0)), "28f472bccf5544d29d47ce5223797e21", 0, "$2a$11$HwTI5kdpct7P/CPMX9eM6.p1bZ3w69zOx0DNhUOTal6/EAUjMGIMG", "0123456789", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "afe7f0fbabd04cddbd77b2c78dcfeff0", 1, "admin" },
                    { "90794052e3144171b73a2205c9d37809", "Staff Employee Address", new DateTimeOffset(new DateTime(2025, 3, 23, 9, 33, 52, 281, DateTimeKind.Unspecified).AddTicks(7715), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1988, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff_employee@gmail.com", "Staff Employee", 1, "empty", new DateTimeOffset(new DateTime(2025, 3, 23, 9, 33, 52, 281, DateTimeKind.Unspecified).AddTicks(7715), new TimeSpan(0, 7, 0, 0, 0)), "28f472bccf5544d29d47ce5223797e21", 0, "$2a$11$dXrKcJAQLuLJbRpSllIfQuRhFe6ecrmTy8xEluAW5RqRhbPwnvCaq", "0966332211", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "830225e9ca4541419b82c76e5ce670b7", 1, "staff_employee" },
                    { "a19fbb199fb74103a17e0c97fe3a894c", "Customer Organization Address", new DateTimeOffset(new DateTime(2025, 3, 23, 9, 33, 52, 167, DateTimeKind.Unspecified).AddTicks(8396), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1992, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer_organization@gmail.com", "Customer Organization", 2, "empty", new DateTimeOffset(new DateTime(2025, 3, 23, 9, 33, 52, 167, DateTimeKind.Unspecified).AddTicks(8396), new TimeSpan(0, 7, 0, 0, 0)), "28f472bccf5544d29d47ce5223797e21", 200, "$2a$11$619WAX.dpkYLj/3rMu9AVObHXb3rcMD4QCLyksHrusZLsdwYarsLO", "0977554433", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "03912efa2c7f4586bb32b6b8dfdc9826", 1, "customer_organization" },
                    { "bc0f6d9bf7b2463a85358014070e5f59", "Trainer Member Address", new DateTimeOffset(new DateTime(2025, 3, 23, 9, 33, 51, 828, DateTimeKind.Unspecified).AddTicks(687), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1985, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "trainer_member@gmail.com", "Trainer Member", 1, "empty", new DateTimeOffset(new DateTime(2025, 3, 23, 9, 33, 51, 828, DateTimeKind.Unspecified).AddTicks(687), new TimeSpan(0, 7, 0, 0, 0)), "28f472bccf5544d29d47ce5223797e21", 0, "$2a$11$GaWBiodHe5q0yImvlhIlT.SL48upF/nGunTSEAV3KFMisfK2jWZ7e", "0987654321", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ee741db0d7294aceaa9c361dab1a253a", 1, "trainer_member" },
                    { "df71c939b0c74cb697080ae7055f11c5", "Customer Individual Address", new DateTimeOffset(new DateTime(2025, 3, 23, 9, 33, 52, 55, DateTimeKind.Unspecified).AddTicks(4426), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1995, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer_individual@gmail.com", "Customer Individual", 2, "empty", new DateTimeOffset(new DateTime(2025, 3, 23, 9, 33, 52, 55, DateTimeKind.Unspecified).AddTicks(4426), new TimeSpan(0, 7, 0, 0, 0)), "28f472bccf5544d29d47ce5223797e21", 100, "$2a$11$BbN4pDUHjhQFn46H0TWVZe5.BFITi9dBDUggAf5BqeisgAoIAFw7C", "0988112233", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "a364df780be740ae9c2e4f4d8c1bcf06", 1, "customer_individual" }
                });

            migrationBuilder.InsertData(
                table: "DogBreeds",
                columns: new[] { "Id", "CreatedTime", "Description", "DogTypeId", "LastUpdatedTime", "Name", "Status" },
                values: new object[,]
                {
                    { "1c49ea971f3245d6be2fc57d9d00fdd1", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A fluffy and energetic small breed.", "fe95dc1803a945a68a16368ee20bb11c", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Pomeranian", 1 },
                    { "2a9762d7af614a918e5b50763c809239", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A tiny breed known for its lively personality.", "fe95dc1803a945a68a16368ee20bb11c", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Chihuahua", 1 },
                    { "5104d9a7ee484d1e9deeaa5c4ee8ab7f", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A loyal and protective breed, often used as a guard dog.", "38e4bde4713b44c7857c238faee8b17e", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Rottweiler", 1 },
                    { "62084d91e2a34062bd47fac8f60d91bd", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A curious and friendly breed known for its great sense of smell.", "e4d84a1b04564b1eac93686da5ed3891", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Beagle", 1 },
                    { "6d57c21e4e664bea97c3ac7822b4b178", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A strong and intelligent breed used in working roles.", "38e4bde4713b44c7857c238faee8b17e", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "German Shepherd", 1 },
                    { "a8ebf8995f394dd2b8b06e73f926df53", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A highly intelligent and energetic breed.", "e4d84a1b04564b1eac93686da5ed3891", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Border Collie", 1 },
                    { "ab040de66f1742e784c44b6e77bdd558", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A small, muscular dog with a distinctive bat-like ear shape.", "fe95dc1803a945a68a16368ee20bb11c", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "French Bulldog", 1 },
                    { "b851fac40d1c4befbce78af9cb997b66", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A friendly and intelligent large breed.", "38e4bde4713b44c7857c238faee8b17e", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Golden Retriever", 1 },
                    { "c923f4c2b5d84fdca3661053041ae7ca", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A friendly and intelligent medium-sized breed.", "e4d84a1b04564b1eac93686da5ed3891", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Cocker Spaniel", 1 }
                });

            migrationBuilder.InsertData(
                table: "Equipments",
                columns: new[] { "Id", "CreatedTime", "Description", "EquipmentCategoryId", "LastUpdatedTime", "Name", "Status" },
                values: new object[,]
                {
                    { "4eae38eb3ef04506918fb96278de3668", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A brush for maintaining a dog's coat and hygiene.", "505bc7e58be54b72b1634084772bed35", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Grooming Brush", 1 },
                    { "675195344e184af1af53cdefa0f3dc57", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A clicker used for positive reinforcement training.", "0da87b4d397c4b5cb74b3ab186c8b985", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Training Clicker", 1 },
                    { "cd9fce55230047c3963a78ed10c070ec", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A comfortable harness designed for safety and control.", "95078837cecb4bc3b11acfcb18c57bdf", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Dog Harness", 1 }
                });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "Content", "CreatedTime", "ImageUrl", "LastUpdatedTime", "StaffId", "Status", "TimePublished", "Title" },
                values: new object[,]
                {
                    { "04c25f4cb1624ea0aafc44c6a9365928", "Training your dog is crucial for a harmonious relationship between pet and owner...", new DateTimeOffset(new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/blog1.jpg", new DateTimeOffset(new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "90794052e3144171b73a2205c9d37809", 1, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Importance of Dog Training" },
                    { "3f4a2c0104c04b3597e38efa8c1a2696", "Providing a balanced diet is essential for your dog's overall health and well-being...", new DateTimeOffset(new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/blog2.jpg", new DateTimeOffset(new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "35f3ac27b17a4295a337b78341807c6a", 1, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Understanding Canine Nutrition" }
                });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "Id", "CreatedTime", "DateOfBirth", "DogBreedId", "Gender", "ImageUrl", "LastUpdatedTime", "Name", "RegistrationTime", "Status" },
                values: new object[,]
                {
                    { "00583a64b6564f95afb24fd3ced987b5", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateOnly(2020, 6, 10), "62084d91e2a34062bd47fac8f60d91bd", 0, "https://example.com/dog6.jpg", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Daisy", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { "0a31e68c8ab948598db829119ad303d1", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateOnly(2021, 7, 18), "a8ebf8995f394dd2b8b06e73f926df53", 1, "https://example.com/dog5.jpg", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Max", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { "0bd12e7dc4f1437da140a6dc2dc926ad", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateOnly(2022, 1, 30), "ab040de66f1742e784c44b6e77bdd558", 0, "https://example.com/dog3.jpg", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Luna", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { "1f66a91d3eb14e27972d3350e646cf6d", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateOnly(2021, 5, 15), "2a9762d7af614a918e5b50763c809239", 0, "https://example.com/dog1.jpg", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Bella", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { "2541af20051a47db88eed1e7b8d10e68", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateOnly(2019, 9, 14), "6d57c21e4e664bea97c3ac7822b4b178", 1, "https://example.com/dog8.jpg", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Rex", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { "68f21d1bbd9a40a5980c57ad0d8cbbba", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateOnly(2021, 3, 8), "5104d9a7ee484d1e9deeaa5c4ee8ab7f", 0, "https://example.com/dog9.jpg", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Zara", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { "696499b846d0486da5d4c4c209610b67", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateOnly(2018, 11, 25), "b851fac40d1c4befbce78af9cb997b66", 1, "https://example.com/dog7.jpg", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Buddy", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { "905a6529c2d44595be248663218a16f1", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateOnly(2019, 12, 5), "c923f4c2b5d84fdca3661053041ae7ca", 1, "https://example.com/dog4.jpg", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Charlie", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { "9665cff6ccae4e0fada2e86eaa910b09", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateOnly(2020, 8, 22), "1c49ea971f3245d6be2fc57d9d00fdd1", 1, "https://example.com/dog2.jpg", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Rocky", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });

            migrationBuilder.InsertData(
                table: "TrainerSkills",
                columns: new[] { "Id", "CreatedTime", "LastUpdatedTime", "SkillId", "TrainerId" },
                values: new object[,]
                {
                    { "2939c154e9f04317b41248388b6f2d21", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "56e479f7881b4baf840c69db1dc69154", "bc0f6d9bf7b2463a85358014070e5f59" },
                    { "b3833e55495a4049996dfc28820f593a", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "24aee1f8ad8d4d76b6ab9898e1733b57", "23c1a3c8753d4d349a4b378c5dfe99a5" },
                    { "d35873e224854ce3bed0012cfe8e5fca", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "bee87c802fb84f749ee1b9544177ca6f", "23c1a3c8753d4d349a4b378c5dfe99a5" },
                    { "d60a806fb9bc4112834c8917749b50b7", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "24aee1f8ad8d4d76b6ab9898e1733b57", "bc0f6d9bf7b2463a85358014070e5f59" },
                    { "d71d21f23e174c93913ff2ae52451bac", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "fc6c1be2372d4622bdd131ae1bc86a55", "23c1a3c8753d4d349a4b378c5dfe99a5" },
                    { "d7ddee2e36ea4bb7b6aa6b8913f1f8b5", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "56e479f7881b4baf840c69db1dc69154", "23c1a3c8753d4d349a4b378c5dfe99a5" },
                    { "e73852d373db4d7eb40866e2993d5c8c", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "5127126e02684789bace61adc31d270d", "23c1a3c8753d4d349a4b378c5dfe99a5" },
                    { "efa763e682cb48c4b27165daa0572e90", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "5127126e02684789bace61adc31d270d", "bc0f6d9bf7b2463a85358014070e5f59" }
                });

            migrationBuilder.InsertData(
                table: "TrainerSpecializations",
                columns: new[] { "Id", "CreatedTime", "LastUpdatedTime", "SpecializaionId", "TrainerId" },
                values: new object[,]
                {
                    { "0582a92730a7447e8306867c8229aaa2", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "8e5070597a5f4069967fb4dc1d696237", "23c1a3c8753d4d349a4b378c5dfe99a5" },
                    { "1dd776d4784a461c820505b0dca0a17d", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "4016bc5d36bb44f3a0ce8c56d8863441", "23c1a3c8753d4d349a4b378c5dfe99a5" },
                    { "e4c7d6640d4143e6b787eeed51ba8d6c", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "558b3f6bd6144abfb2fa642635050d21", "bc0f6d9bf7b2463a85358014070e5f59" }
                });

            migrationBuilder.InsertData(
                table: "DogOwnerships",
                columns: new[] { "Id", "CreatedTime", "CustomerId", "DogId", "FromDate", "LastUpdatedTime", "ToDate" },
                values: new object[,]
                {
                    { "0229c2aa42c64c7ea2aeb1ac843f9be1", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "a19fbb199fb74103a17e0c97fe3a894c", "2541af20051a47db88eed1e7b8d10e68", new DateOnly(2023, 5, 7), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), null },
                    { "23d497dfcbca46b3a6d8d824b763e5b1", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "a19fbb199fb74103a17e0c97fe3a894c", "68f21d1bbd9a40a5980c57ad0d8cbbba", new DateOnly(2023, 7, 22), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), null },
                    { "3f601a06f0a04c36af1f03fab23e101c", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "df71c939b0c74cb697080ae7055f11c5", "9665cff6ccae4e0fada2e86eaa910b09", new DateOnly(2023, 3, 15), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), null },
                    { "504ec6afd9194a5c9ddaf8966284b746", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "a19fbb199fb74103a17e0c97fe3a894c", "0bd12e7dc4f1437da140a6dc2dc926ad", new DateOnly(2022, 6, 10), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), null },
                    { "5a13747de125445d9cd25b32f2cf58fc", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "a19fbb199fb74103a17e0c97fe3a894c", "0a31e68c8ab948598db829119ad303d1", new DateOnly(2020, 4, 20), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), null },
                    { "6874018864024f8c909fe45381dcd87e", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "a19fbb199fb74103a17e0c97fe3a894c", "696499b846d0486da5d4c4c209610b67", new DateOnly(2023, 2, 14), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), null },
                    { "a92c1e88095c46e6b86a8a7aee30e082", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "a19fbb199fb74103a17e0c97fe3a894c", "905a6529c2d44595be248663218a16f1", new DateOnly(2021, 9, 5), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), null },
                    { "cf6ccf22594c46e68c57fe9e89265701", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "df71c939b0c74cb697080ae7055f11c5", "1f66a91d3eb14e27972d3350e646cf6d", new DateOnly(2023, 1, 1), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), null },
                    { "d27695d982dc4e4ea58d0d63d80cf47a", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "a19fbb199fb74103a17e0c97fe3a894c", "00583a64b6564f95afb24fd3ced987b5", new DateOnly(2022, 8, 12), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "3787a33421be4310ac5eb1ab8d697fbf");

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: "04c25f4cb1624ea0aafc44c6a9365928");

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: "3f4a2c0104c04b3597e38efa8c1a2696");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "8d3e15f1cba34bb188544eafa1e8f952");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "d40034d06b7e4f7db33aa7f7655b546e");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "e534e655f8d2443fa3c68f26bac2033b");

            migrationBuilder.DeleteData(
                table: "DogOwnerships",
                keyColumn: "Id",
                keyValue: "0229c2aa42c64c7ea2aeb1ac843f9be1");

            migrationBuilder.DeleteData(
                table: "DogOwnerships",
                keyColumn: "Id",
                keyValue: "23d497dfcbca46b3a6d8d824b763e5b1");

            migrationBuilder.DeleteData(
                table: "DogOwnerships",
                keyColumn: "Id",
                keyValue: "3f601a06f0a04c36af1f03fab23e101c");

            migrationBuilder.DeleteData(
                table: "DogOwnerships",
                keyColumn: "Id",
                keyValue: "504ec6afd9194a5c9ddaf8966284b746");

            migrationBuilder.DeleteData(
                table: "DogOwnerships",
                keyColumn: "Id",
                keyValue: "5a13747de125445d9cd25b32f2cf58fc");

            migrationBuilder.DeleteData(
                table: "DogOwnerships",
                keyColumn: "Id",
                keyValue: "6874018864024f8c909fe45381dcd87e");

            migrationBuilder.DeleteData(
                table: "DogOwnerships",
                keyColumn: "Id",
                keyValue: "a92c1e88095c46e6b86a8a7aee30e082");

            migrationBuilder.DeleteData(
                table: "DogOwnerships",
                keyColumn: "Id",
                keyValue: "cf6ccf22594c46e68c57fe9e89265701");

            migrationBuilder.DeleteData(
                table: "DogOwnerships",
                keyColumn: "Id",
                keyValue: "d27695d982dc4e4ea58d0d63d80cf47a");

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: "4eae38eb3ef04506918fb96278de3668");

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: "675195344e184af1af53cdefa0f3dc57");

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: "cd9fce55230047c3963a78ed10c070ec");

            migrationBuilder.DeleteData(
                table: "Memberships",
                keyColumn: "Id",
                keyValue: "01d9059a2bae4ffe949d5b6d79bab8f8");

            migrationBuilder.DeleteData(
                table: "Memberships",
                keyColumn: "Id",
                keyValue: "85ab8cfa4658442abd31fd66da960d4d");

            migrationBuilder.DeleteData(
                table: "TrainerSkills",
                keyColumn: "Id",
                keyValue: "2939c154e9f04317b41248388b6f2d21");

            migrationBuilder.DeleteData(
                table: "TrainerSkills",
                keyColumn: "Id",
                keyValue: "b3833e55495a4049996dfc28820f593a");

            migrationBuilder.DeleteData(
                table: "TrainerSkills",
                keyColumn: "Id",
                keyValue: "d35873e224854ce3bed0012cfe8e5fca");

            migrationBuilder.DeleteData(
                table: "TrainerSkills",
                keyColumn: "Id",
                keyValue: "d60a806fb9bc4112834c8917749b50b7");

            migrationBuilder.DeleteData(
                table: "TrainerSkills",
                keyColumn: "Id",
                keyValue: "d71d21f23e174c93913ff2ae52451bac");

            migrationBuilder.DeleteData(
                table: "TrainerSkills",
                keyColumn: "Id",
                keyValue: "d7ddee2e36ea4bb7b6aa6b8913f1f8b5");

            migrationBuilder.DeleteData(
                table: "TrainerSkills",
                keyColumn: "Id",
                keyValue: "e73852d373db4d7eb40866e2993d5c8c");

            migrationBuilder.DeleteData(
                table: "TrainerSkills",
                keyColumn: "Id",
                keyValue: "efa763e682cb48c4b27165daa0572e90");

            migrationBuilder.DeleteData(
                table: "TrainerSpecializations",
                keyColumn: "Id",
                keyValue: "0582a92730a7447e8306867c8229aaa2");

            migrationBuilder.DeleteData(
                table: "TrainerSpecializations",
                keyColumn: "Id",
                keyValue: "1dd776d4784a461c820505b0dca0a17d");

            migrationBuilder.DeleteData(
                table: "TrainerSpecializations",
                keyColumn: "Id",
                keyValue: "e4c7d6640d4143e6b787eeed51ba8d6c");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "23c1a3c8753d4d349a4b378c5dfe99a5");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "35f3ac27b17a4295a337b78341807c6a");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "90794052e3144171b73a2205c9d37809");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "a19fbb199fb74103a17e0c97fe3a894c");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "bc0f6d9bf7b2463a85358014070e5f59");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "df71c939b0c74cb697080ae7055f11c5");

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: "00583a64b6564f95afb24fd3ced987b5");

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: "0a31e68c8ab948598db829119ad303d1");

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: "0bd12e7dc4f1437da140a6dc2dc926ad");

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: "1f66a91d3eb14e27972d3350e646cf6d");

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: "2541af20051a47db88eed1e7b8d10e68");

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: "68f21d1bbd9a40a5980c57ad0d8cbbba");

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: "696499b846d0486da5d4c4c209610b67");

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: "905a6529c2d44595be248663218a16f1");

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: "9665cff6ccae4e0fada2e86eaa910b09");

            migrationBuilder.DeleteData(
                table: "EquipmentCategories",
                keyColumn: "Id",
                keyValue: "0da87b4d397c4b5cb74b3ab186c8b985");

            migrationBuilder.DeleteData(
                table: "EquipmentCategories",
                keyColumn: "Id",
                keyValue: "505bc7e58be54b72b1634084772bed35");

            migrationBuilder.DeleteData(
                table: "EquipmentCategories",
                keyColumn: "Id",
                keyValue: "95078837cecb4bc3b11acfcb18c57bdf");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "afe7f0fbabd04cddbd77b2c78dcfeff0");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "24aee1f8ad8d4d76b6ab9898e1733b57");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "5127126e02684789bace61adc31d270d");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "56e479f7881b4baf840c69db1dc69154");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "bee87c802fb84f749ee1b9544177ca6f");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "fc6c1be2372d4622bdd131ae1bc86a55");

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: "4016bc5d36bb44f3a0ce8c56d8863441");

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: "558b3f6bd6144abfb2fa642635050d21");

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: "8e5070597a5f4069967fb4dc1d696237");

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: "1c49ea971f3245d6be2fc57d9d00fdd1");

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: "2a9762d7af614a918e5b50763c809239");

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: "5104d9a7ee484d1e9deeaa5c4ee8ab7f");

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: "62084d91e2a34062bd47fac8f60d91bd");

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: "6d57c21e4e664bea97c3ac7822b4b178");

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: "a8ebf8995f394dd2b8b06e73f926df53");

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: "ab040de66f1742e784c44b6e77bdd558");

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: "b851fac40d1c4befbce78af9cb997b66");

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: "c923f4c2b5d84fdca3661053041ae7ca");

            migrationBuilder.DeleteData(
                table: "Memberships",
                keyColumn: "Id",
                keyValue: "28f472bccf5544d29d47ce5223797e21");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "03912efa2c7f4586bb32b6b8dfdc9826");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1005e54c31f249ef8a7337d77f92f06a");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "830225e9ca4541419b82c76e5ce670b7");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "a364df780be740ae9c2e4f4d8c1bcf06");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "e507e39010454782b947a9850e903471");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "ee741db0d7294aceaa9c361dab1a253a");

            migrationBuilder.DeleteData(
                table: "DogTypes",
                keyColumn: "Id",
                keyValue: "38e4bde4713b44c7857c238faee8b17e");

            migrationBuilder.DeleteData(
                table: "DogTypes",
                keyColumn: "Id",
                keyValue: "e4d84a1b04564b1eac93686da5ed3891");

            migrationBuilder.DeleteData(
                table: "DogTypes",
                keyColumn: "Id",
                keyValue: "fe95dc1803a945a68a16368ee20bb11c");

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
    }
}
