using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public bool Active { get; set; }
        public DateTime Date { get; set; }
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public int Quantity { get; set; }
        public object Address { get; set; }
        public char Description { get; set; }
    }
}