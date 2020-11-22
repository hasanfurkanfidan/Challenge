using Hff.Challenge.DataAccess.Abstract;
using Hff.Challenge.DataAccess.Concrete.Context;
using Hff.Challenge.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hff.Challenge.DataAccess.Concrete.Repositories
{
    public class EfGenericRepository<TEntity> : IGenericDal<TEntity> where TEntity : class, IEntity, new()
    {
        public async Task AddAsync(TEntity entity)
        {
            using (var context = new ChallengeContext())
            {
                await context.AddAsync(entity);
                await context.SaveChangesAsync();
            }
        }

        public async Task DeleteAsync(TEntity entity)
        {
            using (var context = new ChallengeContext())
            {
                context.Remove(entity);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            using (var context = new ChallengeContext())
            {
                return await context.Set<TEntity>().ToListAsync();
            }
        }

        public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter)
        {
            using (var context = new ChallengeContext())
            {
                return await context.Set<TEntity>().Where(filter).ToListAsync();
            }
        }

        public async Task<List<TEntity>> GetAllAsync<TKey>(Expression<Func<TEntity, TKey>> keySelector)
        {
            using (var context = new ChallengeContext())
            {
                return await context.Set<TEntity>().OrderByDescending(keySelector).ToListAsync();
            }
        }

        public async Task UpdateAsync(TEntity entity)
        {
            using (var context = new ChallengeContext())
            {
                context.Update(entity);
                await context.SaveChangesAsync();
            }
        }
    }
}
