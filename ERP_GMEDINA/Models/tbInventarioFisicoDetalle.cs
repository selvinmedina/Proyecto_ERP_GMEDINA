
namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbInventarioFisicoDetalle
    {
        public int invfd_Id { get; set; }
        public int invf_Id { get; set; }
        public string prod_Codigo { get; set; }
        public decimal invfd_Cantidad { get; set; }
        public decimal invfd_CantidadSistema { get; set; }
        public int uni_Id { get; set; }
        public int invfd_UsuarioCrea { get; set; }
        public System.DateTime invfd_FechaCrea { get; set; }
        public Nullable<int> invfd_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> invfd_FechaModifica { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        public virtual tbUnidadMedida tbUnidadMedida { get; set; }
        public virtual tbInventarioFisico tbInventarioFisico { get; set; }
        public virtual tbProducto tbProducto { get; set; }
    }
}
