using FurnitureApp.Interfaces;

namespace FurnitureApp.Products.Chair.Victorian;

public class VictorianChair: IChair
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