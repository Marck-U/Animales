using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EstadoUsuario : System.Web.UI.Page
{
    sql sql = new sql();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (txt_estado.Text.Trim().Equals(""))
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Que mal','No deje el campo vacio','error');", true);
        }
        else
        {
            if (txt_estado.Text.Trim().Length < 3)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Que mal','El nombre es demaciado corto','error');", true);
            }
            else
            {
                if (sql.validar("SELECT * FROM Estado WHERE Estado ='" + txt_estado.Text + "'"))
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Que mal','No se puede duplicar el nombre','error');", true);
                }
                else
                {
                    int ingresar = sql.ejecutar("INSERT INTO Estado(Estado) VALUES('" + txt_estado.Text + "')");
                    if (ingresar > 0)
                    {
                        ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Genial!','Estado registrado','success');", true);
                        llenaGrilla();
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('UPS!','Error inesperado','error');", true);

                    }
                }
            }
        }
    }
    protected void Unnamed1_SelectedIndexChanged(object sender, EventArgs e)
    {
       
    }
    protected void llenaGrilla()
    {
        sql.llenaGrid(GridView1, "SELECT *FROM Estado");
    }

}