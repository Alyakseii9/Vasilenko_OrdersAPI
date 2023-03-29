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
    }
}
