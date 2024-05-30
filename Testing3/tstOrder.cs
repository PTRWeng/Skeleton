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
            Error = AnOrder.Valid(orderQuantity, orderDescription, orderAmount, orderDate, shippingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void orderDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string orderDate = ""; //this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(orderQuantity, orderDescription, orderAmount, orderDate, shippingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void orderDateMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string orderDate = "a"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(orderQuantity, orderDescription, orderAmount, orderDate, shippingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void orderDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string orderDate = "aa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(orderQuantity, orderDescription, orderAmount, orderDate, shippingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void orderDateMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string orderDate = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(orderQuantity, orderDescription, orderAmount, orderDate, shippingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void orderDateMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string orderDate = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(orderQuantity, orderDescription, orderAmount, orderDate, shippingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void orderDateMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string orderDate = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(orderQuantity, orderDescription, orderAmount, orderDate, shippingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void orderDateMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string orderDate = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should fail
            //invoke the method
            Error = AnOrder.Valid(orderDescription, orderQuantity, orderAmount, orderDate, shippingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void orderDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string orderDate = "";
            orderDate = orderDate.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnOrder.Valid(orderQuantity, orderDescription, orderAmount, orderDate, shippingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void orderAmountMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string orderAmount = ""; //this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(orderQuantity, orderDescription, orderAmount, orderDate, shippingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void orderAmountMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string orderAmount = "a"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(orderQuantity, orderDescription, orderAmount, orderDate, shippingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void orderAmountMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string orderAmount = "aa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(orderQuantity, orderDescription, orderAmount, orderDate, shippingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void orderAmountMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string orderAmount = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(orderQuantity, orderDescription, orderAmount, orderDate, shippingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void orderAmountMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string orderAmount = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(orderQuantity, orderDescription, orderAmount, orderDate, shippingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void orderAmountMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string orderAmount = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(orderQuantity, orderDescription, orderAmount, orderDate, shippingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void orderAmountMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string orderAmount = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should fail
            //invoke the method
            Error = AnOrder.Valid(orderDescription, orderQuantity, orderAmount, orderDate, shippingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void orderAmountExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string orderAmount = "";
            orderAmount = orderAmount.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnOrder.Valid(orderQuantity, orderDescription, orderAmount, orderDate, shippingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void orderQuantityMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string orderQuantity = ""; //this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(orderQuantity, orderDescription, orderAmount, orderDate, shippingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void orderQuantityMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string orderQuantity = "a"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(orderQuantity, orderDescription, orderAmount, orderDate, shippingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void orderQuantityMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string orderQuantity = "aa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(orderQuantity, orderDescription, orderAmount, orderDate, shippingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void orderQuantityMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string orderQuantity = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(orderQuantity, orderDescription, orderAmount, orderDate, shippingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void orderQuantityMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string orderQuantity = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(orderQuantity, orderDescription, orderAmount, orderDate, shippingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void orderQuantityMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string orderQuantity = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(orderQuantity, orderDescription, orderAmount, orderDate, shippingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void orderQuantityMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string orderQuantity = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should fail
            //invoke the method
            Error = AnOrder.Valid(orderDescription, orderQuantity, orderAmount, orderDate, shippingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void orderQuantityExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string orderQuantity = "";
            orderQuantity = orderQuantity.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnOrder.Valid(orderQuantity, orderDescription, orderAmount, orderDate, shippingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void orderDescriptionMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string orderDescription = ""; //this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(orderQuantity, orderDescription, orderAmount, orderDate, shippingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void orderDescriptionMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string orderDescription = "a"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(orderQuantity, orderDescription, orderAmount, orderDate, shippingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void orderDescriptionMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string orderDescription = "aa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(orderQuantity, orderDescription, orderAmount, orderDate, shippingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void orderDescriptionMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string orderDescription = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(orderQuantity, orderDescription, orderAmount, orderDate, shippingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void orderDescriptionMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string orderDescription = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(orderQuantity, orderDescription, orderAmount, orderDate, shippingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void orderDescriptionMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string orderDescription = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(orderQuantity, orderDescription, orderAmount, orderDate, shippingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void orderDescriptionMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string orderDescription = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should fail
            //invoke the method
            Error = AnOrder.Valid(orderDescription, orderQuantity, orderAmount, orderDate, shippingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void orderDescriptionExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string orderDescription = "";
            orderDescription = orderDescription.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnOrder.Valid(orderQuantity, orderDescription, orderAmount, orderDate, shippingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void shippingAddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string shippingAddress = ""; //this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(orderQuantity, orderDescription, orderAmount, orderDate, shippingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void shippingAddressMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string shippingAddress = "a"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(orderQuantity, orderDescription, orderAmount, orderDate, shippingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void shippingAddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string shippingAddress = "aa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(orderQuantity, orderDescription, orderAmount, orderDate, shippingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void shippingAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string shippingAddress = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(orderQuantity, orderDescription, orderAmount, orderDate, shippingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void shippingAddressMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string shippingAddress = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(orderQuantity, orderDescription, orderAmount, orderDate, shippingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void shippingAddressMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string shippingAddress = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(orderQuantity, orderDescription, orderAmount, orderDate, shippingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void shippingAddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string shippingAddress = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should fail
            //invoke the method
            Error = AnOrder.Valid(orderDescription, orderQuantity, orderAmount, orderDate, shippingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void shippingAddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string shippingAddress = "";
            shippingAddress = shippingAddress.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnOrder.Valid(orderQuantity, orderDescription, orderAmount, orderDate, shippingAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
