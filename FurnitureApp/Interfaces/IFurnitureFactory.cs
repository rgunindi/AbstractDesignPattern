namespace FurnitureApp.Interfaces;

public interface IFurnitureFactory
{
    public IChair CreateChair();
    public ISofa CreateSofa();
    public ICoffeeTable CreateCoffeeTable();
}

