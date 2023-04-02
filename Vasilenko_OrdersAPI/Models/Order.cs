using System.ComponentModel.DataAnnotations;

namespace Vasilenko_OrdersAPI.Models
{
    public sealed class Order
    {
        public int  Id { get; set; }  

        public string ProductName { get; set; } = string.Empty; 

        public int ProductPrice { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public Order()
        { 
        
        }
    }
}
