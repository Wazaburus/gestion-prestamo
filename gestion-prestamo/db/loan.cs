//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace gestion_prestamo.db
{
    using System;
    using System.Collections.Generic;
    
    public partial class loan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public loan()
        {
            this.payments = new HashSet<payment>();
        }
    
        public int id { get; set; }
        public string debbtor_name { get; set; }
        public string debtor_document_id { get; set; }
        public string debtor_telephone { get; set; }
        public string guarantor_name { get; set; }
        public string guarantor_document_id { get; set; }
        public string guarantor_telephone { get; set; }
        public decimal amount { get; set; }
        public Nullable<decimal> debt { get; set; }
        public Nullable<decimal> closing_expense { get; set; }
        public string time { get; set; }
        public Nullable<decimal> rate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<payment> payments { get; set; }
    }
}
