using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace OfficeManagement.Models
{
    public class GeneralModel
    {
        public int ID { get; set; }

        public string CompanyName { get; set; }

        public string ModalNo { get; set; }

        public string PartName { get; set; }

        public string PartNo { get; set; }

        public string SellNormalPrice { get; set; }
        public string SellQuantityPrice { get; set; }
        public string Tracking { get; set; }

        public string MarketPrice { get; set; }
    }
}
