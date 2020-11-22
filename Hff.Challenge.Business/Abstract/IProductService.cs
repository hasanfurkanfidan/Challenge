using Hff.Challenge.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hff.Challenge.Business.Abstract
{
    public interface IProductService:IGenericService<Product>
    {
        Task<List<Product>> GetAllWithCategories();
        Task<Product> GetById(int id);
    }
}
