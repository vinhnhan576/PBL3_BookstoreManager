//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PBL3
{
    using System;
    using System.Collections.Generic;
    
    public partial class Store_Import
    {
        public string StoreImportID { get; set; }
        public string ProductID { get; set; }
        public int ImportQuantity { get; set; }
        public System.DateTime ImportDate { get; set; }
        public double SellingPrice { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
