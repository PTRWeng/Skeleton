using System;

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
            //set the private data members to the test data value
            mGameID = 2;
            mReleaseDate = Convert.ToDateTime("19/01/2024");
            mAvailable = true;
            mGameTitle = "Stellar Blade";
            mGameDescription = "Embark on an epic journey across war-torn 19th-century Japan in this combat-focused open-world action RPG from Team NINJA, the veteran studio behind Nioh and NINJA Gaiden.";
            mGamePlatform = "PS5";
            mPrice = 44.99;
            //always return true
            return true;
        }
    }
}