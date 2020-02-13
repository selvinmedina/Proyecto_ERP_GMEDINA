
namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbEmpleado
    {
        public short emp_Id { get; set; }
        public string emp_Nombres { get; set; }
        public string emp_Apellidos { get; set; }
        public string emp_Sexo { get; set; }
        public System.DateTime emp_FechaNacimiento { get; set; }
        public byte tpi_Id { get; set; }
        public string emp_Identificacion { get; set; }
        public string emp_Telefono { get; set; }
        public string emp_Correoelectronico { get; set; }
        public string emp_TipoSangre { get; set; }
        public string emp_Puesto { get; set; }
        public System.DateTime emp_FechaIngreso { get; set; }
        public string emp_Direccion { get; set; }
        public string emp_RazonInactivacion { get; set; }
        public int emp_UsuarioCrea { get; set; }
        public System.DateTime emp_FechaCrea { get; set; }
        public Nullable<int> emp_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> emp_FechaModifica { get; set; }
        public bool emp_Estado { get; set; }
        public string emp_RazonSalida { get; set; }
        public Nullable<System.DateTime> emp_FechaDeSalida { get; set; }
    }
}
