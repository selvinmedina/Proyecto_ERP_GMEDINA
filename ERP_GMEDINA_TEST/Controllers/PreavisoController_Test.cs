using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ERP_GMEDINA.Controllers;
using ERP_GMEDINA.Models;
using System.Web.Mvc;

namespace ERP_GMEDINA_TEST.Controllers
{
    [TestClass]
    public class PreavisoController_Test
    {
        //Instancia del Controlador
        PreavisoController _PreavisoController = new PreavisoController();

        //Instancia de la Entidad
        tbPreaviso tbPreaviso = new tbPreaviso();

        //Post:Create
        [TestMethod]
        public void Crear()
        {
            //Arrange//
            tbPreaviso.prea_RangoInicioMeses = 1;
            tbPreaviso.prea_RangoFinMeses = 2;
            tbPreaviso.prea_DiasPreaviso = 15;
            tbPreaviso.prea_UsuarioCrea = 1;
            tbPreaviso.prea_FechaCrea = DateTime.Now;

            //Act//

            //Set de la variable antes declarada para la captura del Return del Método
            _PreavisoController.Create(tbPreaviso);

            //Assert//
            Assert.IsTrue(tbPreaviso.prea_IdPreaviso > 0);

        }

        //Post:Create
        [TestMethod]
        public void Create()
        {
            //Arrange//
            tbPreaviso.prea_RangoInicioMeses = 3;
            tbPreaviso.prea_RangoFinMeses = 4;
            tbPreaviso.prea_DiasPreaviso = 10;
            tbPreaviso.prea_UsuarioCrea = 1;
            tbPreaviso.prea_FechaCrea = DateTime.Now;

            //Variable para Capturar el Return del Método
            string ReturnValue = string.Empty;

            //Act//
            ActionResult js = _PreavisoController.Create(tbPreaviso);

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

            tbPreaviso.prea_IdPreaviso = 1;
            tbPreaviso.prea_RangoInicioMeses = 2;
            tbPreaviso.prea_RangoFinMeses = 4;
            tbPreaviso.prea_DiasPreaviso = 30;
            tbPreaviso.prea_UsuarioModifica = 1;
            tbPreaviso.prea_FechaModifica = DateTime.Now;

            //Variable para Capturar el Return del Método
            string ReturnValue = string.Empty;

            //Act//

            //Set de la variable antes declarada para la captura del Return del Método
            ReturnValue = (string)(_PreavisoController.Editar(tbPreaviso)).Data;

            //Assert//
            Assert.IsTrue(ReturnValue == "bien");

        }

        //Post:Inactivar
        [TestMethod]
        public void Inactivar()
        {
            //Arrange//

            int? id = 1;

            //Variable para Capturar el Return del Método
            string ReturnValue = string.Empty;

            //Act//

            //Set de la variable antes declarada para la captura del Return del Método
            ReturnValue = (string)(_PreavisoController.Inactivar(id)).Data;

            //Assert//
            Assert.IsTrue(ReturnValue == "bien");

        }

        //Post:Create
        [TestMethod]
        public void Activate()
        {
            //Arrange//

            //Act//

            //Set de la variable antes declarada para la captura del Return del Método
            _PreavisoController.Activar(1);

            //Assert//
            Assert.IsTrue(tbPreaviso.prea_IdPreaviso > 0);

        }

        //Post:Activar
        [TestMethod]
        public void Activar()
        {
            //Arrange//

            //Variable para Capturar el Return del Método
            string ReturnValue = string.Empty;

            //Act//
            ActionResult js = _PreavisoController.Activar(1);

            JsonResult json = js as JsonResult;

            ReturnValue = (string)(json).Data;

            //Assert//
            Assert.IsTrue(ReturnValue == "bien");

        }
    }
}
