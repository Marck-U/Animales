using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Vacunas : System.Web.UI.Page
{
    int id;
    sql sql = new sql();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_insert_Click1(object sender, EventArgs e)
    {
        try
        {
            if (txt_vacuna.Text.Trim().Equals(""))
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups','No deje el campo vacio','error');", true);
            }
            else
            {
                if (txt_vacuna.Text.Trim().Length < 3)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups','Demaciado corto el nombre','error');", true);
                }
                else
                {
                    if (sql.validar("SELECT * FROM Tipo_Vacuna WHERE TipoVacuna ='" + txt_vacuna.Text + "'"))
                    {
                        ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups','No se puede duplicarl el nombre','error');", true);
                    }
                    else
                    {
                        int ingresar = sql.ejecutar("INSERT INTO Tipo_Vacuna (TipoVacuna) VALUES ('" + txt_vacuna.Text + "')");
                        if (ingresar > 0)
                        {
                            ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Bien!','Tipo Vacuna Registrado','success');", true);
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
        catch {
            ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups','Error Inesperado','error');", true);
        }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        //id = Convert.ToInt32(GridView1.SelectedRow.Cells[0].Text);
        txt_vacuna.Text = GridView1.SelectedRow.Cells[1].Text;
    }

    protected void llenaGrilla()
    {
        sql.llenaGrid(GridView1, "SELECT * FROM Tipo_Vacuna");
    }
}