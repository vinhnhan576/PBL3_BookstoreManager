using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class StoreImportDetailView
    {
        public string StoreImportDetailID { get; set; }
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public int ImportQuantity { get; set; }
    }
}
