using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.Remoting.Messaging;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {

        [TestMethod]
        public void InstanceOK()
        {
            clsStaff AStaff = new clsStaff();
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void StaffIDPropertyOk()
        {
            clsStaff AStaff = new clsStaff();
            int TestData = 1;
            AStaff.StaffID = TestData;
            Assert.AreEqual(AStaff.StaffID, TestData);

        }

        [TestMethod]
        public void StaffFirstNamePropertyOk()
        {
            clsStaff AStaff = new clsStaff();
            string TestData = "John";
            AStaff.StaffFirstName = TestData;
            Assert.AreEqual(AStaff.StaffFirstName, TestData);
        }
        [TestMethod]
        public void StaffLastNamePropertyOk()
        {
            clsStaff AStaff = new clsStaff();
            string TestData = "Wick";
            AStaff.StaffLastName = TestData;
            Assert.AreEqual(AStaff.StaffLastName, TestData);
        }
        [TestMethod]
        public void StaffDateofBirthPropertyOk()
        {
            clsStaff AStaff = new clsStaff();
            DateTime TestData = DateTime.Now.Date;
            AStaff.StaffDateofBirth = TestData;
            Assert.AreEqual(AStaff.StaffDateofBirth, TestData);
        }
        [TestMethod]
        public void StaffNumberPropertyOk()
        {
            clsStaff AStaff = new clsStaff();
            string TestData = "5";

            AStaff.StaffNumber = TestData;
            Assert.AreEqual(AStaff.StaffNumber, TestData);
        }
        [TestMethod]
        public void StaffAddressPropertyOk()
        {
            clsStaff AStaff = new clsStaff();
            String TestData = "2";
            AStaff.StaffAddress = TestData;
            Assert.AreEqual(AStaff.StaffAddress, TestData);
        }
        [TestMethod]
        public void StaffEmailPropertyOk()
        {
            clsStaff AStaff = new clsStaff();
            string TestData = "John1@gmail.com";
            AStaff.StaffEmail = TestData;
            Assert.AreEqual(AStaff.StaffEmail, TestData);
        }

        [TestMethod]

        public void Find()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Int32 StaffID = 6;
            Found = AStaff.Find(StaffID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffIDFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 StaffID = 6;

            Found = AStaff.Find(StaffID);
            if (AStaff.StaffID != 6)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestStaffFirstNameFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 StaffID = 6;

            Found = AStaff.Find(StaffID);
            if (AStaff.StaffFirstName != "Wick")
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestStaffLastNameFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 StaffID = 6;

            Found = AStaff.Find(StaffID);
            if (AStaff.StaffLastName != "John")
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestDateofBirthFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 StaffID = 6;

            Found = AStaff.Find(StaffID);
            if (AStaff.StaffDateofBirth != DateTime.Now.Date)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestStaffNumberFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 StaffID = 6;

            Found = AStaff.Find(StaffID);
            if (AStaff.StaffNumber != "0111")
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }


        [TestMethod]
        public void TestStaffAddressFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 StaffID = 6;

            Found = AStaff.Find(StaffID);
            if (AStaff.StaffAddress != "LE7")
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestStaffEmailFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 StaffID = 6;

            Found = AStaff.Find(StaffID);
            if (AStaff.StaffEmail != "Hamza12@gmail.com")
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }
    }
}
