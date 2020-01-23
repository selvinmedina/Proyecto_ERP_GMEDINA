using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ERP_GMEDINA.Controllers;
using ERP_GMEDINA.Models;
using System.Web.Mvc;

namespace ERP_GMEDINA_TEST.Controllers
{
    [TestClass]
    public class DecimoTercerMesController_Test
    {
        private ERP_GMEDINAEntities db = new ERP_GMEDINAEntities();

        //Instancia del Controlador
        DecimoTercerMesController _DecimoTercerMesController = new DecimoTercerMesController();

        [TestMethod]
        public void InsertDecimoTercerMes()
        {
            //Arrange

            tbDecimoTercerMes DecimoTercerMes = new tbDecimoTercerMes();

            int? emp_Id = 6;
            decimal? dtm_Monto = 9000.00M;

            DecimoTercerMes.emp_Id = emp_Id;
            DecimoTercerMes.dtm_Monto = dtm_Monto;

            //Instancia de la Entidad
            List<tbDecimoTercerMes> ListDecimoTercerMes = new List<tbDecimoTercerMes>();

            ListDecimoTercerMes.Add(DecimoTercerMes);

            //Variable para capturar el valor de retorno
            int ReturnValue = 0;

            //
            //ACT
            //

            //Seteo de la variable para capturar el valor de retorno
            ReturnValue = (int)(_DecimoTercerMesController.InsertDecimoTercerMes(ListDecimoTercerMes)).Data;

            //
            //ASSERT
            //
            Assert.IsTrue(ReturnValue > 0);
        }


    }
}

