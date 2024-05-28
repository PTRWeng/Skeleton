using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //get the data from the session object
        AnOrder = (clsOrder)Session["Order"];
        //display the order id for the entry
        Response.Write(AnOrder.OrderID);
        //display the order quantity for this entry
        Response.Write(AnOrder.OrderQuantity + "\n");
        //display the order Description for this entry
        Response.Write(AnOrder.OrderDescription + "\n");
        //display the order address for this entry
        Response.Write(AnOrder.ShippingAddress + "\n");
        //display the order date for this entry
        Response.Write(AnOrder.OrderDate + "\n");
        //display the order price for this entry
        Response.Write(AnOrder.OrderAmount + "\n");
        //display the order available for this entry
        Response.Write(AnOrder.Available);
    }
}