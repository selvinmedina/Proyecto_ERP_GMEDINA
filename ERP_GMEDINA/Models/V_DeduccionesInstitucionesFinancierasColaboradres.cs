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
    
    public partial class V_DeduccionesInstitucionesFinancierasColaboradres
    {
        public int deif_IdDeduccionInstFinanciera { get; set; }
        public int emp_Id { get; set; }
        public decimal deif_Monto { get; set; }
        public string deif_Comentarios { get; set; }
        public int deif_UsuarioCrea { get; set; }
        public System.DateTime deif_FechaCrea { get; set; }
        public Nullable<int> deif_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> deif_FechaModifica { get; set; }
        public bool deif_Activo { get; set; }
        public int insf_IdInstitucionFinanciera { get; set; }
        public string insf_DescInstitucionFinanc { get; set; }
        public string cde_DescripcionDeduccion { get; set; }
    }
}
