using System;

namespace ClassLibrary
{
    public class clsStaff
    {

        private Boolean mActive;
        private int mStaffID ;
        private string mStaffFirstName ;
        private string mStaffLastName ;
        private DateTime mStaffDateofBirth;
        private string mStaffNumber;
        private string mStaffAddress ;
        private string mStaffEmail ;

        public bool Active
        {
            get
            {

                return mActive;

            }
            set
            {
              mActive=  value;
            }
        }
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
            mActive = true;
            mStaffID= 6;
            mStaffFirstName = "Wick";
            mStaffLastName = "John";
            mStaffDateofBirth = DateTime.Now;
            mStaffNumber = "0111";
            mStaffAddress = "LE7";
            mStaffEmail = "Hamza12@gmail.com";
            return true;




        }


    }
}