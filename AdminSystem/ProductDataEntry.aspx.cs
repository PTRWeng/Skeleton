using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsGame
        clsGame AnGame = new clsGame();
        //capture the GameTitle
        AnGame.GameTitle = txtGameTitle.Text;
        //capture the GameDescription
        AnGame.GameDescription = txtGameDescription.Text;
        //capture the GamePlatform
        AnGame.GamePlatform = txtGamePlatform.Text;
        //capture the RelaeseDate
        AnGame.ReleaseDate = Convert.ToDateTime(txtReleaseDate.Text);
        //capture the Price
        AnGame.Price = Convert.ToDouble(txtPrice.Text);
        //capture Available check box
        AnGame.Available = chkAvailable.Checked;
        //store the game in the session object
        Session["AnGame"] = AnGame;
        //navigate to the view page
        Response.Redirect("ProductViewer.aspx");
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
}