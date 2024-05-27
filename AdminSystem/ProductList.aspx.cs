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

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the ecord to be edited
        Int32 GameID;
        //if a record has been selected from the list
        if (lstGameList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            GameID = Convert.ToInt32(lstGameList.SelectedValue);
            //store the data in the session object
            Session["GameID"] = GameID;
            //redirect to the edit page
            Response.Redirect("ProductDataEntry.aspx");
        }
        else   //if no record has been selected
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be deleted
        Int32 GameID;
        //if a record has been selected from the list
        if(lstGameList.SelectedIndex != -1)
        {
            //geet the primary key value of the record delte
            GameID = Convert.ToInt32(lstGameList.SelectedValue);
            //store the data in the session object
            Session["GameID"] = GameID;
            //redirect to the delete page
            Response.Redirect("ProductConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            //display an error message
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the game object
        clsGameCollection AnGame = new clsGameCollection();
        //retrieve the value of game title from the presentation layer
        AnGame.ReportByGameTitle(txtFilter.Text);
        //set the data source to the list of games in the collection
        lstGameList.DataSource = AnGame.GameList;
        //set the name of the primary key
        lstGameList.DataValueField = "GameID";
        //set the name of the feild to display
        lstGameList.DataTextField = "GameTitle";
        //bind the data to the list
        lstGameList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the game object
        clsGameCollection AnGame = new clsGameCollection();
        //set an empty string
        AnGame.ReportByGameTitle("");
        //clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        //set the data source to the list of games in the collection
        //set the data source to the list of games in the collection
        lstGameList.DataSource = AnGame.GameList;
        //set the name of the primary key
        lstGameList.DataValueField = "GameID";
        //set the name of the feild to display
        lstGameList.DataTextField = "GameTitle";
        //bind the data to the list
        lstGameList.DataBind();
    }
}