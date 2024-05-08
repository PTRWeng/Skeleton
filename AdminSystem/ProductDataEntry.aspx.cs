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
}