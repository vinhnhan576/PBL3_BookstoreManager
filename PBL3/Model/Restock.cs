using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3.Model
{
    [Table("Restock")]
    public partial class Restock
    {
        public Restock()
        {
            RestockDetails = new HashSet<RestockDetail>();
        }
        [Key][Required]
        public string RestockID { get; set; }
        public System.DateTime ImportDate { get; set; }
        public double TotalExpense { get; set; }
        [Required]
        public string PersonID { get; set; }
        [ForeignKey("PersonID")]
        public virtual Person Person { get; set; }
        public virtual ICollection<RestockDetail> RestockDetails { get; set; }
    }
}
