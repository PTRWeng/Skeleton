using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 StaffID;
    protected void Page_Load(object sender, EventArgs e)
    {
        StaffID = Convert.ToInt32(Session["StaffID"]);
    }

    protected void Yes_Click(object sender, EventArgs e)
    {
        clsStaffCollection AllStaffs = new clsStaffCollection();
        AllStaffs.ThisStaff.Find(StaffID);
        AllStaffs.Delete();
        Response.Redirect("StaffList.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffList.aspx");
    }
}