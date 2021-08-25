using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DMS.ViewModel
{
    public class ProductModelGroupViewModel
    {
        public string GroupName { get; set; }
        public string ModelName { get; set; }
        public int? ProductId { get; set; }
    }

    public class ProductViewModel
    {
        public int ProductID { get; set; }
        public string Code { get; set; }
        public string ProdName { get; set; }
        public string ModelSerial { get; set; }
        public string Model { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<decimal> CampaignPrice { get; set; }
        public Nullable<decimal> MRP { get; set; }
        public string ProdType { get; set; }
        public string PCategory { get; set; }
        public string GroupName { get; set; }
        public string Discontinue { get; set; }
        public Nullable<int> ProdTag { get; set; }
        public Nullable<System.DateTime> EntryDate { get; set; }
    }
}
