using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //get the data from the session Object 
        AnCustomer = (clsCustomer)Session["AnCustomer"];
        //display the CustomerId of this entry 
        Response.Write(AnCustomer.CustomerId);
        //display the Firstname of the customer
        Response.Write(AnCustomer.CustomerFirstName);    
        //display the LastName of the customer
        Response.Write(AnCustomer.CustomerLastName);    
        //display the email address of the customer 
        Response.Write(AnCustomer.CustomerEmailAdress);
        //display the date of birth of the customer 
        Response.Write(AnCustomer.CustomerDateOfBirth);
        //display the address of the customer
        Response.Write(AnCustomer.CustomerAdress);
        //display the placed order for this entry
        Response.Write(AnCustomer.PlacedOrder);
    }
}