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


        public int StaffID

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

        public string Valid(string staffFirstName, string staffLastName, string staffDateofBirth, string staffNumber, string staffAddress, string staffEmail)
        {
            String Error = "";
            DateTime TestDate;

            if (staffFirstName.Length == 0)
            {
                Error += "First Name Cant be empty.";
            }
            if (staffFirstName.Length > 20)
            {
                Error += "First name shoud be smaller than 20.";
            }

            if (staffLastName.Length == 0)
            {
                Error += "Last Name Cant be empty.";
            }
            if (staffLastName.Length > 20)
            {
                Error += "Last name shoud be smaller than 20.";
            }

            try
            {
                TestDate = Convert.ToDateTime(staffDateofBirth);
                if (TestDate > DateTime.Now.Date)
                {
                    Error += "Date cant be in the future......";
                }
                if (TestDate < DateTime.Now.Date)
                {
                    Error += "Date cant be in the Past.....";
                }
            }
            catch
            {
                Error += "Invalid data.";
            }


            if (staffNumber.Length < 6)
            {
                Error += "Number's Minimum is 6 digit long.";
            }
            if (staffNumber.Length > 15)
            {
                Error += "numbers' is 15 digit long.";
            }


            if (staffEmail.Length == 0)
            {
                Error += "StaffEmail cant be empty.";
            }
            if (staffEmail.Length > 30)
            {
                Error += "StaffEmail Must be lesser than 30 Characters.";
            }

            if (staffAddress.Length == 0)
            {
                Error += "StaffAddress cant be empty.";
            }
            if (staffAddress.Length > 200)
            {
                Error += "StaffAddress must be lesser than 200 Characters.";
            }


            return Error;
        }
    }
}