using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Testing3
{
    [TestClass]
    public class tstOrder
    {        [TestMethod]
        public void InstanceOK()
        {
            //crat an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void StatusPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property 
            AnOrder.Available = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnOrder.Available, TestData);
        }
        [TestMethod]
            
        public void DatePropertyOK()
        {
             //create an instance of the class we want to create
             clsOrder AnOrder = new clsOrder();
             //create some test data to assign to the property
             DateTime TestData = DateTime.Now.Date;
             //assign the data to the property
             AnOrder.OrderDate = TestData;
             //test to see that the two values are the same
             Assert.AreEqual(AnOrder.OrderDate, TestData);
        }

        [TestMethod]

        public void IdPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.OrderID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderID, TestData);
        }


        [TestMethod]

        public void AmountPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            double TestData = 13;
            //assign the data to the property
            AnOrder.OrderAmount = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderAmount, TestData);
        }

        [TestMethod]

        public void QuantityPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 2;
            //assign the data to the property
            AnOrder.OrderQuantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderQuantity, TestData);
        }

        [TestMethod]

        public void AddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "25 grasmere street";
            //assign the data to the property
            AnOrder.ShippingAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.ShippingAddress, TestData);
        }

        [TestMethod]

        public void DescriptionPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "Call Of Duty";
            //assign the data to the property
            AnOrder.OrderDescription = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderDescription, TestData);
        }

        [TestMethod]
        public void FindMeMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderId = 1;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }


        [TestMethod]
        public void TestOrderIDFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 6;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the game ID
            if (AnOrder.OrderID != 6)
            {
                OK = false;
            }
            //test to see that result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderDateFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 6;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the release date property
            if (AnOrder.OrderDate != Convert.ToDateTime("29/09/2023"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStatusFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 6;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the availble property
            if (AnOrder.mOrderStatus != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAmountFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 6;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the game price property
            if (AnOrder.OrderAmount != 69)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestQuantityFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 6;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the game price property
            if (AnOrder.OrderQuantity != 3)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddressFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 6;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the game price property
            if (AnOrder.ShippingAddress != "25 London Road")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDescriptionFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 6;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the game description property
            if (AnOrder.OrderDescription != "League Of Legends")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        //good test data
        //create some test data to pass the method
        String orderId = "1";
        String orderDate = DateTime.Now.ToShortDateString();
        String orderStatus = "True";
        String orderAmount = "13";
        String orderQuantity = "2";
        String orderDescription = "The Last Of Us";


        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnOrder.Valid(orderId, orderDate, orderStatus, orderAmount, orderQuantity, orderDescription);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void orderIdMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String orderId = ""; //this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(orderId, orderDate, orderStatus, orderAmount, orderQuantity, orderDescription);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void orderIdMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string orderId = "a"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(orderId, orderDate, orderStatus, orderAmount, orderQuantity, orderDescription);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void orderIdMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string orderId = "aa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(orderId, orderDate, orderStatus, orderAmount, orderQuantity, orderDescription);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void orderIdMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string orderId = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(orderId, orderDate, orderStatus, orderAmount, orderQuantity, orderDescription);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void orderIdMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string orderId = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(orderId, orderDate, orderStatus, orderAmount, orderQuantity, orderDescription);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void orderIdMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string orderId = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(orderId, orderDate, orderStatus, orderAmount, orderQuantity, orderDescription);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void orderIdMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string orderId = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should fail
            //invoke the method
            Error = AnOrder.Valid(orderId, orderDate, orderStatus, orderAmount, orderQuantity, orderDescription);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void orderIdExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string orderId = "";
            orderId = orderId.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnOrder.Valid(orderId, orderDate, orderStatus, orderAmount, orderQuantity, orderDescription);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

    }
}

    

