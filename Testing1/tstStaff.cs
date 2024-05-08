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
            clsStaff AnStaff = new clsStaff();
            Assert.IsNotNull(AnStaff);

        }
        [TestMethod]
        public void ActivePropertyOk()
        {
            clsStaff AnStaff2 = new clsStaff();
            Boolean TestData = true;
            AnStaff2.Active = TestData;
            Assert.AreEqual(AnStaff2.Active, TestData);



        }
    }
}