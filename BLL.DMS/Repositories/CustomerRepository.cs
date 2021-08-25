using DAL.DMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DMS.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly dbCIDEntities _context;
        public CustomerRepository(dbCIDEntities context)
        {
            _context = context;
        }
        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public List<string> GetAllCities()
        {
            return _context.tbDistThanas.Select(x => x.Dist).Distinct().ToList();
        }

        public bool SaveAll()
        {
            throw new NotImplementedException();
        }
    }
}
