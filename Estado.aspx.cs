using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Estado : System.Web.UI.Page
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
            if (txt_estadoA.Text.Trim().Equals(""))
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups!','No deje los campos vacios','error');", true);
            }
            else
            {
                if (txt_estadoA.Text.Trim().Length < 3)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups!','El nombre del estado es muy corto','error');", true);
                }
                else
                {
                    if (sql.validar("SELECT * FROM Estado_Animal WHERE EstadoA ='" + txt_estadoA.Text + "'"))
                    {
                        ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups!','No se puede duplicar el estado','error');", true);
                    }
                    else
                    {
                        int ingresar = sql.ejecutar("INSERT INTO Estado_Animal(EstadoA) VALUES('" + txt_estadoA.Text + "')");
                        if (ingresar > 0)
                        {
                            ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Bien hecho!','Registro Completo','success');", true);
                            llenaGrilla();
                        }
                        else
                        {
                            ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups!','No se pudo registrar el estado','success');", true);
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
        sql.llenaGrid(GridView1, "SELECT *FROM Estado_Animal");
    }

}