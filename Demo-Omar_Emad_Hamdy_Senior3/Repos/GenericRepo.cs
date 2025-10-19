
using Demo_Omar_Emad_Hamdy_Senior3.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo_Omar_Emad_Hamdy_Senior3.Repos
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        readonly AppDbContext _db;
        readonly DbSet<T> _dbSet;

        public GenericRepo(AppDbContext db)
        {
            _db = db;
            _dbSet = _db.Set<T>();
        }

        public async Task AddAsync(T entity)
        {
           await _dbSet.AddAsync(entity);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
          _dbSet.Remove(entity);
           await _db.SaveChangesAsync();
        }

        public async Task findAsync(int id)
        {
            await _dbSet.FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
           return await _dbSet.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task SaveAsync(T entity)
        {
           await _db.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
             _dbSet.Update(entity);
            await _db.SaveChangesAsync();
        }
    }
}