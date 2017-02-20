using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Adopcion : System.Web.UI.Page
{
    sql sql = new sql();
    int run;
    protected void Page_Load(object sender, EventArgs e)
    {
        //String rut = Session["rut"].ToString();
        if (!IsPostBack)
        {
            if (Session["user"] != null)
            {
                //Session["usuario"] = run.ToString();
                SqlDataReader lector = sql.consulta("exec muestraA");
                String mascota = "";
                int contador = 0;
                while (lector.Read())
                {
                    mascota += "		<div class='container2'>";
                    mascota += "                 <div class='card medium' style='border-radius:34px;'>";
                    mascota += "                     <div class='card-image waves-effect waves-block waves-light'>";
                    mascota += "                 	    <img class='activator' src='" + lector[8].ToString() + "' />";
                    mascota += "                        </div>";
                    mascota += "                        <div class='card-content'>";
                    mascota += "                        <h4 class='deep-orange-text center-align'>" + lector[1].ToString() + "</h4>";
                    mascota += "                        <span class='card-title activator'><i class='material-icons right'>more_vert</i></span>" + "<br/>";
                    mascota += "                        </div>";
                    mascota += "                        <div class='card-reveal' transform: translateY(-100%);'>";
                    mascota += "                            <span class='card-title deep-dark-text center-align'><b>Datos Personales</b><i class='material-icons right'>close</i></span>";
                    mascota += "                            <p id = 'texto' class='deep-orange-text'>Nombre: " + lector[1].ToString() + " </p>";
                    mascota += "                            <p class='deep-orange-text'>Raza: " + lector[2].ToString() + " </p>";
                    mascota += "                            <p class='deep-orange-text'>Genero: " + lector[7].ToString() + " </p>";
                    mascota += "                            <p class='deep-orange-text'>Comuna: " + lector[4].ToString() + " </p>";
                    mascota += "                            <p class='deep-orange-text'>Tipo: " + lector[5].ToString() + " </p>";
                    mascota += "                            <p class='deep-orange-text'>Descripcion: " + lector[6].ToString() + " </p>";
                    mascota += "                          <button type='button' class='btn waves-effect waves-light deep-orange' onclick=\"asignarValores('" + lector[0].ToString() + "','" + Session["rut"].ToString() + "');\" style='margin-left:1%; width:100%;' />adoptar</button>";
                    mascota += "                        </div>";
                    mascota += "                    </div>";
                    mascota += "                </div>";
                    contador++;
                }
                mascotas.InnerHtml = (mascota);
            }
        }
        else
        {
            adoptar();

        }
    }
    protected void adoptar()
    {
        DateTime Fecha = DateTime.Today;
        try
        {
            int animal = Convert.ToInt32(idAnimal.Value);
            int persona = Convert.ToInt32(rut.Value);
            SqlDataReader lector = sql.consulta("exec muestraA ");
            //int idAnimal = Convert.ToInt32(lector[0].ToString());
            if (lector.Read())
            {
                if (lector[3].ToString().Equals("Adoptado"))
                {
                    Mensajes("Ups!", "Está mascota ya está adoptada", "error");
                }
                else
                {

                    int exec = sql.ejecutar("exec insertarAdopcion'" + animal + "','" + persona + "','" + Fecha + "'");
                    if (exec > 0)
                    {
                        // Mensajes("Felicitaciones", "Adoptaste", "success");
                        Response.Redirect("Adoptaste.aspx");
                    }
                    else
                    {
                        //ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups!','no se pudo hacer la  adopción','error');", true);
                        Mensajes("UPS!", "Está Mascota ya está adoptada", "error");
                    }
                }
            }
        }
        catch
        {
            //ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups!','Error inesperado','error');", true);
            Mensajes("UPS!", "Ocurrio un error", "error");
        }
    }
    protected void Mensajes(String tit, String msj, String tipo)
    {
        ScriptManager.RegisterStartupScript(this, GetType(), "Popup",
            "swal({" +
            "title: '" + tit + "'," +
            "text: '" + msj + "'," +
            "type: '" + tipo + "'," +
            "});",
            true);
    }
    protected void adoptar_Click(object sender, EventArgs e)
    {
        adoptar();
    }
    protected void boton_ServerClick(object sender, EventArgs e)
    {

    }

}
