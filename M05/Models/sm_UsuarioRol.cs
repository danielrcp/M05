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
    
    public partial class sm_UsuarioRol
    {
        public int IdUsuario { get; set; }
        public int RoleId { get; set; }
    
        public virtual sm_Rol sm_Rol { get; set; }
    }
}