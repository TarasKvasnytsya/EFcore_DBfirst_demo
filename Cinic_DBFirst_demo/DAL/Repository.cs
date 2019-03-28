using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cinic_DBFirst_demo.DAL
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity: class
    {
        protected readonly DbContext Context;

        public Repository(DbContext context)
        {
            Context = context;
        }

        public TEntity Get (int id)
        {
            return Context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Context.Set<TEntity>();
        }

        public EntityEntry<TEntity> Add(TEntity entity)
        {
            return Context.Set<TEntity>().Add(entity);
        }

        public EntityEntry<TEntity> Remove(TEntity entity)
        {
            return Context.Set<TEntity>().Remove(entity);
        }
    }
}
