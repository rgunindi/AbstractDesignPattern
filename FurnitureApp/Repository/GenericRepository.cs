using FurnitureApp.Common;
using FurnitureApp.Context;
using FurnitureApp.Entities;
using FurnitureApp.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FurnitureApp.Repository;

public class GenericRepository<T>: IGenericRepositoryAsync<T> where T: BaseEntity
{
    private readonly FakeDbContext _context;
    public GenericRepository(FakeDbContext context)
    {
        _context = context;
    }
    public async Task<List<T>> GetAllAsync()
    {
        return await _context.Set<T>().ToListAsync();
    }

    public async Task<T> GetByIdAsync(Guid id)
    {
            return await _context.Set<T>().FindAsync(id) ?? throw new Exception("Entity not found");
    }
    public async Task<T> AddAsync(T entity)
    {
        await _context.AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }
}