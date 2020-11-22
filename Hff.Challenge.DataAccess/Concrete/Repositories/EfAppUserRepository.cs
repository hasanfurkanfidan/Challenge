using Hff.Challenge.DataAccess.Abstract;
using Hff.Challenge.DataAccess.Concrete.Context;
using Hff.Challenge.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hff.Challenge.DataAccess.Concrete.Repositories
{
    public class EfAppUserRepository : EfGenericRepository<AppUser>, IAppUserDal
    {
        public async Task<bool> CheckUser(string email, string password)
        {
            var context = new ChallengeContext();
            var user =await context.AppUsers.Where(p => p.Email == email && p.Password == password).FirstOrDefaultAsync();
            if (user != null)
            {
                return  true;
            }
            else
            {
                return false;
            }

        }
    }
}
