using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {


        List<clsStaff> mStaffList = new List<clsStaff>();
        clsStaff mThisStaff = new clsStaff();
        public clsStaffCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaff_SelectAll");
            PopulateArray(DB);
        }


        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            
            RecordCount = DB.Count;
            mStaffList = new List<clsStaff>();
            while (Index < RecordCount)
            {
                clsStaff AStaff = new clsStaff();
                AStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                AStaff.StaffFirstName = Convert.ToString(DB.DataTable.Rows[Index]["StaffFirstName"]);
                AStaff.StaffLastName = Convert.ToString(DB.DataTable.Rows[Index]["StaffLastName"]);
                AStaff.StaffDateofBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["StaffDateofBirth"]);
                AStaff.StaffEmail = Convert.ToString(DB.DataTable.Rows[Index]["StaffEmail"]);
                AStaff.StaffAddress = Convert.ToString(DB.DataTable.Rows[Index]["StaffAddress"]);
                AStaff.StaffNumber = Convert.ToString(DB.DataTable.Rows[Index]["StaffNumber"]);
                mStaffList.Add(AStaff);
                Index++;
            }
        }

        public List<clsStaff> StaffList
        {
            get { return mStaffList; }
            set { mStaffList = value; }
        }
        public int Count
        {
            get { return mStaffList.Count; }
            set { }
        }
        public clsStaff ThisStaff
        {
            get { return mThisStaff; }
            set { mThisStaff = value; }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffFirstName", mThisStaff.StaffFirstName);
            DB.AddParameter("@StaffLastName", mThisStaff.StaffLastName);
            DB.AddParameter("@StaffDateofBirth", mThisStaff.StaffDateofBirth);
            DB.AddParameter("@StaffAddress", mThisStaff.StaffAddress);
            DB.AddParameter("@StaffNumber", mThisStaff.StaffNumber);
            DB.AddParameter("@StaffEmail", mThisStaff.StaffEmail);

            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void ReportByStaffFirstname(string StaffFirstName)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffFirstName", StaffFirstName);
            DB.Execute("sproc_tblStaff_FilterByStaffFirstName");

            PopulateArray(DB);
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            DB.AddParameter("@StaffFirstName", mThisStaff.StaffFirstName);
            DB.AddParameter("@StaffLastName", mThisStaff.StaffLastName);
            DB.AddParameter("@StaffDateofBirth", mThisStaff.StaffDateofBirth);
            DB.AddParameter("@StaffAddress", mThisStaff.StaffAddress);
            DB.AddParameter("@StaffNumber", mThisStaff.StaffNumber);
            DB.AddParameter("@StaffEmail", mThisStaff.StaffEmail);

            DB.Execute("sproc_tblStaff_Update");
        }
    }
}