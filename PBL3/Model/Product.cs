using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.Model
{
    [Table("Product")] 
    public class Product
    {
        public Product()
        {
            Receipt_Details = new HashSet<ReceiptDetail>();
            StoreImportDetails = new HashSet<StoreImportDetail>();
            RestockDetails = new HashSet<RestockDetail>();
        }

        [Column("ID")][Key]
        public string ProductID { get; set; }
        [Column("Name")][Required]
        public string ProductName { get; set; }
        public string Category { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int PublishYear { get; set; }
        public double SellingPrice { get; set; }
        public string Status { get; set; }
        public string DiscountID { get; set; }
        public int StockQuantity { get; set; }
        public int StoreQuantity { get; set; }

        [ForeignKey("DiscountID")]
        public virtual Discount Discount { get; set; }
        public virtual ICollection<ReceiptDetail> Receipt_Details { get; set; }
        public virtual ICollection<StoreImportDetail> StoreImportDetails { get; set; }
        public virtual ICollection<RestockDetail> RestockDetails { get; set; }
    }
}
