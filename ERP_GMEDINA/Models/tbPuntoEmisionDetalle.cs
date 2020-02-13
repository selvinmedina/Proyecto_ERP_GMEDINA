
namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbPuntoEmisionDetalle
    {
        public int pemid_Id { get; set; }
        public int pemi_Id { get; set; }
        public string dfisc_Id { get; set; }
        public string pemid_RangoInicio { get; set; }
        public string pemid_RangoFinal { get; set; }
        public string pemid_NumeroActual { get; set; }
        public System.DateTime pemid_FechaLimite { get; set; }
        public int pemid_UsuarioCrea { get; set; }
        public System.DateTime pemid_FechaCrea { get; set; }
        public Nullable<int> pemid_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> pemid_FechaModifica { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        public virtual tbDocumentoFiscal tbDocumentoFiscal { get; set; }
        public virtual tbPuntoEmision tbPuntoEmision { get; set; }
        public virtual tbPuntoEmision tbPuntoEmision1 { get; set; }
    }
}
