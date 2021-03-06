using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstagramApp.Repository.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> Table { get; }
        Task<TEntity> GetEntity(object id);
        Task<List<TEntity>> GetEntities();
        Task<TEntity> InsertEntity(TEntity entity);
        Task<TEntity> UpdateEntity(TEntity entity);
        Task InsertEntities(List<TEntity> entities);
        Task DeleteEntity(TEntity entity);
    }
}
