using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a instance of clsOrder
        clsOrder Order = new clsOrder();
        //capture order id
        Order.OrderID = Convert.ToInt32(txtorderId.Text);
        //capture active check box
        Order.Available = chkAvailable.Checked;
        //capture the amount
        Order.OrderAmount = Convert.ToDouble(txtorderAmount.Text);
        //capture the order Description
        Order.OrderDescription = Convert.ToString(txtorderDescription.Text);
        //capture order date
        Order.OrderDate = Convert.ToDateTime(DateTime.Now);
        //capture the order quantity
        Order.OrderQuantity = Convert.ToInt32(txtorderQuantity.Text);
        //store the order in the session object
        Session["Order"] = Order;
        //navigate to the new page
        Response.Redirect("OrderViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        // Create an instance of the order class
        clsOrder AnOrder = new clsOrder();
        // Create a variable to store the primary key
        Int32 OrderID;
        // Create a variable to store the result of the find operation
        Boolean Found = false;

        try
        {
            // Get the primary key entered by the user
            OrderID = Convert.ToInt32(txtorderId.Text);

            // Find the record
            Found = AnOrder.Find(OrderID);

            if (Found)
            {
                // Display the values of the properties in the form
                txtorderDescription.Text = AnOrder.OrderDescription;
                txtshippingAddress.Text = AnOrder.ShippingAddress;
                txtorderDate.Text = AnOrder.OrderDate.ToString();
                txtorderAmount.Text = AnOrder.OrderAmount.ToString();
                txtorderQuantity.Text = AnOrder.OrderQuantity.ToString();
                chkAvailable.Checked = AnOrder.Available;
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


    protected void btnOk_Click(object sender, EventArgs e)
    {

    }
}
