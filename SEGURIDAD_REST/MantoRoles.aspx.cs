using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MantoRoles : System.Web.UI.Page
{
    RollBLL objtB = new RollBLL();
    string cod, nombre;
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if(!IsPostBack)
        {
            string codigoRol = Request.QueryString["COD_ROL"];
        if (codigoRol != null)
        {
            RolDTO objRol = RollBLL.MostrarRolesID(codigoRol);
            if (objRol != null)
            {
                TextBox1.Text = objRol.COD_ROL;
                TextBox2.Text = objRol.NOM_ROL;

                HiddenField1.Value = objRol.COD_ROL;
            }

        }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        cod = TextBox1.Text;
        nombre = TextBox2.Text;

        try
        {

            if (string.IsNullOrEmpty(HiddenField1.Value))
            {

                objtB.InsertarRol(cod, nombre);
            }
            else
            {
                objtB.ActualizarRol(cod, nombre);
            }
            Response.Redirect("~/MostrarRoles.aspx");



        }
        catch (Exception)
        {

            throw;
        }
    }
}