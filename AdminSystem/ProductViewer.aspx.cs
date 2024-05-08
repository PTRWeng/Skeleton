using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsGame
        clsGame AnGame = new clsGame();
        //get the data from the session object
        AnGame = (clsGame)Session["Angame"];
        //display the game title for this entry
        Response.Write(AnGame.GameTitle + "\n");
        //display the game Description for this entry
        Response.Write(AnGame.GameDescription + "\n");
        //display the game platform for this entry
        Response.Write(AnGame.GamePlatform + "\n");
        //display the game release date for this entry
        Response.Write(AnGame.ReleaseDate + "\n");
        //display the game price for this entry
        Response.Write(AnGame.Price + "\n");
        //display the game available for this entry
        Response.Write(AnGame.Available);
    }
}