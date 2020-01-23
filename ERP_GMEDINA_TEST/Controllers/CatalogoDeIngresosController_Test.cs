using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ERP_GMEDINA.Controllers;
using ERP_GMEDINA.Models;

namespace ERP_GMEDINA_TEST.Controllers
{
    [TestClass]
    public class CatalogoDeIngresosController_Test
    {
            //TEST DE METODOS DE ACCION DEL CONTROLADOR FormaPago

            //APLICACION DE LAS 3 "A" EN EL TESTING 
            //ARRANGE : PREPARAR 
            //ACT     : ACTUAR
            //ASSERT  : AFIRMAR


            //Instancia del controlador
            CatalogoDeIngresosController _CatalogoDeIngresosController = new CatalogoDeIngresosController();
            //Instancia de la clase
            tbCatalogoDeIngresos tbCatalogoDeIngresos = new tbCatalogoDeIngresos();

            [TestMethod]
            public void CreateTest()
            {
            //
            //ARRANGE
            //

            //Seteo de las propiedades del modelo solicitadas por el método
            tbCatalogoDeIngresos.cin_DescripcionIngreso = "TestProjectCatalogoDeIngresos";
            tbCatalogoDeIngresos.cin_UsuarioCrea = 1;
            tbCatalogoDeIngresos.cin_FechaCrea = DateTime.Now;

            //Variable para capturar el valor de retorno
            string ReturnValue = string.Empty;

            //
            //ACT
            //

            //Seteo de la variable para capturar el valor de retorno
            ReturnValue = (string)(_CatalogoDeIngresosController.Create(tbCatalogoDeIngresos)).Data;

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
            tbCatalogoDeIngresos.cin_IdIngreso = 1;
            tbCatalogoDeIngresos.cin_DescripcionIngreso = "TestProjectCatalogoDeIngresos2";

            //Variable para capturar el valor de retorno
            //string ReturnValue = string.Empty;

            //
            //ACT
            //

            //Seteo de la variable para capturar el valor de retorno
            _CatalogoDeIngresosController.Edit(tbCatalogoDeIngresos.cin_IdIngreso, tbCatalogoDeIngresos.cin_DescripcionIngreso);

            //
            //ASSERT
            //
            Assert.IsTrue(tbCatalogoDeIngresos.cin_IdIngreso > 0);

        }

        [TestMethod]
        public void InactivarTest()
        {
            //
            //ARRANGE
            //

            //Seteo de las propiedades del modelo solicitadas por el método
            tbCatalogoDeIngresos.cin_IdIngreso = 1;

            //
            //ACT
            //

            //Seteo de la variable para capturar el valor de retorno
            _CatalogoDeIngresosController.Inactivar(tbCatalogoDeIngresos.cin_IdIngreso);

            //
            //ASSERT
            //
            Assert.IsTrue(tbCatalogoDeIngresos.cin_IdIngreso > 0);

        }

        [TestMethod]
        public void ActivarTest()
        {
            //
            //ARRANGE
            //

            //Seteo de las propiedades del modelo solicitadas por el método
            tbCatalogoDeIngresos.cin_IdIngreso = 1;

            //
            //ACT
            //

            //Seteo de la variable para capturar el valor de retorno
            _CatalogoDeIngresosController.Activar(tbCatalogoDeIngresos.cin_IdIngreso);

            //
            //ASSERT
            //
            Assert.IsTrue(tbCatalogoDeIngresos.cin_IdIngreso > 0);

        }
    }
}
