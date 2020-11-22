using Hff.Challenge.Business.Abstract;
using Hff.Challenge.DataAccess.Abstract;
using Hff.Challenge.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hff.Challenge.Business.Concrete
{
   public class ProductManager:GenericManager<Product>,IProductService
    {
        private readonly IGenericDal<Product> genericDal;
       private readonly IProductDal _productDal;
        public ProductManager(IGenericDal<Product> genericDal,IProductDal productDal):base(genericDal)
        {
            this.genericDal = genericDal;
            _productDal = productDal;
        }

        public async Task<List<Product>> GetAllWithCategories()
        {
            return await _productDal.GetAllWithCategories();
        }

        public Task<Product> GetById(int id)
        {
            return _productDal.Get(p => p.Id == id);
        }
    }
}
