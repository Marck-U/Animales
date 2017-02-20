using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Registo : System.Web.UI.Page
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
    protected void btn_insert_Click1(object sender, EventArgs e)
    {
        try
        {
            if (txt_rut.Text.Trim().Equals("") || txt_nombre.Text.Trim().Equals("") || txt_apellido.Text.Trim().Equals("") || txt_usuario.Text.Trim().Equals("") || txt_telefono.Text.Trim().Equals("") || txt_correo.Text.Trim().Equals("") || txt_direc.Text.Trim().Equals(""))
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups','No deje los campos vacios','error');", true);
            }
            else
            {
                if (txt_nombre.Text.Trim().Length < 3 || txt_apellido.Text.Trim().Length < 3)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups','Demaciado corto el campo nobre y/o apellido ','error');", true);
                }
                else
                {
                    if (txt_usuario.Text.Trim().Length < 3)
                    {
                        ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups','El nombre de usuario es demaciado corto ','error');", true);
                    }
                    else
                    {
                        if (txt_telefono.Text.Trim().Length < 9 || txt_telefono.Text.Trim().Length > 9)
                        {
                            ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups','El numero de telefono tiene que tener 9 digitos','error');", true);
                        }
                        else
                        {
                            if (sql.validar("SELECT * FROM Cliente WHERE Usuario ='" + txt_usuario.Text + "'"))
                            {
                                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups','El nombre de usuario ya está ocupado','error');", true);
                            }
                            else
                            {
                                if (sql.validar("SELECT * FROM Cliente WHERE Run ='" + txt_rut.Text + "'"))
                                {
                                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups','El rut del usuario ya existe','error');", true);
                                }
                                else
                                {
                                    int registro = sql.ejecutar("INSERT INTO Cliente (Run,Nombre,Apellido,Usuario,Telefono,CorreoE,Direccion,comuna_id,Clave,id_Estado) VALUES ('" + txt_rut.Text + "','" + txt_nombre.Text + "','" + txt_apellido.Text + "','" + txt_usuario.Text + "','" + txt_telefono.Text + "','" + txt_correo.Text + "','" + txt_direc.Text + "','" + DropDownList4.SelectedValue + "','" + txt_pass.Text + "','1')");
                                    if (registro > 0)
                                    {
                                        ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Genial!','Usuario registrado','success');", true);

                                    }
                                    else
                                    {
                                        ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Ups','El Usuario no pudo ser registrado','error');", true);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        catch
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal('Que mal','ocurrio un error inesperado','error');", true);
        }
    }

    protected void DropDownList6_SelectedIndexChanged(object sender, EventArgs e)
    {
        llenaProvincia();
    }
    protected void DropDownList5_SelectedIndexChanged(object sender, EventArgs e)
    {
        llenaComuna();   
    }

    protected void llenaProvincia()
    {
        sql.llenacombo(DropDownList5, "select * from provincias where region_id='" + DropDownList6.SelectedValue.ToString() + "'", "provincia_nombre", "provincia_id");
    }

    protected void llenaComuna()
    {
        sql.llenacombo(DropDownList4, "select * from comunas where provincia_id='" + DropDownList5.SelectedValue.ToString() + "'", "comuna_nombre", "comuna_id");
    }
    protected void llenaCombo()
    {
        sql.llenacombo(DropDownList6, "select * from regiones", "region_nombre", "region_id");
        sql.llenacombo(DropDownList5, "select * from provincias", "provincia_nombre", "provincia_id");
        sql.llenacombo(DropDownList4, "select * from comunas", "comuna_nombre", "comuna_id");
    }
}