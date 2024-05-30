using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Testing4
{
    [TestClass]
    public class tstCustomer
    {
        


        [TestMethod]
        public void InstanceOK()
        {
            //crat an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(AnCustomer);
        }

        [TestMethod]

        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property 
            AnCustomer.Active = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnCustomer.Active, TestData);

        }

        [TestMethod]

        public void PlacedOrderPropertyOk(DateTime TestData)
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            //assign the data to the property
            AnCustomer.PlacedOrder = true;
            //test to see that the two values are the same 
            Assert.AreEqual(AnCustomer.PlacedOrder, true);
        }

        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnCustomer.CustomerId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerId, TestData);
        }

        [TestMethod]
        public void CustomerDateOfBirthPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the two values are the same
            Assert.AreEqual(AnCustomer.CustomerDateOfBirth, TestData);
        }

        [TestMethod]
        public void CustomerEmailAddressPropertyOK(int testData)
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "frankiehardy@gmail.com";
            //assign the data to the property
            AnCustomer.CustomerId = testData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerId, TestData);
        }

        [TestMethod]
        public void CustomerFisrtNamePropertyOK(int testData)
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "frankie";
            //assign the data to the property
            AnCustomer.CustomerId = testData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerId, TestData);
        }
        [TestMethod]

        public void CustomerLastNamePropertyOK(int testData)
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Hardy";
            //assign the data to the property
            AnCustomer.CustomerId = testData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerId, TestData);
        }
        [TestMethod]
        public void CustomerAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "18 Madeley Road, Church Crookham,GU52 6AT";
            //assign the data to the property
            AnCustomer.CustomerAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerId, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a booleoan variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            int CustomerId = 1;
            //invoke the method 
            Found = AnCustomer.Find(CustomerId);
            //test to see if the result is true 
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestCustomerIdFound()
        {
            //create an instance od the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search 
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int CustomerId = 1;
            //invoke the method 
            Found = AnCustomer.Find(CustomerId);
            // check CustomerId
            if (AnCustomer.CustomerId != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerFirstNameFound()
        {
            //create an instance od the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search 
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method 
            Found = AnCustomer.Find(CustomerId);
            // check CustomerId
            if (AnCustomer.CustomerFirstName != "frankie")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerLastNameFound()
        {
            //create an instance od the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search 
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method 
            Found = AnCustomer.Find(CustomerId);
            // check CustomerId
            if (AnCustomer.CustomerLastName != "Hardy")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerDateOfBirthFound()
        {
            //create an instance od the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search 
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method 
            Found = AnCustomer.Find(CustomerId);
            // check CustomerId
            if (AnCustomer.CustomerDateOfBirth != Convert.ToDateTime("18/06/1995"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestCustomerAddressFound()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with method
            int CustomerId = 1;
            //invoke the method
            Found = AnCustomer.Find(CustomerId);
            //check the dateAdded property
            if (AnCustomer.CustomerAddress != Convert.ToString("18 Madeley Road, Church Crookham,GU52 6AT"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        //good test data
        //create some test data to pass the method
        string CustomerFirstName = "Frankie";
        string CustomerLastName = "Hardy";
        string CustomerEmailAdress = "FrankieHardy@gmail.com";
        string CustomerDateOfBirth = DateTime.Now.ToString();
        string CustomerAddress = "428 St Saviours Road LE5 4PX";

        [TestMethod]

        public void validMethodOK()
        {
            //create a instance of the class we want to create
            clsCustomer clsCustomer = new clsCustomer();
            //string variable to store an error message 
            String Error = "";
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerEmailAdress, CustomerAddress, CustomerDateOfBirth);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }



    }
}
