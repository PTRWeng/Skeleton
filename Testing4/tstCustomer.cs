using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
        public void CustomerIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = 1;
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
        public void CustomerEmailAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "frankiehardy@gmail.com";
            //assign the data to the property
            AnCustomer.CustomerId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerId, TestData);
        }

        [TestMethod]
        public void CountryCodePropertyOK()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property 
            Int32 TestData = 1;
            //assign the data to the property 
            AnCustomer.CountryCode = TestData;
            //test to see that the two valus are the same
            Assert.AreEqual (AnCustomer.CountryCode, TestData);
        }

        public void CustomerFisrtNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "frankie";
            //assign the data to the property
            AnCustomer.CustomerId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerId, TestData);
        }

        public void CustomerLastNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "frankie";
            //assign the data to the property
            AnCustomer.CustomerId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerId, TestData);
        }

        public void CustomerEmailAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "frankiehardy@gmail.com";
            //assign the data to the property
            AnCustomer.CustomerId = TestData;
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
            AnCustomer.CustomerId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerId, TestData);
        }

        [TestMethod]
        public void FindMeMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            Found = AnCustomer.Find(CustomerId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIdFound()
        {
            //create an instance of the class we want to create
            clsOrder AnCustomer = new clsCustomer();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            Found = AnCustomer.Find(CustomerId);
            //check the game ID
            if (AnCustomer.CustomerId != 1)
            {
                OK = false;
            }
            //test to see that result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerFirstNameFound()
        {
            //create an instance of the class we want to create
            clsOrder AnCustomer = new clsCustomer();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            string CustomerId = 1;
            //invoke the method
            Found = AnCustomer.Find(CustomerFirstName);
            //check the game ID
            if (AnCustomer.CustomerFirstName != "frankie")
            {
                OK = false;
            }
            //test to see that result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerLastNameFound()
        {
            //create an instance of the class we want to create
            clsOrder AnCustomer = new clsCustomer();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            string CustomerId = 1;
            //invoke the method
            Found = AnCustomer.Find(CustomerLastName);
            //check the game ID
            if (AnCustomer.CustomerFirstName != "hardy")
            {
                OK = false;
            }
            //test to see that result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerEmailAdressFound()
        {
            //create an instance of the class we want to create
            clsOrder AnCustomer = new clsCustomer();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            string CustomerId = 1;
            //invoke the method
            Found = AnCustomer.Find(CustomerEmailAdress);
            //check the game ID
            if (AnCustomer.CustomerEmailAdress != "frankiehardy@gmail.com")
            {
                OK = false;
            }
            //test to see that result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerAdressFound()
        {
            //create an instance of the class we want to create
            clsOrder AnCustomer = new clsCustomer();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            string CustomerId = 1;
            //invoke the method
            Found = AnCustomer.Find(CustomerAddress);
            //check the game ID
            if (AnCustomer.CustomerAdress != "18 Madeley Road, Church Crookham,GU52 6AT")
            {
                OK = false;
            }
            //test to see that result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerDateOfBirthFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            Found = AnCustomer.Find(CustomerDateOfBirth);
            //check the release date property
            if (AnCustomer.CustomerDateOfBirth!= Convert.ToDateTime("28/03/2024"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

    }




}



