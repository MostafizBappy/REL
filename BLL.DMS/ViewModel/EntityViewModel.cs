using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DMS.ViewModel
{
    public class EntityViewModel
    {
        public int EID { get; set; }
        [DisplayName("Serial No")]
        public Nullable<int> SerialNo { get; set; }
        [DisplayName("Name")]
        public string eName { get; set; }
        [DisplayName("Name Bangla")]
        public string eNameBangla { get; set; }
        [DisplayName("Desc")]
        public string EDesc { get; set; }
        [DisplayName("Desc Bangla")]
        public string EDescBangla { get; set; }
        [DisplayName("Entity Type")]
        public string EntityType { get; set; }
        [DisplayName("Parent Entity")]
        public string ParentEntity { get; set; }
        [DisplayName("Showroom Type")]
        public string Showroomtype { get; set; }
        public Nullable<int> CommissionGet { get; set; }
        public Nullable<int> SalesOrShowroom { get; set; }
        public Nullable<int> ActiveDeactive { get; set; }
        public Nullable<int> GroupSL { get; set; }
        public string UserID { get; set; }
        [DisplayName("PC Name")]
        public string PCName { get; set; }
        [DisplayName("Entry Date")]
        public Nullable<System.DateTime> EntryDate { get; set; }
        public Nullable<int> sFlag { get; set; }
        public Nullable<int> EnableSalesSheet { get; set; }
        [DisplayName("Desc")]
        public Nullable<decimal> SecurityMoney { get; set; }
        public Nullable<decimal> DepositedUpTo0809 { get; set; }
        [DisplayName("Desc")]
        public string EntityCode { get; set; }
        public Nullable<int> NoTr { get; set; }
        public Nullable<int> DP_Inactive { get; set; }
        [DisplayName("Desc")]
        public string ContactPerson { get; set; }
        public string Desg { get; set; }
        public string Status { get; set; }
        [DisplayName("Desc")]
        public string ContactNo { get; set; }
        public Nullable<int> InDhk { get; set; }
        public Nullable<int> ZoneID { get; set; }
        [DisplayName("Desc")]
        public string PhoneNo { get; set; }
        [DisplayName("Desc")]
        public string EmailAdd { get; set; }
        public Nullable<int> CorporateSale { get; set; }
        public Nullable<int> iTagStock { get; set; }
        public Nullable<int> SalesCenterType { get; set; }
        public string MapLink { get; set; }
        public Nullable<int> pEID { get; set; }
        [DisplayName("Desc")]
        public string ReqMailTo { get; set; }
    }
}
