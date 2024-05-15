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

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        {
            //create a instance of clsCustomer
            clsCustomer Cutomer = new clsCustomer();
            //capture Customer id
            Customer.CustomerId = Convert.ToInt32(txtCustomerId.Text);
            //capture active check box
            Customer.PlacedOrder = chkPlacedOrder.Checked;
            //capture the amount
            Customer.CustomerEmailAdress = Convert.ToString(txtCustomerEmailAdress.Text);
            //capture the order Description
            Customer.CustomerAddress = Convert.ToString(txtCustomerAddress.Text);
            //capture order date
            Customer.CustomerDateOfBirth = Convert.ToDateTime(DateTime.Now);
            //capture the order quantity
            Customer.CustomerFirstName = Convert.ToString(txtCustomerFirstName.Text);
            //store the order in the session object
            Session["Customer"] = Customer;
            //navigate to the new page
            Response.Redirect("CustomerViewer.aspx");
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        // Create an instance of the Customer class
        clsOrder AnCustomer = new clsCustomer();
        // Create a variable to store the primary key
        Int32 CustomerId;
        // Create a variable to store the result of the find operation
        Boolean Found = false;

        try
        {
            // Get the primary key entered by the user
            CustomerId = Convert.ToInt32(txtCustomerId.Text);

            // Find the record
            Found = AnOrder.Find(OrderID);

            if (Found)
            {
                // Display the values of the properties in the form
                txtCustomerFirstName.Text = AnCustomer.CustomerFirstName;
                txtCustomerLastName.Text = AnCustomer.CustomerLastName;
                txtCustomerDatText = AnCustomer.orderDate.ToString();
                txtorderAmount.Text = AnCustomer.orderAmount.ToString();
                txtorderQuantity.Text = AnCustomer.orderQuantity.ToString();
                chkAvailable.Checked = AnCustomer.Available;
            }
            else
            {
                // Record not found, display an error message
                lblError.Text = "Record with Order ID " + OrderID + " is not found.";
            }
        }
        catch (FormatException)
        {
            // Handle invalid input (non-integer value for GameID)
            lblError.Text = "Please enter a valid Order ID.";
        }
    }
}