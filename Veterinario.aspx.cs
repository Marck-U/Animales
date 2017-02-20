using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Veterinario : System.Web.UI.Page
{
    sql sql = new sql();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            llenaMascota();
            llenaUsuario();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            if (txt_descripcion.Text.Trim().Equals(""))
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups','No deje el campo vacio','error');", true);
            }
            else
            {
                if (txt_descripcion.Text.Trim().Length < 10)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups','descripción demaciada corta','error');", true);
                }
                else
                {
                    if (txt_descripcion.Text.Trim().Length > 100)
                    {
                        ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups','Demaciada larga la descripción','error');", true);
                    }
                    else
                    {
                        int registro = sql.ejecutar("INSERT INTO VisitaVeterinario (fecha,Descripcion,id_Animal,idUsuario) VALUES ('" + fecha.Value + "','" + txt_descripcion.Text + "','" + DropDownList3.SelectedValue + "','" + DropDownList4.SelectedValue + "')");
                        if (registro > 0)
                        {
                            ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Bien!','Registro completo','success');", true);
                            lbl_mensaje.Text = "Visita registrada";
                            llenaGrilla();
                        }
                        else
                        {
                            ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups','No se pudo registrar','error');", true);
                        }
                    }
                }
            }
        }
        catch
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups',Ocurrio un error','error');", true);
        }
    }

    protected void llenaMascota()
    {
        sql.llenacombo(DropDownList3, "SELECT * FROM Animal", "Nombre", "id_Animal");
    }

    protected void llenaUsuario()
    {
        sql.llenacombo(DropDownList4, "SELECT * FROM Usuario", "Usuario", "idUsuario");
    }

    protected void llenaGrilla()
    {
        sql.llenaGrid(GridView1, "SELECT * FROM VisitaVeterinario");
    }
}