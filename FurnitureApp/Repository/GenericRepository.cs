using FurnitureApp.Common;
using FurnitureApp.Context;
using FurnitureApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace FurnitureApp.Repository;

public class GenericRepository<T>: IGenericRepositoryAsync<T> where T: BaseEntity
{
    private readonly FakeDbContext _context = new();
    public async Task<List<T>> GetAllAsync()
    {
        var all=await _context.Chairs.ToListAsync();
        return all.OfType<T>() as List<T>;
    }

    public async Task<T> GetByIdAsync(Guid id)
    {
        var p= await _context.Chairs.FindAsync(id);
        return p as T;
    }

    public async Task<T> AddAsync(T entity)
    {
        _context.Chairs.Add(entity as Chair);
        await _context.SaveChangesAsync();
        return entity;
    }
}