using System;

namespace ClassLibrary
{
    public class clsGame
    {
        public bool Available { get; set; }
        public int GameID { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string GameTitle { get; set; }
        public string GameDescription { get; set; }
        public string GamePlatform { get; set; }
        public double Price { get; set; }
    }
}