
namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbRequisiciones
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbRequisiciones()
        {
            this.tbCompetenciasRequisicion = new HashSet<tbCompetenciasRequisicion>();
            this.tbHabilidadesRequisicion = new HashSet<tbHabilidadesRequisicion>();
            this.tbIdiomasRequisicion = new HashSet<tbIdiomasRequisicion>();
            this.tbRequerimientosEspecialesRequisicion = new HashSet<tbRequerimientosEspecialesRequisicion>();
            this.tbSeleccionCandidatos = new HashSet<tbSeleccionCandidatos>();
            this.tbTitulosRequisicion = new HashSet<tbTitulosRequisicion>();
        }
    
        public int req_Id { get; set; }
        public string req_Experiencia { get; set; }
        public string req_Sexo { get; set; }
        public string req_Descripcion { get; set; }
        public int req_EdadMinima { get; set; }
        public int req_EdadMaxima { get; set; }
        public string req_EstadoCivil { get; set; }
        public bool req_EducacionSuperior { get; set; }
        public bool req_Permanente { get; set; }
        public string req_Duracion { get; set; }
        public bool req_Estado { get; set; }
        public string req_RazonInactivo { get; set; }
        public string req_Vacantes { get; set; }
        public int req_VacantesOcupadas { get; set; }
        public Nullable<System.DateTime> req_FechaRequisicion { get; set; }
        public Nullable<System.DateTime> req_FechaContratacion { get; set; }
        public int req_UsuarioCrea { get; set; }
        public System.DateTime req_FechaCrea { get; set; }
        public Nullable<int> req_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> req_FechaModifica { get; set; }
        public string req_NivelEducativo { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbCompetenciasRequisicion> tbCompetenciasRequisicion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbHabilidadesRequisicion> tbHabilidadesRequisicion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbIdiomasRequisicion> tbIdiomasRequisicion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbRequerimientosEspecialesRequisicion> tbRequerimientosEspecialesRequisicion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbSeleccionCandidatos> tbSeleccionCandidatos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbTitulosRequisicion> tbTitulosRequisicion { get; set; }
    }
}
