using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ERP_GMEDINA.Controllers;
using ERP_GMEDINA.Models;

namespace ERP_GMEDINA_TEST.Controllers
{

    [TestClass]
    public class AuxilioCesantiaController_Test
    {
        //TEST DE METODOS DE ACCION DEL CONTROLADOR FormaPago

        //APLICACION DE LAS 3 "A" EN EL TESTING 
        //ARRANGE : PREPARAR 
        //ACT     : ACTUAR
        //ASSERT  : AFIRMAR


        //Instancia del controlador
        AuxilioDeCesantiasController _auxiliocesantia = new AuxilioDeCesantiasController();
        //Instancia de la clase
        tbAuxilioDeCesantias tbauxiliocesantia = new tbAuxilioDeCesantias();

        [TestMethod]
        public void Create()
        {
            //
            //ARRANGE
            //

            //Seteo de las propiedades del modelo solicitadas por el método
            tbauxiliocesantia.aces_RangoInicioMeses = 1;
            tbauxiliocesantia.aces_RangoFinMeses = 5;
            tbauxiliocesantia.aces_DiasAuxilioCesantia = 7;
            tbauxiliocesantia.aces_UsuarioCrea = 1;
            tbauxiliocesantia.aces_FechaCrea = DateTime.Now;

            //Variable para capturar el valor de retorno
            string ReturnValue = string.Empty;

            //
            //ACT
            //

            //Seteo de la variable para capturar el valor de retorno
            ReturnValue = (string)(_auxiliocesantia.Create(tbauxiliocesantia)).Data;

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
            tbauxiliocesantia.aces_IdAuxilioCesantia = 2;
            tbauxiliocesantia.aces_RangoInicioMeses = 7;
            tbauxiliocesantia.aces_RangoFinMeses = 12;
            tbauxiliocesantia.aces_DiasAuxilioCesantia = 9;

            //Variable para capturar el valor de retorno
            string ReturnValue = string.Empty;

            //
            //ACT
            //

            //Seteo de la variable para capturar el valor de retorno
            ReturnValue = (string)(_auxiliocesantia.Edit(tbauxiliocesantia)).Data;


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
            //

            //Seteo de las propiedades del modelo solicitadas por el método
            tbauxiliocesantia.aces_IdAuxilioCesantia = 1;


            //Variable para capturar el valor de retorno
            string ReturnValue = string.Empty;

            //
            //ACT
            //

            //Seteo de la variable para capturar el valor de retorno
            ReturnValue = (string)(_auxiliocesantia.Inactivar(tbauxiliocesantia.aces_IdAuxilioCesantia)).Data;

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
            //

            //Seteo de las propiedades del modelo solicitadas por el método
            tbauxiliocesantia.aces_IdAuxilioCesantia = 1;


            //Variable para capturar el valor de retorno
            string ReturnValue = string.Empty;

            //
            //ACT
            //

            //Seteo de la variable para capturar el valor de retorno
            ReturnValue = (string)(_auxiliocesantia.Activar(tbauxiliocesantia.aces_IdAuxilioCesantia)).Data;

            //
            //ASSERT
            //
            Assert.IsTrue(ReturnValue == "bien");

        }
    }
}
