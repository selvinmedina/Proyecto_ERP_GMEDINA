//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP_GMEDINA.Models.Inventario
{
    using System;
    
    public partial class UDP_Vent_tbSolicitudEfectivoDetalle_Select_Result
    {
        public int IdSolicitud { get; set; }
        public System.DateTime FechaSolicitud { get; set; }
        public string Sucursal { get; set; }
        public string Caja { get; set; }
        public string Moneda { get; set; }
        public Nullable<decimal> MontoSolicitado { get; set; }
        public Nullable<decimal> MontoEntregado_ { get; set; }
    }
}