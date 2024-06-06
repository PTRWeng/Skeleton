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
        private string mCustomerEmailAddress;
        //orderDate public property
        public string CustomerEmailAddress
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerEmailAddress;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerEmailAddress = value;
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
        private Int32  mCustomerId;
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

        public DateTime DateTemp { get; private set; }

        //*****FIND METHOD*****//


        public bool Find(int CustomerId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address id to search for 
            DB.AddParameter("@CustomerId", CustomerId);
            //execute the stored procedure
            DB.Execute("sparoc_tblCustomer_FilterByCustomerId");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1) 
            {
                //copy the data from the database to the private data members
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mCustomerFirstName = Convert.ToString(DB.DataTable.Rows[0]["CustomerFirstName"]);
                mCustomerLastName = Convert.ToString(DB.DataTable.Rows[0]["CustomerLastName"]);
                mCustomerEmailAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmailAddress"]);
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



        public string Valid(string CustomerFirstName, string CustomerLastName, string CustomerDateOfBirth, string CustomerEmailAddress, string CustomerAddress)
        {

            //create a string variable to store the error
            string Error = "";
            //if the orderId is blank
            if (CustomerFirstName.Length == 0)
            {
                //record the error
                Error = Error + "The Customer firstname may not be blank : ";
            }
            //if the order id is greater than 10 characters
            if (CustomerFirstName.Length > 10)
            {
                //record the error
                Error = Error + "The Customer firstname must be less than 10 characters : ";
            }


            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(CustomerDateOfBirth);

                DateTime DateComp = DateTime.Now.Date;
                if (DateTemp < DateComp) //compare dateAdded with Date
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateComp)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }

            //is the order id blank
            if (CustomerAddress.Length == 0)
            {
                //record the error
                Error = Error + "The Customer Address may not be blank : ";
            }


            //if the order id is too long
            if (CustomerAddress.Length > 50)
            {
                //record the error
                Error = Error + "The Customer Address must be less than 50 characters : ";
            }


            //is the order id blank
            if (CustomerEmailAddress.Length == 0)
            {
                //record the error
                Error = Error + "The Customer EmailAddress may not be blank : ";
            }


            //if the order id is too long
            if (CustomerEmailAddress.Length > 50)
            {
                //record the error
                Error = Error + "The Customer EmailAddress must be less than 20 characters : ";
            }


            //is the order id blank
            if (CustomerDateOfBirth.Length == 0)
            {
                //record the error
                Error = Error + "The order date may not be blank : ";
            }


            //if the order id is too long
            if (CustomerLastName.Length > 10)
            {
                //record the error
                Error = Error + "The shipping address must be less than 50 characters : ";
            }


            //return any error messages
            return Error;
        }

    

    }


}
