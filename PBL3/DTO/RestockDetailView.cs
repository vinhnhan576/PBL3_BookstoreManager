using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    internal class RestockDetailView
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public int ImportQuantity { get; set; }
        public double  ImportPrice{ get; set; }
        public double Total { get; set; }
    }
}
