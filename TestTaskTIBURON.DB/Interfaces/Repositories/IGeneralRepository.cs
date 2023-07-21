using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TestTaskTIBURON.Core;

namespace TestTaskTIBURON.DB.Interfaces.Repositories
{
    public interface IGeneralRepository<TEntity> where TEntity : Entity
    {
        Task AddEntityAsync(TEntity entity);
        void Update(TEntity entity);
        Task<TEntity?> GetEntityAsync(int id);
        Task<TEntity?> GetEntityByPropertyAsync(Expression<Func<TEntity, bool>> predicate);
    }
}
