using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Usuario : System.Web.UI.Page
{
    sql sql = new sql();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            llenaEstado();
            llenaTipo();
        }
    }
    protected void btn_insert_Click1(object sender, EventArgs e)
    {
        try
        {
            if (txt_usuario.Text.Trim().Equals("") || txt_pass.Text.Trim().Equals(""))
            {
                lbl_mensaje.Text = "no deje los campo vacio";
            }
            else
            {
                if (txt_usuario.Text.Trim().Length < 3)
                {
                    lbl_mensaje.Text = "Usuario demaciado corto";
                }
                else
                {
                    if (txt_pass.Text.Trim().Length < 2)
                    {
                        lbl_mensaje.Text = "Contraseña demaciada corta";
                    }
                    else
                    {
                        if (sql.validar("SELECT * FROM Usuario WHERE Usuario ='" + txt_usuario.Text + "'"))
                        {
                            lbl_mensaje.Text = "El usuario ya existe elija otro";
                        }
                        else
                        {
                            int registro = sql.ejecutar("INSERT INTO Usuario (Usuario,Password,id_Tipo,id_Estado) VALUES ('"+ txt_usuario.Text + "','" +txt_pass.Text + "','" + DropDownList3.SelectedValue + "','"  + DropDownList4.SelectedValue + "')");
                            if (registro > 0)
                            {
                                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Bien!','Registro usuario completo','success');", true);
                                llenaGrilla();
                            }
                            else
                            {
                                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups','No se pudo registrar el usuario','error');", true);
                            }
                        }
                    }
                }
            }
        }
        catch
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups','Error','error');", true);
        }
    }

    protected void llenaEstado()
    {
        sql.llenacombo(DropDownList4, "select * from Estado", "Estado", "id_Estado");
    }

    protected void llenaTipo()
    {
        sql.llenacombo(DropDownList3, "select * from Tipo", "Tipo", "id_Tipo");
    }

    protected void llenaGrilla()
    {
        sql.llenaGrid(Admin, "SELECT * FROM Usuario");
    }
}