using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsGameCollection
    {
        //private data member for the list
        List<clsGame> mGamelist = new List<clsGame>();
        //private member data for thisGame
        clsGame mThisGame = new clsGame();

        //public property for the game list
        public List<clsGame> GameList 
        {
            get 
            {
                //return the private data
                return mGamelist;
            }
            set
            {
                //set the private data
                mGamelist = value;
            }
        }
        //public property for count
        public int Count 
        {
            get
            {
                //retune the count of the list
                return mGamelist.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        public clsGame ThisGame 
        { 
            get
            {
                //return the private data
                return mThisGame;
            }
            set
            {
                //set the private data
                mThisGame = value;
            }
        }

        public int Add()
        {
            //adds a record to the database based on the values of mThisGame
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@GameTitle", mThisGame.GameTitle);
            DB.AddParameter("@GameDescription", mThisGame.GameDescription);
            DB.AddParameter("@GamePlatform", mThisGame.GamePlatform);
            DB.AddParameter("@ReleaseDate", mThisGame.ReleaseDate);
            DB.AddParameter("@Price", mThisGame.Price);
            DB.AddParameter("@Available", mThisGame.Available);

            //execute the query returning the primary kay value
            return DB.Execute("sproc_tblGame_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of thisGame
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the new stored procedure
            DB.AddParameter("@GameID", mThisGame.GameID);
            DB.AddParameter("@GameTitle", mThisGame.GameTitle);
            DB.AddParameter("@GameDescription", mThisGame.GameDescription);
            DB.AddParameter("@GamePlatform", mThisGame.GamePlatform);
            DB.AddParameter("@ReleaseDate", mThisGame.ReleaseDate);
            DB.AddParameter("@Price", mThisGame.Price);
            DB.AddParameter("@Available", mThisGame.Available);
            //execute the stored procedure
            DB.Execute("sproc_tblGame_Update");
        }

        public clsGameCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblGame_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank game
                clsGame AnGame = new clsGame();
                //read in fields for the current record
                AnGame.GameID = Convert.ToInt32(DB.DataTable.Rows[Index]["GameID"]);
                AnGame.GameTitle = Convert.ToString(DB.DataTable.Rows[Index]["GameTitle"]);
                AnGame.GameDescription = Convert.ToString(DB.DataTable.Rows[Index]["GameDescription"]);
                AnGame.GamePlatform = Convert.ToString(DB.DataTable.Rows[Index]["Gameplatform"]);
                AnGame.ReleaseDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["ReleaseDate"]);
                AnGame.Price = Convert.ToDouble(DB.DataTable.Rows[Index]["Price"]);
                AnGame.Available = Convert.ToBoolean(DB.DataTable.Rows[Index]["Available"]);
                //add the record to the private data member
                mGamelist.Add(AnGame);
                //point at the next record
                Index++;
            }
        }
    }
}