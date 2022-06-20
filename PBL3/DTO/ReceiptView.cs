using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    internal class ReceiptView
    {
        public string ReceiptID { get; set; }
        public string Salesman { get; set; }
        public string Customer  { get; set; }
        public DateTime Date { get; set; }
        public double Total { get; set; }
        public bool Status { get; set; }
    }
}
