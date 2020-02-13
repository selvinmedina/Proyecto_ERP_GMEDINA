
namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbPagosArqueo
    {
        public int arqpg_Id { get; set; }
        public int mocja_Id { get; set; }
        public short tpa_Id { get; set; }
        public decimal arqpg_PagosSistema { get; set; }
        public decimal arqpg_PagosConteo { get; set; }
        public int arqpg_UsuarioCrea { get; set; }
        public System.DateTime arqpg_FechaCrea { get; set; }
        public Nullable<int> arqpg_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> arqpg_FechaModifica { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        public virtual tbMovimientoCaja tbMovimientoCaja { get; set; }
        public virtual tbTipoPago tbTipoPago { get; set; }
    }
}
