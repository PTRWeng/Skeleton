using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TeamMainMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnGames_Click(object sender, EventArgs e)
    {
        //redirect the user to the game product login page
        Response.Redirect("ProductLogin.aspx");
    }

    protected void btnCustomers_Click(object sender, EventArgs e)
    {
    //redirect the user to the game product login page
    Response.Redirect("CustomerLogin.aspx");
    }
}
