using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ERP_GMEDINA.Controllers;
using ERP_GMEDINA.Models;

namespace ERP_GMEDINA_TEST.Controllers
{
    [TestClass]
    public class TechosDeduccionesController_Test
    {
        TechosDeduccionesController _TechosDeduccionesController = new TechosDeduccionesController();
        //Instancia de la clase
        tbTechosDeducciones tbTechosDeducciones = new tbTechosDeducciones();

        [TestMethod]
        public void Create()
        {
            //
            //ARRANGE
            //

            //Seteo de las propiedades del modelo solicitadas por el método
            tbTechosDeducciones.tddu_PorcentajeColaboradores = (decimal)10.05;
            tbTechosDeducciones.tddu_PorcentajeEmpresa = (decimal)15.50;
            tbTechosDeducciones.tddu_Techo = (decimal)500.00;
            tbTechosDeducciones.cde_IdDeducciones = 1;
            tbTechosDeducciones.tddu_UsuarioCrea = 1;
            tbTechosDeducciones.tddu_FechaCrea = DateTime.Now;

            //Variable para capturar el valor de retorno
            string ReturnValue = string.Empty;

            //
            //ACT
            //

            //Seteo de la variable para capturar el valor de retorno
            ReturnValue = (string)(_TechosDeduccionesController.Create(tbTechosDeducciones)).Data;

            //
            //ASSERT
            //
            Assert.IsTrue(ReturnValue == "bien");

        }

        [TestMethod]
        public void Edit()
        {
            //
            //ARRANGE
            //

            //Seteo de las propiedades del modelo solicitadas por el método
            tbTechosDeducciones.tddu_IdTechosDeducciones = 1;
            tbTechosDeducciones.tddu_PorcentajeColaboradores = (decimal)10.05;
            tbTechosDeducciones.tddu_PorcentajeEmpresa = (decimal)15.50;
            tbTechosDeducciones.tddu_Techo = (decimal)500.00;
            tbTechosDeducciones.cde_IdDeducciones = 1;
            tbTechosDeducciones.tddu_UsuarioModifica = 1;
            tbTechosDeducciones.tddu_FechaModifica = DateTime.Now;

            //Variable para capturar el valor de retorno
            string ReturnValue = string.Empty;

            //
            //ACT
            //

            //Seteo de la variable para capturar el valor de retorno
            ReturnValue = (string)(_TechosDeduccionesController.Edit(tbTechosDeducciones)).Data;

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
            //Variable para capturar el valor de retorno
            string ReturnValue = string.Empty;

            //
            //ACT
            //

            //Seteo de la variable para capturar el valor de retorno
            ReturnValue = (string)(_TechosDeduccionesController.Inactivar(1)).Data;

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
            //Variable para capturar el valor de retorno
            string ReturnValue = string.Empty;

            //
            //ACT
            //

            //Seteo de la variable para capturar el valor de retorno
            ReturnValue = (string)(_TechosDeduccionesController.Activar(1)).Data;

            //
            //ASSERT
            //
            Assert.IsTrue(ReturnValue == "bien");

        }
    }
}

