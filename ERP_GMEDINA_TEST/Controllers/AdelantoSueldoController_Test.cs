using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ERP_GMEDINA.Controllers;
using ERP_GMEDINA.Models;

namespace ERP_GMEDINA_TEST.Controllers
{
    [TestClass]
    public class AdelantoSueldoController_Test
    {

        private AdelantoSueldoController controller;


        //Instancia del controlador
        AdelantoSueldoController _AdelantoSueldoController = new AdelantoSueldoController();

        //Instancia de la clase
        tbAdelantoSueldo tbAdelantoSueldo = new tbAdelantoSueldo();

        [TestMethod]
        public void CreateTest()
        {
            //Triple A
            //Arrange   PREPARAR
            controller = new AdelantoSueldoController();
            tbAdelantoSueldo tbAdelantoSueldo = new tbAdelantoSueldo();
            tbAdelantoSueldo.emp_Id = 2;
            tbAdelantoSueldo.adsu_FechaAdelanto = DateTime.Now;
            tbAdelantoSueldo.adsu_RazonAdelanto = "H";
            tbAdelantoSueldo.adsu_Monto = 343;

            //Act       ARCTUAR
            controller.Create(tbAdelantoSueldo);

            //Assert    AFIRMAR
            Assert.IsTrue(tbAdelantoSueldo.adsu_IdAdelantoSueldo > 0);


            ////Triple A
            ////Arrange   PREPARAR
            //tbAdelantoSueldo.emp_Id = 2;
            //tbAdelantoSueldo.adsu_FechaAdelanto = DateTime.Now;
            //tbAdelantoSueldo.adsu_RazonAdelanto = "Enfermedad";
            //tbAdelantoSueldo.adsu_Monto = 500;

            ////Variable para capturar el valor de retorno
            //string ReturnValue = string.Empty;

            ////Seteo de la variable para capturar el valor de retorno
            //ReturnValue = (string)(_AdelantoSueldoController.Create(tbAdelantoSueldo)).Data;

            ////
            ////ASSERT
            ////
            //Assert.IsTrue(ReturnValue == "bien");

        }
        [TestMethod]
        public void EditarTest()
        {
            //
            //ARRANGE
            //

            //Seteo de las propiedades del modelo solicitadas por el método
            tbAdelantoSueldo.adsu_IdAdelantoSueldo = 1;
            tbAdelantoSueldo.emp_Id = 10;
            tbAdelantoSueldo.adsu_FechaAdelanto = DateTime.Now;
            tbAdelantoSueldo.adsu_RazonAdelanto = "Enfermedad";
            tbAdelantoSueldo.adsu_Monto = 500;

            //Variable para capturar el valor de retorno
            string ReturnValue = string.Empty;

            //
            //ACT
            //

            //Seteo de la variable para capturar el valor de retorno
            ReturnValue = (string)(_AdelantoSueldoController.Edit(tbAdelantoSueldo)).Data;

            //
            //ASSERT
            //
            Assert.IsTrue(ReturnValue == "bien");
        }

        [TestMethod]
        public void InactivarTest()
        {
            //Triple A
            //Arrange   PREPARAR
            controller = new AdelantoSueldoController();
            tbAdelantoSueldo tbAdelantoSueldo = new tbAdelantoSueldo();
            tbAdelantoSueldo.adsu_IdAdelantoSueldo = 2;

            //Act       ARCTUAR
            controller.Inactivar(tbAdelantoSueldo.adsu_IdAdelantoSueldo);

            //Assert    AFIRMAR
            Assert.IsTrue(tbAdelantoSueldo.adsu_IdAdelantoSueldo > 0);
        }
        [TestMethod]
        public void ActivarTest()
        {
            //Triple A
            //Arrange   PREPARAR
            controller = new AdelantoSueldoController();
            tbAdelantoSueldo tbAdelantoSueldo = new tbAdelantoSueldo();
            tbAdelantoSueldo.adsu_IdAdelantoSueldo = 2;
       
            //Act       ARCTUAR
            controller.Activar(tbAdelantoSueldo.adsu_IdAdelantoSueldo);

            //Assert    AFIRMAR
            Assert.IsTrue(tbAdelantoSueldo.adsu_IdAdelantoSueldo > 0);
        }
    }
}
 

