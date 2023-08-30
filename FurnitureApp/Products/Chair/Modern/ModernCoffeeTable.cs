using FurnitureApp.Interfaces;

namespace FurnitureApp.Products.Chair.Modern;

public class ModernCoffeeTable: ICoffeeTable
{
    private const int Legs = 4;

    public bool HasLegs()
    {
        return Legs > 0;
    }

    public void PutOn()
    {
        Console.WriteLine("I'm putting something on a modern coffee table.");
    }
}