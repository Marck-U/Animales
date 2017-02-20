using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_insert_Click(object sender, EventArgs e)
    {
        try
        {
            sql sql = new sql();
            if (txt_usuario.Text.Equals("") || txt_pass.Text.Equals(""))
            {
                lbl_Mensaje.Text = "No deje los campos vacios";
            }
            else
            {
                if (txt_usuario.Text.Equals("") || txt_pass.Text.Equals(""))
                {
                    lbl_Mensaje.Text = "No deje los campos vacios";
                }
                else
                {
                    SqlDataReader lector = sql.consulta("SELECT * FROM Usuario WHERE Usuario ='" + txt_usuario.Text + "'");
                    if (lector.Read())
                    {
                        if (lector[2].ToString().Equals(txt_pass.Text)) // validamos que la contraseña ingresada coinsida con la que está en la bdd
                        {
                            if (lector[4].ToString().Equals("1")) // se valida el estado del usuari
                            {
                                if (lector[3].ToString().Equals("1")) // se validad el tipo del usuario
                                {
                                    Session["admin"] = txt_usuario.Text;
                                    Response.Redirect("SesionAdmin.aspx");
                                }
                                else
                                {
                                    lbl_Mensaje.Text = "Usuario inexistente";
                                }

                            }
                            else
                            {
                                if (lector[4].ToString().Equals("2"))
                                {
                                    lbl_Mensaje.Text = "Su cuenta está inactiva";
                                }
                                else
                                {
                                    lbl_Mensaje.Text = "Su cuenta está Bloqueada";
                                }
                            }

                        }
                        else
                        {
                            lbl_Mensaje.Text = "Password/ Usuario Incorrecto";
                        }
                    }
                    else
                    {
                        lbl_Mensaje.Text = "Usuario inexistente";
                    }
                }
            }
        }
        catch
        {
            lbl_Mensaje.Text = "Ingrese datos validos";
        }
    }
}