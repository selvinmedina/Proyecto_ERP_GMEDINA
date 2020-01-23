using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ERP_GMEDINA.Controllers;

namespace ERP_GMEDINA_TEST.Controllers
{
    [TestClass]
    public class FechaPlanillaControllerTest
    {
        FechaPlanillaController controller = new FechaPlanillaController();
        
         
        [TestMethod]
        public void ComprobanteEmpleadoEncabezado()
        {
            controller = new FechaPlanillaController();
            var result = controller.ComprobanteEmpleadoEncabezado(1,2019);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void getTipoPlanilla()
        {
            controller = new FechaPlanillaController();
            var result = controller.getTipoPlanilla(2019);
            Assert.IsNotNull(result);
        }




    }
}
