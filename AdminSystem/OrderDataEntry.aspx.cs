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

    //variable to store the primary key value of the record to be deleted
    Int32 orderId;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the order to be processed
        orderId = Convert.ToInt32(Session["orderId"]);
        if (IsPostBack == false)
        {
            //if this is the not a new record
            if (orderId != -1)
            {
                //display the current data for the record
                DisplayOrder();
            }
        }
    }


    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a instance of clsOrder
        clsOrder AnOrder = new clsOrder();
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
        //capture the shipping address
        string shippingAddress = txtshippingAddress.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AnOrder.Valid(orderDescription, orderQuantity, orderAmount, orderDate, shippingAddress);
        if (Error == "")
        {

            //capture the order description
            AnOrder.orderDescription = orderDescription;
            //capture the order quantity
            AnOrder.orderQuantity = Convert.ToInt32(orderQuantity);
            //capture the order amount
            AnOrder.orderAmount = Convert.ToInt32(orderAmount);
            //capture the order date
            AnOrder.orderDate = Convert.ToDateTime(orderDate);
            //capture the order date
            AnOrder.shippingAddress = Convert.ToString(shippingAddress);
            //capture available
            AnOrder.orderStatus = chkStatus.Checked;
            //create a new instance of the order collection
            clsOrderCollection orderList = new clsOrderCollection();

            //if this is a new record i.e. orderid = -1 then add the data
            if (orderId == -1)
            {
                //set the Thisorder property
                orderList.ThisOrder = AnOrder;
                //add the new record
                orderList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                orderList.ThisOrder.Find(orderId);
                //set the Thisorder property
                orderList.ThisOrder = AnOrder;
                //update the record
                orderList.Update();
            }
            //redirect back to the list page
            Response.Redirect("OrderList.aspx");
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
            // Handle invalid input (non-integer value for orderId)
            lblError.Text = "Please enter a valid Order ID.";
        }
    }


    void DisplayOrder()
    {
        //create an instance of the order book
        clsOrderCollection Order = new clsOrderCollection();
        //find the record to update
        Order.ThisOrder.Find(orderId);
        //display the data for the record
        txtorderId.Text = Order.ThisOrder.orderId.ToString();
        txtorderQuantity.Text = Order.ThisOrder.orderQuantity.ToString();
        txtorderDescription.Text = Order.ThisOrder.orderDescription.ToString();
        txtshippingAddress.Text = Order.ThisOrder.shippingAddress.ToString();
        txtorderDate.Text = Order.ThisOrder.orderDate.ToString();
        txtorderAmount.Text = Order.ThisOrder.orderAmount.ToString();
        chkStatus.Checked = Order.ThisOrder.orderStatus;
    }

    protected void btnReturnToMainMenu_Click(object sender, EventArgs e)
    {
        //redirect the user to the main menu page
        Response.Redirect("TeamMainMenu.aspx");
    }

}
