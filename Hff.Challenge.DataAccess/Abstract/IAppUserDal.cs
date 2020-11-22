using Hff.Challenge.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hff.Challenge.DataAccess.Abstract
{
    public interface IAppUserDal:IGenericDal<AppUser>
    {
        Task<bool> CheckUser(string email,string password);
    }
}
