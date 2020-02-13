
namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbSalida
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbSalida()
        {
            this.tbEntrada = new HashSet<tbEntrada>();
            this.tbSalidaDetalle = new HashSet<tbSalidaDetalle>();
        }
    
        public int sal_Id { get; set; }
        public int bod_Id { get; set; }
        public long fact_Id { get; set; }
        public System.DateTime sal_FechaElaboracion { get; set; }
        public byte estm_Id { get; set; }
        public byte tsal_Id { get; set; }
        public int sal_BodDestino { get; set; }
        public bool sal_EsAnulada { get; set; }
        public int tdev_Id { get; set; }
        public string sal_RazonAnulada { get; set; }
        public int sal_UsuarioCrea { get; set; }
        public System.DateTime sal_FechaCrea { get; set; }
        public Nullable<int> sal_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> sal_FechaModifica { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        public virtual tbBodega tbBodega { get; set; }
        public virtual tbBodega tbBodega1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbEntrada> tbEntrada { get; set; }
        public virtual tbEstadoMovimiento tbEstadoMovimiento { get; set; }
        public virtual tbFactura tbFactura { get; set; }
        public virtual tbTipoDevolucion tbTipoDevolucion { get; set; }
        public virtual tbTipoSalida tbTipoSalida { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbSalidaDetalle> tbSalidaDetalle { get; set; }
    }
}
