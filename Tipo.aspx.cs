using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Tipo : System.Web.UI.Page
{
    sql sql = new sql();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            txt_tipo.Text = GridView1.SelectedRow.Cells[2].Text;
        }
        catch
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups','Error','error');", true);
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            if (txt_tipo.Text.Trim().Equals(""))
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups','No deje los campos vacios','error');", true);
            }
            else
            {
                if (txt_tipo.Text.Trim().Length < 3)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups','El nombre es demaciado corto','error');", true);
                }
                else
                {
                    if (sql.validar("SELECT * FROM Tipo_Animal WHERE Tipo_Animal ='" + txt_tipo.Text + "'"))
                    {
                        ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups','No puede haber dos nombres iguales','error');", true);
                    }
                    else
                    {
                        int ingresar = sql.ejecutar("INSERT INTO Tipo_Animal(Tipo_Animal) VALUES('" + txt_tipo.Text + "')");
                        if (ingresar > 0)
                        {
                            ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Bien!','Tipo Mascota Registrada','error');", true);
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
            ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups','Error inesperado','error');", true);
        }
    }
    protected void llenaGrilla()
    {
        sql.llenaGrid(GridView1, "SELECT * FROM Tipo_Animal");
    }
    protected void GridView1_RowDeleted(object sender, GridViewDeletedEventArgs e)
    {

    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {

    }
}