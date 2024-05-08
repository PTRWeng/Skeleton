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
            AnOrder.Active = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnOrder.Active, TestData);
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
            int TestData = 1;
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
            decimal TestData = 13;
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
            int TestData = 2;
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

    }
}

    

