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
        private object varchar;

        public int Id { get; private set; }
        public decimal Amount { get; private set; }
        public int Quantity { get; private set; }
        public char Address { get; private set; }
        public char Description { get; private set; }

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
             AnOrder.Date = TestData;
             //test to see that the two values are the same
             Assert.AreEqual(AnOrder.Date, TestData);
        }

        [TestMethod]

        public void IdPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            int TestData = Id;
            //assign the data to the property
            AnOrder.Id = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Id, TestData);
        }

        [TestMethod]

        public void AmountPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            decimal TestData = Amount;
            //assign the data to the property
            AnOrder.Amount = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Amount, TestData);
        }

        [TestMethod]

        public void QuantityPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            int TestData = Quantity;
            //assign the data to the property
            AnOrder.Quantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Quantity, TestData);
        }

        [TestMethod]

        public void AddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            char TestData = Address;
            //assign the data to the property
            AnOrder.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Address, TestData);
        }

        [TestMethod]

        public void DescriptionPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            char TestData = Description;
            //assign the data to the property
            AnOrder.Description = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Description, TestData);
        }

    }
}

    

