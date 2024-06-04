using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;

namespace Testing1
{
    [TestClass]
    public class tstStaffUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaffUser AnUser = new clsStaffUser();
            Assert.IsNotNull(AnUser);
        }


        [TestMethod]
        public void AdminIDPropertyOK()
        {
            clsStaffUser AnUser = new clsStaffUser();
            Int32 TestData = 1;
            AnUser.UserID = TestData;
            Assert.AreEqual(AnUser.UserID, TestData);
        }


        [TestMethod]
        public void UsernamePropertyOK()
        {
            clsStaffUser AnUser = new clsStaffUser();
            string TestData = "Usera";
            AnUser.UserName = TestData;
            Assert.AreEqual(AnUser.UserName, TestData);
        }


        [TestMethod]
        public void PasswordPropertyOK()
        {
            clsStaffUser AnUser = new clsStaffUser();
            string TestData = "avdc1234";
            AnUser.Password = TestData;
            Assert.AreEqual(AnUser.Password, TestData);
        }



        [TestMethod]
        public void DepartmentPropertyOK()
        {
            clsStaffUser AnUser = new clsStaffUser();
            string TestData = "Staff Department";

            AnUser.Department = TestData;
            Assert.AreEqual(AnUser.Department, TestData);
        }

        [TestMethod]

        public void FindAdminMethodOK()
        {
            clsStaffUser AnUser = new clsStaffUser();
            Boolean Found = false;
            string UserName = "Hamza Yaqoob";
            string Password = "abcd1234";
            Found = AnUser.FindUser(UserName, Password);
            Assert.IsTrue(Found);
        }

        [TestMethod]

        public void TestUsernamePWFound()
        {
            clsStaffUser AnUser = new clsStaffUser();
            Boolean Found = false;
            Boolean Ok = true;
            string UserName = "Hamza Yaqoob";
            string Password = "abcd1234";
            Found = AnUser.FindUser(UserName, Password);

            if (AnUser.UserName != UserName && AnUser.Password != Password)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }
    }
}
