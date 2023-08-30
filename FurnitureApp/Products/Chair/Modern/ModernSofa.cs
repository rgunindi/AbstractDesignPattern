using FurnitureApp.Interfaces;

namespace FurnitureApp.Products.Chair.Modern;

public class ModernSofa: ISofa
{
    private const int Legs = 4;
    private const int Seats = 3;

    public bool HasLegs()
    {
        return Legs > 0;
    }

    public int GetNumberOfSeats()
    {
        return Seats;
    }

    public void SitOn()
    {
        Console.WriteLine("I'm sitting on a modern sofa.");
    }
}