using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace OfficeManagement.Models
{
    public class PurchaseModel
    {
        public int PurchaseID { get; set; }
        public int GeneralDetailsID { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string VendorName { get; set; }
        public string PurchasePrice { get; set; }
        public string MarketPrice { get; set; }
    }
}
