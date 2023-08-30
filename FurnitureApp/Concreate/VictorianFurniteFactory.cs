using FurnitureApp.Interfaces;

namespace FurnitureApp.Concreate;

public class VictorianFurniteFactory: IFurnitureFactory
{
    public IChair CreateChair()
    {
        throw new NotImplementedException();
    }

    public ISofa CreateSofa()
    {
        throw new NotImplementedException();
    }

    public ICoffeeTable CreateCoffeeTable()
    {
        throw new NotImplementedException();
    }
}