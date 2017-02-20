using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Comuna : System.Web.UI.Page
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
            if (txt_Comuna.Text.Trim().Equals(""))
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups!','No deje los campos vacios','error');", true);
            }
            else
            {
                if (txt_Comuna.Text.Trim().Length < 4)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups!','Nombre de comuna demaciada corta','error');", true);
                }
                else
                {
                    if (sql.validar("SELECT * FROM comunas WHERE comuna_nombre ='" + txt_Comuna.Text + "'"))
                    {
                        ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups!','El nombre de la comuna ya existe','error');", true);
                    }
                    else
                    {
                        int ingresar = sql.ejecutar("INSERT INTO comunas(comuna_nombre,provincia_id) VALUES('" + txt_Comuna.Text + "','" + DropDownList2.SelectedValue + "')");
                        if (ingresar > 0)
                        {
                            ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Genial!','Comuna registrada','success');", true);
                            llenaGrilla();
                        }
                        else
                        {
                            ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups!','No se pudo registrar la comuna','error');", true);

                        }
                    }
                }
            }
        }
        catch
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups!','Ocurrio un error inesperado','error');", true);
        }

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        llenaProvincia();
    }

    protected void llenaGrilla()
    {
        sql.llenaGrid(GridView1, "SELECT * FROM comunas");
    }

    protected void llenaProvincia()
    {
        sql.llenacombo(DropDownList2, "select * from provincias where region_id='" + DropDownList1.SelectedValue.ToString() + "'", "provincia_nombre", "provincia_id");
    }
    protected void llenaCombo()
    {
        sql.llenacombo(DropDownList1, "select * from regiones", "region_nombre", "region_id");
        sql.llenacombo(DropDownList2, "select * from provincias", "provincia_nombre", "provincia_id");
    }
}