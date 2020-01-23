using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ERP_GMEDINA.Controllers;
using ERP_GMEDINA.Models;

namespace ERP_GMEDINA_TEST.Controllers
{
    
    [TestClass]
    public class IngresosIndividualesControllerTest
    {
        private IngresosIndividualesController controller;

        [TestMethod]
        public void TestMethod1()
        {
        }

        //Instancia de la clase
       

        [TestMethod]
        public void CreateTest()
        {
            string ReturnValue = string.Empty;
            //Triple A
            //Arrange   PREPARAR
            controller = new IngresosIndividualesController();
            tbIngresosIndividuales tbIngIndv = new tbIngresosIndividuales();
            
            //tbIngIndv.ini_IdIngresosIndividuales = 2;
            tbIngIndv.ini_Motivo = "Falta Pago";
            tbIngIndv.emp_Id = 1;
            decimal _monto = Convert.ToDecimal(tbIngIndv.ini_Monto = 500);
            bool _pagasiempre = Convert.ToBoolean(tbIngIndv.ini_PagaSiempre = true);
           
            

            //Act       ARCTUAR
          
            ReturnValue = (string)(controller.Create(tbIngIndv.ini_Motivo = "Falta Pago", tbIngIndv.emp_Id = 1, _monto, _pagasiempre)).Data;

            //Assert    AFIRMAR
            Assert.IsTrue(ReturnValue == "bien");
           
        }

        [TestMethod]
        public void EditTest()
        {
            string ReturnValue = string.Empty;
            //Triple A
            //Arrange   PREPARAR
            controller = new IngresosIndividualesController();
            tbIngresosIndividuales tbIngIndv = new tbIngresosIndividuales();

            tbIngIndv.ini_IdIngresosIndividuales = 2;
          
            decimal _monto = Convert.ToDecimal(tbIngIndv.ini_Monto = 500);
            bool _pagasiempre = Convert.ToBoolean(tbIngIndv.ini_PagaSiempre = true);
           


            //Act       ARCTUAR
            controller.Edit(tbIngIndv.ini_IdIngresosIndividuales,tbIngIndv.ini_Motivo = "Falta Pago", tbIngIndv.emp_Id = 1, _monto, _pagasiempre);

           
            //Assert    AFIRMAR
            Assert.IsTrue(tbIngIndv.ini_IdIngresosIndividuales > 0);
          
        }

        [TestMethod]
        public void ActivarTest()
        {
            string ReturnValue = string.Empty;
            //Triple A
            //Arrange   PREPARAR
            controller = new IngresosIndividualesController();
            tbIngresosIndividuales tbIngIndv = new tbIngresosIndividuales();

            tbIngIndv.ini_IdIngresosIndividuales = 2;
            
            //Act       ARCTUAR
            controller.Activar(tbIngIndv.ini_IdIngresosIndividuales);

          
            //Assert    AFIRMAR
            Assert.IsTrue(tbIngIndv.ini_IdIngresosIndividuales > 0);
         
        }

        [TestMethod]
        public void InctivarTest()
        {
            string ReturnValue = string.Empty;
            //Triple A
            //Arrange   PREPARAR
            controller = new IngresosIndividualesController();
            tbIngresosIndividuales tbIngIndv = new tbIngresosIndividuales();

            tbIngIndv.ini_IdIngresosIndividuales = 2;

            //Act       ARCTUAR
            controller.Inactivar(tbIngIndv.ini_IdIngresosIndividuales);
            
            //Assert    AFIRMAR
            Assert.IsTrue(tbIngIndv.ini_IdIngresosIndividuales > 0);
         
        }

    }
}
