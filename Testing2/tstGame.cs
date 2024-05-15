using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

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
            DateTime TestData = new DateTime(26 / 04 / 2024);
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
            Assert.IsTrue(Found);
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
            if (AnGame.GameID != 6)
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

        //good test data
        //create some test data to pass the method
        String GameTitle = "Stellar Blade";
        String GameDescription = "The future of humanity hangs in the balance in Stellar Blade, an all-new story-driven action adventure on PlayStation 5. Immerse yourself in a highly detailed post-apocalyptic world that blends beauty and horror to spectacular effect.";
        String GamePlatform = "PS5";
        String ReleaseDate = DateTime.Now.ToShortDateString();
        String Price = "69.9900";

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsGame AnGame = new clsGame();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnGame.Valid(GameTitle, GameDescription, GamePlatform, ReleaseDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GameTitleMinLessOne()
        {
            //create an instance of the class we want to create
            clsGame AnGame = new clsGame();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String GameTitle = ""; //this should trigger an error
            //invoke the method
            Error = AnGame.Valid(GameTitle, GameDescription, GamePlatform, ReleaseDate, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GameTitleMin()
        {
            //create an instance of the class we want to create
            clsGame AnGame = new clsGame();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string GameTitle = "a"; //this should be ok
            //invoke the method
            Error = AnGame.Valid(GameTitle, GameDescription, GamePlatform, ReleaseDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GameTitleMinPlusOne()
        {
            //create an instance of the class we want to create
            clsGame AnGame = new clsGame();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string GameTitle = "aa"; //this should be ok
            //invoke the method
            Error = AnGame.Valid(GameTitle, GameDescription, GamePlatform, ReleaseDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GameTitleMaxLessOne()
        {
            //create an instance of the class we want to create
            clsGame AnGame = new clsGame();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string GameTitle = "";
            GameTitle = GameTitle.PadRight(49, 'a'); //this should  be ok
            //invoke the method
            Error = AnGame.Valid(GameTitle, GameDescription, GamePlatform, ReleaseDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GameTitleMax()
        {
            //create an instance of the class we want to create
            clsGame AnGame = new clsGame();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string GameTitle = "";
            GameTitle = GameTitle.PadRight(50, 'a'); //this should be ok
            //invoke the method
            Error = AnGame.Valid(GameTitle, GameDescription, GamePlatform, ReleaseDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GameTitleMid()
        {
            //create an instance of the class we want to create
            clsGame AnGame = new clsGame();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string GameTitle = "";
            GameTitle = GameTitle.PadRight(25, 'a'); //this should be ok
            //invoke the method
            Error = AnGame.Valid(GameTitle, GameDescription, GamePlatform, ReleaseDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GameTitleMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsGame AnGame = new clsGame();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string GameTitle = "";
            GameTitle = GameTitle.PadRight(51, 'a'); //this should fail
            //invoke the method
            Error = AnGame.Valid(GameTitle, GameDescription, GamePlatform, ReleaseDate, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GameTitleExtremeMax()
        {
            //create an instance of the class we want to create
            clsGame AnGame = new clsGame();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string GameTitle = "";
            GameTitle = GameTitle.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnGame.Valid(GameTitle, GameDescription, GamePlatform, ReleaseDate, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ReleaseDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsGame AnGame = new clsGame();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to release date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string ReleaseDate = TestDate.ToString();
            //invoke the method
            Error = AnGame.Valid(GameTitle, GameDescription, GamePlatform, ReleaseDate, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ReleaseDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsGame AnGame = new clsGame();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string ReleaseDate = TestDate.ToString();
            //invoke the method
            Error = AnGame.Valid(GameTitle, GameDescription, GamePlatform, ReleaseDate, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ReleaseDateMin()
        {
            //create an instance of the class we want to create
            clsGame AnGame = new clsGame();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string ReleaseDate = TestDate.ToString();
            //invoke the method
            Error = AnGame.Valid(GameTitle, GameDescription, GamePlatform, ReleaseDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReleaseDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsGame AnGame = new clsGame();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string ReleaseDate = TestDate.ToString();
            //invoke the method
            Error = AnGame.Valid(GameTitle, GameDescription, GamePlatform, ReleaseDate, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsGame AnGame = new clsGame();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string ReleaseDate = TestDate.ToString();
            //invoke the method
            Error = AnGame.Valid(GameTitle, GameDescription, GamePlatform, ReleaseDate, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ReleaseDateInvalidDate()
        {
            //create an instance of the class we want to create
            clsGame AnGame = new clsGame();
            //string variable to store any error message
            String Error = "";
            //set the ReleaseDate to a non date value
            string ReleaseDate = "this is not a date!";
            //invoke the method
            Error = AnGame.Valid(GameTitle, GameDescription, GamePlatform, ReleaseDate, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}