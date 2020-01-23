using System;
using System.Web.Mvc;
using ERP_GMEDINA.Controllers;
using ERP_GMEDINA.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ERP_GMEDINA_TEST.Controllers
{
    [TestClass]
    public class InstitucionesFinancierasController_Test
    {

        //Instancia del controlador
        InstitucionesFinancierasController _InstitucionesFinancieras = new InstitucionesFinancierasController();
               
        [TestMethod]
        public void CreateTest()
        {
            //Triple A
            //Arrange Preparar
            tbInstitucionesFinancieras InsFin = new tbInstitucionesFinancieras();
            InsFin.insf_DescInstitucionFinanc = "Descripcion";
            InsFin.insf_Contacto = "Contacto";
            InsFin.insf_Telefono = "9836-1287";
            InsFin.insf_Correo = "correo@gmail.com";
            InsFin.insf_UsuarioCrea = 1;
            InsFin.insf_FechaCrea = DateTime.Now;
            InsFin.insf_Activo = true;

            //Act Actuar
            _InstitucionesFinancieras.Create(InsFin);

            //Assert Afirmar
            Assert.IsTrue(InsFin.insf_IdInstitucionFinanciera > 0);
        }

        [TestMethod]
        public void Create()
        {
            //
            //ARRANGE
            //

            //Instancia de la clase
            tbInstitucionesFinancieras tbInstitucionesFinancieras = new tbInstitucionesFinancieras() {

            //Seteo de las propiedades del modelo solicitadas por el método
            insf_DescInstitucionFinanc = "Descripcion",
            insf_Contacto = "Contacto",
            insf_Telefono = "9231-2317",
            insf_Correo = "correo@gmail.com",
            insf_UsuarioCrea = 1,
            insf_FechaCrea = DateTime.Now,
            insf_Activo = true,
        };

            //Variable para capturar el valor de retorno
            string ReturnValue = string.Empty;

            //
            //ACT
            //

            //Seteo de la variable para capturar el valor de retorno
            ReturnValue = (string)(_InstitucionesFinancieras.Create(tbInstitucionesFinancieras)).Data;

            //
            //ASSERT
            //
            Assert.IsTrue(ReturnValue == "bien");
                       
        }

        [TestMethod]
        public void EditTest()
        {
            //Triple A
            //Arrange Preparar
            tbInstitucionesFinancieras InsFin = new tbInstitucionesFinancieras();
            InsFin.insf_IdInstitucionFinanciera = 1;
            InsFin.insf_DescInstitucionFinanc = "Descripcion";
            InsFin.insf_Contacto = "Contacto";
            InsFin.insf_Telefono = "9836-1287";
            InsFin.insf_Correo = "correo@gmail.com";
            InsFin.insf_UsuarioModifica = 1;
            InsFin.insf_FechaModifica = DateTime.Now;
            InsFin.insf_Activo = true;

            //Act Actuar
            _InstitucionesFinancieras.Edit(InsFin);

            //Assert Afirmar
            Assert.IsTrue(InsFin.insf_IdInstitucionFinanciera < 0);
        }

        [TestMethod]
        public void Edit()
        {
            //
            //ARRANGE
            //

            //Instancia de la clase
            tbInstitucionesFinancieras tbInstitucionesFinancieras = new tbInstitucionesFinancieras()
            {

                //Seteo de las propiedades del modelo solicitadas por el método
                insf_IdInstitucionFinanciera = 1,
                insf_DescInstitucionFinanc = "Descripcion",
                insf_Contacto = "Contacto",
                insf_Telefono = "9231-2317",
                insf_Correo = "correo@gmail.com",
                insf_UsuarioModifica = 1,
                insf_FechaModifica = DateTime.Now,
                insf_Activo = true,
            };

            //Variable para capturar el valor de retorno
            string ReturnValue = string.Empty;

            //
            //ACT
            //

            //Seteo de la variable para capturar el valor de retorno
            ReturnValue = (string)(_InstitucionesFinancieras.Edit(tbInstitucionesFinancieras)).Data;

            //
            //ASSERT
            //
            Assert.IsTrue(ReturnValue == "bien");
        }

        [TestMethod]
        public void InactivarTest()
        {
            //Triple A
            //Arrange Preparar
            tbInstitucionesFinancieras InsFin = new tbInstitucionesFinancieras();

            //Act Actuar
            _InstitucionesFinancieras.Inactivar(1);

            //Assert Afirmar
            Assert.IsTrue(InsFin.insf_IdInstitucionFinanciera < 0);
        }

        [TestMethod]
        public void Inactivar()
        {
            
            //Variable para capturar el valor de retorno
            string ReturnValue = string.Empty;

            //
            //ACT
            //

            //Seteo de la variable para capturar el valor de retorno
            ReturnValue = (string)(_InstitucionesFinancieras.Inactivar(1)).Data;

            //
            //ASSERT
            //
            Assert.IsTrue(ReturnValue == "bien");
        }

        [TestMethod]
        public void ActivarTest()
        {
            //Triple A
            //Arrange Preparar
            tbInstitucionesFinancieras InsFin = new tbInstitucionesFinancieras();

            //Act Actuar
            _InstitucionesFinancieras.Activar(1);

            //Assert Afirmar
            Assert.IsTrue(InsFin.insf_IdInstitucionFinanciera < 0);
        }

        [TestMethod]
        public void Activar()
        {

            //Variable para capturar el valor de retorno
            string ReturnValue = string.Empty;

            //
            //ACT
            //

            //Seteo de la variable para capturar el valor de retorno
            ReturnValue = (string)(_InstitucionesFinancieras.Activar(1)).Data;

            //
            //ASSERT
            //
            Assert.IsTrue(ReturnValue == "bien");
        }
    }
}
