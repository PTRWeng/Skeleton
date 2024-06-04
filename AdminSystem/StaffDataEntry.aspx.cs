using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

public partial class _1_DataEntry : System.Web.UI.Page
{

    int StaffID;
    protected void Page_Load(object sender, EventArgs e)
    {
        StaffID = Convert.ToInt32(Session["StaffID"]);
        if (IsPostBack == false)
        {
            if (StaffID != -1)
            {
                DisplayStaff();
            }
            clsStaffUser AnUser = new clsStaffUser();
            AnUser = (clsStaffUser)Session["AnUser"];
            Response.Write("Logged In as a : " + AnUser.UserName);
        }
    }


    void DisplayStaff()
    {
        clsStaffCollection StaffsAll = new clsStaffCollection();
        StaffsAll.ThisStaff.Find(StaffID);

        txtStaffID.Text = StaffsAll.ThisStaff.StaffID.ToString();
        txtStaffFirstName.Text = StaffsAll.ThisStaff.StaffFirstName.ToString();
        txtStaffLastName.Text = StaffsAll.ThisStaff.StaffLastName.ToString();
        txtStaffDateofBirth.Text = StaffsAll.ThisStaff.StaffDateofBirth.ToString();
        txtStaffNumber.Text = StaffsAll.ThisStaff.StaffNumber.ToString();
        txtStaffAddress.Text = StaffsAll.ThisStaff.StaffAddress.ToString();
        txtStaffEmail.Text = StaffsAll.ThisStaff.StaffEmail.ToString();
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStaff AStaff = new clsStaff();
        string StaffFirstName = txtStaffFirstName.Text;
        string StaffLastName = txtStaffLastName.Text;
        string StaffDateofBirth = txtStaffDateofBirth.Text;
        string StaffNumber = txtStaffNumber.Text;
        string StaffAddress = txtStaffAddress.Text;
        string StaffEmail = txtStaffEmail.Text;
        string Error = "";
        Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDateofBirth, StaffNumber, StaffAddress, StaffEmail);
        if (Error == "")
        {
            AStaff.StaffID = StaffID;
            AStaff.StaffFirstName = StaffFirstName;
            AStaff.StaffLastName = StaffLastName;
            AStaff.StaffDateofBirth = Convert.ToDateTime(StaffDateofBirth);
            AStaff.StaffNumber = StaffNumber;
            AStaff.StaffAddress = StaffAddress;
            AStaff.StaffEmail = StaffEmail;
            
            
            clsStaffCollection StaffList = new clsStaffCollection();
            if (StaffID == -1)
            {
                StaffList.ThisStaff = AStaff;
                StaffList.Add();
            }
            else
            {
                StaffList.ThisStaff.Find(StaffID);
                StaffList.ThisStaff = AStaff;
                StaffList.Update();
            }
            Response.Redirect("StaffList.aspx"); 
              
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStaff AStaff = new clsStaff();
        Int32 StaffID;
        Boolean Found = false;
        StaffID = Convert.ToInt32(txtStaffID.Text);
        Found = AStaff.Find(StaffID);
        if (Found == true)
        {
            txtStaffFirstName.Text = AStaff.StaffFirstName;
            txtStaffLastName.Text = AStaff.StaffLastName;
            txtStaffDateofBirth.Text = AStaff.StaffDateofBirth.ToString();
            txtStaffNumber.Text = AStaff.StaffNumber;
            txtStaffAddress.Text = AStaff.StaffAddress.ToString();
            txtStaffEmail.Text = AStaff.StaffEmail.ToString();

        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffList.aspx");
    }
}