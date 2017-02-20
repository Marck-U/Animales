using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Microsoft.Reporting.WebForms;

public partial class ReporteAdopcion : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            bd_AdopcionAnimalDataSet.AdopcionDataTable dt = new bd_AdopcionAnimalDataSet.AdopcionDataTable();
            bd_AdopcionAnimalDataSetTableAdapters.AdopcionTableAdapter
                da = new bd_AdopcionAnimalDataSetTableAdapters.AdopcionTableAdapter();
            da.Fill(dt);

            ReportDataSource rd = new ReportDataSource();
            rd.Value = dt;
            rd.Name = "DataSet1";

            ReportViewer1.LocalReport.DataSources.Clear();
            ReportViewer1.LocalReport.DataSources.Add(rd);
            ReportViewer1.LocalReport.ReportEmbeddedResource = "Report.rdlc";
            ReportViewer1.LocalReport.ReportPath = @"Report.rdlc";
            ReportViewer1.LocalReport.Refresh();
        }
    }
}