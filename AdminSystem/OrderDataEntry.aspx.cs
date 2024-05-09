using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a instance of clsOrder
        clsOrder Order = new clsOrder();
        //capture order id
        Order.orderId = Convert.ToInt32(txtOrderId.Text);
        //store the order in the session object
        Session["Order"] = Order;
        //navigate to the new page
        Response.Redirect("OrderViewer");
        //capture active check box
        Order.Active = chkActive.Checked;

        //create a instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture order date
        Order.orderDate = Convert.ToDateTime(DateTime.Now);
        //store the order in the session object
        Session["Order"] = Order;
        //navigate to the new page
        Response.Redirect("OrderViewer");

        

    }

}
