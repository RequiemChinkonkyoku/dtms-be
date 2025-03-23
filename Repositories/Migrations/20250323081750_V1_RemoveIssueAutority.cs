using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class V1_RemoveIssueAutority : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "IssuingAuthority",
                table: "DogDocuments");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "IssuingAuthority",
                table: "DogDocuments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
    }
}
