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
    
    public partial class tbAFP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbAFP()
        {
            this.tbDeduccionAFP = new HashSet<tbDeduccionAFP>();
        }
    
        public int afp_Id { get; set; }
        public string afp_Descripcion { get; set; }
        public decimal afp_AporteMinimoLps { get; set; }
        public decimal afp_AporteMinimoDol { get; set; }
        public decimal afp_InteresAporte { get; set; }
        public decimal afp_InteresAnual { get; set; }
        public int tde_IdTipoDedu { get; set; }
        public int afp_UsuarioCrea { get; set; }
        public System.DateTime afp_FechaCrea { get; set; }
        public Nullable<int> afp_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> afp_FechaModifica { get; set; }
        public bool afp_Activo { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbDeduccionAFP> tbDeduccionAFP { get; set; }
        public virtual tbTipoDeduccion tbTipoDeduccion { get; set; }
    }
}
