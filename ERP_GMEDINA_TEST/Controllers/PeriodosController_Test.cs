using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ERP_GMEDINA.Controllers;
using ERP_GMEDINA.Models;

namespace ERP_GMEDINA_TEST.Controllers
{
    [TestClass]
    public class PeriodosController_Test
    {

        private PeriodosController controller;
     

        //Instancia del controlador
        PeriodosController _PeriodosController = new PeriodosController();
        //Instancia de la clase
        tbPeriodos tbPeriodos = new tbPeriodos();
        [TestMethod]
        public void CreateTest()
        { //
            //ARRANGE
            //

            //Seteo de las propiedades del modelo solicitadas por el método
            tbPeriodos.peri_DescripPeriodo = "TestProject";

            //Variable para capturar el valor de retorno
            string ReturnValue = string.Empty;

            //
            //ACT
            //

            //Seteo de la variable para capturar el valor de retorno
            ReturnValue = (string)(_PeriodosController.Create(tbPeriodos)).Data;

            //
            //ASSERT
            //
            Assert.IsTrue(ReturnValue == "bien");
        }


        [TestMethod]
        public void EditarTest()
        {
            //
            //ARRANGE
            //

            //Seteo de las propiedades del modelo solicitadas por el método
            tbPeriodos.peri_IdPeriodo = 1;
            tbPeriodos.peri_DescripPeriodo = "Test";

            //Variable para capturar el valor de retorno
            string ReturnValue = string.Empty;

            //
            //ACT
            //

            //Seteo de la variable para capturar el valor de retorno
            ReturnValue = (string)(_PeriodosController.Editar(tbPeriodos)).Data;

            //
            //ASSERT
            //
            Assert.IsTrue(ReturnValue == "bien");

        }


        [TestMethod]
        public void Editar()
        {
            //Triple A
            //Arrange Preparar

            tbPeriodos.peri_IdPeriodo = 1;
            tbPeriodos.peri_DescripPeriodo = "Test";

            //Act Actuar
            _PeriodosController.Editar(tbPeriodos);

            //Assert Afirmar
            Assert.IsTrue(tbPeriodos.peri_IdPeriodo > 0);
        }



        [TestMethod]
        public void InactivarTest()
        {
            //
            //ARRANGE
            //Variable para capturar el valor de retorno
            string ReturnValue = string.Empty;

            //
            //ACT
            //

            //Seteo de la variable para capturar el valor de retorno
            ReturnValue = (string)(_PeriodosController.Inactivar(1)).Data;

            //
            //ASSERT
            //
            Assert.IsTrue(ReturnValue == "bien");

        }

        [TestMethod]
        public void ActivarTest()
        {
            //
            //ARRANGE
            //Variable para capturar el valor de retorno
            string ReturnValue = string.Empty;

            //
            //ACT
            //

            //Seteo de la variable para capturar el valor de retorno
            ReturnValue = (string)(_PeriodosController.Activar(1)).Data;

            //
            //ASSERT
            //
            Assert.IsTrue(ReturnValue == "bien");

        }

    }
}


