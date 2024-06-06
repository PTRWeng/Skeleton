using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Linq.Expressions;

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

        public void PlacedOrderPropertyOk()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnCustomer.PlacedOrder = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnCustomer.PlacedOrder, TestData);
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
            //assign the data to the property
            AnCustomer.CustomerDateOfBirth = TestData;
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
            AnCustomer.CustomerEmailAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerEmailAddress, TestData);
        }

        [TestMethod]
        public void CustomerFisrtNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "frankie";
            //assign the data to the property
            AnCustomer.CustomerFirstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerFirstName, TestData);
        }
        [TestMethod]

        public void CustomerLastNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Hardy";
            //assign the data to the property
            AnCustomer.CustomerLastName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerLastName, TestData);
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
            Assert.AreNotEqual(AnCustomer.CustomerId, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a booleoan variable to store the results of the validation
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
            Assert.IsFalse(OK);
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
            if (AnCustomer.CustomerLastName != "hardy")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsFalse(OK);
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
        string CustomerFirstName = "frankie";
        string CustomerLastName = "hardy";
        string CustomerEmailAddress = "FrankieHardy@gmail.com";
        string CustomerDateOfBirth = "18/06/1995";
        string CustomerAddress = "18 Madeley Road, Church Crookham,GU52 6AT";

        [TestMethod]

        public void ValidMethodOK()
        {
            //create a instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store an error message 
            String Error = "";
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerEmailAddress, CustomerAddress, CustomerDateOfBirth);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerFirstNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerFirstName = ""; //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerEmailAddress, CustomerAddress, CustomerDateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerFirstNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerFirstName = "a"; //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerEmailAddress, CustomerAddress, CustomerDateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerFirstNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerFirstName = "aa"; //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerEmailAddress, CustomerAddress, CustomerDateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerFirstNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerFirstName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerEmailAddress, CustomerAddress, CustomerDateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerFirstNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerFirstName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerEmailAddress, CustomerAddress, CustomerDateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerFirstNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerFirstName = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerEmailAddress, CustomerAddress, CustomerDateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerFirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerFirstName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerEmailAddress, CustomerAddress, CustomerDateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerFirstNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerFirstName = ""; //this should trigger an error
            CustomerFirstName = CustomerFirstName.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerEmailAddress, CustomerAddress, CustomerDateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerLastNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerLastName = ""; //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerEmailAddress, CustomerAddress, CustomerDateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerLastNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerLastName = "a"; //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerEmailAddress, CustomerAddress, CustomerDateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerLastNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerLastName = "aa"; //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerEmailAddress, CustomerAddress, CustomerDateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerLastNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerLastName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerEmailAddress, CustomerAddress, CustomerDateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerLastNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerLastName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerEmailAddress, CustomerAddress, CustomerDateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerLastNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerLastName = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerEmailAddress, CustomerAddress, CustomerDateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerLastNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerLastName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerEmailAddress, CustomerAddress, CustomerDateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerLastNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerLastName = ""; //this should trigger an error
            CustomerLastName = CustomerLastName.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerEmailAddress, CustomerAddress, CustomerDateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerEmailAddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerEmailAddress = ""; //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerEmailAddress, CustomerAddress, CustomerDateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerEmailAddressMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerEmailAddress = "a"; //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerEmailAddress, CustomerAddress, CustomerDateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerEmailAddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerEmailAddress = "aa"; //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerEmailAddress, CustomerAddress, CustomerDateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerEmailAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerEmailAddress = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerEmailAddress, CustomerAddress, CustomerDateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerEmailAddressMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerEmailAddress = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerEmailAddress, CustomerAddress, CustomerDateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerEmailAddressMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerEmailAddress = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerEmailAddress, CustomerAddress, CustomerDateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerEmailAddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerEmailAddress = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerEmailAddress, CustomerAddress, CustomerDateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerEmailAddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerEmailAddress = ""; //this should trigger an error
            CustomerEmailAddress = CustomerEmailAddress.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerEmailAddress, CustomerAddress, CustomerDateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerAddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerAddress = ""; //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerEmailAddress, CustomerAddress, CustomerDateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerAddressMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerAddress = "a"; //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerEmailAddress, CustomerAddress, CustomerDateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerAddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerAddress = "aa"; //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerEmailAddress, CustomerAddress, CustomerDateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerAddress = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerEmailAddress, CustomerAddress, CustomerDateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerAddressMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerAddress = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerEmailAddress, CustomerAddress, CustomerDateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerAddressMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerAddress = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerEmailAddress, CustomerAddress, CustomerDateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerAddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerAddress = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerEmailAddress, CustomerAddress, CustomerDateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerAddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerAddress = ""; //this should trigger an error
            CustomerAddress = CustomerAddress.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerEmailAddress, CustomerAddress, CustomerDateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerDateOfBirthMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerDateOfBirth = ""; //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerEmailAddress, CustomerAddress, CustomerDateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerDateOfBirthMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerDateOfBirth = "a"; //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerEmailAddress, CustomerAddress, CustomerDateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerDateOfBirthMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerDateOfBirth = "aa"; //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerEmailAddress, CustomerAddress, CustomerDateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerDateOfBirthMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerDateOfBirth = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerEmailAddress, CustomerAddress, CustomerDateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerDateOfBirthMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerDateOfBirth = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerEmailAddress, CustomerAddress, CustomerDateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerDateOfBirthMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerDateOfBirth = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerEmailAddress, CustomerAddress, CustomerDateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerDateOfBirthMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerDateOfBirth = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerEmailAddress, CustomerAddress, CustomerDateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerDateOfBirthExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerDateOfBirth = ""; //this should trigger an error
            CustomerDateOfBirth = CustomerDateOfBirth.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerEmailAddress, CustomerAddress, CustomerDateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

    }
}
