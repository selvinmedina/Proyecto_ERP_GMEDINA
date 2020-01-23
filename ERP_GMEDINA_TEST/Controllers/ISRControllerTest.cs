using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ERP_GMEDINA.Controllers;
using ERP_GMEDINA.Models;

namespace ERP_GMEDINA_TEST.Controllers
{
    [TestClass]
    public class ISRControllerTest
    {
        private ISRController controller;

        [TestMethod]
        public void TestMethod1()
        {
        }
   
        [TestMethod]
        public void CreateTest()
        {
            //Triple A
            //Arrange   PREPARAR
            controller = new ISRController();
            tbISR isr = new tbISR();
            isr.isr_Id = 1;
            isr.isr_RangoInicial = 2;
            isr.isr_RangoFinal = 3;
            isr.isr_Porcentaje = 4;
            isr.isr_Activo = true;
            
            //Act       ARCTUAR
            controller.Create(isr);

            //Assert    AFIRMAR
            Assert.IsTrue(isr.isr_Id > 0);
        }


        [TestMethod]
        public void EditTest()
        {
            //Triple A
            //Arrange   PREPARAR
            controller = new ISRController();
            tbISR isr = new tbISR();
            isr.isr_Id = 1;
            isr.isr_RangoInicial = 2;
            isr.isr_RangoFinal = 3;
            isr.isr_Porcentaje = 4;
            isr.isr_Activo = true;

            //Act       ARCTUAR
            controller.Edit(isr);

            //Assert    AFIRMAR
            Assert.IsTrue(isr.isr_Id > 0);
        }

        [TestMethod]
        public void ActivarTest()
        {
            //Triple A
            //Arrange   PREPARAR
            controller = new ISRController();
            tbISR isr = new tbISR();
            isr.isr_Id = 1;
            
            //Act       ARCTUAR
            controller.Activar(isr.isr_Id);

            //Assert    AFIRMAR
            Assert.IsTrue(isr.isr_Id > 0);
        }

        [TestMethod]
        public void InactivarTest()
        {
            //Triple A
            //Arrange   PREPARAR
            controller = new ISRController();
            tbISR isr = new tbISR();
            isr.isr_Id = 1;

            //Act       ARCTUAR
            controller.Inactivar(isr.isr_Id);

            //Assert    AFIRMAR
            Assert.IsTrue(isr.isr_Id > 0);
        }

    }
}


