using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Raza : System.Web.UI.Page
{
    sql sql = new sql();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            if (txt_raza.Text.Trim().Equals(""))
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups!','No deje el campo vacio','error');", true);
            }
            else
            {
                if (txt_raza.Text.Trim().Length < 6)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups!','nombre de raza muy corto','error');", true);
                }
                else
                {
                    if (sql.validar("SELECT * FROM Raza WHERE Raza ='" + txt_raza.Text + "'"))
                    {
                        ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups!','No pueden haber dos razas iguales','error');", true);
                    }
                    else
                    {
                        int ingresar = sql.ejecutar("INSERT INTO Raza(Raza) VALUES('" + txt_raza.Text + "')");
                        if (ingresar > 0)
                        {
                            ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Bien!','Raza Registrada','success');", true);
                            llenaGrilla();
                        }
                        else
                        {
                            ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups!','No se pudo registrar la raza','error');", true);
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
        sql.llenaGrid(GridView1, "SELECT * FROM Raza");
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {

    }
    protected void GridView1_RowDeleted(object sender, GridViewDeletedEventArgs e)
    {

    }
}