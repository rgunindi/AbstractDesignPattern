using System.ComponentModel.DataAnnotations;
using FurnitureApp.Entities;

namespace FurnitureApp.Models;

public class ChairViewModel 
{
    public string Name { get; set; }= null!;
    [Required]
    public decimal Price { get; set; }
    public string Description { get; set; } = null!;
    public modelType ModelType { get; set; }
    public ChairViewModel(Chair c)
    {
        Name = c.Name;
        Price = c.Price;
        Description = c.Description;
        ModelType = c.ModelType;
    }
}