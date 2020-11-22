using Hff.Challenge.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hff.Challenge.DataAccess.Abstract
{
    public interface IProductDal:IGenericDal<Product>
    {
        Task<List<Product>> GetAllWithCategories();
    }
}
