using Hff.Challenge.DataAccess.Abstract;
using Hff.Challenge.DataAccess.Concrete.Context;
using Hff.Challenge.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hff.Challenge.DataAccess.Concrete.Repositories
{
    public class EfProductRepository : EfGenericRepository<Product>, IProductDal
    {
        public async Task<List<Product>> GetAllWithCategories()
        {
            using var context = new ChallengeContext();
            return  await context.Products.Include(p => p.Category).ToListAsync();
        }
    }
}
