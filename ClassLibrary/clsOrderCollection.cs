using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        //private data member for the list
        List<clsOrder> morderlist = new List<clsOrder>();
        //private member data for thisorder
        clsOrder mThisOrder = new clsOrder();

        //public property for the order list
        public List<clsOrder> orderList
        {
            get
            {
                //return the private data
                return morderlist;
            }
            set
            {
                //set the private data
                morderlist = value;
            }
        }
        //public property for count
        public int Count
        {
            get
            {
                //retune the count of the list
                return morderlist.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        public clsOrder ThisOrder
        {
            get
            {
                //return the private data
                return mThisOrder;
            }
            set
            {
                //set the private data
                mThisOrder = value;
            }
        }

        public int Add()
        {
            //adds a record to the database based on the values of mThisorder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@orderDate", mThisOrder.orderDate);
            DB.AddParameter("@orderStatus", mThisOrder.orderStatus);
            DB.AddParameter("@orderAmount", mThisOrder.orderAmount);
            DB.AddParameter("@orderQuantity", mThisOrder.orderQuantity);
            DB.AddParameter("@shippingAddress", mThisOrder.shippingAddress);
            DB.AddParameter("@orderDescription", mThisOrder.orderDescription);
            //execute the query returning the primary kay value
            return DB.Execute("sproc_tblorder_Insert");
        }


        public void Update()
        {
            //update a record to the database based on the values of mThisorder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@orderId", mThisOrder.orderId);
            DB.AddParameter("@orderDate", mThisOrder.orderDate);
            DB.AddParameter("@orderStatus", mThisOrder.orderStatus);
            DB.AddParameter("@orderAmount", mThisOrder.orderAmount);
            DB.AddParameter("@orderQuantity", mThisOrder.orderQuantity);
            DB.AddParameter("@shippingAddress", mThisOrder.shippingAddress);
            DB.AddParameter("@orderDescription", mThisOrder.orderDescription);
            //execute the query returning the primary kay value
            DB.Execute("sproc_tblorder_Update");
        }


        public void Delete()
        {
            //deletes the record pointed to by thisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@orderId", mThisOrder.orderId);
            //execute the stored procedure
            DB.Execute("sproc_tblorder_Delete");
        }


        public void ReportByorderDescription(string orderDescription)
        {
            //filters the records based on a full or partial order Description
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //sent the orderDescription parameter to the database
            DB.AddParameter("@orderDescription", orderDescription);
            //execute the stored procedure
            DB.Execute("sproc_tblorder_FilterByorderDescription");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public clsOrderCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblorder_SelectAll");
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
            morderlist = new List<clsOrder>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank order object
                clsOrder AnOrder = new clsOrder();
                //read in the fields from the current record
                AnOrder.orderId = Convert.ToInt32(DB.DataTable.Rows[Index]["orderId"]);
                AnOrder.orderQuantity = Convert.ToInt32(DB.DataTable.Rows[Index]["orderQuantity"]);
                AnOrder.orderDescription = Convert.ToString(DB.DataTable.Rows[Index]["orderDescription"]);
                AnOrder.shippingAddress = Convert.ToString(DB.DataTable.Rows[Index]["shippingAddress"]);
                AnOrder.orderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["orderDate"]);
                AnOrder.orderAmount = Convert.ToDouble(DB.DataTable.Rows[Index]["orderAmount"]);
                AnOrder.orderStatus = Convert.ToBoolean(DB.DataTable.Rows[Index]["orderStatus"]);
                //add the record to the private data member
                morderlist.Add(AnOrder);
                //point at the next record
                Index++;
            }
        }

    }

}
