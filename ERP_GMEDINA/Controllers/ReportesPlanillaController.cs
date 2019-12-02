﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using Microsoft.Reporting.WebForms;
using ERP_GMEDINA.Models;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using ERP_GMEDINA.DataSets;

namespace ERP_GMEDINA.Controllers
{
    public class ReportesPlanillaController : Controller
    {
		private ERP_GMEDINAEntities db = new ERP_GMEDINAEntities();

        // Index de todos los reportes
        public ActionResult Index()
        {
            return View();
        }

		//-------------------------------------------------------------------------------------------------------------------------------
		//Reporte Decimo Tercer Mes - INICIO

		//Index 
		ReportesPlanillaDS ds = new ReportesPlanillaDS();
		public ActionResult DecimoTercerMesIndexRPT()
		{
			ReportViewer reportViewer = new ReportViewer();
			reportViewer.ProcessingMode = ProcessingMode.Local;
			reportViewer.SizeToReportContent = false;
			reportViewer.Width = Unit.Pixel(1050);
			reportViewer.Height = Unit.Pixel(500);
			reportViewer.BackColor = System.Drawing.Color.White;

			var connectionString = ConfigurationManager.ConnectionStrings["ERP_GMEDINAConnectionString"].ConnectionString;


			SqlConnection conx = new SqlConnection(connectionString);
			SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM Plani.V_DecimoTercerMes_RPT", conx);

			adp.Fill(ds, ds.V_DecimoTercerMes_RPT.TableName);

			reportViewer.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath) + @"ReportesPlanilla\DecimoTercerMesRPT.rdlc";
			reportViewer.LocalReport.DataSources.Add(new ReportDataSource("ReportesPlanillaDS", ds.Tables[0]));


			ViewBag.ReportViewerDecimoTercerMesRPT = reportViewer;
			return View();
		}

		//Reporte con parametros
		public ActionResult DecimoTercerMesParametrosRPT(DateTime dtm_FechaPago, string id)
		{
			LocalReport lr = new LocalReport();
			string path = Path.Combine(Server.MapPath("~/ReportesPlanilla"), "DecimoTercerMesRPT.rdlc");
			if (System.IO.File.Exists(path))
			{
				lr.ReportPath = path;
			}
			else
			{
				return View("Index");
			}
			List<V_DecimoTercerMes_RPT> cm = new List<V_DecimoTercerMes_RPT>();

			cm = db.V_DecimoTercerMes_RPT.Where(x => dtm_FechaPago == x.dtm_FechaPago).ToList();

			ReportDataSource rd = new ReportDataSource("ReportesPlanillaDS", cm);
			lr.DataSources.Add(rd);
			string reportType = id;
			string mimeType;
			string encoding;
			string fileNameExtension;
			string deviceInfo =

			"<DeviceInfo>" +
			"  <OutputFormat>" + id + "</OutputFormat>" +
			"  <PageWidth>8.5in</PageWidth>" +
			"  <PageHeight>11in</PageHeight>" +
			"  <MarginTop>0.5in</MarginTop>" +
			"  <MarginLeft>1in</MarginLeft>" +
			"  <MarginRight>1in</MarginRight>" +
			"  <MarginBottom>0.5in</MarginBottom>" +
			"</DeviceInfo>";

			Warning[] warnings;
			string[] streams;
			byte[] renderedBytes;

			renderedBytes = lr.Render(
				reportType,
				deviceInfo,
				out mimeType,
				out encoding,
				out fileNameExtension,
				out streams,
				out warnings);

			return File(renderedBytes, mimeType);
		}
		//Reporte Decimo Tercer Mes - FIN
		//-------------------------------------------------------------------------------------------------------------------------------





	}
}