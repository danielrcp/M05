//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace M05.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class sm_TipoEvento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sm_TipoEvento()
        {
            this.sm_GuiaPaciente = new HashSet<sm_GuiaPaciente>();
        }
    
        public int idTipoEvento { get; set; }
        public string descripcion { get; set; }
        public string createdBy { get; set; }
        public Nullable<System.DateTime> createdDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sm_GuiaPaciente> sm_GuiaPaciente { get; set; }
    }
}
