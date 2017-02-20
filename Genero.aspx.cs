using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Genero : System.Web.UI.Page
{
    sql sql = new sql();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        txt_genero.Text = GridView1.SelectedRow.Cells[2].Text;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            if (txt_genero.Text.Trim().Equals(""))
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups!','No deje los campos vacios','error');", true);
            }
            else
            {
                if (txt_genero.Text.Trim().Length < 4)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups!','Demaciado corto el nombre','error');", true);
                }
                else
                {
                    if (sql.validar("SELECT * FROM Genero WHERE Genero ='" + txt_genero.Text + "'"))
                    {
                        ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups!','No se puede duplicar el genero','error');", true);
                    }
                    else
                    {
                        int ingresar = sql.ejecutar("INSERT INTO Genero(Genero) VALUES('" + txt_genero.Text + "')");
                        if (ingresar > 0)
                        {
                            ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Bien!','Genero registrado','success');", true);
                            llenaGrilla();
                        }
                        else
                        {
                            ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups!','No se pudo registrar el genero','error');", true);
                        }
                     }
                 }
             }
         }
        catch
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups!','Ocurrio un error','error');", true);
        }
    }
    protected void llenaGrilla()
    {
        sql.llenaGrid(GridView1, "SELECT * FROM Genero");
    }
}