using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ERP_GMEDINA.Controllers;
using System.Web.Helpers;
using System.Web.Mvc;

namespace ERP_GMEDINA_TEST.Controllers
{
    public class PlanillaTestig
    {
        public int ID { get; set; }
        public bool enviarEmail { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
    }

    public class SalarioPromedio
    {
        public decimal netoAPagarColaborador { get; set; }
        public List<decimal> mesesPago { get; set; }
        public bool esMensual { get; set; }
        public  decimal SalarioPromedioAnualPagadoAlAnio { get; set; }
        public decimal salarioPromedioAnualPagadoAlMes { get; set; }

    }

    [TestClass]
    public class PlanillasController_Test
    {

        private PlanillaController controller = new PlanillaController();
        [TestMethod]
        public void GenerarPlanilla()
        {
            //Triple A
            //Arrange   PREPARAR
            PlanillaTestig PlaniTest = new PlanillaTestig();

            PlaniTest.ID = 2;
            PlaniTest.enviarEmail = true;
            PlaniTest.fechaInicio = DateTime.Now;
            PlaniTest.fechaFin = DateTime.Now;
            //Act       ARCTUAR
            string Result = controller.GenerarPlanilla(PlaniTest.ID,
                                                       PlaniTest.enviarEmail,
                                                       PlaniTest.fechaInicio,
                                                       PlaniTest.fechaFin).ToString();
            //Assert    AFIRMAR
            Assert.IsTrue(Result != null);
        }
        [TestMethod]
        public void SalarioPromedioTest()
        {
            //Triple A
            //Arrange   PREPARAR
            List<decimal> ListaDecimal = new List<decimal>();
            ListaDecimal.Add((decimal)1.10);
            ListaDecimal.Add((decimal)2.45);
            ListaDecimal.Add((decimal)3.67);
            SalarioPromedio SalProm = new SalarioPromedio();

            SalProm.netoAPagarColaborador = (decimal)4500.00;
            SalProm.mesesPago = ListaDecimal;
            SalProm.esMensual = true;
            decimal SalarioMensual = (decimal)80000.00;
            decimal SalarioAnual = (decimal)450.00;


            //Act       ARCTUAR
            decimal Result = PlanillaController.SalarioPromedioAnualISR(SalProm.netoAPagarColaborador,
                                                                SalProm.mesesPago,
                                                                SalProm.esMensual,
                                                               ref SalarioMensual,
                                                               ref SalarioAnual);
            //Assert    AFIRMAR
            Assert.IsTrue(Result != null);
        }
    }



    //[TestClass]
    //public class SalarioPromedioAnualISR_Test
    //{
    //    private PlanillaController controller = new PlanillaController();
    //    [TestMethod]
    //    public void SalarioPromedioTest()
    //    {
    //        //Triple A
    //        //Arrange   PREPARAR
    //        List<decimal> ListaDecimal = new List<decimal>();
    //        ListaDecimal.Add((decimal)1.10);
    //        ListaDecimal.Add((decimal)2.45);
    //        ListaDecimal.Add((decimal)3.67);
    //        SalarioPromedio SalProm = new SalarioPromedio();

    //        SalProm.netoAPagarColaborador = (decimal)4500.00;
    //        SalProm.mesesPago = ListaDecimal;
    //        SalProm.esMensual = true;
    //        decimal SalarioMensual = (decimal)80000.00;
    //        decimal SalarioAnual = (decimal)450.00;
           

    //        //Act       ARCTUAR
    //        decimal Result =PlanillaController.SalarioPromedioAnualISR(SalProm.netoAPagarColaborador,
    //                                                            SalProm.mesesPago,
    //                                                            SalProm.esMensual,
    //                                                           ref SalarioMensual,
    //                                                           ref SalarioAnual);
    //        //Assert    AFIRMAR
    //        Assert.IsTrue(Result != null);
    //    }
    //}
}


internal class PlanillasController
    {
    }

