using Microsoft.EntityFrameworkCore;
using Models.Entities;
using System;

namespace Repositories.SeedingData
{
    public static class DogBreed
    {
        public static readonly string ChihuahuaBreedId = "4bee6ab4f7f841d69bacedcfd25c8d07";
        public static readonly string PomeranianBreedId = "a8f5f1675aaf4d1b8f7c8d924d3c3c4b";
        public static readonly string FrenchBulldogBreedId = "bb57a3e3cd2048e88e02f5b87a935a62";

        public static readonly string CockerSpanielBreedId = "c1a3ebdb3bfa44cc81f3a1f6205f8b64";
        public static readonly string BorderCollieBreedId = "df76e3ed02444a61ad1efba0a5b75f06";
        public static readonly string BeagleBreedId = "e478aa3ff61d4b6f88d3b3e3a7f47b14";

        public static readonly string GoldenRetrieverBreedId = "f3c7da2e95764c47be56aeb742ecf3b1";
        public static readonly string GermanShepherdBreedId = "0d4f1f5a2b4a45d699cf43a66f5b8b22";
        public static readonly string RottweilerBreedId = "1a5c9e4f7d884cf2a3f99e26c7b5a081";
        
        public static readonly string LabradorRetrieverBreedId = "3247294f9f9a45c8955199c3066192c9";
        public static readonly string BulldogBreedId = "b5f376ebf99a4a8293f18a0c271290ab";
        public static readonly string PoodleBreedId = "63d611f7216246499e46b6defb6098b9";
        public static readonly string GermanShorthairedPointerBreedId = "e2b8d97535d84818bc98a69b49d8bdfc";
        public static readonly string YorkshireTerrierBreedId = "e27a5039f2324051af1d7e1734640af8";
        public static readonly string BoxerBreedId = "a38bbb30b1184f519e2fe22e50bd668f";
        public static readonly string DachshundBreedId = "2a5dc45831ec40db8c5dc56e813da54e";
        public static readonly string PembrokeWelshCorgiBreedId = "50984473e08e4ed192f04b0f8e9bdbbc";
        public static readonly string SiberianHuskyBreedId = "a249c57a19bc4e6a8174dbdbd5d96d03";
        public static readonly string AustralianShepherdBreedId = "11ec1c0720c84e068dedad95fb3827ee";
        public static readonly string GreatDaneBreedId = "e148682139144675bf904b81cb3fb708";
        public static readonly string DobermanPinscherBreedId = "3fb47571a051449eaa74e41d6d49bc94";
        public static readonly string CavalierKingCharlesSpanielBreedId = "f92e30c58b4549318d638b83eeb51484";
        public static readonly string MiniatureSchnauzerBreedId = "4188b09d5c4f474896c765a5a08b9cfb";
        public static readonly string ShihTzuBreedId = "a963c667cf274b89988003c07e055957";
        public static readonly string BostonTerrierBreedId = "706a3f97e49a4faab7030d0224610128";
        public static readonly string BerneseMountainDogBreedId = "a72974af6cf54b3fb422bbdfba0f2f76";
        public static readonly string HavaneseBreedId = "1577dcfd85ba4161b5872ec670182636";
        public static readonly string ShetlandSheepdogBreedId = "3b64dbd9ce1340bc9600730198ccabdd";
        public static readonly string BrittanyBreedId = "ae994be25bfd4989aa07edf1bdca7d6e";
        public static readonly string EnglishSpringerSpanielBreedId = "b48b0357529246698aff1eec4f5f7305";
        public static readonly string MiniatureAmericanShepherdBreedId = "7323fb393bbd4203ab6a532eb2d12d2f";
        public static readonly string VizslaBreedId = "7338ded54afe4ca29edfc4194ebdb498";
        public static readonly string MastiffBreedId = "7b070734a2be4c41b2053ae04298ef03";
        public static readonly string BassetHoundBreedId = "a240c5a7f2384416a1b3a700990a5980";
        public static readonly string BelgianMalinoisBreedId = "c3a1d2c1607b412d9a11276ce4dcb373";
        public static readonly string WeimaranerBreedId = "10cb65b3564d4a73977a25e9c5b8d6e8";
        public static readonly string NewfoundlandBreedId = "0c1f80749c0c4e089675a9ea29700828";
        public static readonly string CollieBreedId = "57ff7e29579f44e7a6caa6d502d6e706";
        public static readonly string RhodesianRidgebackBreedId = "80eac71cdfb84d67856a14932cfe1fbe";
        public static readonly string WestHighlandWhiteTerrierBreedId = "5aed9503cb1a4bce800649097bc6b24d";
        public static readonly string ShibaInuBreedId = "0604f18f9462485d9e917cab75fabe72";
        public static readonly string BichonFriseBreedId = "1891cb0aff3242cbaf3d7b7f221b8202";
        public static readonly string AkitaBreedId = "90596631df314cfdabfcfe561a524522";
        public static readonly string StBernardBreedId = "e8043d1c5e8b442b922f474a136a60eb";
        public static readonly string BloodhoundBreedId = "792b660e12044960b3ab6ad5abc56d6f";
        public static readonly string AlaskanMalamuteBreedId = "501e6dfe8dd949b4a844d508692afd55";
        public static readonly string WhippetBreedId = "e9ebc2a0ac8e459aa04c2ed7e83ec102";
        public static readonly string AiredaleTerrierBreedId = "574f28a6245f4f059ae91fdfd92ddc1d";
        public static readonly string PortugueseWaterDogBreedId = "7de7d8ca3eaf4ff48c9148f58f2ffa01";
        public static readonly string ChineseSharPeiBreedId = "4cb17f9f4b8a4c1eb72995423b43c7de";
        public static readonly string ScottishTerrierBreedId = "b4260400258b4916bd262102ad2a4f57";
        public static readonly string PapillonBreedId = "cdddcdc9a46a452ba6cc3386c8e4c5de";
        public static readonly string BullmastiffBreedId = "f7bed420fbe54d439b6a2fe9a0973f4e";
        public static readonly string SoftCoatedWheatenTerrierBreedId = "c966e96cf32a46e7919e96e6fb087d7f";
        public static readonly string SamoyedBreedId = "636b28ff298d4917b7d0a5bdd4914fa9";
        public static readonly string CaneCorsoBreedId = "b77812b2f7ac424192ce0bf42c109d1d";
        public static readonly string AustralianCattleDogBreedId = "2bcb15b6ecf54feaba45b81e3d95ef0c";
        public static readonly string ChesapeakeBayRetrieverBreedId = "6763770460cd4dad871f2b8caaf11bac";
        public static readonly string LhasaApsoBreedId = "722b2de40ac640ae8babe339aaeea6fb";
        public static readonly string IrishSetterBreedId = "72a72d9ee54144d29d8c9ad68d8f7a9d";
        public static readonly string StaffordshireBullTerrierBreedId = "77c1151900174e078357ba5cdd43837c";
        public static readonly string BasenjiBreedId = "e12d89fc61db4b95a731112865ca8418";
        public static readonly string ToyPoodleBreedId = "23db7f587fb0407c84eac0a69661a489";
        public static readonly string IrishWolfhoundBreedId = "68e3ddfd1bd64938879a424da8ecad8a";
        public static readonly string AnatolianShepherdDogBreedId = "feea0d621a2c4c7bba462678e307256a";
        public static readonly string SilkyTerrierBreedId = "2deb9f4780f94499b9d11f77cb89b788";
        public static readonly string ItalianGreyhoundBreedId = "82effcb73e9a459cb1d120d407ba58a6";
        public static readonly string JapaneseChinBreedId = "b66739fcf3cb445bbb6edf4bfa95559e";
        public static readonly string NorwegianElkhoundBreedId = "9252e36058624f91b8a2255d540f0d53";
        public static readonly string TibetanTerrierBreedId = "b681f01741674236b3ceb3cf5e07f9f7";
        public static readonly string BelgianTervurenBreedId = "d858c29c5daf4e7e8e6efc4928a33907";
        public static readonly string ManchesterTerrierBreedId = "e79077ac5b5e433c97408a5ac33bb928";
        public static readonly string GreatPyreneesBreedId = "c4fa9665f1a04ccf91a6f7a1e51e2803";
        public static readonly string BeauceronBreedId = "2cac44e97cca43bda05c6f77363be8fd";
        public static readonly string AmericanStaffordshireTerrierBreedId = "c90f005329034e7da7470c5d1034fad5";
        public static readonly string RatTerrierBreedId = "9ad624b6947f4ef8a7b284ef37c82d1e";
        public static readonly string AmericanEskimoDogBreedId = "5953ec316f62480cbe50e868f40fb7f6";
        public static readonly string KeeshondBreedId = "9d25369141a94632ad9564019f6e9c44";
        public static readonly string SchipperkeBreedId = "77a7755020e7437286c141428f04d9c1";
        public static readonly string EnglishSetterBreedId = "61d1a8c088074009af469411bab9b247";
        public static readonly string BrusselsGriffonBreedId = "ea0463cc67f2412ba33f9fab41f5c893";
        public static readonly string NorwichTerrierBreedId = "edc260ee91c74ca7bb01da2f9cd786cb";
        public static readonly string ClumberSpanielBreedId = "eb59e3e86d804e36a4c6ca72bc5f71cd";
        public static readonly string RedboneCoonhoundBreedId = "b99d79dd26364ac799a19dacc7fc55a7";
        public static readonly string DandieDinmontTerrierBreedId = "de8b46b081d44d5186263c7efeefbba4";
        public static readonly string CurlyCoatedRetrieverBreedId = "8fb63e6cc8af48ceb9f9ba05c5fc9c81";
        public static readonly string KomondorBreedId = "bdca1920ec75441d99ca4091fb1fe392";
        public static readonly string SalukiBreedId = "88aa8ff5db1941ccbb0dabe0ce20a852";
        public static readonly string BelgianSheepdogBreedId = "7c69704cecd5436fbb389648a98b846d";
        public static readonly string PlottBreedId = "f0e8d662d0374b3baae37c193b21fa7d";
        public static readonly string BorzoiBreedId = "a890604e55bb4bef9ad623df4fbfe360";
        public static readonly string NorfolkTerrierBreedId = "ecfbc638fce442b89abe339d172580fb";
        public static readonly string AfghanHoundBreedId = "cc9b408851244bf2996c3b2141a9db03";
        public static readonly string FinnishSpitzBreedId = "5e2190b75f9b465e8123dcb437bd7017";
        public static readonly string SealyhamTerrierBreedId = "10cefed27da643429ef45930a5d9a89e";
        public static readonly string GlenOfImaalTerrierBreedId = "983ada75a4ea4f978ebae7ab4ee8dafc";
        public static readonly string BoerboelBreedId = "63a7634d18064455aea386593f6fa90b";
        public static readonly string TibetanSpanielBreedId = "ce93ff279a1c40758c900da5701e1f8f";
        public static readonly string FoxTerrierBreedId = "4f8d45bd3c794a56aa45073b5200bbe7";
        public static readonly string EntlebucherMountainDogBreedId = "8fe869ef7bd945b4b285b05975e84a2f";
        public static readonly string LeonbergerBreedId = "737052045aae413db7021d8196bb0839";
        public static readonly string SwedishVallhundBreedId = "77c4a51b84af4e62aa55dacd1f0d2131";
        public static readonly string FieldSpanielBreedId = "913c9f3e14fe4ffda2de8c3a80a388c0";
        

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Entities.DogBreed>().HasData(
                // Small Dog Breeds
                new Models.Entities.DogBreed
                {
                    Id = ChihuahuaBreedId,
                    Name = "Chihuahua",
                    Description = "A tiny breed known for its lively personality.",
                    Status = 1,
                    DogTypeId = DogType.SmallDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = PomeranianBreedId,
                    Name = "Pomeranian",
                    Description = "A fluffy and energetic small breed.",
                    Status = 1,
                    DogTypeId = DogType.SmallDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = FrenchBulldogBreedId,
                    Name = "French Bulldog",
                    Description = "A small, muscular dog with a distinctive bat-like ear shape.",
                    Status = 1,
                    DogTypeId = DogType.SmallDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },

                // Medium Dog Breeds
                new Models.Entities.DogBreed
                {
                    Id = CockerSpanielBreedId,
                    Name = "Cocker Spaniel",
                    Description = "A friendly and intelligent medium-sized breed.",
                    Status = 1,
                    DogTypeId = DogType.MediumDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = BorderCollieBreedId,
                    Name = "Border Collie",
                    Description = "A highly intelligent and energetic breed.",
                    Status = 1,
                    DogTypeId = DogType.MediumDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = BeagleBreedId,
                    Name = "Beagle",
                    Description = "A curious and friendly breed known for its great sense of smell.",
                    Status = 1,
                    DogTypeId = DogType.MediumDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },

                // Large Dog Breeds
                new Models.Entities.DogBreed
                {
                    Id = GoldenRetrieverBreedId,
                    Name = "Golden Retriever",
                    Description = "A friendly and intelligent large breed.",
                    Status = 1,
                    DogTypeId = DogType.LargeDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = GermanShepherdBreedId,
                    Name = "German Shepherd",
                    Description = "A strong and intelligent breed used in working roles.",
                    Status = 1,
                    DogTypeId = DogType.LargeDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = RottweilerBreedId,
                    Name = "Rottweiler",
                    Description = "A loyal and protective breed, often used as a guard dog.",
                    Status = 1,
                    DogTypeId = DogType.LargeDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },

                new Models.Entities.DogBreed
                {
                    Id = LabradorRetrieverBreedId,
                    Name = "Labrador Retriever",
                    Description = "Labrador Retriever breed description.",
                    Status = 1,
                    DogTypeId = DogType.LargeDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },

                new Models.Entities.DogBreed
                {
                    Id = BulldogBreedId,
                    Name = "Bulldog",
                    Description = "Bulldog breed description.",
                    Status = 1,
                    DogTypeId = DogType.MediumDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = PoodleBreedId,
                    Name = "Poodle",
                    Description = "Poodle breed description.",
                    Status = 1,
                    DogTypeId = DogType.MediumDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                
                new Models.Entities.DogBreed
                {
                    Id = GermanShorthairedPointerBreedId,
                    Name = "German Shorthaired Pointer",
                    Description = "German Shorthaired Pointer breed description.",
                    Status = 1,
                    DogTypeId = DogType.MediumDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = YorkshireTerrierBreedId,
                    Name = "Yorkshire Terrier",
                    Description = "Yorkshire Terrier breed description.",
                    Status = 1,
                    DogTypeId = DogType.SmallDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = BoxerBreedId,
                    Name = "Boxer",
                    Description = "Boxer breed description.",
                    Status = 1,
                    DogTypeId = DogType.LargeDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = DachshundBreedId,
                    Name = "Dachshund",
                    Description = "Dachshund breed description.",
                    Status = 1,
                    DogTypeId = DogType.SmallDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = PembrokeWelshCorgiBreedId,
                    Name = "Pembroke Welsh Corgi",
                    Description = "Pembroke Welsh Corgi breed description.",
                    Status = 1,
                    DogTypeId = DogType.SmallDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = SiberianHuskyBreedId,
                    Name = "Siberian Husky",
                    Description = "Siberian Husky breed description.",
                    Status = 1,
                    DogTypeId = DogType.MediumDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = AustralianShepherdBreedId,
                    Name = "Australian Shepherd",
                    Description = "Australian Shepherd breed description.",
                    Status = 1,
                    DogTypeId = DogType.MediumDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = GreatDaneBreedId,
                    Name = "Great Dane",
                    Description = "Great Dane breed description.",
                    Status = 1,
                    DogTypeId = DogType.LargeDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = DobermanPinscherBreedId,
                    Name = "Doberman Pinscher",
                    Description = "Doberman Pinscher breed description.",
                    Status = 1,
                    DogTypeId = DogType.LargeDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = CavalierKingCharlesSpanielBreedId,
                    Name = "Cavalier King Charles Spaniel",
                    Description = "Cavalier King Charles Spaniel breed description.",
                    Status = 1,
                    DogTypeId = DogType.SmallDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = MiniatureSchnauzerBreedId,
                    Name = "Miniature Schnauzer",
                    Description = "Miniature Schnauzer breed description.",
                    Status = 1,
                    DogTypeId = DogType.SmallDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = ShihTzuBreedId,
                    Name = "Shih Tzu",
                    Description = "Shih Tzu breed description.",
                    Status = 1,
                    DogTypeId = DogType.SmallDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = BostonTerrierBreedId,
                    Name = "Boston Terrier",
                    Description = "Boston Terrier breed description.",
                    Status = 1,
                    DogTypeId = DogType.SmallDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = BerneseMountainDogBreedId,
                    Name = "Bernese Mountain Dog",
                    Description = "Bernese Mountain Dog breed description.",
                    Status = 1,
                    DogTypeId = DogType.LargeDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
               
                new Models.Entities.DogBreed
                {
                    Id = HavaneseBreedId,
                    Name = "Havanese",
                    Description = "Havanese breed description.",
                    Status = 1,
                    DogTypeId = DogType.SmallDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = ShetlandSheepdogBreedId,
                    Name = "Shetland Sheepdog",
                    Description = "Shetland Sheepdog breed description.",
                    Status = 1,
                    DogTypeId = DogType.MediumDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = BrittanyBreedId,
                    Name = "Brittany",
                    Description = "Brittany breed description.",
                    Status = 1,
                    DogTypeId = DogType.MediumDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = EnglishSpringerSpanielBreedId,
                    Name = "English Springer Spaniel",
                    Description = "English Springer Spaniel breed description.",
                    Status = 1,
                    DogTypeId = DogType.MediumDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                
                new Models.Entities.DogBreed
                {
                    Id = MiniatureAmericanShepherdBreedId,
                    Name = "Miniature American Shepherd",
                    Description = "Miniature American Shepherd breed description.",
                    Status = 1,
                    DogTypeId = DogType.MediumDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
               
                new Models.Entities.DogBreed
                {
                    Id = VizslaBreedId,
                    Name = "Vizsla",
                    Description = "Vizsla breed description.",
                    Status = 1,
                    DogTypeId = DogType.MediumDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                
                new Models.Entities.DogBreed
                {
                    Id = MastiffBreedId,
                    Name = "Mastiff",
                    Description = "Mastiff breed description.",
                    Status = 1,
                    DogTypeId = DogType.LargeDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = BassetHoundBreedId,
                    Name = "Basset Hound",
                    Description = "Basset Hound breed description.",
                    Status = 1,
                    DogTypeId = DogType.MediumDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = BelgianMalinoisBreedId,
                    Name = "Belgian Malinois",
                    Description = "Belgian Malinois breed description.",
                    Status = 1,
                    DogTypeId = DogType.LargeDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = WeimaranerBreedId,
                    Name = "Weimaraner",
                    Description = "Weimaraner breed description.",
                    Status = 1,
                    DogTypeId = DogType.LargeDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = NewfoundlandBreedId,
                    Name = "Newfoundland",
                    Description = "Newfoundland breed description.",
                    Status = 1,
                    DogTypeId = DogType.LargeDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = CollieBreedId,
                    Name = "Collie",
                    Description = "Collie breed description.",
                    Status = 1,
                    DogTypeId = DogType.MediumDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = RhodesianRidgebackBreedId,
                    Name = "Rhodesian Ridgeback",
                    Description = "Rhodesian Ridgeback breed description.",
                    Status = 1,
                    DogTypeId = DogType.LargeDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = WestHighlandWhiteTerrierBreedId,
                    Name = "West Highland White Terrier",
                    Description = "West Highland White Terrier breed description.",
                    Status = 1,
                    DogTypeId = DogType.SmallDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = ShibaInuBreedId,
                    Name = "Shiba Inu",
                    Description = "Shiba Inu breed description.",
                    Status = 1,
                    DogTypeId = DogType.MediumDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = BichonFriseBreedId,
                    Name = "Bichon Frise",
                    Description = "Bichon Frise breed description.",
                    Status = 1,
                    DogTypeId = DogType.SmallDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = AkitaBreedId,
                    Name = "Akita",
                    Description = "Akita breed description.",
                    Status = 1,
                    DogTypeId = DogType.LargeDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = StBernardBreedId,
                    Name = "St. Bernard",
                    Description = "St. Bernard breed description.",
                    Status = 1,
                    DogTypeId = DogType.LargeDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = BloodhoundBreedId,
                    Name = "Bloodhound",
                    Description = "Bloodhound breed description.",
                    Status = 1,
                    DogTypeId = DogType.LargeDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = AlaskanMalamuteBreedId,
                    Name = "Alaskan Malamute",
                    Description = "Alaskan Malamute breed description.",
                    Status = 1,
                    DogTypeId = DogType.LargeDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = WhippetBreedId,
                    Name = "Whippet",
                    Description = "Whippet breed description.",
                    Status = 1,
                    DogTypeId = DogType.MediumDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = AiredaleTerrierBreedId,
                    Name = "Airedale Terrier",
                    Description = "Airedale Terrier breed description.",
                    Status = 1,
                    DogTypeId = DogType.MediumDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = PortugueseWaterDogBreedId,
                    Name = "Portuguese Water Dog",
                    Description = "Portuguese Water Dog breed description.",
                    Status = 1,
                    DogTypeId = DogType.MediumDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = ChineseSharPeiBreedId,
                    Name = "Chinese Shar-Pei",
                    Description = "Chinese Shar-Pei breed description.",
                    Status = 1,
                    DogTypeId = DogType.MediumDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = ScottishTerrierBreedId,
                    Name = "Scottish Terrier",
                    Description = "Scottish Terrier breed description.",
                    Status = 1,
                    DogTypeId = DogType.SmallDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = PapillonBreedId,
                    Name = "Papillon",
                    Description = "Papillon breed description.",
                    Status = 1,
                    DogTypeId = DogType.SmallDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = BullmastiffBreedId,
                    Name = "Bullmastiff",
                    Description = "Bullmastiff breed description.",
                    Status = 1,
                    DogTypeId = DogType.LargeDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = SoftCoatedWheatenTerrierBreedId,
                    Name = "Soft Coated Wheaten Terrier",
                    Description = "Soft Coated Wheaten Terrier breed description.",
                    Status = 1,
                    DogTypeId = DogType.MediumDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = SamoyedBreedId,
                    Name = "Samoyed",
                    Description = "Samoyed breed description.",
                    Status = 1,
                    DogTypeId = DogType.MediumDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = CaneCorsoBreedId,
                    Name = "Cane Corso",
                    Description = "Cane Corso breed description.",
                    Status = 1,
                    DogTypeId = DogType.LargeDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = AustralianCattleDogBreedId,
                    Name = "Australian Cattle Dog",
                    Description = "Australian Cattle Dog breed description.",
                    Status = 1,
                    DogTypeId = DogType.MediumDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = ChesapeakeBayRetrieverBreedId,
                    Name = "Chesapeake Bay Retriever",
                    Description = "Chesapeake Bay Retriever breed description.",
                    Status = 1,
                    DogTypeId = DogType.LargeDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = LhasaApsoBreedId,
                    Name = "Lhasa Apso",
                    Description = "Lhasa Apso breed description.",
                    Status = 1,
                    DogTypeId = DogType.SmallDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = IrishSetterBreedId,
                    Name = "Irish Setter",
                    Description = "Irish Setter breed description.",
                    Status = 1,
                    DogTypeId = DogType.LargeDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = StaffordshireBullTerrierBreedId,
                    Name = "Staffordshire Bull Terrier",
                    Description = "Staffordshire Bull Terrier breed description.",
                    Status = 1,
                    DogTypeId = DogType.MediumDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = BasenjiBreedId,
                    Name = "Basenji",
                    Description = "Basenji breed description.",
                    Status = 1,
                    DogTypeId = DogType.MediumDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = ToyPoodleBreedId,
                    Name = "Toy Poodle",
                    Description = "Toy Poodle breed description.",
                    Status = 1,
                    DogTypeId = DogType.SmallDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = IrishWolfhoundBreedId,
                    Name = "Irish Wolfhound",
                    Description = "Irish Wolfhound breed description.",
                    Status = 1,
                    DogTypeId = DogType.LargeDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = AnatolianShepherdDogBreedId,
                    Name = "Anatolian Shepherd Dog",
                    Description = "Anatolian Shepherd Dog breed description.",
                    Status = 1,
                    DogTypeId = DogType.LargeDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = SilkyTerrierBreedId,
                    Name = "Silky Terrier",
                    Description = "Silky Terrier breed description.",
                    Status = 1,
                    DogTypeId = DogType.SmallDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = ItalianGreyhoundBreedId,
                    Name = "Italian Greyhound",
                    Description = "Italian Greyhound breed description.",
                    Status = 1,
                    DogTypeId = DogType.SmallDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = JapaneseChinBreedId,
                    Name = "Japanese Chin",
                    Description = "Japanese Chin breed description.",
                    Status = 1,
                    DogTypeId = DogType.SmallDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = NorwegianElkhoundBreedId,
                    Name = "Norwegian Elkhound",
                    Description = "Norwegian Elkhound breed description.",
                    Status = 1,
                    DogTypeId = DogType.MediumDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = TibetanTerrierBreedId,
                    Name = "Tibetan Terrier",
                    Description = "Tibetan Terrier breed description.",
                    Status = 1,
                    DogTypeId = DogType.MediumDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = BelgianTervurenBreedId,
                    Name = "Belgian Tervuren",
                    Description = "Belgian Tervuren breed description.",
                    Status = 1,
                    DogTypeId = DogType.MediumDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = ManchesterTerrierBreedId,
                    Name = "Manchester Terrier",
                    Description = "Manchester Terrier breed description.",
                    Status = 1,
                    DogTypeId = DogType.SmallDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = GreatPyreneesBreedId,
                    Name = "Great Pyrenees",
                    Description = "Great Pyrenees breed description.",
                    Status = 1,
                    DogTypeId = DogType.LargeDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = BeauceronBreedId,
                    Name = "Beauceron",
                    Description = "Beauceron breed description.",
                    Status = 1,
                    DogTypeId = DogType.LargeDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = AmericanStaffordshireTerrierBreedId,
                    Name = "American Staffordshire Terrier",
                    Description = "American Staffordshire Terrier breed description.",
                    Status = 1,
                    DogTypeId = DogType.MediumDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = RatTerrierBreedId,
                    Name = "Rat Terrier",
                    Description = "Rat Terrier breed description.",
                    Status = 1,
                    DogTypeId = DogType.SmallDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = AmericanEskimoDogBreedId,
                    Name = "American Eskimo Dog",
                    Description = "American Eskimo Dog breed description.",
                    Status = 1,
                    DogTypeId = DogType.SmallDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = KeeshondBreedId,
                    Name = "Keeshond",
                    Description = "Keeshond breed description.",
                    Status = 1,
                    DogTypeId = DogType.MediumDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = SchipperkeBreedId,
                    Name = "Schipperke",
                    Description = "Schipperke breed description.",
                    Status = 1,
                    DogTypeId = DogType.SmallDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = EnglishSetterBreedId,
                    Name = "English Setter",
                    Description = "English Setter breed description.",
                    Status = 1,
                    DogTypeId = DogType.MediumDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = BrusselsGriffonBreedId,
                    Name = "Brussels Griffon",
                    Description = "Brussels Griffon breed description.",
                    Status = 1,
                    DogTypeId = DogType.SmallDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = NorwichTerrierBreedId,
                    Name = "Norwich Terrier",
                    Description = "Norwich Terrier breed description.",
                    Status = 1,
                    DogTypeId = DogType.SmallDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = ClumberSpanielBreedId,
                    Name = "Clumber Spaniel",
                    Description = "Clumber Spaniel breed description.",
                    Status = 1,
                    DogTypeId = DogType.MediumDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = RedboneCoonhoundBreedId,
                    Name = "Redbone Coonhound",
                    Description = "Redbone Coonhound breed description.",
                    Status = 1,
                    DogTypeId = DogType.MediumDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = DandieDinmontTerrierBreedId,
                    Name = "Dandie Dinmont Terrier",
                    Description = "Dandie Dinmont Terrier breed description.",
                    Status = 1,
                    DogTypeId = DogType.SmallDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = CurlyCoatedRetrieverBreedId,
                    Name = "Curly-Coated Retriever",
                    Description = "Curly-Coated Retriever breed description.",
                    Status = 1,
                    DogTypeId = DogType.LargeDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = KomondorBreedId,
                    Name = "Komondor",
                    Description = "Komondor breed description.",
                    Status = 1,
                    DogTypeId = DogType.LargeDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = SalukiBreedId,
                    Name = "Saluki",
                    Description = "Saluki breed description.",
                    Status = 1,
                    DogTypeId = DogType.LargeDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = BelgianSheepdogBreedId,
                    Name = "Belgian Sheepdog",
                    Description = "Belgian Sheepdog breed description.",
                    Status = 1,
                    DogTypeId = DogType.LargeDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = PlottBreedId,
                    Name = "Plott",
                    Description = "Plott breed description.",
                    Status = 1,
                    DogTypeId = DogType.MediumDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = BorzoiBreedId,
                    Name = "Borzoi",
                    Description = "Borzoi breed description.",
                    Status = 1,
                    DogTypeId = DogType.LargeDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = NorfolkTerrierBreedId,
                    Name = "Norfolk Terrier",
                    Description = "Norfolk Terrier breed description.",
                    Status = 1,
                    DogTypeId = DogType.SmallDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = AfghanHoundBreedId,
                    Name = "Afghan Hound",
                    Description = "Afghan Hound breed description.",
                    Status = 1,
                    DogTypeId = DogType.LargeDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = FinnishSpitzBreedId,
                    Name = "Finnish Spitz",
                    Description = "Finnish Spitz breed description.",
                    Status = 1,
                    DogTypeId = DogType.MediumDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = SealyhamTerrierBreedId,
                    Name = "Sealyham Terrier",
                    Description = "Sealyham Terrier breed description.",
                    Status = 1,
                    DogTypeId = DogType.SmallDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = GlenOfImaalTerrierBreedId,
                    Name = "Glen of Imaal Terrier",
                    Description = "Glen of Imaal Terrier breed description.",
                    Status = 1,
                    DogTypeId = DogType.SmallDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = BoerboelBreedId,
                    Name = "Boerboel",
                    Description = "Boerboel breed description.",
                    Status = 1,
                    DogTypeId = DogType.LargeDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = TibetanSpanielBreedId,
                    Name = "Tibetan Spaniel",
                    Description = "Tibetan Spaniel breed description.",
                    Status = 1,
                    DogTypeId = DogType.SmallDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = FoxTerrierBreedId,
                    Name = "Fox Terrier",
                    Description = "Fox Terrier breed description.",
                    Status = 1,
                    DogTypeId = DogType.SmallDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = EntlebucherMountainDogBreedId,
                    Name = "Entlebucher Mountain Dog",
                    Description = "Entlebucher Mountain Dog breed description.",
                    Status = 1,
                    DogTypeId = DogType.MediumDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = LeonbergerBreedId,
                    Name = "Leonberger",
                    Description = "Leonberger breed description.",
                    Status = 1,
                    DogTypeId = DogType.LargeDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = SwedishVallhundBreedId,
                    Name = "Swedish Vallhund",
                    Description = "Swedish Vallhund breed description.",
                    Status = 1,
                    DogTypeId = DogType.MediumDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Models.Entities.DogBreed
                {
                    Id = FieldSpanielBreedId,
                    Name = "Field Spaniel",
                    Description = "Field Spaniel breed description.",
                    Status = 1,
                    DogTypeId = DogType.MediumDogTypeId,
                    CreatedTime = new DateTimeOffset(new DateTime(2000, 1, 1)),
                    LastUpdatedTime = new DateTimeOffset(new DateTime(2000, 1, 1))
                }
            );
        }
    }
}
