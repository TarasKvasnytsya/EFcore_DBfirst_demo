using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cinic_DBFirst_demo.DAL
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Get(int id);
        Task<IEnumerable<TEntity>> GetAll();

        EntityEntry<TEntity> Add(TEntity entity);
        EntityEntry<TEntity> Remove(TEntity entity);
    }
}
