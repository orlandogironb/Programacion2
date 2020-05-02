using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MostrarRoles : System.Web.UI.Page
{

    RollBLL objBLL = new RollBLL();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        string CodeRol;
        LinkButton btnElimanr = (LinkButton)sender;
        CodeRol = (btnElimanr.CommandArgument);
        objBLL.BorrarRol(CodeRol);
        GridView1.DataBind();
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}