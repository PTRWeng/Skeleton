using System;
using System.IO;


namespace ClassLibrary
{
    public class clsOrder
    {
        //private data member for the status property
        private Boolean morderStatus;
        //active public property
        public bool orderStatus
        {
            get
            {
                //this line of code sends data out of the property
                return morderStatus;
            }
            set
            {
                //this line of code allows data into the property
                morderStatus = value;
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
        public int orderId
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

        //private data member for the order amount
        private double morderAmount;
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


        //private data member for the shipping address property
        private string mshippingAddress;
        //shipping address public property
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
        public int orderQuantity
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

        public static DateTime DateTemp { get; private set; }


        /****** FIND METHOD ******/


        public bool Find(int orderId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the order id to search for
            DB.AddParameter("@orderId", orderId);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByorderId");
            //if one recode is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                morderId = Convert.ToInt32(DB.DataTable.Rows[0]["orderId"]);
                morderQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["orderQuantity"]);
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

       

        
            

        public string Valid(string orderQuantity, string orderDescription, string orderAmount, string orderDate, string shippingAddress)
        {
                //create a string variable to store the error
                string Error = "";
                //if the orderId is blank
                if (orderQuantity.Length == 0)
                {
                    //record the error
                    Error = Error + "The order id may not be blank : ";
                }
                //if the order id is greater than 10 characters
                if (orderQuantity.Length > 10)
                {
                    //record the error
                    Error = Error + "The order id must be less than 10 characters : ";
                }

                try
                {
                    //copy the dateAdded value to the DateTemp variable
                    DateTemp = Convert.ToDateTime(orderDate);

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
                if (orderDescription.Length == 0)
                {
                    //record the error
                    Error = Error + "The order description may not be blank : ";
                }


                //if the order id is too long
                if (orderDescription.Length > 50)
                {
                    //record the error
                    Error = Error + "The order description must be less than 50 characters : ";
                }


                //is the order id blank
                if (orderAmount.Length == 0)
                {
                    //record the error
                    Error = Error + "The order id may not be blank : ";
                }


                //if the order id is too long
                if (orderAmount.Length > 20)
                {
                    //record the error
                    Error = Error + "The order amount must be less than 20 characters : ";
                }


                //is the order id blank
                if (orderDate.Length == 0)
                {
                    //record the error
                    Error = Error + "The order date may not be blank : ";
                }


                //if the order id is too long
                if (shippingAddress.Length > 50)
                {
                    //record the error
                    Error = Error + "The shipping address must be less than 50 characters : ";
                }


                //return any error messages
                return Error;
            }
        }
    }


