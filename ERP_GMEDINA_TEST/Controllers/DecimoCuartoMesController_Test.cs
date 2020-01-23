using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ERP_GMEDINA.Controllers;
using ERP_GMEDINA.Models;
using System.Collections.Generic;

namespace ERP_GMEDINA_TEST.Controllers
{
    [TestClass]
    public class DecimoCuartoMesController_Test
    {
        DecimoCuartoMesController _DecimoCuartoMesController = new DecimoCuartoMesController();
        tbDecimoCuartoMes DecimoCuartoMes = new tbDecimoCuartoMes();
        List<tbDecimoCuartoMes> tbDecimoCuartoMesList = new List<tbDecimoCuartoMes>();
        //tbDecimoCuartoMes tbDecimoCuartoMes = new tbDecimoCuartoMes();
        //METODO INSERT
        [TestMethod]
        public void InsertDecimoCuartoMes()
        {
            //ARRANGE
            DecimoCuartoMes.emp_Id = 1;
            DecimoCuartoMes.dcm_Monto = 1000;
            tbDecimoCuartoMesList.Add(DecimoCuartoMes);
            int ReturnValue;

            //ACT
            ReturnValue = (int)(_DecimoCuartoMesController.InsertDecimoCuartoMes(tbDecimoCuartoMesList)).Data;

            //ASSERT
            Assert.IsTrue(ReturnValue > 0);
        }
    }
}
