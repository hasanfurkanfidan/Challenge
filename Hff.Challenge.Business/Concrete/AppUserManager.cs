using Hff.Challenge.Business.Abstract;
using Hff.Challenge.DataAccess.Abstract;
using Hff.Challenge.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hff.Challenge.Business.Concrete
{
   public class AppUserManager:GenericManager<AppUser>,IAppUserService
    {
        private readonly IGenericDal<AppUser> _genericDal;
        public AppUserManager(IGenericDal<AppUser>genericDal):base(genericDal)
        {
                
        }
    }
}
