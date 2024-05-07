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

        [TestMethod]
        public void AvailablePropertyOK()
        {
            //creat an instance of the class we want to create
            clsGame AnGame = new clsGame();
            //creat some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnGame.Available = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnGame.Available, TestData);
        }

        [TestMethod]
        public void ReleaseDateProperty()
        {
            //creat an instance of the class we want to create
            clsGame AnGame = new clsGame();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnGame.ReleaseDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnGame.ReleaseDate, TestData);

        }

        [TestMethod]
        public void GameIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsGame AnGame = new clsGame();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnGame.GameID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnGame.GameID, TestData);
        }

        [TestMethod]
        public void GameTitlePropertyOK()
        {
            //create an instance of the class we want to create
            clsGame AnGame = new clsGame();
            //create some test data to assign to the property
            string TestData = "Stellar Blade";
            //assign the data to the property
            AnGame.GameTitle = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnGame.GameTitle, TestData);
        }

        [TestMethod]
        public void GameDescriptionPropertyOK()
        {
            //create an instance of the class we want to create
            clsGame AnGame = new clsGame();
            //create some test data to assign to the property
            string TestData = "Relive or play for the first time Ellie and Abby’s story, now with graphical enhancements, new gameplay modes like the roguelike survival experience No Return, full DualSense wireless controller integration, and more.";
            //assign the data to the property
            AnGame.GameDescription = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnGame.GameDescription, TestData);
        }

        [TestMethod]
        public void GamePlatformPropertyOK()
        {
            //create an instance of the class we want to create
            clsGame AnGame = new clsGame();
            //create some test data to assign to the property
            string TestData = "PS5";
            AnGame.GamePlatform = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnGame.GamePlatform, TestData);
        }

        [TestMethod]
        public void PricePropertyOK()
        {
            //create an instance of the class we want to create
            clsGame AnGame = new clsGame();
            //create some test data to assign to the property
            double TestData = 69.99;
            //assign the data to the property
            AnGame.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnGame.Price, TestData);
        }
    }
}
