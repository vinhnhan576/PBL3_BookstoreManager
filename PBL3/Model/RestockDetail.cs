using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3.Model
{
    [Table("RestockDetail")]
    public partial class RestockDetail
    {
        [Key][Required][StringLength(10)]
        public string RestockDetailID { get; set; }
        public string RestockID { get; set; }
        public string ProductID { get; set; }
        public int ImportQuantity { get; set; }
        public double ImportPrice { get; set; }
        public double Total { get; set; }
        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }
        [ForeignKey("RestockID")]
        public virtual Restock Restock { get; set; }
    }
}
