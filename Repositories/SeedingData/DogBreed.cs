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
                }
            );
        }
    }
}
