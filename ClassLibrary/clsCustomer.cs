using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public clsCustomer()
        {
        }

        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public int CustomerId { get; set; }
    }
}