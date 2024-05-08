using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        

        public bool Active { get; set; }
        public DateTime orderDate { get; set; }
        public int orderId { get; set; }
        public decimal orderAmount { get; set; }
        public string orderDescription { get; set; }
        public string shippingAddress { get; set; }
        public int orderQuantity { get; set; }
    }
}