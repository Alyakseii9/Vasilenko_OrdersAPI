using System.ComponentModel.DataAnnotations;

namespace Vasilenko_OrdersAPI.Models
{
    public sealed class Order
    {
        public int /* Guid */Id { get; set; } //Идентификатор
      /*  [Required(ErrorMessage = "Укажите наименование курса")]  */
        public string Buer/* Title */ { get; set; } = string.Empty; //Название курса
        /*    [Range(1, 300, ErrorMessage = "Количество часов должно быть в промежутке от 1 до 300")]
            [Required(ErrorMessage = "Укажите количество часов")]  */
        public int Cena { get; set; } 
        public decimal Total { get; set; }
        public Order()
        { 
        
        }
        /*   Spyrgyash
    public class Order
    {
        public Guid Id { get; set; }
        public decimal Total { get; set; }
        public Guid BuyerId { get; set; }
        public List<ProductItem> ProductItems { get; set; }
    }
         *   
         *   */
        /*  Matskevitch
        public class Order
    {
        public Guid Id { get; set; }
        public string Buyer { get; set; }
        public decimal Total { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
        public Order()
        {
            Id = Guid.NewGuid();
        }        
    }
         * 
         * 
         * */
    }
}
