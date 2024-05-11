using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {

        [TestMethod]
        public void TestMethod1()
        {
            clsStaff AStaff = new clsStaff();
            Assert.IsNotNull(AStaff);

        }
        [TestMethod]
        public void ActivePropertyOk()
        {
            clsStaff AStaff = new clsStaff();
            Boolean TestData = true;
            AStaff.Active = TestData;
            Assert.AreEqual(AStaff.Active, TestData);




        }
        [TestMethod]
        public void StaffIDPropertyNotOk() 
        {
            clsStaff AStaff = new clsStaff();
            int TestData = 1;
            AStaff.StaffID = TestData;
            Assert.AreEqual(AStaff.StaffID, TestData);

        }
        [TestMethod]
        public void StaffFirstNamePropertyNotOk() 
        {
            clsStaff AStaff = new clsStaff();
            string TestData = "John";
            AStaff.StaffFirstName = TestData; 
            Assert.AreEqual(AStaff.StaffFirstName, TestData);
        }
        [TestMethod]
        public void StaffLastNamePropertyNotOk()
        {
            clsStaff AStaff = new clsStaff();
            string TestData = "Wick";
            AStaff.StaffLastName = TestData;
            Assert.AreEqual(AStaff.StaffLastName, TestData);
        }
        [TestMethod]
        public void StaffDateofBirthPropertyNotOk()
        {
            clsStaff AStaff = new clsStaff();
            DateTime TestData = DateTime.Now.Date;
            AStaff.StaffDateofBirth= TestData;
            Assert.AreEqual(AStaff.StaffDateofBirth, TestData);
        }
        [TestMethod]
        public void StaffNumberPropertyNotOk()
        {
            clsStaff AStaff = new clsStaff();
            string TestData = "5";

            AStaff.StaffNumber= TestData;
            Assert.AreEqual(AStaff.StaffNumber, TestData);
        }
        [TestMethod]
        public void StaffAddressPropertyNotOk()
        {
            clsStaff AStaff = new clsStaff();
            Int32 TestData = 1;
            AStaff.StaffAddress = TestData;
            Assert.AreEqual(AStaff.StaffAddress, TestData);
        }
        [TestMethod]
        public void StaffEmailPropertyNotOk()
        {
            clsStaff AStaff = new clsStaff();
            string TestData = "John1@gmail.com";
            AStaff.StaffEmail = TestData;
            Assert.AreEqual(AStaff.StaffEmail, TestData);
        }

    }
}
