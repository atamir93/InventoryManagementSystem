using InventoryManagement.Domain.Common;
using InventoryManagement.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace InventoryManagement.Infrastructure.Repositories
{
    public class Repository<TEntity> : ICrudRepository<TEntity> where TEntity : class, IAggregateRoot
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<TEntity> _dbSet;
        public Repository()
        {
        }
        public Repository(ApplicationDbContext context)
        {
            this._context = context;
            this._dbSet = context.Set<TEntity>();
        }

        public IEnumerable<TEntity> List()
        {
            return _dbSet.ToList();
        }

        public TEntity GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Insert(TEntity entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entityToDelete = _dbSet.Find(id);
            _dbSet.Remove(entityToDelete);
            _context.SaveChanges();
        }
    }
}
