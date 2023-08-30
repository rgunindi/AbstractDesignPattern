using FurnitureApp.Common;
using FurnitureApp.Entities;

namespace FurnitureApp.Models;

public class ChairViewModel 
{
    public string Name { get; set; } = null!;
    public decimal Price { get; set; }
    public string Description { get; set; } = null!;
    public ChairViewModel(Chair c)
    {
        this.Name = c.Name;
        this.Price = c.Price;
        this.Description = c.Description;
    }
}