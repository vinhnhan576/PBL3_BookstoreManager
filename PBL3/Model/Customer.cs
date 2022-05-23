using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3.Model
{
    [Table("Customer")]
    public partial class Customer
    {
        
        public Customer()
        {
            Receipts = new HashSet<Receipt>();
        }
        [Column("Phone Number")][Key][StringLength(11)][Required]
        public string PhoneNumber { get; set; }
        [Column("Customer Name")]
        [Required]
        public string CustomerName { get; set; }
        public string RankID { get; set; }
        [Column("Total Spending")]
        public double TotalSpending { get; set; }
        public int Used { get; set; }
        [ForeignKey("RankID")]
        public virtual Rank Rank { get; set; }
        public virtual ICollection<Receipt> Receipts { get; set; }
        public bool IsValidDiscount(int used = 2)
        {
            if (this.Used < used)
                return true;
            else
            {
                return false;
            }
        }
    }
}
