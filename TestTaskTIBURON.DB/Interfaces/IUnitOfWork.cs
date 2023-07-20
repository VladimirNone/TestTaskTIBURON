
using TestTaskTIBURON.Core;
using TestTaskTIBURON.DB.Interfaces.Repositories;

namespace TestTaskTIBURON.DB.Interfaces
{
    public interface IUnitOfWork
    {
        IGeneralRepository<TEntity> GetRepository<TEntity>(bool hasCustomRepository = false) where TEntity : Entity;
        Task Commit();
        Task Rollback();
    }
}
