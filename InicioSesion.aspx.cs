using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_insert_Click(object sender, EventArgs e)
    {
        sql sql = new sql();
        try
        {
            if (txt_usuario.Text.Equals("") || txt_pass.Text.Equals(""))
            {
                lbl_Mensaje.Text = "No deje los campos vacios";
            }
            else
            {
                SqlDataReader lector = sql.consulta("SELECT * FROM Cliente WHERE Usuario ='" + txt_usuario.Text + "'");
                if (lector.Read())
                {
                    if (lector[8].ToString().Equals(txt_pass.Text)) // validamos que la contraseña ingresada coinsida con la que está en la bdd
                    {
                        if (lector[10].ToString().Equals("1"))
                        {
                            Session["user"] = txt_usuario.Text;
                            Session["rut"] = lector[0].ToString();// se declara la session rut para al momento de adoptar, se guarde el rut en session
                            Response.Redirect("Inicio.aspx");
                        }
                        else
                        {
                            if(lector[10].ToString().Equals("2")){
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
        catch
        {
            lbl_Mensaje.Text = "Datos no validos";
        }
    }
    protected void Unnamed1_Click(object sender, EventArgs e)
    {

    }
    protected void txt_pass_TextChanged(object sender, EventArgs e)
    {

    }
}