using System.ComponentModel.DataAnnotations;

namespace AnimalShelter.Models
{
  public class Dog
  {
    public int DogId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Breed { get; set; }
  }
}