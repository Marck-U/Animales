using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Provincia : System.Web.UI.Page
{
    sql sql = new sql();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            llenaCombo();
        }
        else
        {
            ScriptManager.RegisterStartupScript(this, typeof(Page), "popup", "Inicializa();", true);
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            if (txt_Provincia.Text.Trim().Equals(""))
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups','No deje los campos vacios','error');", true);
            }
            else
            {
                if (txt_Provincia.Text.Trim().Length < 4)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups','El nombre de la comuna es muy corto','error');", true);
                }
                else
                {
                    if (sql.validar("SELECT * FROM provincias WHERE provincia_nombre ='" + txt_Provincia.Text + "'"))
                    {
                        ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups','El nombre de la comuna ya existe','error');", true);
                    }
                    else
                    {
                        int ingresar = sql.ejecutar("INSERT INTO provincias(provincia_nombre,region_id) VALUES('" + txt_Provincia.Text + "','" + DropDownList1.SelectedValue + "')");
                        if (ingresar > 0)
                        {
                            ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Bien!','El nombre de la comuna fue registrado','success');", true);
                            llenaGrilla();
                        }
                        else
                        {
                            ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups','No se pudo registrar la comuna','error');", true);
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
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        llenaCombo();
    }

    protected void llenaGrilla()
    {
        sql.llenaGrid(GridView1, "SELECT * FROM provincias");
    }

    protected void llenaCombo()
    {
        sql.llenacombo(DropDownList1, "select * from provincias", "provincia_nombre", "provincia_id");
    }
}