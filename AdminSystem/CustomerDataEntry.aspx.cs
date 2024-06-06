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

   
    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the customer class
        clsCustomer AnCustomer = new clsCustomer();
        //create a variable to store the primary key
        Int32 CustomerId;
        //create a variable to store the result of the find operation
        Boolean Found = false;  
        //get the primary key enteredby the user
        CustomerId = Convert.ToInt32(txtCustomerId.Text);
        //find record
        Found = AnCustomer.Find(CustomerId);    
        //if found
        if (Found==true)
        {
            //display the values of the properties in the form 
            txtCustomerFirstName.Text = AnCustomer.CustomerFirstName;
            txtCustomerLastName.Text = AnCustomer.CustomerLastName;
            txtCustomerDateOfBirth.Text = AnCustomer.CustomerDateOfBirth.ToString();
            txtCustomerEmailAddress.Text = AnCustomer.CustomerEmailAddress;
            txtCustomerAddress.Text = AnCustomer.CustomerAddress;
            chkOrderPlaced.Checked = AnCustomer.Active;
        }
    }

   
    protected void btnOk_Click(object sender, EventArgs e)
    {
       //create a new instance of clsCustomer
       clsCustomer AnCustomer = new clsCustomer();
        //capture the FirstName 
        string CustomerLastName = txtCustomerLastName.Text;
        //store the LastName in the session object
        string CustomerFirstName = txtCustomerFirstName.Text;
        //store the LastName in the session object
        string CustomerDateOfBirth = txtCustomerDateOfBirth.Text;
        //store the LastName in the session object
        string CustomerEmailAddress = txtCustomerEmailAddress.Text;
        //store the LastName in the session object
        string CustomerAddress = txtCustomerAddress.Text;
        //store the LastName in the session object
        string PlacedOrder = chkOrderPlaced.Text;
        //error
        string Error = "";
        //validate data
        Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerEmailAddress, CustomerAddress, CustomerDateOfBirth);
        if (Error == "")
        {
            //capture customer first name
            AnCustomer.CustomerFirstName = CustomerFirstName;
            //capture customer last name
            AnCustomer.CustomerLastName = CustomerLastName;
            //capture customer address
            AnCustomer.CustomerAddress = CustomerAddress;
            //capture customer email
            AnCustomer.CustomerEmailAddress = CustomerEmailAddress;
            //capture customer dob
            AnCustomer.CustomerDateOfBirth = Convert.ToDateTime(CustomerDateOfBirth);
            //store the customer in the session object
            Session["AnCustomer"] = AnCustomer;
            //navigate to the view page
            Response.Redirect("CustomerViewer.aspx");
        }
        else
        {
            //display error
            lblError.Text = Error;
        }

    }



   
}

 
