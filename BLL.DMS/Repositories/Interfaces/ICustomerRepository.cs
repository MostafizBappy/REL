using DAL.DMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DMS.Repositories
{
    public interface ICustomerRepository
    {
        void Add(Customer entity);
        void Delete(Customer entity);
        bool SaveAll();
        List<string> GetAllCities();
    }
}
