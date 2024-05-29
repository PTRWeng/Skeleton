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
    protected void Page_Load(object sender, EventArgs e)
    {

    }



    protected void btnFind_Click(object sender, EventArgs e)
    {
        // Create an instance of the order class
        clsOrder AnOrder = new clsOrder();
        // Create a variable to store the primary key
        Int32 orderId;
        // Create a variable to store the result of the find operation
        Boolean Found = false;

        try
        {
            // Get the primary key entered by the user
            orderId = Convert.ToInt32(txtorderId.Text);

            // Find the record
            Found = AnOrder.Find(orderId);

            if (Found)
            {
                // Display the values of the properties in the form
                txtorderDescription.Text = AnOrder.orderDescription;
                txtshippingAddress.Text = AnOrder.shippingAddress;
                txtorderDate.Text = AnOrder.orderDate.ToString();
                txtorderAmount.Text = AnOrder.orderAmount.ToString();
                txtorderQuantity.Text = AnOrder.orderQuantity.ToString();
                chkStatus.Checked = AnOrder.orderStatus;
            }
            else
            {
                // Record not found, display an error message
                lblError.Text = "Record with Order ID " + orderId + " is not found.";
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
        //create a instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture order id
        string orderId = txtorderId.Text;
        //capture active check box
        string orderStatus = chkStatus.Text;
        //capture the amount
        string orderAmount = txtorderAmount.Text;
        //capture the order Description
        string orderDescription = txtorderDescription.Text;
        //capture order date
        string orderDate = txtorderDate.Text;
        //capture the order quantity
        string orderQuantity = txtorderQuantity.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AnOrder.Valid(orderId, orderDescription, orderQuantity, orderAmount, orderDate);
        if (Error == "")
        {
            //capture the order id
            AnOrder.orderId = Convert.ToInt32(orderId);
            //capture the order description
            AnOrder.orderDescription = orderDescription;
            //capture the order quantity
            AnOrder.orderQuantity = Convert.ToInt32(orderQuantity);
            //capture the order amount
            AnOrder.orderAmount = Convert.ToInt32(orderAmount);
            //capture the order date
            AnOrder.orderDate = Convert.ToDateTime(orderDate);
            //store the order in the session object
            Session["AnOrder"] = AnOrder;
            //navigate to the new page
            Response.Redirect("OrderViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        // Create an instance of the order class
        clsOrder AnOrder = new clsOrder();
        // Create a variable to store the primary key
        Int32 orderId;
        // Create a variable to store the result of the find operation
        Boolean Found = false;

        try
        {
            // Get the primary key entered by the user
            orderId = Convert.ToInt32(txtorderId.Text);

            // Find the record
            Found = AnOrder.Find(orderId);

            if (Found)
            {
                // Display the values of the properties in the form
                txtorderDescription.Text = AnOrder.orderDescription;
                txtshippingAddress.Text = AnOrder.shippingAddress;
                txtorderDate.Text = AnOrder.orderDate.ToString();
                txtorderAmount.Text = AnOrder.orderAmount.ToString();
                txtorderQuantity.Text = AnOrder.orderQuantity.ToString();
                chkStatus.Checked = AnOrder.orderStatus;
            }
            else
            {
                // Record not found, display an error message
                lblError.Text = "Record with Order ID " + orderId + " is not found.";
            }
        }
        catch (FormatException)
        {
            // Handle invalid input (non-integer value for GameID)
            lblError.Text = "Please enter a valid Order ID.";
        }
    }

}