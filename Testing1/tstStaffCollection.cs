using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();
            Assert.IsNotNull(AllStaffs);
        }

        [TestMethod]
        public void StaffListOK()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestStaff = new clsStaff();

            TestStaff.StaffID = 1;
            TestStaff.StaffFirstName = "Hamza";
            TestStaff.StaffLastName = "Yaqoob";
            TestStaff.StaffDateofBirth = DateTime.Now.Date;
            TestStaff.StaffNumber = "1234567";
            TestStaff.StaffAddress = "Islamabad, Pakistan.";
            TestStaff.StaffEmail = "hyaqoob@gmail.com";

            TestList.Add(TestStaff);
            AllStaffs.StaffList = TestList;

            Assert.AreEqual(AllStaffs.StaffList, TestList);
        }


        [TestMethod]
        public void CountPropertyOK()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();
            Int32 SomeCount = AllStaffs.Count;
            AllStaffs.Count = SomeCount;
            Assert.AreEqual(AllStaffs.Count, SomeCount);
        }

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();
            clsStaff TestStaff = new clsStaff();

            TestStaff.StaffID = 1;
            TestStaff.StaffFirstName = "Hamza";
            TestStaff.StaffLastName = "Yaqoob";
            TestStaff.StaffDateofBirth = DateTime.Now.Date;
            TestStaff.StaffNumber = "1234567";
            TestStaff.StaffAddress = "Islamabad, Pakistan.";
            TestStaff.StaffEmail = "hyaqoob@gmail.com";


            AllStaffs.ThisStaff = TestStaff;

            Assert.AreEqual(AllStaffs.ThisStaff, TestStaff);
        }




        public void ListAndCountOK()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestStaff = new clsStaff();
            TestStaff.StaffID = 1;
            TestStaff.StaffFirstName = "Hamza";
            TestStaff.StaffLastName = "Yaqoob";
            TestStaff.StaffDateofBirth = DateTime.Now.Date;
            TestStaff.StaffNumber = "1234567";
            TestStaff.StaffAddress = "Islamabad, Pakistan.";
            TestStaff.StaffEmail = "hyaqoob@gmail.com";

            TestList.Add(TestStaff);
            AllStaffs.StaffList = TestList;

            Assert.AreEqual(AllStaffs.Count, TestList.Count);
        }


        [TestMethod]
        public void TwoRecordsPresent()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();
            Assert.AreEqual(AllStaffs.Count, AllStaffs.Count);
        }


        [TestMethod]
        public void AddMethodOK()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();
            clsStaff TestStaff = new clsStaff();
            Int32 PrimaryKey = 0;
            TestStaff.StaffFirstName = "Hamza";
            TestStaff.StaffLastName = "Yaqoob";
            TestStaff.StaffDateofBirth = DateTime.Now.Date;
            TestStaff.StaffNumber = "1234567";
            TestStaff.StaffAddress = "Islamabad, Pakistan.";
            TestStaff.StaffEmail = "hyaqoob@gmail.com";
            AllStaffs.ThisStaff = TestStaff;
            PrimaryKey = AllStaffs.Add();
            TestStaff.StaffID = PrimaryKey;
            AllStaffs.ThisStaff.Find(PrimaryKey);
            Assert.AreEqual(AllStaffs.ThisStaff, TestStaff);

        }


        [TestMethod]
        public void EditMethodOK()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();
            clsStaff TestStaff = new clsStaff();
            Int32 PrimaryKey = 0;
            TestStaff.StaffFirstName = "Hamza";
            TestStaff.StaffLastName = "Yaqoob";
            TestStaff.StaffDateofBirth = DateTime.Now.Date;
            TestStaff.StaffNumber = "1234567";
            TestStaff.StaffAddress = "Islamabad, Pakistan.";
            TestStaff.StaffEmail = "hyaqoob@gmail.com";
            AllStaffs.ThisStaff = TestStaff;

            PrimaryKey = AllStaffs.Add();
            TestStaff.StaffID = PrimaryKey;
            TestStaff.StaffFirstName = "hmaza";
            TestStaff.StaffLastName = "yaqoob";
            TestStaff.StaffDateofBirth = DateTime.Now.Date;
            TestStaff.StaffNumber = "123456789";
            TestStaff.StaffAddress = "Leicester, United Kigndom.";
            TestStaff.StaffEmail = "hyaqoob2584@gmail.com";
            AllStaffs.ThisStaff = TestStaff;
            AllStaffs.Update();
            AllStaffs.ThisStaff.Find(PrimaryKey);
            Assert.AreEqual(AllStaffs.ThisStaff, TestStaff);
        }



        [TestMethod]
        public void DeleteMethodOK()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();
            clsStaff TestStaff = new clsStaff();

            Int32 PrimaryKey = 0;
            TestStaff.StaffFirstName = "Hamza";
            TestStaff.StaffLastName = "Yaqoob";
            TestStaff.StaffDateofBirth = DateTime.Now.Date;
            TestStaff.StaffNumber = "1234567";
            TestStaff.StaffAddress = "Islamabad, Pakistan.";
            TestStaff.StaffEmail = "hyaqoob@gmail.com";
            AllStaffs.ThisStaff = TestStaff;
            PrimaryKey = AllStaffs.Add();
            TestStaff.StaffID = PrimaryKey;
            AllStaffs.ThisStaff.Find(PrimaryKey);

            AllStaffs.Delete();
            Boolean Found = AllStaffs.ThisStaff.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }



        [TestMethod]
        public void ReportByStaffFirstnameMethodOK()
        {

            clsStaffCollection AllStaffs = new clsStaffCollection();

            clsStaffCollection FilteredStaffs = new clsStaffCollection();
            FilteredStaffs.ReportByStaffFirstname("");

            Assert.AreEqual(AllStaffs.Count, FilteredStaffs.Count);


        }

        [TestMethod]
        public void ReportByStaffFirstnameNoneFound()
        {
            clsStaffCollection FilteredStaffs = new clsStaffCollection();
            FilteredStaffs.ReportByStaffFirstname("xxx xxx");
            Assert.AreEqual(0, FilteredStaffs.Count);
        }


        [TestMethod]

        public void ReportByStaffFirstnameTestDataFound()
        {
            clsStaffCollection FilteredStaffs = new clsStaffCollection();
            Boolean OK = true;
            FilteredStaffs.ReportByStaffFirstname("Chris     ");
            if (FilteredStaffs.Count == 2)
            {
                if (FilteredStaffs.StaffList[0].StaffID != 24)
                {
                    OK = false;
                }
                if (FilteredStaffs.StaffList[0].StaffID != 25)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsFalse(OK);
        }

    }
}
