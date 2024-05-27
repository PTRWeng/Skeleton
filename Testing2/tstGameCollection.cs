using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstGameCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsGameCollection AllGame = new clsGameCollection();
            //test to see that is exists
            Assert.IsNotNull(AllGame);
        }

        [TestMethod]
        public void GameListOK()
        {
            //create an instance of the class we want to create
            clsGameCollection AllGame = new clsGameCollection();
            //create some test data needs to be a list of objects
            //in this case the data needs to be a list of objects
            List<clsGame> TestList = new List<clsGame>();
            //Add an Item to the List
            //create the item of test data
            clsGame TestItem = new clsGame();
            //set its properties
            TestItem.Available = true;  
            TestItem.GameID = 1;
            TestItem.GameTitle = "Stellar Blade";
            TestItem.GameDescription = "The future of humanity hangs in the balance in Stellar Blade, an all-new story-driven action adventure on PlayStation 5. Immerse yourself in a highly detailed post-apocalyptic world that blends beauty and horror to spectacular effect.";
            TestItem.GamePlatform = "PS5";
            TestItem.ReleaseDate = DateTime.Now;
            TestItem.Price = 69.99;
            //add the time to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllGame.GameList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllGame.GameList, TestList);
        }

        [TestMethod]
        public void ThisGamepropertyOK()
        {
            //create an instance of the class we want to create
            clsGameCollection AllGame = new clsGameCollection();
            //create some test data to assign to the property
            clsGame TestGame = new clsGame();
            //set the properties of the test object
            TestGame.Available = true;
            TestGame.GameID = 1;
            TestGame.GameTitle = "Stellar Blade";
            TestGame.GameDescription = "The future of humanity hangs in the balance in Stellar Blade, an all-new story-driven action adventure on PlayStation 5. Immerse yourself in a highly detailed post-apocalyptic world that blends beauty and horror to spectacular effect.";
            TestGame.GamePlatform = "PS5";
            TestGame.ReleaseDate = DateTime.Now;
            TestGame.Price = 69.99;
            //assign the data to the property
            AllGame.ThisGame = TestGame;
            //test to see that the two values are the same
            Assert.AreEqual(AllGame.ThisGame, TestGame);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsGameCollection AllGame = new clsGameCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsGame> TestList = new List<clsGame>();
            //Add an Item to the List
            //create the item of test data
            clsGame TestItem = new clsGame();
            //set its properties
            TestItem.Available = true;
            TestItem.GameID = 1;
            TestItem.GameTitle = "Stellar Blade";
            TestItem.GameDescription = "The future of humanity hangs in the balance in Stellar Blade, an all-new story-driven action adventure on PlayStation 5. Immerse yourself in a highly detailed post-apocalyptic world that blends beauty and horror to spectacular effect.";
            TestItem.GamePlatform = "PS5";
            TestItem.ReleaseDate = DateTime.Now;
            TestItem.Price = 69.99;
            //add the time to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllGame.GameList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllGame.Count, TestList.Count);
        }

        [TestMethod]
        public void AddmethodOK()
        {
            //create an instance of the class we want to create
            clsGameCollection AllGame = new clsGameCollection();
            //create the item of test data
            clsGame TestItem = new clsGame();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Available = true;
            TestItem.GameID = 1;
            TestItem.GameTitle = "Stellar Blade";
            TestItem.GameDescription = "The future of humanity hangs in the balance in Stellar Blade, an all-new story-driven action adventure on PlayStation 5. Immerse yourself in a highly detailed post-apocalyptic world that blends beauty and horror to spectacular effect.";
            TestItem.GamePlatform = "PS5";
            TestItem.ReleaseDate = DateTime.Now;
            TestItem.Price = 69.99;
            //set ThisGame to the test data
            AllGame.ThisGame = TestItem;
            //add the record
            PrimaryKey = AllGame.Add();
            //set the primary key of the test data
            TestItem.GameID = PrimaryKey;
            //find the record
            AllGame.ThisGame.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllGame.ThisGame, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an intance of the class we want to create
            clsGameCollection AllGame = new clsGameCollection();
            //create the item of test data
            clsGame TestItem = new clsGame();
            //variable to store the primary kay
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Available = true;
            TestItem.GameTitle = "Stellar Blade";
            TestItem.GameDescription = "The future of humanity hangs in the balance in Stellar Blade, an all-new story-driven action adventure on PlayStation 5. Immerse yourself in a highly detailed post-apocalyptic world that blends beauty and horror to spectacular effect.";
            TestItem.GamePlatform = "PS5";
            TestItem.ReleaseDate = DateTime.Now;
            TestItem.Price = 69.99;
            //set ThisGame to the test data
            AllGame.ThisGame = TestItem;
            //add the record
            PrimaryKey = AllGame.Add();
            //set the primary key of the test data
            TestItem.GameID = PrimaryKey;
            //modify the test record
            TestItem.Available = true;
            TestItem.GameTitle = "Stellar Blade";
            TestItem.GameDescription = "The future of humanity hangs in the balance in Stellar Blade, an all-new story-driven action adventure on PlayStation 5. Immerse yourself in a highly detailed post-apocalyptic world that blends beauty and horror to spectacular effect.";
            TestItem.GamePlatform = "Xbox One";
            TestItem.ReleaseDate = DateTime.Now;
            TestItem.Price = 59.99;
            //set the record based on the new test data
            AllGame.ThisGame = TestItem;
            //update the record
            AllGame.Update();
            //find the record
            AllGame.ThisGame.Find(PrimaryKey);
            //test to see if ThisGame matches the test data
            Assert.AreEqual(AllGame.ThisGame, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsGameCollection AllGames = new clsGameCollection();
            //create the item of test data
            clsGame TestItem = new clsGame();
            //variable to store the primary kay
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Available = true;
            TestItem.GameID = 1;
            TestItem.GameTitle = "Stellar Blade";
            TestItem.GameDescription = "The future of humanity hangs in the balance in Stellar Blade, an all-new story-driven action adventure on PlayStation 5. Immerse yourself in a highly detailed post-apocalyptic world that blends beauty and horror to spectacular effect.";
            TestItem.GamePlatform = "PS5";
            TestItem.ReleaseDate = DateTime.Now;
            TestItem.Price = 69.99;
            //set ThisGame to the test data
            AllGames.ThisGame = TestItem;
            //add the record
            PrimaryKey = AllGames.Add();
            //set the primary key of the test data
            TestItem.GameID = PrimaryKey;
            //find the record
            AllGames.ThisGame.Find(PrimaryKey);
            //delete the record
            AllGames.Delete();
            //now find the record
            Boolean Found = AllGames.ThisGame.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByGameTitleMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsGameCollection AllGames = new clsGameCollection();
            //create an instance of the filtered data
            clsGameCollection FilteredGames = new clsGameCollection();
            //apply a blank string (should return all records);
            FilteredGames.ReportByGameTitle("");
            //test to see that the two values are the same
            Assert.AreEqual(AllGames.Count, FilteredGames.Count);
        }

        [TestMethod]
        public void ReportByGameTitleNoneFound()
        {
            //create an instance of the class we want to create
            clsGameCollection FilteredGames = new clsGameCollection();
            //apply a game title that doesn't exist
            FilteredGames.ReportByGameTitle("xxxxxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredGames.Count);
        }

        [TestMethod]
        public void ReportByGameTitleTestDataFound()
        {
            //create an instance of the filtered data
            clsGameCollection FilteredGames = new clsGameCollection();
            //variable to store the outcome
            Boolean OK = true;
            //apply a game title that doesn't exist
            FilteredGames.ReportByGameTitle("xxxxxx");
            //check that the correct number of records are found
            if (FilteredGames.Count == 2)
            {
                //check to see that the first record in 26
                if (FilteredGames.GameList[0].GameID != 26)
                {
                    OK = false;
                }
                //check to see that the first record is 28
                if (FilteredGames.GameList[1].GameID != 28)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no record
            Assert.IsTrue(OK);
        }
    }
}
