using Hff.Challenge.Business.Abstract;
using Hff.Challenge.DataAccess.Abstract;
using Hff.Challenge.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hff.Challenge.Business.Concrete
{
   public class ProductManager:GenericManager<Product>,IProductService
    {
        private readonly IGenericDal<Product> genericDal;
        public ProductManager(IGenericDal<Product> genericDal):base(genericDal)
        {
            this.genericDal = genericDal;
        }
    }
}
