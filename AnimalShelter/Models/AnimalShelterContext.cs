using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
      : base(options)
    {
    }

    public DbSet<Dog> Dogs { get; set; }
    public DbSet<Cat> Cats { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Dog>()
                .HasData(
                    new Dog { DogId = 1, Name = "Uma", Breed = "Pit Bull"},
                    new Dog { DogId = 2, Name = "Abner", Breed = "Australian Cattledog"},
                    new Dog { DogId = 3, Name = "Jackson", Breed = "Lab Mix"},
                    new Dog { DogId = 4, Name = "Aden", Breed = "Australian Cattledog"},
                    new Dog { DogId = 5, Name = "Meeks", Breed = "Lab Mix"},
                    new Dog { DogId = 6, Name = "Brett", Breed = "Retriever"},
                    new Dog { DogId = 7, Name = "Parker", Breed = "Pit Bull"},
                    new Dog { DogId = 8, Name = "Miss Precious", Breed = "Chihuahua"},
                    new Dog { DogId = 9, Name = "Chickie", Breed = "Pit Bull"},
                    new Dog { DogId = 10, Name = "Jasmine", Breed = "German Sheppard"} 
                );
            builder.Entity<Cat>()
                .HasData(
                    new Cat { CatId = 1, Name = "Baby Girl", Breed = "Short Hair"},
                    new Cat { CatId = 2, Name = "Inky", Breed = "Short Hair"},
                    new Cat { CatId = 3, Name = "Marley", Breed = "Siamese"},
                    new Cat { CatId = 4, Name = "Michael", Breed = "Short Hair"},
                    new Cat { CatId = 5, Name = "Paprika", Breed = "Short Hair"},
                    new Cat { CatId = 6, Name = "Poe", Breed = "Long Hair"},
                    new Cat { CatId = 7, Name = "Brutus", Breed = "Short Hair"},
                    new Cat { CatId = 8, Name = "Ludo", Breed = "Short Hair"},
                    new Cat { CatId = 9, Name = "Nala", Breed = "Long Hair"},
                    new Cat { CatId = 10, Name = "Turbo", Breed = "Siamese"}
                );
        }
  }
}