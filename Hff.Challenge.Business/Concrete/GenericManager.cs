using Hff.Challenge.Business.Abstract;
using Hff.Challenge.DataAccess.Abstract;
using Hff.Challenge.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hff.Challenge.Business.Concrete
{
    public class GenericManager<TEntity> : IGenericService<TEntity> where TEntity : class, IEntity, new()
    {
        private readonly IGenericDal<TEntity> _genericDal;
        public GenericManager(IGenericDal<TEntity> genericDal)
        {
            _genericDal = genericDal;
        }
        public async Task AddAsync(TEntity entity)
        {
           await _genericDal.AddAsync(entity);
        }

        public async Task DeleteAsync(TEntity entity)
        {
            await _genericDal.DeleteAsync(entity);
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _genericDal.GetAllAsync();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            await _genericDal.UpdateAsync(entity);
        }
    }
}
