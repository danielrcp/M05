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
    
    public partial class sm_Persona
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sm_Persona()
        {
            this.sm_GuiaPaciente = new HashSet<sm_GuiaPaciente>();
        }
    
        public int idTipoIdentificacion { get; set; }
        public string numeroIdentificacion { get; set; }
        public string primerNombre { get; set; }
        public string segundoNombre { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public int idTipo { get; set; }
        public System.DateTime fechaNacimiento { get; set; }
        public Nullable<int> idCiudad { get; set; }
        public string celular { get; set; }
        public string telefonoFijo { get; set; }
        public string correo { get; set; }
        public System.DateTime createdDate { get; set; }
        public string createdBy { get; set; }
        public Nullable<System.DateTime> updatedDate { get; set; }
        public string updatedBy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sm_GuiaPaciente> sm_GuiaPaciente { get; set; }
        public virtual sm_Paciente sm_Paciente { get; set; }
        public virtual sm_Paciente sm_Paciente1 { get; set; }
        public virtual sm_PacientePrograma sm_PacientePrograma { get; set; }
    }
}