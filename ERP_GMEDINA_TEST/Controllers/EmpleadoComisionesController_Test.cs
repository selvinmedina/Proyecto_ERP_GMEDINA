using System;
using ERP_GMEDINA.Controllers;
using ERP_GMEDINA.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ERP_GMEDINA_TEST.Controllers
{
    [TestClass]
    public class EmpleadoComisionesController_Test
    {

        //Instancia del controlador
        EmpleadoComisionesController _EmpleadoComisiones = new EmpleadoComisionesController();

        [TestMethod]
        public void CreateTest()
        {
            //Triple A
            //Arrange Preparar
            tbEmpleadoComisiones EmpCom = new tbEmpleadoComisiones();
            EmpCom.emp_Id = 1;
            EmpCom.cin_IdIngreso = 1;
            EmpCom.cc_FechaRegistro = DateTime.Now;
            EmpCom.cc_Pagado = true;
            EmpCom.cc_UsuarioCrea = 1;
            EmpCom.cc_FechaCrea = DateTime.Now;
            EmpCom.cc_PorcentajeComision = 1;
            EmpCom.cc_TotalVenta = 1;

            //Act Actuar
            _EmpleadoComisiones.Create(EmpCom);

            //Assert Afirmar
            Assert.IsTrue(EmpCom.cc_Id > 0);
        }

        [TestMethod]
        public void Create()
        {
            //
            //ARRANGE
            //

            //Instancia de la clase
            tbEmpleadoComisiones EmpCom = new tbEmpleadoComisiones()
            {

                //Seteo de las propiedades del modelo solicitadas por el método
                emp_Id = 1,
                cin_IdIngreso = 1,
                cc_FechaRegistro = DateTime.Now,
                cc_Pagado = true,
                cc_UsuarioCrea = 1,
                cc_FechaCrea = DateTime.Now,
                cc_PorcentajeComision = 2,
                cc_TotalVenta = 2,
            };

            //Variable para capturar el valor de retorno
            string ReturnValue = string.Empty;

            //
            //ACT
            //

            //Seteo de la variable para capturar el valor de retorno
            ReturnValue = (string)(_EmpleadoComisiones.Create(EmpCom)).Data;

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
            tbEmpleadoComisiones EmpCom = new tbEmpleadoComisiones();
            EmpCom.emp_Id = 1;
            EmpCom.cin_IdIngreso = 1;
            EmpCom.cc_FechaRegistro = DateTime.Now;
            EmpCom.cc_Pagado = true;
            EmpCom.cc_UsuarioModifica = 1;
            EmpCom.cc_FechaModifica = DateTime.Now;
            EmpCom.cc_PorcentajeComision = 1;
            EmpCom.cc_TotalVenta = 3;

            //Act Actuar
            _EmpleadoComisiones.Edit(EmpCom);

            //Assert Afirmar
            Assert.IsTrue(EmpCom.cc_Id < 0);
        }

        [TestMethod]
        public void Edit()
        {
            //
            //ARRANGE
            //

            //Instancia de la clase
            tbEmpleadoComisiones EmpCom = new tbEmpleadoComisiones()
            {

                //Seteo de las propiedades del modelo solicitadas por el método
                cc_Id = 1,
                emp_Id = 1,
                cin_IdIngreso = 1,
                cc_FechaRegistro = DateTime.Now,
                cc_UsuarioModifica = 1,
                cc_FechaModifica = DateTime.Now,
                cc_PorcentajeComision = 1,
                cc_TotalVenta = 5,
            };

            //Variable para capturar el valor de retorno
            string ReturnValue = string.Empty;

            //
            //ACT
            //

            //Seteo de la variable para capturar el valor de retorno
            ReturnValue = (string)(_EmpleadoComisiones.Edit(EmpCom)).Data;

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
            tbEmpleadoComisiones EmpCom = new tbEmpleadoComisiones();

            //Act Actuar
            _EmpleadoComisiones.Inactivar(1);

            //Assert Afirmar
            Assert.IsTrue(EmpCom.cc_Id < 0);
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
            ReturnValue = (string)(_EmpleadoComisiones.Inactivar(1)).Data;

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
            tbEmpleadoComisiones EmpCom = new tbEmpleadoComisiones();

            //Act Actuar
            _EmpleadoComisiones.Activar(1);

            //Assert Afirmar
            Assert.IsTrue(EmpCom.cc_Id < 0);
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
            ReturnValue = (string)(_EmpleadoComisiones.Activar(1)).Data;

            //
            //ASSERT
            //
            Assert.IsTrue(ReturnValue == "bien");
        }
    }
}
