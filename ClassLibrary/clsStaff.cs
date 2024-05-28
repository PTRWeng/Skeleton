using System;
using System.Net;

namespace ClassLibrary
{
    public class clsStaff
    {

        private int mStaffID ;
        private string mStaffFirstName ;
        private string mStaffLastName ;
        private DateTime mStaffDateofBirth;
        private string mStaffNumber;
        private string mStaffAddress ;
        private string mStaffEmail ;


        public int Staff

        {
            get
            {
                return mStaffID;
            }
            set
            {
                mStaffID = value;
            }
         }
        public string StaffFirstName
        {
            get
            {
                return mStaffFirstName;
            }
            set
            {
                mStaffFirstName= value;
            }
        }
        public string StaffLastName
        {
            get
            {
                return mStaffLastName;      
            }   
            set
            {
                mStaffLastName= value;
            }

        }
        public DateTime StaffDateofBirth
        {
            get
            {
                return mStaffDateofBirth;   

            }
            set { mStaffDateofBirth= value; }

        }
        public string StaffNumber
        {
            get
            { return mStaffNumber;}
            set
            {
                mStaffNumber= value;
            }
        }
        public string StaffAddress
        {
            get
            { return mStaffAddress; }
            set
            {
                mStaffAddress= value;
            }
        }
        
        public string StaffEmail
        {
            get
            {
                return mStaffEmail;
            }
            set { 
            mStaffEmail= value;} 
        }

        public bool Find(int StaffID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffID", StaffID);
            DB.Execute("stpr_tblStaff_FilterByStaffID");
            if (DB.Count == 1)
            {
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mStaffFirstName = Convert.ToString(DB.DataTable.Rows[0]["StaffFirstName"]);
                mStaffLastName = Convert.ToString(DB.DataTable.Rows[0]["StaffLastName"]);
                mStaffNumber = Convert.ToString(DB.DataTable.Rows[0]["StaffNumber"]);
                mStaffAddress = Convert.ToString(DB.DataTable.Rows[0]["StaffAddress"]);
                mStaffEmail = Convert.ToString(DB.DataTable.Rows[0]["StaffEmail"]);
                mStaffDateofBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["StaffDateofBirth"]);

                return true;
            }
            else
            {
                return false;
            }
        }


    }
}