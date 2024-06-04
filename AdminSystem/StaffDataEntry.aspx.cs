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
    protected void Page_Load(object sender, EventArgs e)
    {

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
            AStaff.StaffFirstName = StaffFirstName;
            AStaff.StaffLastName = StaffLastName;
            AStaff.StaffDateofBirth = Convert.ToDateTime(StaffDateofBirth);
            AStaff.StaffNumber = StaffNumber;
            AStaff.StaffAddress = StaffAddress;
            AStaff.StaffEmail = StaffEmail;
            Session["AStaff"] = AStaff;


            /*
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
            Response.Redirect("StaffsList.aspx"); 
              
             */
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