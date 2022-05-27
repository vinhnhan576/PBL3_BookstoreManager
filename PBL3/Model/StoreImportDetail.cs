using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3.Model
{
    [Table("StoreImportDetail")]
    public partial class StoreImportDetail
    {
        [Column("ID")][Key][Required][StringLength(10)]
        public string StoreImportDetailID { get; set; }
        public string StoreImportID { get; set; }
        public string ProductID { get; set; }
        public int ImportQuantity { get; set; }
        [ForeignKey("StoreImportID")]
        public virtual StoreImport StoreImport { get; set; }
        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }
    }
}
