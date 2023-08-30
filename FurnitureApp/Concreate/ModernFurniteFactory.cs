using FurnitureApp.Interfaces;
using FurnitureApp.Products.Chair;
using FurnitureApp.Products.Chair.Modern;

namespace FurnitureApp.Concreate;

public class ModernFurniteFactory: IFurnitureFactory
{
    public IChair CreateChair()
    {
        return new ModernChair();
    }

    public ISofa CreateSofa()
    {
        return new ModernSofa();
    }

    public ICoffeeTable CreateCoffeeTable()
    {
        return new ModernCoffeeTable();
    }
}