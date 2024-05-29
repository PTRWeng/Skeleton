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
            AllOrder.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrder.Count, TestList.Count);
        }

        

        

    }
}

