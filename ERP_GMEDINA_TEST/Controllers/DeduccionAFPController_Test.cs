using System;
using ERP_GMEDINA.Controllers;
using ERP_GMEDINA.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ERP_GMEDINA_TEST.Controllers
{

    [TestClass]
    public class DeduccionAFPController_Test
    {
        //Instancia del controlador
        DeduccionAFPController _DeduccionAFP = new DeduccionAFPController();

        [TestMethod]
        public void CreateTest()
        {
            //Triple A
            //Arrange Preparar
            tbDeduccionAFP DedAfp = new tbDeduccionAFP();
            DedAfp.dafp_AporteLps = 12;
            DedAfp.afp_Id = 1;
            DedAfp.emp_Id = 1;
            DedAfp.dafp_UsuarioCrea = 1;
            DedAfp.dafp_FechaCrea = DateTime.Now;

            //Act Actuar
            _DeduccionAFP.Create(DedAfp);

            //Assert Afirmar
            Assert.IsTrue(DedAfp.dafp_Id > 0);
        }

        [TestMethod]
        public void Create()
        {
            //
            //ARRANGE
            //

            //Instancia de la clase
            tbDeduccionAFP DedAfp = new tbDeduccionAFP()
            {

                //Seteo de las propiedades del modelo solicitadas por el método
                dafp_AporteLps = 14,
                afp_Id = 1,
                emp_Id = 1,
                dafp_UsuarioCrea = 1,
                dafp_FechaCrea = DateTime.Now,
            };

            //Variable para capturar el valor de retorno
            string ReturnValue = string.Empty;

            //
            //ACT
            //

            //Seteo de la variable para capturar el valor de retorno
            ReturnValue = (string)(_DeduccionAFP.Create(DedAfp)).Data;

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
            tbDeduccionAFP DedAfp = new tbDeduccionAFP();
            DedAfp.dafp_Id = 1;
            DedAfp.dafp_AporteLps = 16;
            DedAfp.afp_Id = 1;
            DedAfp.emp_Id = 1;
            DedAfp.dafp_UsuarioModifica = 1;
            DedAfp.dafp_FechaModifica = DateTime.Now;

            //Act Actuar
            _DeduccionAFP.Edit(DedAfp);

            //Assert Afirmar
            Assert.IsTrue(DedAfp.dafp_Id < 0);
        }

        [TestMethod]
        public void Edit()
        {
            //
            //ARRANGE
            //

            //Instancia de la clase
            tbDeduccionAFP DedAfp = new tbDeduccionAFP()
            {

                //Seteo de las propiedades del modelo solicitadas por el método
                dafp_Id = 1,
                dafp_AporteLps = 18,
                afp_Id = 1,
                emp_Id = 1,
                dafp_UsuarioModifica = 1,
                dafp_FechaModifica = DateTime.Now
            };

            //Variable para capturar el valor de retorno
            string ReturnValue = string.Empty;

            //
            //ACT
            //

            //Seteo de la variable para capturar el valor de retorno
            ReturnValue = (string)(_DeduccionAFP.Edit(DedAfp)).Data;

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
            tbDeduccionAFP DedAfp = new tbDeduccionAFP();

            //Act Actuar
            _DeduccionAFP.Inactivar(1);

            //Assert Afirmar
            Assert.IsTrue(DedAfp.dafp_Id < 0);
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
            ReturnValue = (string)(_DeduccionAFP.Inactivar(1)).Data;

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
            tbDeduccionAFP DedAfp = new tbDeduccionAFP();

            //Act Actuar
            _DeduccionAFP.Activar(1);

            //Assert Afirmar
            Assert.IsTrue(DedAfp.dafp_Id < 0);
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
            ReturnValue = (string)(_DeduccionAFP.Activar(1)).Data;

            //
            //ASSERT
            //
            Assert.IsTrue(ReturnValue == "bien");
        }
    }
}
