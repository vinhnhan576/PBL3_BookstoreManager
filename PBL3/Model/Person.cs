using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3.Model
{
    [Table("Person")]
    public partial class Person
    {
        public Person()
        {
            this.Receipts = new HashSet<Receipt>();
            this.Restocks = new HashSet<Restock>();
        }
        [Column("ID")][Key][Required][StringLength(10)]
        public string PersonID { get; set; }
        public string PersonName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Role { get; set; }
        public bool Gender { get; set; }
        public string Email { get; set; }

        [ForeignKey("PersonID")]
        public virtual Account Account { get; set; }
        public virtual ICollection<Receipt> Receipts { get; set; }
        public virtual ICollection<Restock> Restocks { get; set; }
    }
}
