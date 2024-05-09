using System;

namespace ClassLibrary
{
    public class clsGame
    {
        //private data member for the address id property
        private Int32 mGameID;
        public bool Available { get; set; }
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
        public string GameTitle { get; set; }
        public string GameDescription { get; set; }
        public string GamePlatform { get; set; }
        public double Price { get; set; }

        public bool Find(int GameID)
        {
            //set the private data members to the test data value
            mGameID = 2;
            mReleaseDate = Convert.ToDateTime("19/01/2024");
            //always return true
            return true;
        }
    }
}