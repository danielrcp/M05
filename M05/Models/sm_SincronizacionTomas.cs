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
    
    public partial class sm_SincronizacionTomas
    {
        public int idSincronizacion { get; set; }
        public string uuid { get; set; }
        public Nullable<int> idTipoTipoIdentificacion { get; set; }
        public string numeroIdentificacion { get; set; }
        public Nullable<System.DateTime> ultimaSincronizacion { get; set; }
        public string createdBy { get; set; }
        public Nullable<System.DateTime> createdDate { get; set; }
        public string updatedBy { get; set; }
        public Nullable<System.DateTime> updatedDate { get; set; }
        public string tokenPush { get; set; }
    
        public virtual sm_SincronizacionTomas sm_SincronizacionTomas1 { get; set; }
        public virtual sm_SincronizacionTomas sm_SincronizacionTomas2 { get; set; }
    }
}
