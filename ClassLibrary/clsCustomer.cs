using System;

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
        private DateTime mCustomerFirstName;
        //orderDate public property
        public DateTime CustomerFirstName
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
         private string mCustomerAdress;
         //orderDate public property
         public string CustomerAdress
         {
                   get
                   {
                //this line of code sends data out of the property
                return mCustomerAdress;
                   }
                 set
                 {
                //this line of code allows data into the property
                mCustomerAdress = value;
                 }

         }

        //private data member for the release date property
        private int  mCustomerId;

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
            //set the private data members to the test Data value
            mCustomerId = 1;
            mDateAdded = Convert.ToDateTime("23/12/2022");
           //always return true
           return true;
        }
    }


}