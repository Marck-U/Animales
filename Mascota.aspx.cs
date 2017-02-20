using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Mascota : System.Web.UI.Page
{
    sql sql = new sql();
    int id;
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["idAnimal"] = id;
    }

    protected void Unnamed3_Click(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            Boolean fileOK = false;
            String path = Server.MapPath("~/image/");
            if (Img.HasFile)
            {
                String fileExtension =
                    System.IO.Path.GetExtension(Img.FileName).ToLower();
                String[] allowedExtensions = { ".gif", ".png", ".jpeg", ".jpg" };
                for (int i = 0; i < allowedExtensions.Length; i++)
                {
                    if (fileExtension == allowedExtensions[i])
                    {
                        fileOK = true;
                    }
                }
            }
            if (fileOK)
            {
                try
                {
                    Img.PostedFile.SaveAs(path
                        + Img.FileName);
                    sql.ejecutar("update Animal set imagen = '" + Img.FileName + "' where id_Animal = '" + 1 + "'");
                    muestraImagen();
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups!','se subio','success');", true);
                }
                catch (Exception ex)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups!','Error Inesperado','error');", true);
                }
            }
            else
            {
                lbl_mensaje.Text = "la imagen no cumple con el formato correcto.";
            }
        }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            txt_Nombre.Text = GridView1.SelectedRow.Cells[1].Text;
            txt_raza.Text = GridView1.SelectedRow.Cells[2].Text;
            txt_estado.Text = GridView1.SelectedRow.Cells[3].Text;
            txt_Comuna.Text = GridView1.SelectedRow.Cells[4].Text;
            txt_tipo.Text = GridView1.SelectedRow.Cells[5].Text;
            txt_descripcion.Text = GridView1.SelectedRow.Cells[6].Text;
            txt_genero.Text = GridView1.SelectedRow.Cells[7].Text;
            id = Convert.ToInt32(GridView1.SelectedRow.Cells[0].Text);
        }
        catch
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups!','Ocurrio un error','error');", true);
        }
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            if (txt_Nombre.Text.Equals("") || txt_raza.Text.Equals("") || txt_tipo.Text.Equals("") || txt_descripcion.Text.Equals(""))
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups!','No deje los campos vacios','error');", true);
            }
            else
            {
                if (sql.validar("SELECT * FROM Usuario WHERE Animal ='" + txt_Nombre.Text + "'"))
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups!','el nombre de la mascota ya está en uso','error');", true);
                }
                else
                {
                    int ingresar = sql.ejecutar("INSERT INTO Usuario VALUES('" + txt_Nombre.Text + "','" + txt_raza.Text + "'," + txt_tipo.Text + "," + txt_descripcion.Text + "')");
                    if (ingresar > 0)
                    {
                        ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Bien!','Mascota registrada','success');", true);
                        llenaGrilla();
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups!','No se pudo registrar la mascota','error');", true);
                    }
                }
            }
        }
        catch
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups!','Error Inesperado','error');", true);
        }
    }
   

    private void muestraImagen()
    {
        SqlDataReader lector = sql.consulta("select imagen from Animal where correo = '" + 1 + "'");
        String img = "";
        if (lector.Read())
        {
            img = lector[10].ToString();
        }

         Image1.ImageUrl = "~/image/" + img;
    }
    

    protected void llenaGrilla()
    {
        sql.llenaGrid(GridView1, "exec muestraA");
    }
}