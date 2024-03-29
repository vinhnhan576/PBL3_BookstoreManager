﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3.Model
{
    [Table("StoreImport")]
    public partial class StoreImport
    {
        public StoreImport()
        {
            StoreImportDetails = new HashSet<StoreImportDetail>();
        }
        [Key][Required][StringLength(10)]
        public string StoreImportID { get; set; }
        public DateTime ImportDate { get; set; }
        public string PersonID { get; set; }

        [ForeignKey("PersonID")]
        public virtual Person Person { get; set; }
        public virtual ICollection<StoreImportDetail> StoreImportDetails { get; set; }
    }
}