//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class V_EquipoTrabajoDetalles
    {
        public int eqem_Id { get; set; }
        public int eqtra_Id { get; set; }
        public int emp_Id { get; set; }
        public string eqtra_Codigo { get; set; }
        public string eqtra_Descripcion { get; set; }
        public string eqtra_Observacion { get; set; }
        public bool eqem_Estado { get; set; }
        public string eqem_RazonInactivo { get; set; }
        public System.DateTime eqem_Fecha { get; set; }
        public int eqem_UsuarioCrea { get; set; }
        public System.DateTime eqem_FechaCrea { get; set; }
        public Nullable<int> eqem_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> eqem_FechaModifica { get; set; }
    }
}
