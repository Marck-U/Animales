using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Region : System.Web.UI.Page
{
    sql sql = new sql();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            if (txt_region.Text.Trim().Equals("") || txt_numeroRegion.Text.Trim().Equals(""))
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups!','No deje los campos vacios','error');", true);
            }
            else
            {
                if (txt_region.Text.Trim().Length < 3)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups!','Demaciado corto el nombre','error');", true);
                }
                else
                {
                    if (txt_numeroRegion.Text.Trim().Length >= 3)
                    {
                        ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups!','Numero de region demaciado largo','error');", true);
                    }
                    else
                    {
                        if (sql.validar("SELECT * FROM regiones WHERE region_nombre ='" + txt_region.Text + "'"))
                        {
                            ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups!','Region ya existente','error');", true);
                        }
                        else
                        {
                            int ingresar = sql.ejecutar("INSERT INTO regiones(region_nombre,region_ordinal) VALUES('" + txt_region.Text + "','" + txt_numeroRegion.Text + "')");
                            if (ingresar > 0)
                            {
                                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Bien!','Region registrada','success');", true);
                                llenaGrilla();
                            }
                            else
                            {
                                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups!','No se pudo registrar la region','error');", true);
                            }
                        }
                    }
                }
            }
        }
        catch
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups!','Error inesperado','error');", true);
        }
    }
    protected void llenaGrilla()
    {
        sql.llenaGrid(GridView1, "SELECT *FROM regiones");
    }
}