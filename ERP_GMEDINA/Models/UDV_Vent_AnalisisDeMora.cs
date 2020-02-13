
namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UDV_Vent_AnalisisDeMora
    {
        public long fact_Id { get; set; }
        public string RTN { get; set; }
        public string Nombres { get; set; }
        public int Máximo_Días_Crédito { get; set; }
        public decimal Máximo_Monto_Crédito { get; set; }
        public System.DateTime fact_Fecha { get; set; }
        public Nullable<System.DateTime> FechaVencimiento { get; set; }
        public Nullable<decimal> SaldoActual { get; set; }
        public Nullable<decimal> MORADE30 { get; set; }
        public Nullable<decimal> MORADE60 { get; set; }
        public Nullable<decimal> MORADE90 { get; set; }
    }
}
