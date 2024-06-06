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

    protected void btnOrders_Click(object sender, EventArgs e)
    {
        //redirect the user to the order login page
        Response.Redirect("OrderLogin.aspx");
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

    protected void btnStaff_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffLogin.aspx");
    }
}


