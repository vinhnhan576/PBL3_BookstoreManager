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
    
    public partial class RestockDetail
    {
        public string RestockDetailID { get; set; }
        public string RestockID { get; set; }
        public string ProductID { get; set; }
        public int ImportQuantity { get; set; }
        public Nullable<double> ImportPrice { get; set; }
        public Nullable<double> Total { get; set; }
        public string PersonID { get; set; }
    
        public virtual Person Person { get; set; }
        public virtual Restock Restock { get; set; }
        public virtual Product Product { get; set; }
    }
}
