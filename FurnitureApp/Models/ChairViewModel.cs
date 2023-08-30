using FurnitureApp.Common;
using FurnitureApp.Entities;

namespace FurnitureApp.Models;

public class ChairViewModel: BaseEntity
{
    public ChairViewModel(Chair c)
    {
        this.Name = c.Name;
        this.Price = c.Price;
        this.Description = c.Description;
    }
}