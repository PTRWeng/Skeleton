using System;
using System.Security.Cryptography.X509Certificates;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public clsCustomer()
        {
        }

        public bool Active { get; set; }

        //private data member for the available property
        private Boolean mPlacedOrder;
        //active public property
        public bool PlacedOrder
        {
            get
            {
                //this line of code sends data out of the property
                return mPlacedOrder;
            }
            set
            {
                //this line of code allows data into the property
                mPlacedOrder = value;

            }
        }


            //private data member for the release date property
             private DateTime mCustomerDateOfBirth;
            //orderDate public property
             public DateTime CustomerDateOfBirth
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerDateOfBirth;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerDateOfBirth = value;
            }
        }

        //private data member for the release date property
        private string mCustomerFirstName;
        //orderDate public property
        public string CustomerFirstName
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerFirstName;
            }

            set =>
                //this line of code allows data into the property
                mCustomerFirstName = value;
        }

        //private data member for the release date property
        private string mCustomerLastName;
        //orderDate public property
        public string CustomerLastName
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerLastName;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerLastName = value;
            }
        }

        //private data member for the release date property
        private string mCustomerEmailAdress;
        //orderDate public property
        public string CustomerEmailAdress
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerEmailAdress;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerEmailAdress = value;
            }
        }


         //private data member for the release date property
         private string mCustomerAddress;
         //orderDate public property
         public string CustomerAddress
         {
                   get
                   {
                //this line of code sends data out of the property
                return mCustomerAddress;
                   }
                 set
                 {
                //this line of code allows data into the property
                mCustomerAddress = value;
                 }

         }

        //private data member for the release date property
        private int  mCustomerId;
        private DateTime mDateAdded;

        //orderDate public property
        public int CustomerId
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerId;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerId = value;
            }

        }

        //*****FIND METHOD*****//
        

        public bool Find(int CustomerId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address id to search for 
            DB.AddParameter("@CustomerId", CustomerId);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_filterByCustomerId");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1) 
            {
                //copy the data from the database to the private data members
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0][CustomerId]);
                mCustomerFirstName = Convert.ToString(DB.DataTable.Rows[0]["CustomerFirstName"]);
                mCustomerLastName = Convert.ToString(DB.DataTable.Rows[0]["CustomerLastName"]);
                mCustomerEmailAdress = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmailAdress"]);
                mCustomerDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["CustomerDateOfBirth"]);
                mCustomerAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerAddress"]);
                mPlacedOrder = Convert.ToBoolean(DB.DataTable.Rows[0]["PlacedOrder"]);
                //return that everything worked OK
                return true;
            }

            //if no record wa found
            else
            {
                //return false indicating there is a problem
                return false;
            }


            
        }
        public string Valid(string CustomerFirstName, string CustomerLastname, string CustomerDateOfBirth, string CustomerEmailAdress, string CustomerAddress)
        {
                //record the error
                Error = Error + "The shipping address must be less than 50 characters : ";
            }

        }

    }


}