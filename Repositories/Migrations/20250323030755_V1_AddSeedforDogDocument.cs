using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class V1_AddSeedforDogDocument : Migration
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
                    { "3f3a3953e82348b49ec2466bdc3bc784", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Addresses problem behaviors and corrective training for dogs.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Behavioral Modification", 1 },
                    { "49dfbf47acc54e03bff603715a24d3b5", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Focuses on advanced obedience and specialized training techniques.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Advanced Training", 1 },
                    { "91082895f4504e2b955ce19599c3ad94", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Covers fundamental obedience commands and essential skills.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Basic Training", 1 }
                });

            migrationBuilder.InsertData(
                table: "DogDocumentTypes",
                columns: new[] { "Id", "CreatedTime", "Description", "LastUpdatedTime", "Name" },
                values: new object[,]
                {
                    { "36042241238d4a6b94c54df1ae2ef062", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Document detailing the dog's health insurance policy.", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Health Insurance" },
                    { "43227c23455d4aa9b75365a286bfe69d", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Official document proving the dog's lineage and breed.", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Pedigree Certificate" },
                    { "59ed6370b7a44e5f81af14d983e0f884", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Certification proving the dog is qualified as a therapy dog.", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Therapy Dog Certification" },
                    { "637c85ce08c34549840ef782c720c284", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Official license permitting the dog to be used for breeding.", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Breeding License" },
                    { "672850dfe45540239e3388c162e7acfc", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Document containing the dog's microchip details.", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Microchip Registration" },
                    { "795780ea162c40b79b99e23ad09fd215", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Certificate awarded for participation or winning in dog shows.", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Show Competition Certificate" },
                    { "9980d1a6d6154434a0fc350ba65c67ba", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Certificate proving the dog has completed a training program.", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Training Certificate" },
                    { "a05880b2a6ac4c7793da54d913fc3a7e", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Legal documents for the adoption of the dog.", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Adoption Papers" },
                    { "e02e01be87904edb8f7bf12f0e27f1f8", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Document containing vaccination history of the dog.", new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Vaccination Record" }
                });

            migrationBuilder.InsertData(
                table: "DogTypes",
                columns: new[] { "Id", "CreatedTime", "Description", "LastUpdatedTime", "Name", "Status" },
                values: new object[,]
                {
                    { "3e742350d1a342bb98abb9afd02a33aa", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Large-sized dog breeds", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Large", 1 },
                    { "addef8a118ea4285ab68a26583ba089a", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Medium-sized dog breeds", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Medium", 1 },
                    { "db92a74d1bca4738afa4d775b7f57aa4", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Small-sized dog breeds", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Small", 1 }
                });

            migrationBuilder.InsertData(
                table: "EquipmentCategories",
                columns: new[] { "Id", "CreatedTime", "Description", "LastUpdatedTime", "Name", "Status" },
                values: new object[,]
                {
                    { "bf589e7df3a249f3b48bd24ce401060a", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Equipment used for dog training and obedience exercises.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Training Tools", 1 },
                    { "ce7dda743e294b2dbfa8d7470f177bba", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Tools used for dog grooming, including brushes and clippers.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Grooming Equipment", 1 },
                    { "d2881608c36e4f93b0e29f70ccc1d2d4", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Protective gear for dogs, such as harnesses and pads.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Safety Gear", 1 }
                });

            migrationBuilder.InsertData(
                table: "Memberships",
                columns: new[] { "Id", "CreatedTime", "Description", "DiscountAmount", "LastUpdatedTime", "Name", "RequiredPoints" },
                values: new object[,]
                {
                    { "0383b1b8c4da4aeda3b15448582963a7", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Entry-level membership", 0m, new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Basic", 0 },
                    { "951ec72a63904816857bef8747ba8738", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Elite membership", 20m, new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Platinum", 1000 },
                    { "ae18a4fb2c874fd78b217d9c6e019512", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Premium membership", 10m, new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Gold", 500 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedTime", "Description", "LastUpdatedTime", "Name", "Status" },
                values: new object[,]
                {
                    { "4aca89ad500a4ccf88fc387fb3203eba", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Trainer responsible for courses and lessons", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Trainer_Member", 1 },
                    { "7a9d724be0744dadbb70ee173af51278", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Staff employee member managing operations", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Staff_Employee", 1 },
                    { "9546c4a031e54038b1c0a1e91828db5c", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Lead trainer responsible for courses and lessons", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Trainer_Lead", 1 },
                    { "961f548e2f214205b0ff0ab6028921ea", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Organizational customer who can enroll in courses", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Customer_Organizational", 1 },
                    { "db16396ac6b14e19aa314ed1bab402c8", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Individual customer who can enroll in courses", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Customer_Individual", 1 },
                    { "e404ea5e9e534b48b0bd2b4802c6af3a", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Staff manager member managing operations", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Staff_Manager", 1 },
                    { "f6f66051635d4be1ae994afca1664b33", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "System administrator with full access", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Admin", 1 }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "CreatedTime", "Description", "LastUpdatedTime", "Name", "Status" },
                values: new object[,]
                {
                    { "ce8597792f5e4dcb9bf2ea0f5a957f9a", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Helping dogs become comfortable around other animals and people.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Socialization", 1 },
                    { "d1d426a922d74ff8a31936f9e905b3b7", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Training dogs to follow basic commands like sit, stay, and come.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Basic Commands", 1 },
                    { "da58f9f2cba2492682029425c56a3c10", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Enhancing a dog's physical abilities and responsiveness through obstacle courses.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Agility Training", 1 },
                    { "eb7c17ab658c4851bbc7bc584b113a7c", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Addressing and correcting unwanted behaviors in dogs.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Behavioral Correction", 1 },
                    { "fc1626207ed94d8380072bf67a74e6fc", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Training dogs for guarding and protective behavior.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Protection Training", 1 }
                });

            migrationBuilder.InsertData(
                table: "Specializations",
                columns: new[] { "Id", "CreatedTime", "Description", "LastUpdatedTime", "Name" },
                values: new object[,]
                {
                    { "26d8ec7cca444e87b07a246a551f7a6e", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Helping dogs overcome behavioral issues.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Behavioral Therapy" },
                    { "30eea12e080642998e0d031950eba20d", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Training dogs for agility courses and competitions.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Agility Training" },
                    { "506458d889064ab7934ee797d267feb3", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Basic and advanced obedience training for dogs.", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Obedience Training" }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Address", "CreatedTime", "DateOfBirth", "Email", "FullName", "Gender", "ImageUrl", "LastUpdatedTime", "MembershipId", "MembershipPoints", "Password", "PhoneNumber", "RegistrationTime", "RoleId", "Status", "Username" },
                values: new object[,]
                {
                    { "215faf644c3c402d8312e9ea3369005b", "Staff Employee Address", new DateTimeOffset(new DateTime(2025, 3, 23, 10, 7, 54, 181, DateTimeKind.Unspecified).AddTicks(8014), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1988, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff_employee@gmail.com", "Staff Employee", 1, "empty", new DateTimeOffset(new DateTime(2025, 3, 23, 10, 7, 54, 181, DateTimeKind.Unspecified).AddTicks(8014), new TimeSpan(0, 7, 0, 0, 0)), "0383b1b8c4da4aeda3b15448582963a7", 0, "$2a$11$L6VMAbcwRe30EQuGPksmTOLh78dC.HDaYs0qFUkg36zMmiWsS4nv.", "0966332211", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7a9d724be0744dadbb70ee173af51278", 1, "staff_employee" },
                    { "2c5a23e6584e4129bae285cb63694681", "Trainer Member Address", new DateTimeOffset(new DateTime(2025, 3, 23, 10, 7, 53, 719, DateTimeKind.Unspecified).AddTicks(2889), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1985, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "trainer_member@gmail.com", "Trainer Member", 1, "empty", new DateTimeOffset(new DateTime(2025, 3, 23, 10, 7, 53, 719, DateTimeKind.Unspecified).AddTicks(2889), new TimeSpan(0, 7, 0, 0, 0)), "0383b1b8c4da4aeda3b15448582963a7", 0, "$2a$11$OpCtM/oW6W/Tf8TakAP4B.XqTYHaOA8pmZIHBGyetBPfLrNIUeyoW", "0987654321", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4aca89ad500a4ccf88fc387fb3203eba", 1, "trainer_member" },
                    { "30f3752615534f3e981932ebb53ab285", "Customer Individual Address", new DateTimeOffset(new DateTime(2025, 3, 23, 10, 7, 53, 949, DateTimeKind.Unspecified).AddTicks(1764), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1995, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer_individual@gmail.com", "Customer Individual", 2, "empty", new DateTimeOffset(new DateTime(2025, 3, 23, 10, 7, 53, 949, DateTimeKind.Unspecified).AddTicks(1764), new TimeSpan(0, 7, 0, 0, 0)), "0383b1b8c4da4aeda3b15448582963a7", 100, "$2a$11$BB6TUwFgVihoOuR/L8QrKeWDBYBgCw4jra3wRlN6D.uo7CoUiMr4.", "0988112233", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "db16396ac6b14e19aa314ed1bab402c8", 1, "customer_individual" },
                    { "431753f94cc74affaabedd250e15a4de", "Staff Manager Address", new DateTimeOffset(new DateTime(2025, 3, 23, 10, 7, 54, 300, DateTimeKind.Unspecified).AddTicks(2252), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1980, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff_manager@gmail.com", "Staff Manager", 1, "empty", new DateTimeOffset(new DateTime(2025, 3, 23, 10, 7, 54, 300, DateTimeKind.Unspecified).AddTicks(2252), new TimeSpan(0, 7, 0, 0, 0)), "0383b1b8c4da4aeda3b15448582963a7", 0, "$2a$11$Lhi4iVRTo.EA0/KovSb0N.Dv6NjkxfVBo.zm71WmTJ3TpXRKH/o6i", "0955223344", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "e404ea5e9e534b48b0bd2b4802c6af3a", 1, "staff_manager" },
                    { "ac432bd246a74fb7ae3dd585c39144e8", "Customer Organization Address", new DateTimeOffset(new DateTime(2025, 3, 23, 10, 7, 54, 63, DateTimeKind.Unspecified).AddTicks(549), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1992, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer_organization@gmail.com", "Customer Organization", 2, "empty", new DateTimeOffset(new DateTime(2025, 3, 23, 10, 7, 54, 63, DateTimeKind.Unspecified).AddTicks(549), new TimeSpan(0, 7, 0, 0, 0)), "0383b1b8c4da4aeda3b15448582963a7", 200, "$2a$11$91iyesNbqtA4/7B72tiOZu1Sr0gqlOfwMWjG/1I1w9rmeMErF3u92", "0977554433", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "961f548e2f214205b0ff0ab6028921ea", 1, "customer_organization" },
                    { "ac908e5d3d5b4a53a3e5c17308f9309c", "Admin Address", new DateTimeOffset(new DateTime(2025, 3, 23, 10, 7, 53, 603, DateTimeKind.Unspecified).AddTicks(9430), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", "Admin User", 1, "empty", new DateTimeOffset(new DateTime(2025, 3, 23, 10, 7, 53, 603, DateTimeKind.Unspecified).AddTicks(9430), new TimeSpan(0, 7, 0, 0, 0)), "0383b1b8c4da4aeda3b15448582963a7", 0, "$2a$11$/Wg00FBYkdjJGtLdSlym2ehnArpqN/oP6xoeHBO0.SJDLkkuH1sQK", "0123456789", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f6f66051635d4be1ae994afca1664b33", 1, "admin" },
                    { "bfe42d83023840efa405572cf451ed6b", "Trainer Lead Address", new DateTimeOffset(new DateTime(2025, 3, 23, 10, 7, 53, 832, DateTimeKind.Unspecified).AddTicks(2405), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1983, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "trainer_lead@gmail.com", "Trainer Lead", 1, "empty", new DateTimeOffset(new DateTime(2025, 3, 23, 10, 7, 53, 832, DateTimeKind.Unspecified).AddTicks(2405), new TimeSpan(0, 7, 0, 0, 0)), "0383b1b8c4da4aeda3b15448582963a7", 0, "$2a$11$Ohx.1HM9.wYRuFjfgKGNPOSuEljf1Umf1YNuvMYzCeP/SrvNEc8q.", "0911223344", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9546c4a031e54038b1c0a1e91828db5c", 1, "trainer_lead" }
                });

            migrationBuilder.InsertData(
                table: "DogBreeds",
                columns: new[] { "Id", "CreatedTime", "Description", "DogTypeId", "LastUpdatedTime", "Name", "Status" },
                values: new object[,]
                {
                    { "02f0710451de472cb3765cae550e3983", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A curious and friendly breed known for its great sense of smell.", "addef8a118ea4285ab68a26583ba089a", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Beagle", 1 },
                    { "272ed288a22c4634b3df87347d436de3", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A friendly and intelligent medium-sized breed.", "addef8a118ea4285ab68a26583ba089a", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Cocker Spaniel", 1 },
                    { "34bd0db5cfea403e87a893e5d0bbdebb", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A tiny breed known for its lively personality.", "db92a74d1bca4738afa4d775b7f57aa4", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Chihuahua", 1 },
                    { "552d3f9cfd5c413884a0c827ba1f3d2b", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A small, muscular dog with a distinctive bat-like ear shape.", "db92a74d1bca4738afa4d775b7f57aa4", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "French Bulldog", 1 },
                    { "6091c9e41f494b34a171ca21602f16d8", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A highly intelligent and energetic breed.", "addef8a118ea4285ab68a26583ba089a", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Border Collie", 1 },
                    { "87f6188d4c844bea9f06fa4d888e62dc", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A strong and intelligent breed used in working roles.", "3e742350d1a342bb98abb9afd02a33aa", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "German Shepherd", 1 },
                    { "8c26eec9201f48eda89b368373553ef2", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A friendly and intelligent large breed.", "3e742350d1a342bb98abb9afd02a33aa", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Golden Retriever", 1 },
                    { "8de3c0542b3c44ddbfe7785aa265d1be", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A loyal and protective breed, often used as a guard dog.", "3e742350d1a342bb98abb9afd02a33aa", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Rottweiler", 1 },
                    { "949c8566c6ed43a39663b92651ad281c", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A fluffy and energetic small breed.", "db92a74d1bca4738afa4d775b7f57aa4", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Pomeranian", 1 }
                });

            migrationBuilder.InsertData(
                table: "Equipments",
                columns: new[] { "Id", "CreatedTime", "Description", "EquipmentCategoryId", "LastUpdatedTime", "Name", "Status" },
                values: new object[,]
                {
                    { "0ac25f7855a84585bdeeb01d7400bca8", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A clicker used for positive reinforcement training.", "bf589e7df3a249f3b48bd24ce401060a", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Training Clicker", 1 },
                    { "ba83ad9675c14e6db41ef5f4b24c2662", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A comfortable harness designed for safety and control.", "d2881608c36e4f93b0e29f70ccc1d2d4", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Dog Harness", 1 },
                    { "fd569aae2040492a8d4a718b2bf36617", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "A brush for maintaining a dog's coat and hygiene.", "ce7dda743e294b2dbfa8d7470f177bba", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Grooming Brush", 1 }
                });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "Content", "CreatedTime", "ImageUrl", "LastUpdatedTime", "StaffId", "Status", "TimePublished", "Title" },
                values: new object[,]
                {
                    { "1a5d57b63cb84fa69149f6f3c0e9c5a8", "Training your dog is crucial for a harmonious relationship between pet and owner...", new DateTimeOffset(new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/blog1.jpg", new DateTimeOffset(new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "215faf644c3c402d8312e9ea3369005b", 1, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Importance of Dog Training" },
                    { "cea9eeb12d60485ba435cc4fc2fe811f", "Providing a balanced diet is essential for your dog's overall health and well-being...", new DateTimeOffset(new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "https://example.com/blog2.jpg", new DateTimeOffset(new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "431753f94cc74affaabedd250e15a4de", 1, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Understanding Canine Nutrition" }
                });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "Id", "CreatedTime", "DateOfBirth", "DogBreedId", "Gender", "ImageUrl", "LastUpdatedTime", "Name", "RegistrationTime", "Status" },
                values: new object[,]
                {
                    { "0183af359c43482d88dcdd3d0dd6e4a1", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateOnly(2022, 1, 30), "552d3f9cfd5c413884a0c827ba1f3d2b", 0, "https://example.com/dog3.jpg", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Luna", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { "0999ddb2e73648faa29d16f33eea5ed0", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateOnly(2020, 8, 22), "949c8566c6ed43a39663b92651ad281c", 1, "https://example.com/dog2.jpg", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Rocky", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { "157cd3db746548b1abfd918a7a673045", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateOnly(2021, 7, 18), "6091c9e41f494b34a171ca21602f16d8", 1, "https://example.com/dog5.jpg", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Max", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { "1aaeb3072f4c4f7ca9a231e206064a24", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateOnly(2019, 9, 14), "87f6188d4c844bea9f06fa4d888e62dc", 1, "https://example.com/dog8.jpg", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Rex", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { "4defa4d820a444a688feae61b6b55222", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateOnly(2018, 11, 25), "8c26eec9201f48eda89b368373553ef2", 1, "https://example.com/dog7.jpg", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Buddy", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { "5b4d60721b664b32ac425fe131b29214", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateOnly(2019, 12, 5), "272ed288a22c4634b3df87347d436de3", 1, "https://example.com/dog4.jpg", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Charlie", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { "94e47c4ac085487490eb8f45c13d2bb6", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateOnly(2021, 3, 8), "8de3c0542b3c44ddbfe7785aa265d1be", 0, "https://example.com/dog9.jpg", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Zara", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { "d15ff7d2410a474e82aa624676abf84b", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateOnly(2020, 6, 10), "02f0710451de472cb3765cae550e3983", 0, "https://example.com/dog6.jpg", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Daisy", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { "f989df546cbb4e1fabe8367d9a659cae", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateOnly(2021, 5, 15), "34bd0db5cfea403e87a893e5d0bbdebb", 0, "https://example.com/dog1.jpg", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Bella", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });

            migrationBuilder.InsertData(
                table: "TrainerSkills",
                columns: new[] { "Id", "CreatedTime", "LastUpdatedTime", "SkillId", "TrainerId" },
                values: new object[,]
                {
                    { "33434df2df6e44dba9b5812d1edf7c92", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "da58f9f2cba2492682029425c56a3c10", "2c5a23e6584e4129bae285cb63694681" },
                    { "3f5219d9d9044960aa6c53517fc2f864", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "fc1626207ed94d8380072bf67a74e6fc", "bfe42d83023840efa405572cf451ed6b" },
                    { "5ef7fbf6376146aa829b8d142f1ef9e0", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "ce8597792f5e4dcb9bf2ea0f5a957f9a", "bfe42d83023840efa405572cf451ed6b" },
                    { "71789a6d0c654a97903fda83d63f967f", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "eb7c17ab658c4851bbc7bc584b113a7c", "2c5a23e6584e4129bae285cb63694681" },
                    { "8aa10fca785a42e4ad3a2de94fcb75c3", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "d1d426a922d74ff8a31936f9e905b3b7", "2c5a23e6584e4129bae285cb63694681" },
                    { "9472d104654f4a7496f653d79c2688d1", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "da58f9f2cba2492682029425c56a3c10", "bfe42d83023840efa405572cf451ed6b" },
                    { "ab2a8c7e5f6f49bdbef83225dde084cb", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "eb7c17ab658c4851bbc7bc584b113a7c", "bfe42d83023840efa405572cf451ed6b" },
                    { "eff871c7638c48bf9dce7deb665842b7", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "d1d426a922d74ff8a31936f9e905b3b7", "bfe42d83023840efa405572cf451ed6b" }
                });

            migrationBuilder.InsertData(
                table: "TrainerSpecializations",
                columns: new[] { "Id", "CreatedTime", "LastUpdatedTime", "SpecializaionId", "TrainerId" },
                values: new object[,]
                {
                    { "1f62bf2fbc784409a57e6a4bbe5b81d1", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "30eea12e080642998e0d031950eba20d", "bfe42d83023840efa405572cf451ed6b" },
                    { "35fa00965885417f8856f3e737d8cde7", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "26d8ec7cca444e87b07a246a551f7a6e", "bfe42d83023840efa405572cf451ed6b" },
                    { "596c9c79035c4b7db0a5e256a391f3f8", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "506458d889064ab7934ee797d267feb3", "2c5a23e6584e4129bae285cb63694681" }
                });

            migrationBuilder.InsertData(
                table: "DogDocuments",
                columns: new[] { "Id", "CreatedTime", "Description", "DogDocumentTypeId", "DogId", "ImageUrl", "IssueDate", "IssuingAuthority", "LastUpdatedTime", "Name", "Status", "UploadTime" },
                values: new object[,]
                {
                    { "493412ceae9c427b96cb1c745993e515", new DateTimeOffset(new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Therapy dog certification for Zara.", "59ed6370b7a44e5f81af14d983e0f884", "94e47c4ac085487490eb8f45c13d2bb6", "https://example.com/documents/therapy1.jpg", new DateOnly(2021, 4, 1), "Therapy Dogs International", new DateTimeOffset(new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Therapy Dog Certification", 1, new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "5fcb313c83de40cc879818b11aad329e", new DateTimeOffset(new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Annual vaccination record for Bella.", "e02e01be87904edb8f7bf12f0e27f1f8", "f989df546cbb4e1fabe8367d9a659cae", "https://example.com/documents/vaccination1.jpg", new DateOnly(2023, 1, 10), "City Veterinary Clinic", new DateTimeOffset(new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Vaccination Record", 1, new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "7a6f520c6ca7425989bfe67521e201b0", new DateTimeOffset(new DateTime(2019, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Breeding license for Rex.", "637c85ce08c34549840ef782c720c284", "1aaeb3072f4c4f7ca9a231e206064a24", "https://example.com/documents/breeding1.jpg", new DateOnly(2019, 10, 1), "State Breeding Authority", new DateTimeOffset(new DateTime(2019, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Breeding License", 1, new DateTime(2019, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "7cac972c97df45109dd417c519ff8b31", new DateTimeOffset(new DateTime(2020, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Adoption papers for Daisy.", "a05880b2a6ac4c7793da54d913fc3a7e", "d15ff7d2410a474e82aa624676abf84b", "https://example.com/documents/adoption1.jpg", new DateOnly(2020, 7, 12), "Happy Tails Shelter", new DateTimeOffset(new DateTime(2020, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Adoption Papers", 1, new DateTime(2020, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "977aa6d96b4742218f918aa49467e225", new DateTimeOffset(new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Pedigree certificate for Rocky.", "43227c23455d4aa9b75365a286bfe69d", "0999ddb2e73648faa29d16f33eea5ed0", "https://example.com/documents/pedigree1.jpg", new DateOnly(2020, 9, 1), "National Kennel Club", new DateTimeOffset(new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Pedigree Certificate", 1, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "9ac48bd67bb541f08e3b1a80310610e4", new DateTimeOffset(new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Certificate for winning Best in Show.", "795780ea162c40b79b99e23ad09fd215", "4defa4d820a444a688feae61b6b55222", "https://example.com/documents/show1.jpg", new DateOnly(2019, 12, 1), "National Dog Show Association", new DateTimeOffset(new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Show Competition Certificate", 1, new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "a5574170b3a8489189b62c2745d9ec7e", new DateTimeOffset(new DateTime(2021, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Basic obedience training certificate for Charlie.", "9980d1a6d6154434a0fc350ba65c67ba", "5b4d60721b664b32ac425fe131b29214", "https://example.com/documents/training1.jpg", new DateOnly(2021, 3, 20), "Pawsitive Training Center", new DateTimeOffset(new DateTime(2021, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Training Certificate", 1, new DateTime(2021, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "c95204e5d06949cdbb6f850bef38e8f4", new DateTimeOffset(new DateTime(2021, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Health insurance policy for Max.", "36042241238d4a6b94c54df1ae2ef062", "157cd3db746548b1abfd918a7a673045", "https://example.com/documents/insurance1.jpg", new DateOnly(2021, 8, 5), "PetCare Insurance", new DateTimeOffset(new DateTime(2021, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Health Insurance", 1, new DateTime(2021, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "f9bad4d5d4ab402cb6c94cc0c187f7ce", new DateTimeOffset(new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Microchip registration for Luna.", "672850dfe45540239e3388c162e7acfc", "0183af359c43482d88dcdd3d0dd6e4a1", "https://example.com/documents/microchip1.jpg", new DateOnly(2022, 2, 15), "Pet Identification Bureau", new DateTimeOffset(new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "Microchip Registration", 1, new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "DogOwnerships",
                columns: new[] { "Id", "CreatedTime", "CustomerId", "DogId", "FromDate", "LastUpdatedTime", "ToDate" },
                values: new object[,]
                {
                    { "241f99dd8ec94e2f8e53c21a2c92fc04", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "ac432bd246a74fb7ae3dd585c39144e8", "5b4d60721b664b32ac425fe131b29214", new DateOnly(2021, 9, 5), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), null },
                    { "3e337193aeb54a9187c22b0167d3bf69", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "ac432bd246a74fb7ae3dd585c39144e8", "0183af359c43482d88dcdd3d0dd6e4a1", new DateOnly(2022, 6, 10), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), null },
                    { "56b699bc77ad4b5785fb315c56163203", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "30f3752615534f3e981932ebb53ab285", "0999ddb2e73648faa29d16f33eea5ed0", new DateOnly(2023, 3, 15), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), null },
                    { "56e0b0c6ea8841c29c19ec88b56d94b0", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "ac432bd246a74fb7ae3dd585c39144e8", "d15ff7d2410a474e82aa624676abf84b", new DateOnly(2022, 8, 12), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), null },
                    { "68ae3e0c7581425d8bd5d42bd188d4d4", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "ac432bd246a74fb7ae3dd585c39144e8", "1aaeb3072f4c4f7ca9a231e206064a24", new DateOnly(2023, 5, 7), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), null },
                    { "71d886766e114de5863784105996097f", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "ac432bd246a74fb7ae3dd585c39144e8", "4defa4d820a444a688feae61b6b55222", new DateOnly(2023, 2, 14), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), null },
                    { "7e95d146314f4343971c921e975310de", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "30f3752615534f3e981932ebb53ab285", "f989df546cbb4e1fabe8367d9a659cae", new DateOnly(2023, 1, 1), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), null },
                    { "e44a2de4b6a64952b636bc814cc5a430", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "ac432bd246a74fb7ae3dd585c39144e8", "157cd3db746548b1abfd918a7a673045", new DateOnly(2020, 4, 20), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), null },
                    { "fabf98509ec049629a2925f73ab15350", new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), "ac432bd246a74fb7ae3dd585c39144e8", "94e47c4ac085487490eb8f45c13d2bb6", new DateOnly(2023, 7, 22), new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 0, 0, 0)), null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "ac908e5d3d5b4a53a3e5c17308f9309c");

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: "1a5d57b63cb84fa69149f6f3c0e9c5a8");

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: "cea9eeb12d60485ba435cc4fc2fe811f");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "3f3a3953e82348b49ec2466bdc3bc784");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "49dfbf47acc54e03bff603715a24d3b5");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "91082895f4504e2b955ce19599c3ad94");

            migrationBuilder.DeleteData(
                table: "DogDocuments",
                keyColumn: "Id",
                keyValue: "493412ceae9c427b96cb1c745993e515");

            migrationBuilder.DeleteData(
                table: "DogDocuments",
                keyColumn: "Id",
                keyValue: "5fcb313c83de40cc879818b11aad329e");

            migrationBuilder.DeleteData(
                table: "DogDocuments",
                keyColumn: "Id",
                keyValue: "7a6f520c6ca7425989bfe67521e201b0");

            migrationBuilder.DeleteData(
                table: "DogDocuments",
                keyColumn: "Id",
                keyValue: "7cac972c97df45109dd417c519ff8b31");

            migrationBuilder.DeleteData(
                table: "DogDocuments",
                keyColumn: "Id",
                keyValue: "977aa6d96b4742218f918aa49467e225");

            migrationBuilder.DeleteData(
                table: "DogDocuments",
                keyColumn: "Id",
                keyValue: "9ac48bd67bb541f08e3b1a80310610e4");

            migrationBuilder.DeleteData(
                table: "DogDocuments",
                keyColumn: "Id",
                keyValue: "a5574170b3a8489189b62c2745d9ec7e");

            migrationBuilder.DeleteData(
                table: "DogDocuments",
                keyColumn: "Id",
                keyValue: "c95204e5d06949cdbb6f850bef38e8f4");

            migrationBuilder.DeleteData(
                table: "DogDocuments",
                keyColumn: "Id",
                keyValue: "f9bad4d5d4ab402cb6c94cc0c187f7ce");

            migrationBuilder.DeleteData(
                table: "DogOwnerships",
                keyColumn: "Id",
                keyValue: "241f99dd8ec94e2f8e53c21a2c92fc04");

            migrationBuilder.DeleteData(
                table: "DogOwnerships",
                keyColumn: "Id",
                keyValue: "3e337193aeb54a9187c22b0167d3bf69");

            migrationBuilder.DeleteData(
                table: "DogOwnerships",
                keyColumn: "Id",
                keyValue: "56b699bc77ad4b5785fb315c56163203");

            migrationBuilder.DeleteData(
                table: "DogOwnerships",
                keyColumn: "Id",
                keyValue: "56e0b0c6ea8841c29c19ec88b56d94b0");

            migrationBuilder.DeleteData(
                table: "DogOwnerships",
                keyColumn: "Id",
                keyValue: "68ae3e0c7581425d8bd5d42bd188d4d4");

            migrationBuilder.DeleteData(
                table: "DogOwnerships",
                keyColumn: "Id",
                keyValue: "71d886766e114de5863784105996097f");

            migrationBuilder.DeleteData(
                table: "DogOwnerships",
                keyColumn: "Id",
                keyValue: "7e95d146314f4343971c921e975310de");

            migrationBuilder.DeleteData(
                table: "DogOwnerships",
                keyColumn: "Id",
                keyValue: "e44a2de4b6a64952b636bc814cc5a430");

            migrationBuilder.DeleteData(
                table: "DogOwnerships",
                keyColumn: "Id",
                keyValue: "fabf98509ec049629a2925f73ab15350");

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: "0ac25f7855a84585bdeeb01d7400bca8");

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: "ba83ad9675c14e6db41ef5f4b24c2662");

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: "fd569aae2040492a8d4a718b2bf36617");

            migrationBuilder.DeleteData(
                table: "Memberships",
                keyColumn: "Id",
                keyValue: "951ec72a63904816857bef8747ba8738");

            migrationBuilder.DeleteData(
                table: "Memberships",
                keyColumn: "Id",
                keyValue: "ae18a4fb2c874fd78b217d9c6e019512");

            migrationBuilder.DeleteData(
                table: "TrainerSkills",
                keyColumn: "Id",
                keyValue: "33434df2df6e44dba9b5812d1edf7c92");

            migrationBuilder.DeleteData(
                table: "TrainerSkills",
                keyColumn: "Id",
                keyValue: "3f5219d9d9044960aa6c53517fc2f864");

            migrationBuilder.DeleteData(
                table: "TrainerSkills",
                keyColumn: "Id",
                keyValue: "5ef7fbf6376146aa829b8d142f1ef9e0");

            migrationBuilder.DeleteData(
                table: "TrainerSkills",
                keyColumn: "Id",
                keyValue: "71789a6d0c654a97903fda83d63f967f");

            migrationBuilder.DeleteData(
                table: "TrainerSkills",
                keyColumn: "Id",
                keyValue: "8aa10fca785a42e4ad3a2de94fcb75c3");

            migrationBuilder.DeleteData(
                table: "TrainerSkills",
                keyColumn: "Id",
                keyValue: "9472d104654f4a7496f653d79c2688d1");

            migrationBuilder.DeleteData(
                table: "TrainerSkills",
                keyColumn: "Id",
                keyValue: "ab2a8c7e5f6f49bdbef83225dde084cb");

            migrationBuilder.DeleteData(
                table: "TrainerSkills",
                keyColumn: "Id",
                keyValue: "eff871c7638c48bf9dce7deb665842b7");

            migrationBuilder.DeleteData(
                table: "TrainerSpecializations",
                keyColumn: "Id",
                keyValue: "1f62bf2fbc784409a57e6a4bbe5b81d1");

            migrationBuilder.DeleteData(
                table: "TrainerSpecializations",
                keyColumn: "Id",
                keyValue: "35fa00965885417f8856f3e737d8cde7");

            migrationBuilder.DeleteData(
                table: "TrainerSpecializations",
                keyColumn: "Id",
                keyValue: "596c9c79035c4b7db0a5e256a391f3f8");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "215faf644c3c402d8312e9ea3369005b");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "2c5a23e6584e4129bae285cb63694681");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "30f3752615534f3e981932ebb53ab285");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "431753f94cc74affaabedd250e15a4de");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "ac432bd246a74fb7ae3dd585c39144e8");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "bfe42d83023840efa405572cf451ed6b");

            migrationBuilder.DeleteData(
                table: "DogDocumentTypes",
                keyColumn: "Id",
                keyValue: "36042241238d4a6b94c54df1ae2ef062");

            migrationBuilder.DeleteData(
                table: "DogDocumentTypes",
                keyColumn: "Id",
                keyValue: "43227c23455d4aa9b75365a286bfe69d");

            migrationBuilder.DeleteData(
                table: "DogDocumentTypes",
                keyColumn: "Id",
                keyValue: "59ed6370b7a44e5f81af14d983e0f884");

            migrationBuilder.DeleteData(
                table: "DogDocumentTypes",
                keyColumn: "Id",
                keyValue: "637c85ce08c34549840ef782c720c284");

            migrationBuilder.DeleteData(
                table: "DogDocumentTypes",
                keyColumn: "Id",
                keyValue: "672850dfe45540239e3388c162e7acfc");

            migrationBuilder.DeleteData(
                table: "DogDocumentTypes",
                keyColumn: "Id",
                keyValue: "795780ea162c40b79b99e23ad09fd215");

            migrationBuilder.DeleteData(
                table: "DogDocumentTypes",
                keyColumn: "Id",
                keyValue: "9980d1a6d6154434a0fc350ba65c67ba");

            migrationBuilder.DeleteData(
                table: "DogDocumentTypes",
                keyColumn: "Id",
                keyValue: "a05880b2a6ac4c7793da54d913fc3a7e");

            migrationBuilder.DeleteData(
                table: "DogDocumentTypes",
                keyColumn: "Id",
                keyValue: "e02e01be87904edb8f7bf12f0e27f1f8");

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: "0183af359c43482d88dcdd3d0dd6e4a1");

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: "0999ddb2e73648faa29d16f33eea5ed0");

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: "157cd3db746548b1abfd918a7a673045");

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: "1aaeb3072f4c4f7ca9a231e206064a24");

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: "4defa4d820a444a688feae61b6b55222");

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: "5b4d60721b664b32ac425fe131b29214");

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: "94e47c4ac085487490eb8f45c13d2bb6");

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: "d15ff7d2410a474e82aa624676abf84b");

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: "f989df546cbb4e1fabe8367d9a659cae");

            migrationBuilder.DeleteData(
                table: "EquipmentCategories",
                keyColumn: "Id",
                keyValue: "bf589e7df3a249f3b48bd24ce401060a");

            migrationBuilder.DeleteData(
                table: "EquipmentCategories",
                keyColumn: "Id",
                keyValue: "ce7dda743e294b2dbfa8d7470f177bba");

            migrationBuilder.DeleteData(
                table: "EquipmentCategories",
                keyColumn: "Id",
                keyValue: "d2881608c36e4f93b0e29f70ccc1d2d4");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "f6f66051635d4be1ae994afca1664b33");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "ce8597792f5e4dcb9bf2ea0f5a957f9a");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "d1d426a922d74ff8a31936f9e905b3b7");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "da58f9f2cba2492682029425c56a3c10");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "eb7c17ab658c4851bbc7bc584b113a7c");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "fc1626207ed94d8380072bf67a74e6fc");

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: "26d8ec7cca444e87b07a246a551f7a6e");

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: "30eea12e080642998e0d031950eba20d");

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: "506458d889064ab7934ee797d267feb3");

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: "02f0710451de472cb3765cae550e3983");

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: "272ed288a22c4634b3df87347d436de3");

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: "34bd0db5cfea403e87a893e5d0bbdebb");

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: "552d3f9cfd5c413884a0c827ba1f3d2b");

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: "6091c9e41f494b34a171ca21602f16d8");

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: "87f6188d4c844bea9f06fa4d888e62dc");

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: "8c26eec9201f48eda89b368373553ef2");

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: "8de3c0542b3c44ddbfe7785aa265d1be");

            migrationBuilder.DeleteData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: "949c8566c6ed43a39663b92651ad281c");

            migrationBuilder.DeleteData(
                table: "Memberships",
                keyColumn: "Id",
                keyValue: "0383b1b8c4da4aeda3b15448582963a7");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "4aca89ad500a4ccf88fc387fb3203eba");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "7a9d724be0744dadbb70ee173af51278");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "9546c4a031e54038b1c0a1e91828db5c");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "961f548e2f214205b0ff0ab6028921ea");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "db16396ac6b14e19aa314ed1bab402c8");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "e404ea5e9e534b48b0bd2b4802c6af3a");

            migrationBuilder.DeleteData(
                table: "DogTypes",
                keyColumn: "Id",
                keyValue: "3e742350d1a342bb98abb9afd02a33aa");

            migrationBuilder.DeleteData(
                table: "DogTypes",
                keyColumn: "Id",
                keyValue: "addef8a118ea4285ab68a26583ba089a");

            migrationBuilder.DeleteData(
                table: "DogTypes",
                keyColumn: "Id",
                keyValue: "db92a74d1bca4738afa4d775b7f57aa4");

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
