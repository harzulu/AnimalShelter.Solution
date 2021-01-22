using System.ComponentModel.DataAnnotations;

namespace AnimalShelter.Models
{
  public class Cat
  {
    public int CatId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Breed { get; set; }
  }
}