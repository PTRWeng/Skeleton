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
    }
}