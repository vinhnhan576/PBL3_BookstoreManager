using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3.Model
{
    [Table("Account")]
    public partial class Account
    {
        [Key]
        public string PersonID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        [ForeignKey("PersonID")][Required]
        public virtual Person Person { get; set; }
    }
}
