using FurnitureApp.Context;
using FurnitureApp.Entities;

namespace FurnitureApp.Repository;

public class ChairRepository: GenericRepository<Chair>, IChairRepository
{
    public ChairRepository(FakeDbContext context) : base(context)
    {
    }
}