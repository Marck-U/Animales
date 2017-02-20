using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Inicio : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //String rut = Session["rut"].ToString();
        if (Session["user"] == null)
        {
            Response.Redirect("index.aspx");
        }
    }
}
