using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //test to see that is exists
            Assert.IsNotNull(AllOrder);
        }


        [TestMethod]
        public void OrderListOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create some test data needs to be a list of objects
            //in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //Add an Item to the List
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.orderStatus = true;
            TestItem.orderId = 1;
            TestItem.orderDescription = "The Last Of Us";
            TestItem.orderQuantity = 2;
            TestItem.orderDate = DateTime.Now;
            TestItem.orderAmount = 13;
            //add the time to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrder.orderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrder.orderList, TestList);
        }

        [TestMethod]
        public void ThisOrderpropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create some test data to assign to the property
            clsOrder TestItem = new clsOrder();
            //set the properties of the test object
            TestItem.orderStatus = true;
            TestItem.orderId = 1;
            TestItem.orderDescription = "The Last Of Us";
            TestItem.orderQuantity = 2;
            TestItem.orderDate = DateTime.Now;
            TestItem.orderAmount = 13;
            //assign the data to the property
            AllOrder.ThisOrder = TestItem;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrder.ThisOrder, TestItem);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //Add an Item to the List
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.orderStatus = true;
            TestItem.orderId = 1;
            TestItem.orderDescription = "The Last Of Us";
            TestItem.orderQuantity = 2;
            TestItem.orderDate = DateTime.Now;
            TestItem.orderAmount = 13;
            //add the time to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrder.orderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrder.Count, TestList.Count);
        }


        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.orderStatus = true;
            TestItem.orderId = 1;
            TestItem.orderDescription = "The Last Of Us";
            TestItem.orderQuantity = 2;
            TestItem.orderDate = DateTime.Now;
            TestItem.orderAmount = 13;
            TestItem.shippingAddress = "25 grasmere street";
            //set Thisorder to the test data
            AllOrder.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrder.Add();
            //set the primary key of the test data
            TestItem.orderId = PrimaryKey;
            //find the record
            AllOrder.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrder.ThisOrder, TestItem);
        }



        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.orderStatus = true;
            TestItem.orderId = 1;
            TestItem.orderDescription = "The Last Of Us";
            TestItem.orderQuantity = 2;
            TestItem.orderDate = DateTime.Now;
            TestItem.orderAmount = 13;
            TestItem.shippingAddress = "25 grasmere street";
            //set Thisorder to the test data
            AllOrder.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrder.Add();
            //set the primary key of the test data
            TestItem.orderId = PrimaryKey;
            //modify the test record
            TestItem.orderStatus = true;
            TestItem.orderId = 1;
            TestItem.orderDescription = "The Last Of Us";
            TestItem.orderQuantity = 1;
            TestItem.orderDate = DateTime.Now;
            TestItem.orderAmount = 15;
            TestItem.shippingAddress = "25 grasmere street";
            //set the record based on the new test data
            AllOrder.ThisOrder = TestItem;
            //update the record
            AllOrder.Update();
            //find the record
            AllOrder.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrder.ThisOrder, TestItem);
        }


        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.orderStatus = true;
            TestItem.orderId = 1;
            TestItem.orderDescription = "The Last Of Us";
            TestItem.orderQuantity = 2;
            TestItem.orderDate = DateTime.Now;
            TestItem.orderAmount = 13;
            TestItem.shippingAddress = "25 grasmere street";
            //set Thisorder to the test data
            AllOrder.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrder.Add();
            //set the primary key of the test data
            TestItem.orderId = PrimaryKey;
            //find the record
            AllOrder.ThisOrder.Find(PrimaryKey);
            //delete the record
            AllOrder.Delete();
            //now find the record
            Boolean Found = AllOrder.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.IsFalse(Found);
        }


        [TestMethod]
        public void ReportByorderDescriptionMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create an instance of the filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //apply a blank string (should return all records);
            FilteredOrders.ReportByorderDescription("");
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByorderDescriptionNoneFound()
        {
            //create an instance of the class we want to create
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //apply a order title that doesn't exist
            FilteredOrders.ReportByorderDescription("yyyyyyy");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByorderDescriptionTestDataFound()
        {
            //create an instance of the filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //apply a order title that doesn't exist
            FilteredOrders.ReportByorderDescription("xxxxxx");
            //variable to store the outcome
            Boolean OK = true;
            //check that the correct number of records are found
            if (FilteredOrders.Count == 2)
            {
                //check to see that the first record in 26
                if (FilteredOrders.orderList[0].orderId != 26)
                {
                    OK = false;
                }
                //check to see that the first record is 28
                if (FilteredOrders.orderList[1].orderId != 28)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no record
            Assert.IsFalse(OK);
        }
    }
}

