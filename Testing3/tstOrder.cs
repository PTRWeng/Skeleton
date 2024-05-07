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
            AnOrder.Active = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnOrder.Active, TestData);
        }
            [TestMethod]
            
            public void DateAddedPropertyOK()
            {
             //create an instance of the class we want to create
               clsOrder AnOrder = new clsOrder();
                //create some test data to assign to the property
                DateTime TestData = DateTime.Now.Date;
                //assign the data to the property
                AnOrder.DateAdded = TestData;
                //test to see that the two values are the same
                Assert.AreEqual(AnOrder.DateAdded, TestData);
            }
        

    }
}

    

