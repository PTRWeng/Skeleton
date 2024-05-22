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
    }
}
