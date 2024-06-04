using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayStaffs();
        }
    }

    void DisplayStaffs()
    {
        clsStaffCollection Staffs = new clsStaffCollection();
        lstStaffList.DataSource = Staffs.StaffList;
        lstStaffList.DataValueField = "StaffID";
        lstStaffList.DataTextField = "StaffFirstName";
        lstStaffList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["StaffID"] = -1;
        Response.Redirect("StaffDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 StaffID;
        if (lstStaffList.SelectedIndex != -1)
        {
            StaffID = Convert.ToInt32(lstStaffList.SelectedValue);
            Session["StaffID"] = StaffID;
            Response.Redirect("StaffDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select any STaff to perform Edit Operation";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 StaffID;
        if (lstStaffList.SelectedIndex != -1)
        {
            StaffID = Convert.ToInt32(lstStaffList.SelectedValue);
            Session["StaffID"] = StaffID;
            Response.Redirect("StaffConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select any STaff to perform Delete Operation";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        clsStaffCollection AStaff = new clsStaffCollection();
        AStaff.ReportByStaffFirstname(txtStaffFirstName.Text);
        lstStaffList.DataSource = AStaff.StaffList;
        lstStaffList.DataValueField = "StaffID";
        lstStaffList.DataTextField = "StaffFirstName";
        lstStaffList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        clsStaffCollection AStaff = new clsStaffCollection();
        AStaff.ReportByStaffFirstname("");
        txtStaffFirstName.Text = "";
        lstStaffList.DataSource = AStaff.StaffList;
        lstStaffList.DataValueField = "StaffID";
        lstStaffList.DataTextField = "StaffFirstName";
        lstStaffList.DataBind();
    }
}