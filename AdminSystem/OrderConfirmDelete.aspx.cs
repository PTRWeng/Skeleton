using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //variable to store the primary key value of the record to be deleted
    Int32 orderId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the order to be deleted from session object
        orderId = Convert.ToInt32(Session["orderId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the address book collection class
        clsOrderCollection Order = new clsOrderCollection();
        //find the record to delete
        Order.ThisOrder.Find(orderId);
        //delete the record
        Order.Delete();
        //redirect back to the main page
        Response.Redirect("OrderList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("OrderList.aspx");
    }
}
