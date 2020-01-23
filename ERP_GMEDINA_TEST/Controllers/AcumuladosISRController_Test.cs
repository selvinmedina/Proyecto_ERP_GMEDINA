using System;
using ERP_GMEDINA.Controllers;
using ERP_GMEDINA.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ERP_GMEDINA_TEST.Controllers
{
    [TestClass]
    public class AcumuladosISRController_Test
    {
        //Instancia del controlador
        AcumuladosISRController _AcumuladosISR = new AcumuladosISRController();

        [TestMethod]
        public void CreateTest()
        {
            //Triple A
            //Arrange Preparar
            tbAcumuladosISR AcumISR = new tbAcumuladosISR();
            AcumISR.aisr_Descripcion = "Descripcion";
            AcumISR.aisr_Monto = 1200;
            AcumISR.aisr_UsuarioCrea = 1;
            AcumISR.aisr_FechaCrea = DateTime.Now;
            AcumISR.aisr_Activo = true;

            //Act Actuar
            _AcumuladosISR.Create(AcumISR);

            //Assert Afirmar
            Assert.IsTrue(AcumISR.aisr_Id > 0);
        }

        [TestMethod]
        public void Create()
        {
            //
            //ARRANGE
            //

            //Instancia de la clase
            tbAcumuladosISR AcumISR = new tbAcumuladosISR()
            {

                //Seteo de las propiedades del modelo solicitadas por el método
                aisr_Descripcion = "Descripcion",
                aisr_Monto = 13000,
                aisr_UsuarioCrea = 1,
                aisr_FechaCrea = DateTime.Now,
                aisr_Activo = true,
            };

            //Variable para capturar el valor de retorno
            string ReturnValue = string.Empty;

            //
            //ACT
            //

            //Seteo de la variable para capturar el valor de retorno
            ReturnValue = (string)(_AcumuladosISR.Create(AcumISR)).Data;

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
            tbAcumuladosISR AcumISR = new tbAcumuladosISR();
            AcumISR.aisr_Id = 1;
            AcumISR.aisr_Descripcion = "Descripcion";
            AcumISR.aisr_Monto = 1200;
            AcumISR.aisr_UsuarioModifica = 1;
            AcumISR.aisr_FechaModifica = DateTime.Now;
            AcumISR.aisr_Activo = true;

            //Act Actuar
            _AcumuladosISR.Edit(AcumISR);

            //Assert Afirmar
            Assert.IsTrue(AcumISR.aisr_Id < 0);
        }

        [TestMethod]
        public void Edit()
        {
            //
            //ARRANGE
            //

            //Instancia de la clase
            tbAcumuladosISR AcumISR = new tbAcumuladosISR()
            {

                //Seteo de las propiedades del modelo solicitadas por el método
                aisr_Id = 1,
                aisr_Descripcion = "Descripcion",
                aisr_Monto = 15000,
                aisr_UsuarioModifica = 1,
                aisr_FechaModifica = DateTime.Now,
                aisr_Activo = true,
            };

            //Variable para capturar el valor de retorno
            string ReturnValue = string.Empty;

            //
            //ACT
            //

            //Seteo de la variable para capturar el valor de retorno
            ReturnValue = (string)(_AcumuladosISR.Edit(AcumISR)).Data;

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
            tbAcumuladosISR AcumISR = new tbAcumuladosISR();

            //Act Actuar
            _AcumuladosISR.Inactivar(1);

            //Assert Afirmar
            Assert.IsTrue(AcumISR.aisr_Id < 0);
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
            ReturnValue = (string)(_AcumuladosISR.Inactivar(1)).Data;

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
            tbAcumuladosISR AcumISR = new tbAcumuladosISR();

            //Act Actuar
            _AcumuladosISR.Activar(1);

            //Assert Afirmar
            Assert.IsTrue(AcumISR.aisr_Id < 0);
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
            ReturnValue = (string)(_AcumuladosISR.Activar(1)).Data;

            //
            //ASSERT
            //
            Assert.IsTrue(ReturnValue == "bien");
        }
    }
}
