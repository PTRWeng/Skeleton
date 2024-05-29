using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Testing3
{
    [TestClass]
    public class tstOrder
    {       
        [TestMethod]
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
            AnOrder.orderStatus = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnOrder.orderStatus, TestData);
        }
        [TestMethod]
            
        public void DatePropertyOK()
        {
             //create an instance of the class we want to create
             clsOrder AnOrder = new clsOrder();
             //create some test data to assign to the property
             DateTime TestData = DateTime.Now.Date;
             //assign the data to the property
             AnOrder.orderDate = TestData;
             //test to see that the two values are the same
             Assert.AreEqual(AnOrder.orderDate, TestData);
        }

        [TestMethod]

        public void IdPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.orderId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.orderId, TestData);
        }


        [TestMethod]

        public void AmountPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            double TestData = 13;
            //assign the data to the property
            AnOrder.orderAmount = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.orderAmount, TestData);
        }

        [TestMethod]

        public void QuantityPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 2;
            //assign the data to the property
            AnOrder.orderQuantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.orderQuantity, TestData);
        }

        [TestMethod]

        public void AddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "25 grasmere street";
            //assign the data to the property
            AnOrder.shippingAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.shippingAddress, TestData);
        }

        [TestMethod]

        public void DescriptionPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "Call Of Duty";
            //assign the data to the property
            AnOrder.orderDescription = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.orderDescription, TestData);
        }



        /******************FIND METHOD TEST******************/



        [TestMethod]
        public void FindMeMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 orderId = 1;
            //invoke the method
            Found = AnOrder.Find(orderId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }


        [TestMethod]
        public void TestorderIdFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int orderId = 1;
            //invoke the method
            Found = AnOrder.Find(orderId);
            //check the order ID
            if (AnOrder.orderId != 1)
            {
                OK = false;
            }
            //test to see that result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestorderDateFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 orderId = 1;
            //invoke the method
            Found = AnOrder.Find(orderId);
            //check the release date property
            if (AnOrder.orderDate != Convert.ToDateTime("30/04/2024"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestorderStatusFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 orderId = 1;
            //invoke the method
            Found = AnOrder.Find(orderId);
            //check the availble property
            if (AnOrder.orderStatus != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestorderAmountFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 orderId = 1;
            //invoke the method
            Found = AnOrder.Find(orderId);
            //check the game price property
            if (AnOrder.orderAmount != 13)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestorderQuantityFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 orderId = 1;
            //invoke the method
            Found = AnOrder.Find(orderId);
            //check the game price property
            if (AnOrder.orderQuantity != 2)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestshippingAddressFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 orderId = 1;
            //invoke the method
            Found = AnOrder.Find(orderId);
            //check the game price property
            if (AnOrder.shippingAddress != "25 grasmere street")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestorderDescriptionFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 orderId = 1;
            //invoke the method
            Found = AnOrder.Find(orderId);
            //check the game description property
            if (AnOrder.orderDescription != "The Last Of Us")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        //good test data
        //create some test data to pass the method
        string orderId = "1";
        string orderQuantity = "2";
        string orderDescription = "The Last Of Us";
        string orderAmount = "13";
        string orderDate = "30/04/2024";

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //invoke the method
            Error = AnOrder.Valid(orderId, orderQuantity, orderDescription, orderAmount, orderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void orderIdMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string orderId = ""; //this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(orderId, orderQuantity, orderDescription, orderAmount, orderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void orderIdMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string orderId = "a"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(orderId, orderQuantity, orderDescription, orderAmount, orderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void orderIdMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string orderId = "aa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(orderId, orderQuantity, orderDescription, orderAmount, orderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void orderIdMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string orderId = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(orderId, orderQuantity, orderDescription, orderAmount, orderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void orderIdMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string orderId = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(orderId, orderQuantity, orderDescription, orderAmount, orderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void orderIdMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string orderId = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(orderId, orderQuantity, orderDescription, orderAmount, orderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void orderIdMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string orderId = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should fail
            //invoke the method
            Error = AnOrder.Valid(orderId, orderDescription, orderQuantity, orderAmount, orderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void orderIdExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string orderId = "";
            orderId = orderId.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnOrder.Valid(orderId, orderQuantity, orderDescription, orderAmount, orderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

    }
}

    

