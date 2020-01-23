using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ERP_GMEDINA.Controllers;
using ERP_GMEDINA.Helpers;
using ERP_GMEDINA.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ERP_GMEDINA_TEST.Controllers
{

    [TestClass]
    public class LiquidacionTest
    {
        private LiquidacionController controller;
        private Liquidacion helper;


        [TestMethod]
        public void IndexTest()
        {
            controller = new LiquidacionController();
            ActionResult result = controller.Index();
            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }

        [TestMethod]
        public void GetEmpleadosAreas()
        {
            controller = new LiquidacionController();
            //tbEmpleados emple = new tbEmpleados();
            //emple.emp_Id = 1;
            string result = controller.GetEmpleadosAreas();

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ObtenerInformacionEmpleado()
        {
            controller = new LiquidacionController();
            tbEmpleados emple = new tbEmpleados();
            emple.emp_Id = 1;
            controller.Obtener_Informacion_Empleado(emple.emp_Id,DateTime.Now,1);

            Assert.IsTrue(emple.emp_Id > 0);
        }

        [TestMethod]
        public void GetMotivoLiquidacion()
        {
            controller = new LiquidacionController();
            List<tbMotivoLiquidacion> list = new List<tbMotivoLiquidacion>();
           var result = controller.GetMotivoLiquidacion();
            Assert.ReferenceEquals(list,result);
        }

        [TestMethod]
        public void CalcularLiquidacion()
        {
            controller = new LiquidacionController();
            LiquidacionViewModel LiquidacionVM = new LiquidacionViewModel();
            var result = controller.CalcularLiquidacion(LiquidacionVM);
            Assert.ReferenceEquals(result,LiquidacionVM);
        }
            

        [TestMethod]
        public void RegistrarLiquidacion()
        {
            controller = new LiquidacionController();
            LiquidacionViewModel LiquidacionVM = new LiquidacionViewModel();
           var result = controller.CalcularLiquidacion(LiquidacionVM);
            Assert.ReferenceEquals(result,LiquidacionVM);
        }

        }
}
