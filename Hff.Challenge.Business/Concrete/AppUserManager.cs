using Hff.Challenge.Business.Abstract;
using Hff.Challenge.DataAccess.Abstract;
using Hff.Challenge.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hff.Challenge.Business.Concrete
{
   public class AppUserManager:GenericManager<AppUser>,IAppUserService
    {
        private readonly IGenericDal<AppUser> _genericDal;
        private readonly IAppUserDal appUserDal;
        public AppUserManager(IGenericDal<AppUser>genericDal,IAppUserDal appUserDal):base(genericDal)
        {
            this.appUserDal = appUserDal;
        }

        public async Task<bool> CheckUser(string email, string password)
        {
            return await appUserDal.CheckUser(email, password);
        }
    }
}
