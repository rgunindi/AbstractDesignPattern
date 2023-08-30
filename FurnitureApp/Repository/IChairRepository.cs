using FurnitureApp.Entities;

namespace FurnitureApp.Repository;

public interface IChairRepository: IGenericRepositoryAsync<Chair>
{
    Task<List<Chair>> GetAllAsync();
}