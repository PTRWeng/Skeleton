using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing4
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //test to see that is exists
            Assert.IsNotNull(AllCustomer);
        }


        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data needs to be a list of objects
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //Add an Item to the List
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.PlacedOrder = true;
            TestItem.CustomerFirstName = "Franky";
            TestItem.CustomerLastName = "Hardy";
            TestItem.CustomerDateOfBirth = DateTime.Now;
            TestItem.CustomerAddress = "18 Madeley Road, Church Crookham,GU52 6AT";
            TestItem.CustomerEmailAddress = "Frankyhardy@gmail.com";
            //add the time to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomer.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomer.CustomerList, TestList);
        }

        [TestMethod]
        public void ThisCustomerpropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestItem = new clsCustomer();
            //set the properties of the test object
            TestItem.PlacedOrder = true;
            TestItem.CustomerFirstName = "Franky";
            TestItem.CustomerLastName = "Hardy";
            TestItem.CustomerDateOfBirth = DateTime.Now;
            TestItem.CustomerAddress = "18 Madeley Road, Church Crookham,GU52 6AT";
            TestItem.CustomerEmailAddress = "Frankyhardy@gmail.com";
            //assign the data to the property
            AllCustomer.ThisCustomer = TestItem;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomer.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //Add an Item to the List
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.PlacedOrder = true;
            TestItem.CustomerFirstName = "Franky";
            TestItem.CustomerLastName = "Hardy";
            TestItem.CustomerDateOfBirth = DateTime.Now;
            TestItem.CustomerAddress = "18 Madeley Road, Church Crookham,GU52 6AT";
            TestItem.CustomerEmailAddress = "Frankyhardy@gmail.com";
            //add the time to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomer.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomer.Count, TestList.Count);
        }


        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.PlacedOrder = true;
            TestItem.CustomerFirstName = "Franky";
            TestItem.CustomerLastName = "Hardy";
            TestItem.CustomerDateOfBirth = DateTime.Now;
            TestItem.CustomerAddress = "18 Madeley Road, Church Crookham,GU52 6AT";
            TestItem.CustomerEmailAddress = "Frankyhardy@gmail.com";
            //set ThisCustomer to the test data
            AllCustomer.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomer.Add();
            //set the primary key of the test data
            TestItem.CustomerId = PrimaryKey;
            //find the record
            AllCustomer.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomer.ThisCustomer, TestItem);
        }



        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.PlacedOrder = true;
            TestItem.CustomerFirstName = "Franky";
            TestItem.CustomerLastName = "Hardy";
            TestItem.CustomerDateOfBirth = DateTime.Now;
            TestItem.CustomerAddress = "18 Madeley Road, Church Crookham,GU52 6AT";
            TestItem.CustomerEmailAddress = "Frankyhardy@gmail.com";
            //set ThisCustomer to the test data
            AllCustomer.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomer.Add();
            //set the primary key of the test data
            TestItem.CustomerId = PrimaryKey;
            //modify the test record
            TestItem.PlacedOrder = true;
            TestItem.CustomerFirstName = "Franky";
            TestItem.CustomerLastName = "Hardy";
            TestItem.CustomerDateOfBirth = DateTime.Now;
            TestItem.CustomerAddress = "18 Madeley Road, Church Crookham,GU52 6AT";
            TestItem.CustomerEmailAddress = "Frankyhardy@gmail.com";
            //set the record based on the new test data
            AllCustomer.ThisCustomer = TestItem;
            //update the record
            AllCustomer.Update();
            //find the record
            AllCustomer.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomer.ThisCustomer, TestItem);
        }


        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerId = 1;
            TestItem.PlacedOrder = true;
            TestItem.CustomerFirstName = "Franky";
            TestItem.CustomerLastName = "Hardy";
            TestItem.CustomerDateOfBirth = DateTime.Now;
            TestItem.CustomerAddress = "18 Madeley Road, Church Crookham,GU52 6AT";
            TestItem.CustomerEmailAddress = "Frankyhardy@gmail.com";
            //set ThisCustomer to the test data
            AllCustomer.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomer.Add();
            //set the primary key of the test data
            TestItem.CustomerId = PrimaryKey;
            //find the record
            AllCustomer.ThisCustomer.Find(PrimaryKey);
            //delete the record
            AllCustomer.Delete();
            //now find the record
            Boolean Found = AllCustomer.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.IsFalse(Found);
        }


        [TestMethod]
        public void ReportByCustomerFirstNameMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a blank string (should return all records);
            FilteredCustomers.ReportByCustomerFirstName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByCustomerFirstNameNoneFound()
        {
            //create an instance of the class we want to create
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a Customer title that doesn't exist
            FilteredCustomers.ReportByCustomerFirstName("yyyyyyy");
            //test to see that there are no records
            Assert.AreNotEqual(0, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByCustomerFirstNameTestDataFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a Customer title that doesn't exist
            FilteredCustomers.ReportByCustomerFirstName("xxxxxx");
            //variable to store the outcome
            Boolean OK = true;
            //check that the correct number of records are found
            if (FilteredCustomers.Count == 2)
            {
                //check to see that the first record in 26
                if (FilteredCustomers.CustomerList[0].CustomerId != 26)
                {
                    OK = false;
                }
                //check to see that the first record is 28
                if (FilteredCustomers.CustomerList[1].CustomerId != 28)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no record
            Assert.IsFalse(OK);
        }
    }
}

