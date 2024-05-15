using System;

namespace ClassLibrary
{
    public class clsOrder
    {

        //private data member for the available property
        private Boolean mAvailable;
        //active public property
        public bool Available
        {
            get
            {
                //this line of code sends data out of the property
                return mAvailable;
            }
            set
            {
                //this line of code allows data into the property
                mAvailable = value;
            }
        }


        //private data member for the release date property
        private DateTime morderDate;
        //orderDate public property
        public DateTime OrderDate
        {
            get
            {
                //this line of code sends data out of the property
                return morderDate;
            }
            set
            {
                //this line of code allows data into the property
                morderDate = value;
            }
        }


        //private data member for the order id property
        private Int32 morderId;
        //orderID public property
        public Int32 OrderID
        {
            get
            {
                //this line of code sends data out of the property
                return morderId;
            }
            set
            {
                //this line of code allows data into the property
                morderId = value;
            }
        }


        //private data member for the price property
        private double morderAmount;

        public bool mOrderStatus { get; private set; }

        //county no public property
        public double OrderAmount
        {
            get
            {
                //this line of code sends data out of the property
                return morderAmount;
            }
            set
            {
                //this line of code allows data into the property
                morderAmount = value;
            }
        }

        //private data member for the order description property
        private string morderDescription;
        //house no public property
        public string OrderDescription
        {
            get
            {
                //this line of code sends data out of the property
                return morderDescription;
            }
            set
            {
                //this line of code allows data into the property
                morderDescription = value;
            }
        }


        private string mshippingAddress;
        //house no public property
        public string ShippingAddress
        {
            get
            {
                //this line of code sends data out of the property
                return mshippingAddress;
            }
            set
            {
                //this line of code allows data into the property
                mshippingAddress = value;
            }
        }


        //private data member for the order quantity property
        private Int32 morderQuantity;


        //orderQuantity public property
        public Int32 OrderQuantity
        {
            get
            {
                //this line of code send data out of the property
                return morderQuantity;
            }

            set
            {
                //this line of code allows data into the property
                morderQuantity = value;
            }
        }


        

        public bool Find(int OrderID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the order id to search for
            DB.AddParameter("@OrderID", OrderID);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderID");
            //if one recode is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                morderId = Convert.ToInt32(DB.DataTable.Rows[0]["orderId"]);
                morderQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["orderQuatity"]);
                morderDescription = Convert.ToString(DB.DataTable.Rows[0]["orderDescription"]);
                mshippingAddress = Convert.ToString(DB.DataTable.Rows[0]["shippingAddress"]);
                morderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["orderDate"]);
                morderAmount = Convert.ToDouble(DB.DataTable.Rows[0]["orderAmount"]);
                mOrderStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["orderStatus"]);
                //return that everything worked OK
                return true;
            }
            else
            {
                //return false indicating there is a problem
                return false;
            }


            public string Valid(string orderId, string orderDate, string orderStatus, string orderAmount, string orderQuantity, string orderDescription)
            {
                //create a string variable to store the error
                String Error = "";
                //if the orderId is blank
                if (orderId.Length == 0)
                {
                    //record the error
                    Error = Error + "The order id may not be blank : ";
                }
                //if the order id is greater than 10 characters
                if (orderId.Length > 10)
                {
                    //record the error
                    Error = Error + "The order id must be less than 10 characters : ";
                }
                //return any error messages
                return "";
            }

        }

        public string Valid(string orderId, string orderDate, string orderStatus, string orderAmount, string orderQuantity, string orderDescription)
        {
            throw new NotImplementedException();
        }
    }
}

