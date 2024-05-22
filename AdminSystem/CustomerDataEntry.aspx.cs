using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    

    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //get the data from the session object
        AnCustomer = (clsCustomer)Session["AnCustomer"];
        //display the house CustomeLastName on the data entry 
        Response.Write(AnCustomer.CustomerLastName);
    }

    protected void txtCustomerLastName_TextChanged(object sender, EventArgs e)
    {

    }
    protected void txtCustomerFirstName_TextChanged(object sender, EventArgs e)
    {

    }
    protected void btnFind_Click(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
       //create a new instance of clsCustomer
       clsCustomer AnCustomer = new clsCustomer();
        //capture the FirstName 
        AnCustomer.CustomerLastName = txtCustomerLastName.Text;
        //store the LastName in the session object 
        Session["AnCustomer"] = AnCustomer;
        //navigate to the view page
        Response.Redirect("CustomerViewer.aspx");
    }

    protected void txtCustomerDateOfBirth_TextChanged(object sender, EventArgs e)
    {

    }
}

 