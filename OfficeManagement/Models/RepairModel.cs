using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OfficeManagement.Models
{
    class RepairModel
    {
        public DateTime InwardDate { get; set; }
        public string ModalNo { get; set; }
        public string PartyName { get; set; }
        public string Estimate { get; set; }
        public string Complain { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string BillNo { get; set; }
        public string ReplacePart { get; set; }
        public string Done { get; set; }
    }



}
