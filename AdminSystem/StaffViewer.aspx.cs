using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStaff AStaff = new clsStaff();
        AStaff = (clsStaff)Session["AStaff"];
        Response.Write("StaffID : " + AStaff.StaffID);
        Response.Write("StaffFirstName : " + AStaff.StaffFirstName);
        Response.Write("StaffLastName : " + AStaff.StaffLastName);
        Response.Write("StaffDateofBirth : " + AStaff.StaffDateofBirth);
        Response.Write("StaffAddress : " + AStaff.StaffAddress);
        Response.Write("StaffEmail : " + AStaff.StaffEmail);
    }
}