using FurnitureApp.Interfaces;

namespace FurnitureApp.Products.Chair.Victorian;

public class VictorianCoffeeTable: ICoffeeTable
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