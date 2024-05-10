using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstGame
    {
        /*******************INSTANCE OF THE CLASS TEST****************/

        [TestMethod]
        public void InstanceOK()
        {
            //crat an instance of the class we want to create
            clsGame AnGame = new clsGame();
            //test to see that it exists
            Assert.IsNotNull(AnGame);
        }

        /*******************PROPERTY OK TESTS***************************/

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

        /*******************FIND METHOD TEST**************************/

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsGame AnGame = new clsGame();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 GameID = 2;
            //invoke the method
            Found = AnGame.Find(GameID);
            //test to see if the result is true
            Assert.IsTrue( Found );     
        }

        /******************PROPERTY DATA TESTS***********************/

        [TestMethod]
        public void TestGameIDFound() 
        {
            //create an instance of the class we want to create
            clsGame AnGame = new clsGame();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 GameID = 6;
            //invoke the method
            Found = AnGame.Find(GameID);
            //check the game ID
            if ( AnGame.GameID != 6)
            {
                OK = false;
            }
            //test to see that result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestReleaseDateFound()
        {
            //create an instance of the class we want to create
            clsGame AnGame = new clsGame();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 GameID = 6;
            //invoke the method
            Found = AnGame.Find(GameID);
            //check the release date property
            if (AnGame.ReleaseDate != Convert.ToDateTime("29/09/2023"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestGameTitleFound()
        {
            //create an instance of the class we want to create
            clsGame AnGame = new clsGame();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 GameID = 6;
            //invoke the method
            Found = AnGame.Find(GameID);
            //check the game title property
            if (AnGame.GameTitle != "EA SPORTS FC™ 24")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestGameDescriptionFound()
        {
            //create an instance of the class we want to create
            clsGame AnGame = new clsGame();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 GameID = 6;
            //invoke the method
            Found = AnGame.Find(GameID);
            //check the game description property
            if (AnGame.GameDescription != "Built on innovation and authenticity, feel closer to the game in the most true-to-football experience yet with the best players from the biggest clubs, leagues and competitions around the globe.")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestGameplatformFound()
        {
            //create an instance of the class we want to create
            clsGame AnGame = new clsGame();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 GameID = 6;
            //invoke the method
            Found = AnGame.Find(GameID);
            //check the game platform property
            if (AnGame.GamePlatform != "PS5")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            //create an instance of the class we want to create
            clsGame AnGame = new clsGame();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 GameID = 6;
            //invoke the method
            Found = AnGame.Find(GameID);
            //check the game price property
            if (AnGame.Price != 69.9900)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAvailableFound()
        {
            //create an instance of the class we want to create
            clsGame AnGame = new clsGame();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 GameID = 6;
            //invoke the method
            Found = AnGame.Find(GameID);
            //check the availble property
            if (AnGame.Available != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
