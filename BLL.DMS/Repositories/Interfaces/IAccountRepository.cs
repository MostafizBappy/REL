using DAL.DMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DMS.Repositories
{
    public interface IAccountRepository
    {
        SoftUser GetUserInfoByUserName(string userName);

    }
}
