
namespace ERP_GMEDINA.Models
{
    using System;
    
    public partial class UDP_Vent_tbPedido_Select_Result
    {
        public int ped_Id { get; set; }
        public byte esped_Id { get; set; }
        public string esped_Descripcion { get; set; }
        public System.DateTime ped_FechaElaboracion { get; set; }
        public System.DateTime ped_FechaEntrega { get; set; }
        public int clte_Id { get; set; }
        public int suc_Id { get; set; }
        public long fact_Id { get; set; }
        public int ped_UsuarioCrea { get; set; }
        public System.DateTime ped_FechaCrea { get; set; }
        public Nullable<int> ped_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> ped_FechaModifica { get; set; }
    }
}
