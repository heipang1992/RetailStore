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
    
    public partial class SalesOrderInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SalesOrderInfo()
        {
            this.SalesOrderDefects = new HashSet<SalesOrderDefect>();
            this.SalesOrderProducts = new HashSet<SalesOrderProduct>();
        }
    
        public int orderID { get; set; }
        public string customerNumber { get; set; }
        public Nullable<int> deliveryID { get; set; }
        public Nullable<int> installationID { get; set; }
        public int staffID { get; set; }
        public double price { get; set; }
        public double cast { get; set; }
        public double orderchange { get; set; }
        public System.DateTime date { get; set; }
        public string orderstatus { get; set; }
        public string remark { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderDefect> SalesOrderDefects { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderProduct> SalesOrderProducts { get; set; }
    }
}
