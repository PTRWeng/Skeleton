using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstGame
    {
        [TestMethod]
        public void InstanceOK()
        {
            //crat an instance of the class we want to create
            clsGame AnGame = new clsGame();
            //test to see that it exists
            Assert.IsNotNull(AnGame);
        }
    }
}
