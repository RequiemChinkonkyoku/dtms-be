using Microsoft.EntityFrameworkCore;
using Models.Entities;
using System;

namespace Repositories.SeedingData
{
    public static class DogBreed
    {
        public static readonly string ChihuahuaBreedId = Guid.NewGuid().ToString("N");
        public static readonly string PomeranianBreedId = Guid.NewGuid().ToString("N");
        public static readonly string FrenchBulldogBreedId = Guid.NewGuid().ToString("N");

        public static readonly string CockerSpanielBreedId = Guid.NewGuid().ToString("N");
        public static readonly string BorderCollieBreedId = Guid.NewGuid().ToString("N");
        public static readonly string BeagleBreedId = Guid.NewGuid().ToString("N");

        public static readonly string GoldenRetrieverBreedId = Guid.NewGuid().ToString("N");
        public static readonly string GermanShepherdBreedId = Guid.NewGuid().ToString("N");
        public static readonly string RottweilerBreedId = Guid.NewGuid().ToString("N");

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
