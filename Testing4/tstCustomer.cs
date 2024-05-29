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

        public void DateAddedPropertyOk()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnCustomer.DateAdded, TestData);
        }

        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            int TestData = 1;
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
            string TestData = "Hardy";
            //assign the data to the property
            AnCustomer.CustomerId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerId, TestData);
        }

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

        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustome();
            //create a booleoan variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            int CustomerId = 1;
            //invoke the method 
            Found = AnCustomer.Find(CustomerId);
            //test to see if the result is true 
            Assert.IsTrue(Found);
        }

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
            if (AnCustomer.CustomerId !=1)
            {
                OK = false; 
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);  
        }

        public void TestCustomerFirstNameFound()
        {
            //create an instance od the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search 
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            string CustomerFirstName = "frankie";
            //invoke the method 
            Found = AnCustomer.Find(CustomerId);
            // check CustomerId
            if (AnCustomer.CustomerId != "frankie")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        public void TestCustomerLastNameFound()
        {
            //create an instance od the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search 
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            string CustomerLastName = "Hardy";
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

        public void TestCustomerDateOfBirthFound()
        {
            //create an instance od the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search 
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            string CustomerDateOfBirth = "18/06/1995";
            //invoke the method 
            Found = AnCustomer.Find(CustomerId);
            // check CustomerId
            if (AnCustomer.CustomerDateOfBirth != "18/06/1995" )
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

       

        public void TestDateAddedFound()
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
            if (AnCustomer.DateAdded != Covert.ToDateTime("23/12/2022"))
            {
                OK=false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

    }



}
