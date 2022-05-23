using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3.Model
{
    [Table("Revenue")]
    public partial class Revenue
    {
        [Column("ID")][Key][Required][StringLength(10)]
        public string RevenueID { get; set; }
        public string ReceiptDetailID { get; set; }
        public double Expenses { get; set; }
        public double GrossRevenue { get; set; }
        public double Profit { get; set; }

        [ForeignKey("ReceiptDetailID")]
        public virtual ReceiptDetail ReceiptDetail { get; set; }
    }
}
