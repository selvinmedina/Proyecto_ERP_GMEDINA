using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ERP_GMEDINA.Controllers;
using ERP_GMEDINA.Models;

namespace ERP_GMEDINA_TEST.Controllers
{
    [TestClass]
    public class TipoDeduccionesController_Test
    {
        TipoDeduccionesController _TipoDeducciones = new TipoDeduccionesController();
        tbTipoDeduccion tbTipoDeduccion = new tbTipoDeduccion();

        //METODO CREATE
        [TestMethod]
        public void Create()
        {
            //ARRANGE
            tbTipoDeduccion.tde_Descripcion =  "TestTipoDeduccion";
            tbTipoDeduccion.tde_UsuarioCrea = 1;
            tbTipoDeduccion.tde_FechaCrea = DateTime.Now;
            string ReturnValue = string.Empty;

            //ACT
            ReturnValue = (String)(_TipoDeducciones.Create(tbTipoDeduccion)).Data;

            //ASSERT
            Assert.IsTrue(ReturnValue == "bien");
        }

        //METODO EDIT
        [TestMethod]
        public void Edit()
        {
            //ARRANGE
            tbTipoDeduccion.tde_IdTipoDedu = 1;
            tbTipoDeduccion.tde_Descripcion = "TestEditTipoDedu";
            tbTipoDeduccion.tde_UsuarioModifica = 1;
            tbTipoDeduccion.tde_FechaModifica = DateTime.Now;
            
            string ReturnValue = string.Empty;

            //ACT
            ReturnValue = (String)(_TipoDeducciones.Edit(tbTipoDeduccion)).Data;

            //ASSERT
            Assert.IsTrue(ReturnValue == "bien");
        }

        //METODO INACTIVAR
        [TestMethod]
        public void Inactivar()
        {
            //ARRANGE
            tbTipoDeduccion.tde_IdTipoDedu = 1;

            string ReturnValue = string.Empty;

            //ACT
            ReturnValue = (String)(_TipoDeducciones.Inactivar(tbTipoDeduccion.tde_IdTipoDedu)).Data;

            //ASSERT
            Assert.IsTrue(ReturnValue == "bien");
        }

        //METODO ACTIVAR
        [TestMethod]
        public void Activar()
        {
            //ARRANGE
            tbTipoDeduccion.tde_IdTipoDedu = 1;

            string ReturnValue = string.Empty;

            //ACT
            ReturnValue = (String)(_TipoDeducciones.Activar(tbTipoDeduccion.tde_IdTipoDedu)).Data;

            //ASSERT
            Assert.IsTrue(ReturnValue == "bien");
        }
    }
}
