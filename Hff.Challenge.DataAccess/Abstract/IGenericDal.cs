using Hff.Challenge.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hff.Challenge.DataAccess.Abstract
{
    public interface IGenericDal<TEntity>where TEntity:class,IEntity,new()
    {
        /// <summary>
        /// GetAll with no parameters
        /// </summary>
        /// <returns></returns>
        Task<List<TEntity>> GetAllAsync();
        /// <summary>
        /// GetAll With filter
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity,bool>>filter);
        /// <summary>
        /// GetALL with filter
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="keySelector"></param>
        /// <returns></returns>
        Task<List<TEntity>> GetAllAsync<TKey>(Expression<Func<TEntity,TKey>>keySelector);
        Task<TEntity> Get(Expression<Func<TEntity, bool>> filter);
        Task AddAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(TEntity entity);

        

    }
}
