using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StaffLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        clsStaffUser AnUser = new clsStaffUser();
        string UserName = txtUserName.Text;
        string Password = txtPassword.Text;
        Boolean Found = false;
        UserName = Convert.ToString(txtUserName.Text);
        Password = Convert.ToString(txtPassword.Text);

        Found = AnUser.FindUser(UserName, Password);
        Session["AnUser"] = AnUser;

        if (txtUserName.Text == "")
        {
            lblError.Text = "Enter UserName ";
        }
        else if (txtPassword.Text == "")
        {
            lblError.Text = "Enter Password";
        }

        else if (Found == true)
        {
            Response.Redirect("StaffList.aspx");
        }
        else if (Found == false)
        {
            lblError.Text = "Details are Incorrect.";
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}