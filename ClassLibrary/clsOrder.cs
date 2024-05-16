﻿using System;

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
        public DateTime orderDate
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
        public Int32 orderID
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

        public bool morderStatus { get; private set; }

        //county no public property
        public double orderAmount
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
        public string orderDescription
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
        public string shippingAddress
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
        public Int32 orderQuantity
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

        public object CustomerDateOfBirth { get; set; }

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
                morderStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["orderStatus"]);
                //return that everything worked OK
                return true;
            }
            else
            {
                //return false indicating there is a problem
                return false;
            }

        }
    }
}

