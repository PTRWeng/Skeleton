using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    public object AStaff { get; private set; }

    protected void Page_Load(object sender, EventArgs e)
    {

    }



    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtLastName_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {    
        clsStaff AStaff = new clsStaff();
        AStaff.StaffID = Convert.ToInt32(txtStaffID.Text);
        AStaff.StaffFirstName = txtStaffFirstName.Text;
        AStaff.StaffLastName = txtLastName.Text;
        AStaff.StaffDateofBirth = Convert.ToDateTime(txtStaffDateofBirth.Text);
        AStaff.StaffNumber = txtStaffNumber.Text;
        AStaff.StaffAddress =txtStaffAddress.Text;
        AStaff.StaffEmail = txtStaffEmail.Text;
        Response.Redirect("StaffViewer.aspx");
    }
}