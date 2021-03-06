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
    
    public partial class sm_Programa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sm_Programa()
        {
            this.sm_Guia = new HashSet<sm_Guia>();
            this.sm_PacientePrograma = new HashSet<sm_PacientePrograma>();
        }
    
        public int idPrograma { get; set; }
        public string descripcion { get; set; }
        public int idEstado { get; set; }
        public System.DateTime createdDate { get; set; }
        public string createdBy { get; set; }
        public Nullable<System.DateTime> updatedDate { get; set; }
        public string updatedBy { get; set; }
        public System.DateTime fechaInicio { get; set; }
        public System.DateTime fechaFin { get; set; }
        public int poblacionObjetivo { get; set; }
    
        public virtual sm_Estado sm_Estado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sm_Guia> sm_Guia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sm_PacientePrograma> sm_PacientePrograma { get; set; }
        public virtual sm_Poblacion sm_Poblacion { get; set; }
    }
}
