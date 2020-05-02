using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MantenimientoRoles : System.Web.UI.Page
{
    RollBLL objtB = new RollBLL();
    string cod, nombre;

    protected void Page_Load(object sender, EventArgs e)
    {
     
        


    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        
   
       

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
     
        cod = TextBox1.Text;
        nombre = TextBox2.Text;
        objtB.ActualizarRol(cod, nombre);
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        cod = TextBox1.Text;
        nombre = TextBox2.Text;

        try
        {

            if (string.IsNullOrEmpty(HiddenField1.Value))
            {

                objtB.InsertarRol(cod, nombre);
            }
            else {
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