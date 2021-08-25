using BLL.DMS.ViewModel;
using DAL.DMS;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DMS.Repositories
{
    public class StockRepository : IStockRepository
    {
        private readonly dbCIDEntities _context;
        public StockRepository(dbCIDEntities context)
        {
            _context = context;
            _context.Database.CommandTimeout = 0;
        }
        public List<sp_EntityDateWiseStock_Result> GetEntityDateWiseStock(DateTime date, int entityId, string groupName)
        {
            SqlParameter dateParam = new SqlParameter("@DATE", date);
            SqlParameter entityParam = new SqlParameter("@EntityID", entityId);
            SqlParameter groupParam = new SqlParameter("@GroupName", groupName);
            return _context.Database.SqlQuery<sp_EntityDateWiseStock_Result>("exec sp_EntityDateWiseStock @DATE, @EntityID, @GroupName", dateParam, entityParam, groupParam).ToList();
        }

        public List<sp_GroupWiseOpeningStock_Result> GetGroupWiseOpeningStock(DateTime date, string groupName)
        {
            SqlParameter dateParam = new SqlParameter("@DATE", date);
            SqlParameter groupParam = new SqlParameter("@GroupName", groupName);
            return _context.Database.SqlQuery<sp_GroupWiseOpeningStock_Result>("exec sp_GroupWiseOpeningStock @DATE, @GroupName", dateParam, groupParam).ToList();
        }
        public List<ProductModelGroupViewModel> GetProductGroupName()
        {
            return _context.Products.Where(x => !String.IsNullOrEmpty(x.GroupName)).Select(x => new ProductModelGroupViewModel { GroupName = x.GroupName }).Distinct().OrderBy(x => x.GroupName).ToList();
        }
        public List<ProductModelGroupViewModel> GetProductModelName()
        {
            return _context.Products.Where(x => !String.IsNullOrEmpty(x.Model))
                .Select(x => new ProductModelGroupViewModel 
                { 
                    ModelName = x.Model,
                    ProductId = x.ProductID,
                    GroupName = x.GroupName
                }).Distinct().OrderBy(x => x.ModelName).ToList();
        }

        public List<sp_GroupWiseDistributionPlan_Result> GetShowroomModelWiseDistributionPlan(DateTime date, string groupName, int isWithZone)
        {
            SqlParameter dateParam = new SqlParameter("@DATE", date);
            SqlParameter groupParam = new SqlParameter("@Group", groupName);
            SqlParameter isWithZoneParam = new SqlParameter("@withZone", isWithZone);
            return _context.Database.SqlQuery<sp_GroupWiseDistributionPlan_Result>("exec sp_GroupWiseDistributionPlan @DATE, @Group, @withZone", dateParam, groupParam, isWithZoneParam).ToList();
        }
    }
}
