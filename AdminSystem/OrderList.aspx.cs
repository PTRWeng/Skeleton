using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    

    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayOrders();
        }

        //create a new instance of clsOrderUser
        clsOrderUser AnUser = new clsOrderUser();
        //get data from the session object
        AnUser = (clsOrderUser)Session["AnUser"];
        //display the user name
        Response.Write("Logged in as: " + AnUser.UserName);
    }

    void DisplayOrders()
    {
        //create an instance of the order collection
        clsOrderCollection Orders = new clsOrderCollection();
        //set the data source to list of order in the cllection
        lstorderList.DataSource = Orders.orderList;
        //set the name of the primary key
        lstorderList.DataValueField = "orderId";
        //set the data fields to display
        lstorderList.DataTextField = "orderDescription";
        //bind the data to the list
        lstorderList.DataBind();
    }

    protected void btnReturnToMainMenu_Click(object sender, EventArgs e)
    {
        //redirect the user to the main menu page
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the order object
        clsOrderCollection AnOrder = new clsOrderCollection();
        //set an empty string
        AnOrder.ReportByorderDescription("");
        //clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        //set the data source to the list of orders in the collection
        lstorderList.DataSource = AnOrder.orderList;
        //set the name of the primary key
        lstorderList.DataValueField = "orderId";
        //set the name of the feild to display
        lstorderList.DataTextField = "orderDescription";
        //bind the data to the list
        lstorderList.DataBind();
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the order object
        clsOrderCollection AnOrder = new clsOrderCollection();
        //retrieve the value of order title from the presentation layer
        AnOrder.ReportByorderDescription(txtFilter.Text);
        //set the data source to the list of order in the collection
        lstorderList.DataSource = AnOrder.orderList;
        //set the name of the primary key
        lstorderList.DataValueField = "orderId";
        //set the name of the feild to display
        lstorderList.DataTextField = "orderDescription";
        //bind the data to the list
        lstorderList.DataBind();
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be deleted
        Int32 orderId;
        //if a record has been selected from the list
        if (lstorderList.SelectedIndex != -1)
        {
            //geet the primary key value of the record delte
            orderId = Convert.ToInt32(lstorderList.SelectedValue);
            //store the data in the session object
            Session["orderId"] = orderId;
            //redirect to the delete page
            Response.Redirect("OrderConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            //display an error message
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the ecord to be edited
        Int32 orderId;
        //if a record has been selected from the list
        if (lstorderList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            orderId = Convert.ToInt32(lstorderList.SelectedValue);
            //store the data in the session object
            Session["orderId"] = orderId;
            //redirect to the edit page
            Response.Redirect("OrderDataEntry.aspx");
        }
        else   //if no record has been selected
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this ia a new record
        Session["orderId"] = -1;
        //redirect to the data entry page
        Response.Redirect("OrderDataEntry.aspx");
    }
}
