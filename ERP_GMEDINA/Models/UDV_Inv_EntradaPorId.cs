
namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UDV_Inv_EntradaPorId
    {
        public int ent_Id { get; set; }
        public string ent_NumeroFormato { get; set; }
        public string bod_Nombre { get; set; }
        public System.DateTime ent_FechaElaboracion { get; set; }
        public string prov_Nombre { get; set; }
        public byte tent_id { get; set; }
        public string estm_Descripcion { get; set; }
        public string tent_Descripcion { get; set; }
        public string ent_FacturaCompra { get; set; }
        public System.DateTime ent_FechaCompra { get; set; }
        public string tdev_descripcion { get; set; }
        public string fact_Id { get; set; }
        public int ent_BodegaDestino { get; set; }
        public decimal entd_Cantidad { get; set; }
        public string prod_Codigo { get; set; }
        public string prod_Descripcion { get; set; }
        public string uni_Descripcion { get; set; }
    }
}
