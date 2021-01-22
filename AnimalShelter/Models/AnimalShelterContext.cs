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
        }
    public DbSet<Cat> Cats { get; set; }
  }
}