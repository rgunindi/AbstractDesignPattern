using FurnitureApp.Interfaces;

namespace FurnitureApp.Products.Chair.Modern;

public class ModernChair: IChair
{
    private const int Legs = 4;

    public bool HasLegs()
    {
        return Legs > 0;
    }

    public void SitOn()
    {
        Console.WriteLine("I'm sitting on a modern chair.");
    }
}