using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Data.Common.Interfaces;
using ToDo.Data.DbContexts;
using ToDo.Data.Interfaces;

namespace ToDo.Data.Repositories
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly AppDbContext _dbContext;
        protected DbSet<T> _dbSet;
        public GenericRepository()
        {
            _dbContext = new AppDbContext();
            _dbSet = _dbContext.Set<T>();
        }
        public virtual async Task<bool> CreateAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            return true;
        }

        public virtual async Task<IEnumerable<T>> ReadAllAsync()
        {
            throw new NotImplementedException();
        }

        public virtual async Task<T> ReadAsync(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            return entity;
        }

        public virtual async Task<T> UpdateAsync(int id, T entity)
        {
            return _dbSet.Update(entity).Entity;
        }

        public virtual async Task<T> DeleteAsync(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            _dbSet.Remove(entity);
            return entity;
        }
    }
}
