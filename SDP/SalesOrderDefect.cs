//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SDP
{
    using System;
    using System.Collections.Generic;
    
    public partial class SalesOrderDefect
    {
        public int defectID { get; set; }
        public int orderID { get; set; }
        public int productID { get; set; }
        public int quantity { get; set; }
        public bool isReturn { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual SalesOrderInfo SalesOrderInfo { get; set; }
    }
}
