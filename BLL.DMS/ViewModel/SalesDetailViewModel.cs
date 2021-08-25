using DAL.DMS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DMS.ViewModel
{
    public class SalesDetailViewModel
    {
        public Nullable<int> MRSRMID { get; set; }
        public Nullable<int> ProductID { get; set; }
        [DisplayName("Quantity")]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid quantity")]
        public int Qty { get; set; }
        [DisplayName("MRP (Tk.)")]
        public Nullable<decimal> MRP { get; set; }
        [DisplayName("MRP (Tk.)")]
        public Nullable<double> UnitPrice { get; set; }
        [DisplayName("Total Price (Tk.)")]
        public Nullable<decimal> TotalAmnt { get; set; }
        [DisplayName("Discount Amount")]
        public Nullable<decimal> DiscountAmnt { get; set; }
        [DisplayName("Product SL#")]
        public string SLNO { get; set; }
        [DisplayName("Remarks")]
        public string ProdRemarks { get; set; }
        [DisplayName("Ref. for Discount")]
        public string DisRef { get; set; }
        [DisplayName("Discount Code")]
        public string DisCode { get; set; }
        [DisplayName("With/Adjust Amount")]
        public Nullable<decimal> WithAdjAmnt { get; set; }
        public Nullable<double> RetPrice { get; set; }
        [DisplayName("Net Amount (Tk.)")]
        public Nullable<decimal> NetAmnt { get; set; }
        public Nullable<double> BLIPAmnt { get; set; }
        public Nullable<double> IncentiveAmnt { get; set; }
        public string IncentiveType { get; set; }
        public Nullable<double> CustShowPrice { get; set; }
        [DisplayName("Product Code")]
        public string ProductCode { get; set; }
        public string ProductModel { get; set; }
        public string ProductDescription { get; set; }
        [DisplayName("Campaign Price (Tk.)")]
        public Nullable<decimal> CampaignPrice { get; set; }


        public List<Product> ProductList { get; set; }

        public SalesDetailViewModel()
        {
            ProductList = new List<Product>();
        }
    }
}
