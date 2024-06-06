using System.Collections.Generic;
using System;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerlist = new List<clsCustomer>();
        //private member data for thisCustomer
        clsCustomer mThisCustomer = new clsCustomer();

        //public property for the Customer list
        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerlist;
            }
            set
            {
                //set the private data
                mCustomerlist = value;
            }
        }
        //public property for count
        public int Count
        {
            get
            {
                //retune the count of the list
                return mCustomerlist.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        public clsCustomer ThisCustomer
        {
            get
            {
                //return the private data
                return mThisCustomer;
            }
            set
            {
                //set the private data
                mThisCustomer = value;
            }
        }

        public int Add()
        {
            //adds a record to the database based on the values of mThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerDateOfBirth", mThisCustomer.CustomerDateOfBirth);
            DB.AddParameter("@PlacedOrder", mThisCustomer.PlacedOrder);
            DB.AddParameter("@CustomerAddress", mThisCustomer.CustomerAddress);
            DB.AddParameter("@CustomerFirstName", mThisCustomer.CustomerFirstName);
            DB.AddParameter("@CustomerLastName", mThisCustomer.CustomerLastName);
            DB.AddParameter("@CustomerEmailAddress", mThisCustomer.CustomerEmailAddress);
            //execute the query returning the primary kay value
            return DB.Execute("sproc_tblCustomer_Insert");
        }


        public void Update()
        {
            //update a record to the database based on the values of mThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            DB.AddParameter("@CustomerDateOfBirth", mThisCustomer.CustomerDateOfBirth);
            DB.AddParameter("@PlacedOrder", mThisCustomer.PlacedOrder);
            DB.AddParameter("@CustomerAddress", mThisCustomer.CustomerAddress);
            DB.AddParameter("@CustomerFirstName", mThisCustomer.CustomerFirstName);
            DB.AddParameter("@CustomerLastName", mThisCustomer.CustomerLastName);
            DB.AddParameter("@CustomerEmailAddress", mThisCustomer.CustomerEmailAddress);
            //execute the query returning the primary kay value
            DB.Execute("sproc_tblCustomer_Update");
        }


        public void Delete()
        {
            //deletes the record pointed to by thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Delete");
        }


        public void ReportByCustomerFirstName(string CustomerFirstName)
        {
            //filters the records based on a full or partial Customer Description
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //sent the CustomerDescription parameter to the database
            DB.AddParameter("@CustomerFirstName", CustomerFirstName);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerFirstName");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public clsCustomerCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mCustomerlist = new List<clsCustomer>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank Customer object
                clsCustomer AnCustomer = new clsCustomer();
                //read in the fields from the current record
                AnCustomer.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                AnCustomer.CustomerFirstName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerFirstName"]);
                AnCustomer.CustomerLastName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerLastName"]);
                AnCustomer.CustomerAddress = Convert.ToString(DB.DataTable.Rows[Index]["CustomerAddress"]);
                AnCustomer.CustomerDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["CustomerDateOfBirth"]);
                AnCustomer.CustomerEmailAddress = Convert.ToString(DB.DataTable.Rows[Index]["CustomerEmailAddress"]);
                AnCustomer.PlacedOrder = Convert.ToBoolean(DB.DataTable.Rows[Index]["PlacedOrder"]);
                //add the record to the private data member
                mCustomerlist.Add(AnCustomer);
                //point at the next record
                Index++;
            }
        }

    }

}
