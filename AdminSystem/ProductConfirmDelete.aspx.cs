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
    Int32 GameID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the game to be deleted from session object
        GameID = Convert.ToInt32(Session["GameID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the address book collection class
        clsGameCollection Product = new clsGameCollection();
        //find the record to delete
        Product.ThisGame.Find(GameID);
        //delete the record
        Product.Delete();
        //redirect back to the main page
        Response.Redirect("ProductList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("ProductList.aspx");
    }
}