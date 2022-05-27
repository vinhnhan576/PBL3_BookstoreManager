using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3.Model
{
    [Table("Discount")]
    public partial class Discount
    {
        public Discount()
        {
            Products = new HashSet<Product>();
        }
        [Key][StringLength(10)][Required][Column("ID")]
        public string DiscountID { get; set; }
        [Column("Discount Name")]
        public string DiscountName { get; set; }
        public int Amount { get; set; }
        public string DiscountType { get; set; }
        public System.DateTime StartingDate { get; set; }
        public System.DateTime ExpirationDate { get; set; }
        public int AmmountApply { get; set; }
        public double DiscountApply { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
