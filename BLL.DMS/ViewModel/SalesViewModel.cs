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
    public class SalesViewModel
    {
        [DisplayName("Invoice/Bill #")]
        public string MRSRCode { get; set; }
        [DisplayName("Bill Date")]
        [DataType(DataType.Date)]
        [Required]
        public System.DateTime TDate { get; set; }
        //def: 3
        public Nullable<short> TrType { get; set; }
        [DisplayName("Invoice/Bill #")]
        [Required]
        public string InvoiceNO { get; set; }
        //def: 230
        public Nullable<int> InSource { get; set; }
        //logged In User> EID
        public Nullable<int> OutSource { get; set; }
        //txtPay
        [DisplayName("Pay Amount")]
        [Required]
        public decimal PayAmnt { get; set; }
        [DisplayName("Due Amount")]
        public Nullable<decimal> DueAmnt { get; set; }
        //Customer contact
        public string Customer { get; set; }
        //session: userName
        public string UserID { get; set; }
        public Nullable<System.DateTime> EntryDate { get; set; }
        [Required]
        public decimal NetSalesAmnt { get; set; }
        [DisplayName("Security 1 Code")]
        public string SecurityCode { get; set; }
        [DisplayName("Security 2 Code")]
        public string SecurityCode2 { get; set; }
        [DisplayName("Cash Amount")]
        public Nullable<decimal> CashAmnt { get; set; }
        [DisplayName("Card 1 Amount")]
        public Nullable<decimal> CardAmnt1 { get; set; }
        [DisplayName("Card 2 Amount")]
        public Nullable<decimal> CardAmnt2 { get; set; }
        [DisplayName("Card 1 #")]
        public string CardNo1 { get; set; }
        [DisplayName("Card 2 #")]
        public string CardNo2 { get; set; }
        [DisplayName("Card 1 Type")]
        public string CardType1 { get; set; }
        [DisplayName("Card 2 Type")]
        public string CardType2 { get; set; }
        [DisplayName("Bank 1 Name")]
        public string Bank1 { get; set; }
        [DisplayName("Bank 2 Name")]
        public string Bank2 { get; set; }
        public string TermsCondition { get; set; }
        [DisplayName("Approval 1 Code")]
        public string AppovalCode1 { get; set; }
        [DisplayName("Approval 2 Code")]
        public string AppovalCode2 { get; set; }
        //def: 1
        public Nullable<bool> OnLineSales { get; set; }
        [DisplayName("Ref.By")]
        public string Authorby { get; set; }
        [DisplayName("Sales By (Job ID#)")]
        [Required]
        public string Issby { get; set; }
        [DisplayName("Delivery From")]
        public Nullable<int> DeliveryFrom { get; set; }
        [DisplayName("Remarks/Note")]
        public string Remarks { get; set; }
        //depends on EntityList
        public string Tag { get; set; }
        [DisplayName("Reference Challan#")]
        public string RefCHNo { get; set; }
        [DisplayName("Online Order No.")]
        public string POCode { get; set; }
        [DisplayName("Source Of Information")]
        public string SourceOfInfo { get; set; }

        public IList<SalesDetailViewModel> SalesDetailList { get; set; }
        public SalesDetailViewModel SalesDetailModel { get; set; }
        public IList<Entity> EntityList { get; set; }
        public IList<tbTC> TermsConditionList { get; set; }
        public CustomerViewModel CustomerModel { get; set; }
        public IList<ProductModelGroupViewModel> ModelList { get; set; }
        public IList<string> CardTypeList { get; set; }
        public IList<string> SourceOfInfoList { get; set; }

        public SalesViewModel()
        {
            TDate = DateTime.Today;   
            CustomerModel = new CustomerViewModel();
            SalesDetailModel = new SalesDetailViewModel();
            EntityList = new List<Entity>();
            SalesDetailList = new List<SalesDetailViewModel>();
            TermsConditionList = new List<tbTC>();
            ModelList = new List<ProductModelGroupViewModel>();
            CardTypeList = new List<string>() { "VISA", "MASTER", "AMEX", "OTHERS"};
            SourceOfInfoList = new List<string>() { "Google", "Instagram", "LinkdIn", "Twitter", "News Paper", "TV", "Leaflet", "Mouth to Mouth", "None" };
        }
    }
}
