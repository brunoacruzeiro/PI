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
    
    public partial class PRESCRICAO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRESCRICAO()
        {
            this.RESULTADOes = new HashSet<RESULTADO>();
            this.PARTE_DIAGNOSTICO = new HashSet<PARTE_DIAGNOSTICO>();
        }
    
        public int ID_PRESCRICAO { get; set; }
        public string DETALHES { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RESULTADO> RESULTADOes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PARTE_DIAGNOSTICO> PARTE_DIAGNOSTICO { get; set; }
    }
}