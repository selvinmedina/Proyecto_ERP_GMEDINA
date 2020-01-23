using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ERP_GMEDINA.Controllers;
using ERP_GMEDINA.Models;

namespace ERP_GMEDINA_TEST.Controllers
{
    [TestClass]
    public class AFPController_Test
    {
        AFPController _AFPController = new AFPController();
        //Instancia de la clase
        tbAFP tbAFP = new tbAFP();


        [TestMethod]
        public void Create()
        {
            //
            //ARRANGE
            //

            //Seteo de las propiedades del modelo solicitadas por el método
            tbAFP.afp_Descripcion = "HolaMundo";
            tbAFP.afp_AporteMinimoLps = (int)100.50;
            tbAFP.afp_InteresAporte = (int)50.20;
            tbAFP.afp_InteresAnual = (int)40.60;
            tbAFP.tde_IdTipoDedu = 1;
            tbAFP.afp_UsuarioCrea= 1;
            tbAFP.afp_FechaCrea = DateTime.Now;



            //Variable para capturar el valor de retorno
            string ReturnValue = string.Empty;

            //
            //ACT
            //

            //Seteo de la variable para capturar el valor de retorno
            ReturnValue = (string)(_AFPController.Create(tbAFP)).Data;

            //
            //ASSERT
            //
            Assert.IsTrue(ReturnValue == "bien");
        }

        [TestMethod]
        public void Edit()
        {
            //
            //ARRANGE
            //

            //Seteo de las propiedades del modelo solicitadas por el método
            tbAFP.afp_Id = 1;
            tbAFP.afp_Descripcion = "HolaMundo";
            tbAFP.afp_AporteMinimoLps = (int)100.50;
            tbAFP.afp_InteresAporte = (int)50.20;
            tbAFP.afp_InteresAnual = (int)40.60;
            tbAFP.tde_IdTipoDedu = 1;
            tbAFP.afp_UsuarioModifica = 1;
            tbAFP.afp_FechaModifica = DateTime.Now;



            //Variable para capturar el valor de retorno
            string ReturnValue = string.Empty;

            //
            //ACT
            //

            //Seteo de la variable para capturar el valor de retorno
            ReturnValue = (string)(_AFPController.Edit(tbAFP)).Data;

            //
            //ASSERT
            //
            Assert.IsTrue(ReturnValue == "bien");
        }

        [TestMethod]
        public void Inactivar()
        {
            //
            //ARRANGE
            //Variable para capturar el valor de retorno
            string ReturnValue = string.Empty;

            //
            //ACT
            //

            //Seteo de la variable para capturar el valor de retorno
            ReturnValue = (string)(_AFPController.Inactivar(1)).Data;

            //
            //ASSERT
            //
            Assert.IsTrue(ReturnValue == "bien");

        }

        [TestMethod]
        public void Activar()
        {
            //
            //ARRANGE
            //Variable para capturar el valor de retorno
            string ReturnValue = string.Empty;

            //
            //ACT
            //

            //Seteo de la variable para capturar el valor de retorno
            ReturnValue = (string)(_AFPController.Activar(1)).Data;

            //
            //ASSERT
            //
            Assert.IsTrue(ReturnValue == "bien");

        }
    }
}
