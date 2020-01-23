using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ERP_GMEDINA.Controllers;
using ERP_GMEDINA.Models;

namespace ERP_GMEDINA_TEST.Controllers
{
    [TestClass]
    public class EmpleadoBonosController_Test
    {
        EmpleadoBonosController _EmpleadoBonosController = new EmpleadoBonosController();
        tbEmpleadoBonos tbEmpleadoBonos = new tbEmpleadoBonos();

        //METODO CREATE
        [TestMethod]
        public void Create()
        {
            //ARRANGE
            tbEmpleadoBonos.emp_Id = 1;
            tbEmpleadoBonos.cin_IdIngreso = 1;
            tbEmpleadoBonos.cb_Monto = 1000;
            string ReturnValue = string.Empty;

            //ACT
            ReturnValue = (String)(_EmpleadoBonosController.Create(tbEmpleadoBonos)).Data;

            //ASSERT
            Assert.IsTrue(ReturnValue == "bien");
        }

        //METODO EDIT
        [TestMethod]
        public void edit()
        {
            //ARRANGE
            tbEmpleadoBonos.cb_Id = 1;
            tbEmpleadoBonos.emp_Id = 1;
            tbEmpleadoBonos.cin_IdIngreso = 1;
            tbEmpleadoBonos.cb_Monto = 1000;
            tbEmpleadoBonos.cb_FechaRegistro = DateTime.Now;
            tbEmpleadoBonos.cb_Pagado = true;
            string ReturnValue = string.Empty;

            //ACT
            ReturnValue = (String)(_EmpleadoBonosController.edit(tbEmpleadoBonos)).Data;

            //ASSERT
            Assert.IsTrue(ReturnValue == "bien");
        }

        //METODO INACTIVAR
        [TestMethod]
        public void Inactivar()
        {
            //ARRANGE
            tbEmpleadoBonos.cb_Id = 1;
            string ReturnValue = string.Empty;

            //ACT
            ReturnValue = (String)(_EmpleadoBonosController.Inactivar(tbEmpleadoBonos.cb_Id)).Data;

            //ASSERT
            Assert.IsTrue(ReturnValue == "bien");
        }

        //METODO ACTIVAR
        [TestMethod]
        public void Activar()
        {
            //ARRANGE
            tbEmpleadoBonos.cb_Id = 1;
            string ReturnValue = string.Empty;

            //ACT
            ReturnValue = (String)(_EmpleadoBonosController.Activar(tbEmpleadoBonos.cb_Id)).Data;

            //ASSERT
            Assert.IsTrue(ReturnValue == "bien");
        }
    }
}
