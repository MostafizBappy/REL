using DAL.DMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DMS.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly dbCIDEntities _context;
        public AccountRepository(dbCIDEntities context)
        {
            _context = context;
        }
        public SoftUser GetUserInfoByUserName(string userName)
        {
            return _context.SoftUsers.FirstOrDefault(x => x.UserName.ToLower() == userName.ToLower());
        }

       
    }
}
