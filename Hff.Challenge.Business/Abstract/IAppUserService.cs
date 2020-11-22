using Hff.Challenge.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hff.Challenge.Business.Abstract
{
    public interface IAppUserService : IGenericService<AppUser>
    {
        Task<bool> CheckUser(string email, string password);
    }
}
