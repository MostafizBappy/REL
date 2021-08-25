using BLL.DMS.ViewModel;
using DAL.DMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DMS.Repositories
{
    public interface IStockRepository
    {
        List<ProductModelGroupViewModel> GetProductGroupName();
        List<ProductModelGroupViewModel> GetProductModelName();
        List<sp_GroupWiseOpeningStock_Result> GetGroupWiseOpeningStock(DateTime date, string groupName);
        List<sp_EntityDateWiseStock_Result> GetEntityDateWiseStock(DateTime date, int entityId, string groupName);
        List<sp_GroupWiseDistributionPlan_Result> GetShowroomModelWiseDistributionPlan(DateTime date, string groupName, int isWithZone);
    }
}
