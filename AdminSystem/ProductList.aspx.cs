using System;
using System.Collections.Generic;
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
            DisplayGames();
        }
    }

    void DisplayGames()
    {
        //create an instance of the Game collection
        clsGameCollection Games = new clsGameCollection();
        //set the data source to list of games in the cllection
        lstGameList.DataSource = Games.GameList;
        //set the name of the primary key
        lstGameList.DataValueField = "GameID";
        //set the data fields to display
        lstGameList.DataTextField = "GameTitle";
        //bind the data to the list
        lstGameList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this ia a new record
        Session["GameID"] = -1;
        //redirect to the data entry page
        Response.Redirect("ProductDataEntry.aspx");
    }
}