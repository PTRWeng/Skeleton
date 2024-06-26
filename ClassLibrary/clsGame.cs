﻿using System;
using System.IO;

namespace ClassLibrary
{
    public class clsGame
    {
        //private data member for the available property
        private Boolean mAvailable;
        //active public property
        public bool Available
        {
            get
            {
                //this line of code sends data out of the property
                return mAvailable;
            }
            set
            {
                //this line of code allows data into the property
                mAvailable = value;
            }
        }

        //private data member for the game id property
        private Int32 mGameID;

        //GameID public property
        public Int32 GameID
        {
            get 
            {
                //this line of code sends data out of the property
                return mGameID;
            }
            set
            {
                //this line of code allows data into the property
                mGameID = value;
            }
        }

        //private data member for the release date property
        private DateTime mReleaseDate;
        //ReleaseDate public property
        public DateTime ReleaseDate
        {
            get
            {
                //this line of code send data out of the property
                return mReleaseDate;
            }
            set 
            { 
                //this line of code allows data into the property
                mReleaseDate = value;
            }
        }

        //private data member for the game title property
        private string mGameTitle;
        //house no public property
        public string GameTitle
        {
            get
            {
                //this line of code sends data out of the property
                return mGameTitle;
            }
            set
            {
                //this line of code allows data into the property
                mGameTitle = value;
            }
        }

        //private data member for the game description property
        private string mGameDescription;
        //house no public property
        public string GameDescription
        {
            get
            {
                //this line of code sends data out of the property
                return mGameDescription;
            }
            set
            {
                //this line of code allows data into the property
                mGameDescription = value;
            }
        }

        //private data member for the game platform property
        private string mGamePlatform;
        //house no public property
        public string GamePlatform
        {
            get
            {
                //this line of code sends data out of the property
                return mGamePlatform;
            }
            set
            {
                //this line of code allows data into the property
                mGamePlatform = value;
            }
        }

        //private data member for the price property
        private double mPrice;
        //county no public property
        public double Price
        {
            get
            {
                //this line of code sends data out of the property
                return mPrice;
            }
            set
            {
                //this line of code allows data into the property
                mPrice = value;
            }
        }

        /****** FIND METHOD ******/
        public bool Find(int GameID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the game id to search for
            DB.AddParameter("@GameID", GameID);
            //execute the stored procedure
            DB.Execute("sproc_tblGame_FilterByGameID");
            //if one recode is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mGameID = Convert.ToInt32(DB.DataTable.Rows[0]["GameID"]);
                mGameTitle = Convert.ToString(DB.DataTable.Rows[0]["GameTitle"]);
                mGameDescription = Convert.ToString(DB.DataTable.Rows[0]["GameDescription"]);
                mGamePlatform = Convert.ToString(DB.DataTable.Rows[0]["Gameplatform"]);
                mReleaseDate = Convert.ToDateTime(DB.DataTable.Rows[0]["ReleaseDate"]);
                mPrice = Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);
                mAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["Available"]);
                //return that everything worked OK
                return true;
            }
            else
            {
                //return false indicating there is a problem
                return false;
            }

        }

        public string Valid(string gameTitle, string gameDescription, string gamePlatform, string releaseDate, string price)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //if the Gametitle is blank
            if (gameTitle.Length == 0)
            {
                //record the error
                Error = Error + "The game title may not be blank : ";
            }
            //if the game title is greater than 6 characters
            if (gameTitle.Length > 50)
            {
                //record the error
                Error = Error + "The game title must be less than 50 characters : ";
            }
            DateTime DateComp = DateTime.Now.Date;

            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(releaseDate);
                if (DateTemp < DateComp)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateComp)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date";
            }
            //is the game description blank
            if (gameDescription.Length == 0)
            {
                //record the error
                Error = Error + "The game description may not be blank";
            }
            //if the game description is too long
            if (gameDescription.Length > 1000)
            {
                //record the code
                Error = Error + "THe game description must be less than 1000 characters";
            }
            //is the game platform blank
            if (gamePlatform.Length == 0)
            {
                //record the error
                Error = Error + "The game platform may not be blank : ";
            }
            //if the street is too long
            if (gamePlatform.Length > 50)
            {
                //record the error
                Error = Error + "The game pltform must be less than 50 characters : ";
            }
            //is the price blank
            if (price.Length == 0)
            {
                //record the error
                Error = Error + "The price may not be blank : ";
            }
            //return any error messages
            return Error;

        }

    }
}