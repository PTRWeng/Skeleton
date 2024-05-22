using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 GameID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the game to be processed
        GameID = Convert.ToInt32(Session["GameID"]);
        if (IsPostBack == false)
        {
            //if this is the not a new record
            if (GameID != -1)
            {
                //display the current data for the record
                DisplayGame();
            }
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsGame
        clsGame AnGame = new clsGame();
        //capture the GameTitle
        string GameTitle = txtGameTitle.Text;
        //capture the GameDescription
        string GameDescription = txtGameDescription.Text;
        //capture the GamePlatform
        string GamePlatform = txtGamePlatform.Text;
        //capture the RelaeseDate
        string ReleaseDate = txtReleaseDate.Text;
        //capture the Price
        string Price = txtPrice.Text;
        //capture Available check box
        string Available = chkAvailable.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AnGame.Valid(GameTitle, GameDescription, GamePlatform, ReleaseDate);
        if (Error == "")
        {
            //capture the gmae id
            AnGame.GameID = GameID;
            //capture the game title
            AnGame.GameTitle = GameTitle;
            //capture the game description
            AnGame.GameDescription = GameDescription;
            //capture the game platform
            AnGame.GamePlatform = GamePlatform;
            //capture the release date
            AnGame.ReleaseDate = Convert.ToDateTime(ReleaseDate);
            //capture the price
            AnGame.Price = Convert.ToDouble(Price);
            //capture available
            AnGame.Available = chkAvailable.Checked;
            //create a new instance of the game collection
            clsGameCollection GameList = new clsGameCollection();
            
            //if this is a new record i.e. GameID = -1 then add the data
            if (GameID == -1)
            {
                //set the ThisGame property
                GameList.ThisGame = AnGame;
                //add the new record
                GameList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                GameList.ThisGame.Find(GameID);
                //set the ThisGame property
                GameList.ThisGame = AnGame;
                //update the record
                GameList.Update();
            }
            //redirect back to the list page
            Response.Redirect("ProductList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;  
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        // Create an instance of the game class
        clsGame AnGame = new clsGame();
        // Create a variable to store the primary key
        Int32 GameID;
        // Create a variable to store the result of the find operation
        Boolean Found = false;

        try
        {
            // Get the primary key entered by the user
            GameID = Convert.ToInt32(txtgameID.Text);

            // Find the record
            Found = AnGame.Find(GameID);

            if (Found)
            {
                // Display the values of the properties in the form
                txtGameTitle.Text = AnGame.GameTitle;
                txtGameDescription.Text = AnGame.GameDescription;
                txtGamePlatform.Text = AnGame.GamePlatform;
                txtReleaseDate.Text = AnGame.ReleaseDate.ToString();
                txtPrice.Text = AnGame.Price.ToString();
                chkAvailable.Checked = AnGame.Available;
            }
            else
            {
                // Record not found, display an error message
                lblError.Text = "Record with Game ID " + GameID + " is not found.";
            }
        }
        catch (FormatException)
        {
            // Handle invalid input (non-integer value for GameID)
            lblError.Text = "Please enter a valid Game ID.";
        }
    }

    void DisplayGame()
    {
        //create an instance of the game book
        clsGameCollection Product = new clsGameCollection();
        //find the record to update
        Product.ThisGame.Find(GameID);
        //display the data for the record
        txtgameID.Text = Product.ThisGame.GameID.ToString();
        txtGameTitle.Text = Product.ThisGame.GameTitle.ToString();
        txtGameDescription.Text = Product.ThisGame.GameDescription.ToString();
        txtGamePlatform.Text = Product.ThisGame.GamePlatform.ToString();
        txtReleaseDate.Text = Product.ThisGame.ReleaseDate.ToString();
        txtPrice.Text = Product.ThisGame.Price.ToString();
        chkAvailable.Checked = Product.ThisGame.Available;
    }
}