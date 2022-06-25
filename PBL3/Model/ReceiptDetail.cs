using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3.Model
{
    [Table("ReceiptDetail")]
    public class ReceiptDetail
    {
        public ReceiptDetail()
        {
            //Revenues = new HashSet<Revenue>();
        }
        [Key]
        public string ReceiptDetailID { get; set; }
        [Required]
        public string ProductID { get; set; }
        [Required]
        public int SellingQuantity { get; set; }
        public double SellingPrice { get; set; }
        public double Total { get; set; }
        public string ReceiptID { get; set; }

        [ForeignKey("ReceiptID")]
        public virtual Receipt Receipt { get; set; }
        public virtual Revenue Revenue { get; set; }
        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }
    }
}
