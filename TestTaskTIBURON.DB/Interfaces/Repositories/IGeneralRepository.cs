using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TestTaskTIBURON.Core;

namespace TestTaskTIBURON.DB.Interfaces.Repositories
{
    public interface IGeneralRepository<TEntity> where TEntity : Entity
    {
        DbSet<TEntity> DbSet { get; }

        Task AddEntityAsync(TEntity entity);
        void Update(TEntity entity);
        Task<TEntity?> GetEntityAsync(string id);
        Task<TEntity?> GetEntityByPropertyAsync(Expression<Func<TEntity, bool>> predicate);
    }
}
