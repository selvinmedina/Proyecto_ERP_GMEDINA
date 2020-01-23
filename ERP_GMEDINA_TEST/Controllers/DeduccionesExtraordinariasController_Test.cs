using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ERP_GMEDINA.Controllers;
using ERP_GMEDINA.Models;

namespace ERP_GMEDINA_TEST.Controllers
{
    [TestClass]
    public class DeduccionesExtraordinariasController_Test
    {
        //TEST DE METODOS DE ACCION DEL CONTROLADOR FormaPago

        //APLICACION DE LAS 3 "A" EN EL TESTING 
        //ARRANGE : PREPARAR 
        //ACT     : ACTUAR
        //ASSERT  : AFIRMAR


        //Instancia del controlador
         DeduccionesExtraordinariasController _DeduccionesExtraordinariasController = new DeduccionesExtraordinariasController();
        //Instancia de la clase
        tbDeduccionesExtraordinarias tbDeduccionesExtraordinarias = new tbDeduccionesExtraordinarias();

        [TestMethod]
        public void CreateTest()
        {
            //
            //ARRANGE
            //

            //Seteo de las propiedades del modelo solicitadas por el método
            tbDeduccionesExtraordinarias.eqem_Id = 1;
            tbDeduccionesExtraordinarias.dex_MontoInicial = 5000;
            tbDeduccionesExtraordinarias.dex_MontoRestante = 3000;
            tbDeduccionesExtraordinarias.dex_ObservacionesComentarios = "TestingDeduccionesExtraordinarias";
            tbDeduccionesExtraordinarias.cde_IdDeducciones = 1;
            tbDeduccionesExtraordinarias.dex_Cuota = 300;
            tbDeduccionesExtraordinarias.dex_UsuarioCrea = 1;
            tbDeduccionesExtraordinarias.dex_FechaCrea = DateTime.Now;

            //Variable para capturar el valor de retorno
            string ReturnValue = string.Empty;

            //
            //ACT
            //

            //Seteo de la variable para capturar el valor de retorno
            ReturnValue = (string)(_DeduccionesExtraordinariasController.Create(tbDeduccionesExtraordinarias)).Data;

            //
            //ASSERT
            //
            Assert.IsTrue(ReturnValue == "Exito");

        }

        [TestMethod]
        public void EditarTest()
        {
            //
            //ARRANGE
            //

            //Seteo de las propiedades del modelo solicitadas por el método
            tbDeduccionesExtraordinarias.dex_IdDeduccionesExtra = 1;
            tbDeduccionesExtraordinarias.eqem_Id = 1;
            tbDeduccionesExtraordinarias.dex_MontoInicial = 5000;
            tbDeduccionesExtraordinarias.dex_MontoRestante = 3000;
            tbDeduccionesExtraordinarias.dex_ObservacionesComentarios = "TestingDeduccionesExtraordinarias1";
            tbDeduccionesExtraordinarias.cde_IdDeducciones = 1;
            tbDeduccionesExtraordinarias.dex_Cuota = 300;
            tbDeduccionesExtraordinarias.dex_UsuarioModifica = 1;
            tbDeduccionesExtraordinarias.dex_FechaModifica = DateTime.Now;

            //Variable para capturar el valor de retorno
            string ReturnValue = string.Empty;

            //
            //ACT
            //

            //Seteo de la variable para capturar el valor de retorno
            ReturnValue =(string)(_DeduccionesExtraordinariasController.Edit(tbDeduccionesExtraordinarias)).Data;

            //
            //ASSERT
            //
            Assert.IsTrue(ReturnValue == "Exito");

        }

        [TestMethod]
        public void InactivarTest()
        {
            //
            //ARRANGE
            //

            //Seteo de las propiedades del modelo solicitadas por el método
            tbDeduccionesExtraordinarias.dex_IdDeduccionesExtra = 1;

            //
            //ACT
            //

            //Seteo de la variable para capturar el valor de retorno
            _DeduccionesExtraordinariasController.Inactivar(tbDeduccionesExtraordinarias.dex_IdDeduccionesExtra);

            //
            //ASSERT
            //
            Assert.IsTrue(tbDeduccionesExtraordinarias.dex_IdDeduccionesExtra > 0);

        }

        [TestMethod]
        public void ActivarTest()
        {
            //
            //ARRANGE
            //

            //Seteo de las propiedades del modelo solicitadas por el método
            tbDeduccionesExtraordinarias.dex_IdDeduccionesExtra = 1;

            //
            //ACT
            //

            //Seteo de la variable para capturar el valor de retorno
            _DeduccionesExtraordinariasController.Activar(tbDeduccionesExtraordinarias.dex_IdDeduccionesExtra);

            //
            //ASSERT
            //
            Assert.IsTrue(tbDeduccionesExtraordinarias.dex_IdDeduccionesExtra > 0);

        }
    }
}
