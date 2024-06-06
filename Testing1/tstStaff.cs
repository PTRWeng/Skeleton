using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;
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
            Int32 StaffID = 2;
            Found = AStaff.Find(StaffID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffIDFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 StaffID = 2;

            Found = AStaff.Find(StaffID);
            if (AStaff.StaffID != 2)
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
            Int32 StaffID = 2;

            Found = AStaff.Find(StaffID);
            if (AStaff.StaffFirstName != "Chris     ")
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
            Int32 StaffID = 2;

            Found = AStaff.Find(StaffID);
            if (AStaff.StaffLastName != "Gayle     ")
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
            Int32 StaffID = 2;

            Found = AStaff.Find(StaffID);
            if (AStaff.StaffDateofBirth != Convert.ToDateTime("28-05-2024"))
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
            Int32 StaffID = 2;

            Found = AStaff.Find(StaffID);
            if (AStaff.StaffNumber != "2")
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
            Int32 StaffID = 2;

            Found = AStaff.Find(StaffID);
            if (AStaff.StaffAddress != "33 Le0 5nu")
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
            Int32 StaffID = 2;

            Found = AStaff.Find(StaffID);
            if (AStaff.StaffEmail != "hris1@gmail.com")
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }


        string StaffFirstName = "Hamza";
        string StaffLastName = "Yaqoob";
        string StaffDateofBirth = DateTime.Now.Date.ToString();
        string StaffNumber = "222521";
        string StaffAddress = "Leicester, United K";
        string StaffEmail = "hamzaYaqoob@gmail.com";


        [TestMethod]
        public void ValidMethodOK()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDateofBirth, StaffNumber, StaffAddress, StaffEmail);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StaffFirstNameMinLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String StaffFirstName = "";
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDateofBirth, StaffNumber, StaffAddress, StaffEmail);
            Assert.AreEqual(Error, "First Name Cant be empty.");
        }


        [TestMethod]
        public void StaffFirstNameMin()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String StaffFirstName = "E";
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDateofBirth, StaffNumber, StaffAddress, StaffEmail);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StaffFirstNameMinPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String StaffFirstName = "FF";
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDateofBirth, StaffNumber, StaffAddress, StaffEmail);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StaffFirstNameMaxLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String StaffFirstName = "";
            StaffFirstName = StaffFirstName.PadRight(19, 'E');
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDateofBirth, StaffNumber, StaffAddress, StaffEmail);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstNameMax()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String StaffFirstName = "";
            StaffFirstName = StaffFirstName.PadRight(20, 'E');
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDateofBirth, StaffNumber, StaffAddress, StaffEmail);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StaffFirstNameMaxPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String StaffFirstName = "";
            StaffFirstName = StaffFirstName.PadRight(21, 'E');
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDateofBirth, StaffNumber, StaffAddress, StaffEmail);
            Assert.AreEqual(Error, "First name shoud be smaller than 20.");
        }

        [TestMethod]
        public void StaffFirstNameMid()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String StaffFirstName = "";
            StaffFirstName = StaffFirstName.PadRight(10, 'E');
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDateofBirth, StaffNumber, StaffAddress, StaffEmail);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StaffFirstNameExtremeMAX()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String StaffFirstName = "";
            StaffFirstName = StaffFirstName.PadRight(2000, 'E');
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDateofBirth, StaffNumber, StaffAddress, StaffEmail);
            Assert.AreEqual(Error, "First name shoud be smaller than 20.");
        }



        [TestMethod]
        public void StaffLastNameMinLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String StaffLastName = "";
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDateofBirth, StaffNumber, StaffAddress, StaffEmail);
            Assert.AreEqual(Error, "Last Name Cant be empty.");
        }


        [TestMethod]
        public void StaffLastNameMin()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String StaffLastName = "E";
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDateofBirth, StaffNumber, StaffAddress, StaffEmail);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StaffLastNameMinPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String StaffLastName = "FF";
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDateofBirth, StaffNumber, StaffAddress, StaffEmail);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StaffLastNameMaxLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String StaffLastName = "";
            StaffLastName = StaffLastName.PadRight(19, 'E');
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDateofBirth, StaffNumber, StaffAddress, StaffEmail);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffLastNameMax()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String StaffLastName = "";
            StaffLastName = StaffLastName.PadRight(20, 'E');
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDateofBirth, StaffNumber, StaffAddress, StaffEmail);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StaffLastNameMaxPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String StaffLastName = "";
            StaffLastName = StaffLastName.PadRight(21, 'E');
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDateofBirth, StaffNumber, StaffAddress, StaffEmail);
            Assert.AreEqual(Error, "Last name shoud be smaller than 20.");
        }

        [TestMethod]
        public void StaffLastNameMid()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String StaffLastName = "";
            StaffLastName = StaffLastName.PadRight(10, 'E');
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDateofBirth, StaffNumber, StaffAddress, StaffEmail);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StaffLastNameExtremeMAX()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String StaffLastName = "";
            StaffLastName = StaffLastName.PadRight(2000, 'E');
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDateofBirth, StaffNumber, StaffAddress, StaffEmail);
            Assert.AreEqual(Error, "Last name shoud be smaller than 20.");
        }



        [TestMethod]
        public void StaffEmailMinLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String StaffEmail = "";
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDateofBirth, StaffNumber, StaffAddress, StaffEmail);
            Assert.AreEqual(Error, "StaffEmail cant be empty.");
        }


        [TestMethod]
        public void StaffEmailMin()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String StaffEmail = "E";
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDateofBirth, StaffNumber, StaffAddress, StaffEmail);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StaffEmailMinPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String StaffEmail = "EE";
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDateofBirth, StaffNumber, StaffAddress, StaffEmail);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StaffEmailMaxLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(29, 'E');
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDateofBirth, StaffNumber, StaffAddress, StaffEmail);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMax()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(30, 'E');
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDateofBirth, StaffNumber, StaffAddress, StaffEmail);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StaffEmailMaxPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(31, 'E');
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDateofBirth, StaffNumber, StaffAddress, StaffEmail);
            Assert.AreEqual(Error, "StaffEmail Must be lesser than 30 Characters.");
        }

        [TestMethod]
        public void StaffEmailMid()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(15, 'E');
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDateofBirth, StaffNumber, StaffAddress, StaffEmail);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StaffEmailExtremeMAX()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(300, 'E');
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDateofBirth, StaffNumber, StaffAddress, StaffEmail);
            Assert.AreEqual(Error, "StaffEmail Must be lesser than 30 Characters.");
        }




        [TestMethod]
        public void AddressMinLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String StaffAddress = "";
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDateofBirth, StaffNumber, StaffAddress, StaffEmail);
            Assert.AreEqual(Error, "StaffAddress cant be empty.");
        }


        [TestMethod]
        public void AddressMin()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String StaffAddress = "A";
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDateofBirth, StaffNumber, StaffAddress, StaffEmail);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void AddressMinPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String StaffAddress = "AA";
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDateofBirth, StaffNumber, StaffAddress, StaffEmail);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void AddressMaxLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String StaffAddress = "";
            StaffAddress = StaffAddress.PadRight(199, 'A');
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDateofBirth, StaffNumber, StaffAddress, StaffEmail);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMax()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String StaffAddress = "";
            StaffAddress = StaffAddress.PadRight(200, 'A');
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDateofBirth, StaffNumber, StaffAddress, StaffEmail);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void AddressMaxPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String StaffAddress = "";
            StaffAddress = StaffAddress.PadRight(201, 'A');
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDateofBirth, StaffNumber, StaffAddress, StaffEmail);
            Assert.AreEqual(Error, "StaffAddress must be lesser than 200 Characters.");
        }

        [TestMethod]
        public void AddressMid()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String StaffAddress = "";
            StaffAddress = StaffAddress.PadRight(100, 'A');
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDateofBirth, StaffNumber, StaffAddress, StaffEmail);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void AddressExtremeMAX()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String StaffAddress = "";
            StaffAddress = StaffAddress.PadRight(2000, 'A');
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDateofBirth, StaffNumber, StaffAddress, StaffEmail);
            Assert.AreEqual(Error, "StaffAddress must be lesser than 200 Characters.");
        }





        [TestMethod]
        public void StaffNumberMinLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string StaffNumber = "11111";
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDateofBirth, StaffNumber,StaffAddress, StaffEmail);
            Assert.AreEqual(Error, "Number's Minimum is 6 digit long.");
        }


        [TestMethod]
        public void StaffNumberMin()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string StaffNumber = "111116";
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDateofBirth, StaffNumber,StaffAddress, StaffEmail);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StaffNumberMinPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string StaffNumber = "1111117";
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDateofBirth, StaffNumber, StaffAddress, StaffEmail);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StaffNumberMaxLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string StaffNumber = "11111111111114";
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDateofBirth, StaffNumber, StaffAddress, StaffEmail);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNumberMax()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string StaffNumber = "123456789123415";
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDateofBirth, StaffNumber, StaffAddress, StaffEmail);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StaffNumberMaxPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string StaffNumber = "1234567891234516";
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDateofBirth, StaffNumber, StaffAddress, StaffEmail);
            Assert.AreEqual(Error, "numbers' is 15 digit long.");
        }

        [TestMethod]
        public void StaffNumberMid()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string StaffNumber = "1111117";
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDateofBirth, StaffNumber,StaffAddress, StaffEmail);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffDateofBirthExtremeMin()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            String StaffDateofBirth = TestDate.ToString();
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDateofBirth, StaffNumber,StaffAddress, StaffEmail);
            Assert.AreEqual(Error, "Date cant be in the Past.....");
        }

        [TestMethod]
        public void StaffDateofBirthMinLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            String StaffDateofBirth = TestDate.ToString();
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDateofBirth, StaffNumber,StaffAddress, StaffEmail);
            Assert.AreEqual(Error, "Date cant be in the Past.....");
        }


        [TestMethod]
        public void StaffDateofBirthMin()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            String StaffDateofBirth = TestDate.ToString();
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDateofBirth, StaffNumber,StaffAddress, StaffEmail);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffDateofBirthMinPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            String StaffDateofBirth = TestDate.ToString();
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDateofBirth, StaffNumber,StaffAddress, StaffEmail);
            Assert.AreEqual(Error, "Date cant be in the future......");
        }

        [TestMethod]
        public void StaffDateofBirthExtremeMAX()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            String StaffDateofBirth = TestDate.ToString();
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDateofBirth, StaffNumber,StaffAddress, StaffEmail);
            Assert.AreEqual(Error, "Date cant be in the future......");
        }

        [TestMethod]
        public void StaffDateofBirthInvalidFormat()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String StaffDateofBirth = "Enter Valid Date";
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDateofBirth, StaffNumber,StaffAddress, StaffEmail);
            Assert.AreEqual(Error, "Invalid data.");
        }

    }
}
