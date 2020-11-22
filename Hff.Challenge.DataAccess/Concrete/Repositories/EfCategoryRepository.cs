using Hff.Challenge.DataAccess.Abstract;
using Hff.Challenge.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hff.Challenge.DataAccess.Concrete.Repositories
{
    public class EfCategoryRepository:EfGenericRepository<Category>,ICategoryDal
    {
    }
}
