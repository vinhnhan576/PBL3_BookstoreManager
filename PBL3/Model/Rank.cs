using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PBL3.Model
{
    [Table("Rank")]
    public partial class Rank
    {
        public Rank()
        {
            this.Customers = new HashSet<Customer>();
        }
        [Key]
        [StringLength(10)]
        [Required]
        [Column("ID")]
        public string RankID { get; set; }
        [Column("Rank Name")]
        public string RankName { get; set; }
        public double Requirement { get; set; }
        [Column("Customer Discount")]
        public double CustomerDiscount { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
    }
}
