using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ERP_GMEDINA.Controllers;
using ERP_GMEDINA.Models;

namespace ERP_GMEDINA_TEST.Controllers
{
    [TestClass]
    public class CatalogoDeduccionesController_Test
    {

        //TEST DE METODOS DE ACCION DEL CONTROLADOR FormaPago

        //APLICACION DE LAS 3 "A" EN EL TESTING 
        //ARRANGE : PREPARAR 
        //ACT     : ACTUAR
        //ASSERT  : AFIRMAR


        //Instancia del controlador
        CatalogoDeDeduccionesController _catalogodeducciones = new CatalogoDeDeduccionesController();
        //Instancia de la clase
        tbCatalogoDeDeducciones tbacatalogodeducciones = new tbCatalogoDeDeducciones();

        [TestMethod]
        public void Create()
        {
            //
            //ARRANGE
            //

            //Seteo de las propiedades del modelo solicitadas por el método
            tbacatalogodeducciones.cde_DescripcionDeduccion = "TestProject";
            tbacatalogodeducciones.cde_UsuarioCrea = 1;
            tbacatalogodeducciones.cde_FechaCrea = DateTime.Now;
            //Variable para capturar el valor de retorno
            string ReturnValue = string.Empty;

            //
            //ACT
            //

            //Seteo de la variable para capturar el valor de retorno
            ReturnValue = (string)(_catalogodeducciones.Create(tbacatalogodeducciones)).Data;

            //
            //ASSERT
            //
            Assert.IsTrue(ReturnValue == "bien");
        }

        [TestMethod]
        public void Editar()
        {
            //
            //ARRANGE
            //

            //Seteo de las propiedades del modelo solicitadas por el método
            tbacatalogodeducciones.cde_IdDeducciones = 2;
            tbacatalogodeducciones.cde_DescripcionDeduccion = "TestProject";
            tbacatalogodeducciones.tde_IdTipoDedu = 1;
            tbacatalogodeducciones.cde_PorcentajeColaborador = 15;
            tbacatalogodeducciones.cde_PorcentajeEmpresa =15;


            //Variable para capturar el valor de retorno
            string ReturnValue = string.Empty;

            //
            //ACT
            //

            //Seteo de la variable para capturar el valor de retorno
            ReturnValue = (string)(_catalogodeducciones.Edit(tbacatalogodeducciones)).Data;


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
            tbacatalogodeducciones.cde_IdDeducciones = 2;


            //Variable para capturar el valor de retorno
            string ReturnValue = string.Empty;

            //
            //ACT
            //

            //Seteo de la variable para capturar el valor de retorno
            ReturnValue = (string)(_catalogodeducciones.Inactivar(tbacatalogodeducciones.cde_IdDeducciones)).Data;

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
            tbacatalogodeducciones.cde_IdDeducciones = 2;


            //Variable para capturar el valor de retorno
            string ReturnValue = string.Empty;

            //
            //ACT
            //

            //Seteo de la variable para capturar el valor de retorno
            ReturnValue = (string)(_catalogodeducciones.Activar(tbacatalogodeducciones.cde_IdDeducciones)).Data;

            //
            //ASSERT
            //
            Assert.IsTrue(ReturnValue == "bien");

        }
    }
}
