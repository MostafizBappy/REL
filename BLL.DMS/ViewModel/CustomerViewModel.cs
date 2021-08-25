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
    public class CustomerViewModel
    {
        [DisplayName("Customer Contact #")]
        [DataType(DataType.PhoneNumber)]
        [Required]
        public string Mobile { get; set; }
        [DisplayName("Customer Name")]
        [Required]
        public string CustName { get; set; }
        [DisplayName("Customer Address")]
        public string Address { get; set; }
        public string City { get; set; }
        //session: eID
        public Nullable<int> eID { get; set; }
        //Def: Regular
        public string CustType { get; set; }
        [DisplayName("Customer Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DisplayName("Customer Profession")]
        public string Profession { get; set; }
        [DisplayName("Customer Organization")]
        public string Org { get; set; }
        [DisplayName("Designation")]
        public string Desg { get; set; }
        [DisplayName("Sex")]
        public string CustSex { get; set; }
        //def: N/A
        public string IdentityType { get; set; }
        //def: N/A
        public string IdentityNo { get; set; }
        [DisplayName("Date of Birth")]
        public string DOBT { get; set; }

        public IList<string> CityList { get; set; }
        public IList<string> SexList { get; set; }
        public IList<string> ProfessionList { get; set; }

        public CustomerViewModel()
        {
            SexList = new List<string> { "Male", "Female" };
            ProfessionList = new List<string> { "Business", "Service", "Others" };
        }
    }
}
