using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ERP_GMEDINA.Models
{
    [MetadataType(typeof(cCalculoImpuestoVecinal))]
    public partial class tbDeduccionImpuestoVecinal { }

    public class cCalculoImpuestoVecinal
    {
        [Display(Name = "Número")]
        public int dimv_Id{ get; set; }

        [Display(Name = "Monto")]
        public Nullable<int> dimv_MontoTotal { get; set; }

        [Display(Name = "Cuota")]
        public Nullable<decimal> dimv_CuotaAPagar { get; set; }

        [Display(Name = "Techo")]
        public Nullable<decimal> timv_IdTechoImpuestoVecinal { get; set; }

    }
}