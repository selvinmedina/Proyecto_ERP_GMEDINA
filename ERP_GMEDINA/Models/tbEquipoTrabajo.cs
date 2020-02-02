
namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbEquipoTrabajo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbEquipoTrabajo()
        {
            this.tbEquipoEmpleados = new HashSet<tbEquipoEmpleados>();
        }
    
        public int eqtra_Id { get; set; }
        public string eqtra_Codigo { get; set; }
        public string eqtra_Descripcion { get; set; }
        public string eqtra_Observacion { get; set; }
        public bool eqtra_Estado { get; set; }
        public string eqtra_RazonInactivo { get; set; }
        public int eqtra_UsuarioCrea { get; set; }
        public System.DateTime eqtra_FechaCrea { get; set; }
        public Nullable<int> eqtra_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> eqtra_FechaModifica { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbEquipoEmpleados> tbEquipoEmpleados { get; set; }
    }
}
