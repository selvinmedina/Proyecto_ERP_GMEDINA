using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ERP_GMEDINA.Controllers;
using ERP_GMEDINA.Models;
using System.Collections.Generic;

namespace ERP_GMEDINA_TEST.Controllers
{
    [TestClass]
    public class CatalogoDePlanillasController_Test
    {

        private CatalogoDePlanillasController controller;

        //Instancia del controlador
        CatalogoDePlanillasController _CatalogoDePlanillasController = new CatalogoDePlanillasController();
        //Instancia de la clase
        tbCatalogoDePlanillas tbCatalogoDePlanillas = new tbCatalogoDePlanillas();


        [TestMethod]
        public void getDeduccionIngresos_Test()
        {
            //Triple A
            //Arrange   PREPARAR


            tbCatalogoDePlanillas.cpla_IdPlanilla = 1;

            //Variable para capturar el valor de retorno
            object ReturnValue = null;

            //
            //ACT
            //

            //Seteo de la variable para capturar el valor de retorno
            ReturnValue = (object)(_CatalogoDePlanillasController.getDeduccionIngresos(tbCatalogoDePlanillas.cpla_IdPlanilla)).Data;

            //
            //ASSERT
            //
            Assert.IsTrue(ReturnValue != null);
        }


        [TestMethod]
        public void Create_Test()
        {
            //
            //ARRANGE
            //
            string[] catalogoDePlanillas = { "UnitTest" };
            int[] catalogoDeIngresos = { 2, 3, 4 };
            int[] catalogoDeDeducciones = { 1, 5 };
            bool checkRecibeComision = false;


            //Variable para capturar el valor de retorno
            string ReturnValue = string.Empty;

            //
            //ACT
            //

            //Seteo de la variable para capturar el valor de retorno
            ReturnValue = (string)(_CatalogoDePlanillasController.Create(catalogoDePlanillas, catalogoDeIngresos, catalogoDeDeducciones, checkRecibeComision)).Data;

            //
            //ASSERT
            //
            Assert.IsTrue(ReturnValue == "bien");

        }


        [TestMethod]
        public void GetIngresosDeducciones_Test()
        {
            //Triple A
            //Arrange   PREPARAR
            bool esCrear = true;
            int id = 0;
            bool esIngreso = true;
            //Variable para capturar el valor de retorno
            object ReturnValue = null;
            //ACT

            //Seteo de la variable para capturar el valor de retorno
            ReturnValue = (object)(_CatalogoDePlanillasController.GetIngresosDeducciones
                                                                                       (esCrear, id, esIngreso)).Data;

            //
            //ASSERo
            //
            Assert.IsTrue(ReturnValue != null);
        }

        [TestMethod]
        public void InsertarPlanilla_Test()
        {
            //Triple A
            //Arrange   PREPARAR
            tbCatalogoDePlanillas.cpla_UsuarioModifica = 1;
            tbCatalogoDePlanillas.cpla_FechaModifica = DateTime.Now;
            tbCatalogoDePlanillas.cpla_DescripcionPlanilla = "Diaria";
            tbCatalogoDePlanillas.cpla_FrecuenciaEnDias = 1;
            tbCatalogoDePlanillas.cpla_Activo = true;
            //Variable para capturar el valor de retorno
            IEnumerable<object> ReturnValue = null;
            //ACT

            //Seteo de la variable para capturar el valor de retorno
            ReturnValue = (IEnumerable<object>)(_CatalogoDePlanillasController.InsertarPlanilla(tbCatalogoDePlanillas.cpla_UsuarioModifica ?? 0,
                                                                                         tbCatalogoDePlanillas.cpla_FechaModifica ?? DateTime.Now,
                                                                                         tbCatalogoDePlanillas.cpla_DescripcionPlanilla,
                                                                                         tbCatalogoDePlanillas.cpla_FrecuenciaEnDias,
                                                                                         tbCatalogoDePlanillas.cpla_Activo));

            //
            //ASSERo
            //
            Assert.IsTrue(ReturnValue != null);
        }
        [TestMethod]
        public void DeleteConfirmed_Test()
        {
            controller = new CatalogoDePlanillasController();
            tbCatalogoDePlanillas tbCatalogoDePlanillas = new tbCatalogoDePlanillas();
            //
            //ARRANGE
            //Variable para capturar el valor de retorno
            tbCatalogoDePlanillas.cpla_IdPlanilla = 1;

            //
            //ACT
            //
            controller.DeleteConfirmed(tbCatalogoDePlanillas.cpla_IdPlanilla);

            //Assert    AFIRMAR
            Assert.IsTrue(tbCatalogoDePlanillas.cpla_IdPlanilla > 0);

        }

        [TestMethod]
        public void ActivarPlanilla_Test()
        {
            controller = new CatalogoDePlanillasController();
            tbCatalogoDePlanillas tbCatalogoDePlanillas = new tbCatalogoDePlanillas();
            //
            //ARRANGE
            //Variable para capturar el valor de retorno
            tbCatalogoDePlanillas.cpla_IdPlanilla = 1;

            //
            //ACT
            //
            controller.ActivarPlanilla(tbCatalogoDePlanillas.cpla_IdPlanilla);

            //Assert    AFIRMAR
            Assert.IsTrue(tbCatalogoDePlanillas.cpla_IdPlanilla > 0);

        }

         [TestMethod]
        public void EditPost_Test()
        {
            //
            //ARRANGE
            //
            int id = 2;
            string[] catalogoDePlanillas = { "UnitTest","8" };
            int[] catalogoDeIngresos = { 2, 4 };
            int[] catalogoDeDeducciones = { 5 };
            bool checkRecibeComision = true;


            //Variable para capturar el valor de retorno
            string ReturnValue = string.Empty;

            //
            //ACT
            //

            //Seteo de la variable para capturar el valor de retorno

            ReturnValue = (string)(_CatalogoDePlanillasController.Edit(id, 
                                                                       catalogoDePlanillas, 
                                                                       catalogoDeIngresos, 
                                                                       catalogoDeDeducciones, 
                                                                       checkRecibeComision)).Data;

            //
            //ASSERT
            //
            Assert.IsTrue(ReturnValue == "bien");

        }

        //[TestMethod]
        //public void EditGet_Test()
        //{
        //    controller = new CatalogoDePlanillasController();
        //    //
        //    //ARRANGE
        //    //
        //    int IdPlanilla = 2;
 
        //    //
        //    //ACT
        //    //

        //    //Act       ARCTUAR
        //    controller.Edit(IdPlanilla);

        //    //Assert    AFIRMAR
        //    Assert.IsTrue(tbCatalogoDePlanillas.cpla_IdPlanilla > 0);

        //}
        [TestMethod]
        public void EditarPlanilla()
        {
            //
            //ARRANGE
            //
            int? idPlanillaEdit = 2;
            string MensajeError = "bien";
            int cpla_UsuarioCreaModifica = 1;
            DateTime cpla_FechaCreaModifica = DateTime.Now;
            string cpla_DescripcionPlanilla = "UnitTest";
            int cpla_FrecuenciaEnDias = 7;
            bool checkRecibeComision = true;


            //Variable para capturar el valor de retorno
            string ReturnValue = string.Empty;

            //
            //ACT
            //

            //Seteo de la variable para capturar el valor de retorno

            ReturnValue = (string)(_CatalogoDePlanillasController.EditarPlanilla(idPlanillaEdit,
                                                                                ref MensajeError,
                                                                                cpla_UsuarioCreaModifica,
                                                                                 cpla_FechaCreaModifica,
                                                                                 cpla_DescripcionPlanilla,
                                                                                 cpla_FrecuenciaEnDias,
                                                                                 checkRecibeComision));

            //
            //ASSERT
            //
            Assert.IsTrue(idPlanillaEdit > 0 );

        }

        [TestMethod]
        public void ObtenerCatalogoDePlanilla()
        {
            //
            //ARRANGE
            //
            controller = new CatalogoDePlanillasController();
            //Seteo de las propiedades del modelo solicitadas por el método
            string response = "ok";
            int id = 1;
            //Variable para capturar el valor de retorno
            string ReturnValue = string.Empty;

            //
            //ACT
            //

            //Seteo de la variable para capturar el valor de retorno
            ReturnValue = (string)(_CatalogoDePlanillasController.ObtenerCatalogoDePlanilla(id, response, out tbCatalogoDePlanillas));

            //
            //ASSERT
            //
            Assert.IsFalse(ReturnValue == "bien");

        }


        //METODO EDIT
        [TestMethod]
        public void Edit()
        {
            //ARRANGE
            int id = 1;
            string[] catalogoDePlanillas = { "7", "15" };
            int[] catalogoIngresos = { 1, 2 };
            int[] catalogoDeducciones = { 1, 2 };
            bool checkRecibeComision = true;
            string ReturnValue = "";

            //ACT

            ReturnValue = (String)(_CatalogoDePlanillasController.Edit(id, catalogoDePlanillas, catalogoIngresos, catalogoDeducciones, checkRecibeComision)).Data;

            //ASSERT
            Assert.IsTrue(ReturnValue == "bien");
        }

        //METODO INSERTAR CATALOGO DEDUCCIONES
        [TestMethod]
        public void InsertarCatalogoDeducciones()
        {
            //ARRANGE
            int[] idDeducciones = { 1, 2, 3 };
            string response = "";
            string MensajeError = "1";
            string MensajeErrorCatalogoDeIngresos = "1";
            string MensajeErrorCatalogoDeDeducciones = "";
            IEnumerable<object> listCatalogoDeDeducciones = null;

            //ACT
            _CatalogoDePlanillasController.InsertarCatalogoDeducciones
                (catalogoDeducciones: idDeducciones,
                response: ref response,
                MensajeError: MensajeError,
                MensajeErrorCatalogoDeIngresos: MensajeErrorCatalogoDeIngresos,
                MensajeErrorCatalogoDeDeducciones: ref MensajeErrorCatalogoDeDeducciones,
                listCatalogoDeDeducciones: ref listCatalogoDeDeducciones);

            //ASSERT
            Assert.IsFalse(MensajeErrorCatalogoDeDeducciones.StartsWith("-1"));
        }

        //METODO INSERTAR CATALOGO INGRESOS
        [TestMethod]
        public void InsertarCatalogoIngresos()
        {
            //ARRANGE
            int[] idIngresos = { 1, 2, 3 };
            string response = "";
            string MensajeError = "1";
            string MensajeErrorCatalogoDeIngresos = "";
            //string MensajeErrorCatalogoDeDeducciones = "";
            IEnumerable<object> listCatalogoDeIngresos = null;
            int cpla_UsuarioCreaModifica = 1;

            //ACT
            _CatalogoDePlanillasController.InsertarCatalogoIngresos(idIngresos, ref response, MensajeError, ref MensajeErrorCatalogoDeIngresos, ref listCatalogoDeIngresos, cpla_UsuarioCreaModifica);

            //ASSERT
            Assert.IsFalse(MensajeErrorCatalogoDeIngresos.StartsWith("-1"));

        }
    }

    }




