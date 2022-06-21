using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3.Model
{
    [Table("Receipt")]
    public partial class Receipt
    {
        public Receipt()
        {
            ReceiptDetails = new HashSet<ReceiptDetail>();
        }
        [Key]
        [StringLength(10)]
        [Required]
        [Column("ID")]
        public string ReceiptID { get; set; }
        public System.DateTime Date { get; set; }
        public double Total { get; set; }
        [Column("Staff ID")]
        public string PersonID { get; set; }
        [Column("Customer number")]
        [StringLength(11)]
        public string PhoneNumber { get; set; }
        public bool Status { get; set; }
        [ForeignKey("PersonID")]
        public virtual Person Person { get; set; }
        public virtual ICollection<ReceiptDetail> ReceiptDetails { get; set; }
        [ForeignKey("PhoneNumber")]
        public virtual Customer Customer { get; set; }
    }

}
