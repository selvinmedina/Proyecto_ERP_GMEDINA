using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ERP_GMEDINA.Models;
using System.Web.Mvc;
using ERP_GMEDINA.Controllers;

namespace ERP_GMEDINA_TEST.Controllers
{
    [TestClass]
    public class DeduccionesIndividualesController_Test
    {
     

        //Instancia del Controlador
        DeduccionesIndividualesController _DeduccionesIndividualesController = new DeduccionesIndividualesController();

        //Instancia de la Entidad
        tbDeduccionesIndividuales tbDeduccionesIndividuales = new tbDeduccionesIndividuales();

        //Post:Create
        [TestMethod]
        public void Crear()
        {
            //Arrange//
            int dei_IdDeduccionesIndividuales = 0;
            string dei_Motivo = "TestUnit";
            int emp_Id = 1;
            decimal dei_MontoInicial = 500.00M;
            decimal dei_MontoRestante = 500.00M;
            decimal dei_Cuota = 100.00M;
            bool dei_PagaSiempre = true;

            //Act//

            //Set de la variable antes declarada para la captura del Return del Método
            _DeduccionesIndividualesController.Create(dei_Motivo, emp_Id, dei_MontoInicial, dei_MontoRestante, dei_Cuota, dei_PagaSiempre);

            //Assert//
            Assert.IsTrue(dei_IdDeduccionesIndividuales > 0);

        }

        //Post:Create
        [TestMethod]
        public void Create()
        {
            //Arrange//
            string dei_Motivo = "TestUnit";
            int emp_Id = 1;
            decimal dei_MontoInicial = 500.00M;
            decimal dei_MontoRestante = 500.00M;
            decimal dei_Cuota = 100.00M;
            bool dei_PagaSiempre = true;

            //Variable para Capturar el Return del Método
            string ReturnValue = string.Empty;

            //Act//
            ActionResult js = _DeduccionesIndividualesController.Create(dei_Motivo, emp_Id, dei_MontoInicial, dei_MontoRestante, dei_Cuota, dei_PagaSiempre);

            JsonResult json = js as JsonResult;

            //Set de la variable antes declarada para la captura del Return del Método
            ReturnValue = (string)(json).Data;

            //Assert//
            Assert.IsTrue(ReturnValue == "bien");

        }

        //Post:Edit
        [TestMethod]
        public void Editar()
        {
            //Arrange//
            tbDeduccionesIndividuales tbDeduccionesExtras = new tbDeduccionesIndividuales();

            int dei_IdDeduccionesIndividuales = 1;
            string dei_Motivo = "TestUnit";
            int emp_Id = 5;
            decimal dei_MontoInicial = 1000.00M;
            decimal dei_MontoRestante = 1000.00M;
            decimal dei_Cuota = 100.00M;
            bool dei_PagaSiempre = true;

            //Act//

            //Set de la variable antes declarada para la captura del Return del Método
            _DeduccionesIndividualesController.Edit(dei_IdDeduccionesIndividuales, dei_Motivo, emp_Id, dei_MontoInicial, dei_MontoRestante, dei_Cuota, dei_PagaSiempre);

            //Assert//
            Assert.IsTrue(dei_IdDeduccionesIndividuales > 0);

        }

        //Post:Edit
        [TestMethod]
        public void Edit()
        {
            //Arrange//
            tbDeduccionesIndividuales tbDeduccionesExtras = new tbDeduccionesIndividuales();

            int dei_IdDeduccionesIndividuales = 1;
            string dei_Motivo = "TestUnit";
            int emp_Id = 5;
            decimal dei_MontoInicial = 1000.00M;
            decimal dei_MontoRestante = 1000.00M;
            decimal dei_Cuota = 100.00M;
            bool dei_PagaSiempre = true;

            //Variable para Capturar el Return del Método
            string ReturnValue = string.Empty;

            //Act//
            ActionResult js = _DeduccionesIndividualesController.Edit(dei_IdDeduccionesIndividuales, dei_Motivo, emp_Id, dei_MontoInicial, dei_MontoRestante, dei_Cuota, dei_PagaSiempre);

            JsonResult json = js as JsonResult;

            //Set de la variable antes declarada para la captura del Return del Método
            ReturnValue = (string)(json).Data;

            //Assert//
            Assert.IsTrue(ReturnValue == "bien");

        }


        //Post:Inactivar
        [TestMethod]
        public void Inactivate()
        {
            //Arrange//

            //Act//

            //Set de la variable antes declarada para la captura del Return del Método
            _DeduccionesIndividualesController.Activar(1);

            //Assert//
            Assert.IsTrue(tbDeduccionesIndividuales.dei_IdDeduccionesIndividuales > 0);

        }

        //Post:Inactivar
        [TestMethod]
        public void Inactivar()
        {
            //Arrange//

            //Variable para Capturar el Return del Método
            string ReturnValue = string.Empty;

            //Act//
            ActionResult js = _DeduccionesIndividualesController.Activar(1);

            JsonResult json = js as JsonResult;

            ReturnValue = (string)(json).Data;

            //Assert//
            Assert.IsTrue(ReturnValue == "bien");

        }

        //Post:Activar
        [TestMethod]
        public void Activate()
        {
            //Arrange//

            //Act//

            //Set de la variable antes declarada para la captura del Return del Método
            _DeduccionesIndividualesController.Activar(1);

            //Assert//
            Assert.IsTrue(tbDeduccionesIndividuales.dei_IdDeduccionesIndividuales > 0);

        }

        //Post:Activar
        [TestMethod]
        public void Activar()
        {
            //Arrange//

            //Variable para Capturar el Return del Método
            string ReturnValue = string.Empty;

            //Act//
            ActionResult js = _DeduccionesIndividualesController.Activar(1);

            JsonResult json = js as JsonResult;

            ReturnValue = (string)(json).Data;

            //Assert//
            Assert.IsTrue(ReturnValue == "bien");

        }
    }
}
