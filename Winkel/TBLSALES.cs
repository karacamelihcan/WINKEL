//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Winkel
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLSALES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLSALES()
        {
            this.TBLNOTIFICATION = new HashSet<TBLNOTIFICATION>();
        }
    
        public short SALESID { get; set; }
        public Nullable<short> SELLERID { get; set; }
        public Nullable<short> CUSTOMERID { get; set; }
        public Nullable<short> PRODUCTID { get; set; }
        public Nullable<byte> SALESNUMBER { get; set; }
        public Nullable<decimal> COST { get; set; }
    
        public virtual TBLCUSTOMER TBLCUSTOMER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLNOTIFICATION> TBLNOTIFICATION { get; set; }
        public virtual TBLPRODUCT TBLPRODUCT { get; set; }
        public virtual TBLSELLER TBLSELLER { get; set; }
    }
}