//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PI
{
    using System;
    using System.Collections.Generic;
    
    public partial class PARTE_DIAGNOSTICO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PARTE_DIAGNOSTICO()
        {
            this.PRESCRICAOs = new HashSet<PRESCRICAO>();
        }
    
        public int ID_PARTE_DIAGNOSTICO { get; set; }
        public int ID_DIAGNOSTICO { get; set; }
        public string ITEM_PARTE { get; set; }
    
        public virtual DIAGNOSTICO DIAGNOSTICO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRESCRICAO> PRESCRICAOs { get; set; }
    }
}
