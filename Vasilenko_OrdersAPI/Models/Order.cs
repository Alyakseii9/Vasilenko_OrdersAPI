using System.ComponentModel.DataAnnotations;

namespace Vasilenko_OrdersAPI.Models
{
    public sealed class Order
    {
        public int /* Guid */ Id { get; set; }   //Идентификатор

        public string ProductName/* Title */ { get; set; } = string.Empty; //Название

        public int ProductPrice { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public Order()
        { 
        
        }
    }
}
