﻿
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TestTaskTIBURON.Core;
using TestTaskTIBURON.DB.Interfaces.Repositories;

namespace TestTaskTIBURON.DB.Implementations.Repositories
{
    public class GeneralRepository<T> : IGeneralRepository<T> where T : Entity
    {
        protected DbSet<T> DbSet { get; set; }
        protected SurveyDbContext DbContext { get; private set; }

        public GeneralRepository(SurveyDbContext dbContext)
        {
            DbSet = dbContext.Set<T>();
            DbContext = dbContext;
        }

        public virtual async Task AddEntityAsync(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            await DbSet.AddAsync(entity);
        }

        public virtual void Update(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            DbSet.Update(entity);
        }

        public virtual async Task<T?> GetEntityAsync(int id)
        {
            return await DbSet.FindAsync(id);
        }

        public virtual async Task<T?> GetEntityByPropertyAsync(Expression<Func<T, bool>> predicate)
        {
            return await DbSet.SingleOrDefaultAsync(predicate);
        }
    }
}
