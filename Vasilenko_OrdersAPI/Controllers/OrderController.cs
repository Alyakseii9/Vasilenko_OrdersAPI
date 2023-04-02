using Microsoft.AspNetCore.Mvc;
using Vasilenko_OrdersAPI.Services;
using Vasilenko_OrdersAPI.Models;

namespace Vasilenko_OrdersAPI.Controllers
{
    [Route("api/[controller]")]
    public class OrdersController : Controller
    {
        private readonly IOrder _order;
        public OrdersController(IOrder order)
        {
            _order = order;
        }
        // GET api/orders
        [HttpGet]
        public IEnumerable<Order> Get()
        {
            return _order.GetAll();
        }
        // GET api/orders/3
        [HttpGet("{id}")]
        //public Order Get(int id)
        //{
        //    return _order.Get(id);
        //}
        public IActionResult Get(int id)
        {
            var order = _order.Get(id);
            if (order == null || order.Id == -1)
                return NotFound();
            return new ObjectResult(order);
        }
        // POST api/orders
        [HttpPost]
        //public int Post([FromBody] Order order)
        //{
        //    return _order.Add(order);
        //}
        public IActionResult Post([FromBody] Order order)
        {
            // обработка частных случаев валидации
            if (order.ProductPrice == 3)
                ModelState.AddModelError("ProductPrice", " не может быть равно 3");
            if (order.ProductName.ToLower().IndexOf("Неликвид") > -1)
            {
                ModelState.AddModelError("ProductName", "Недопустимое наименование - Неликвид");
            }
            // если есть ошибки - возвращаем ошибку 400
            if (!ModelState.IsValid)
            {
                string validationErrors = string.Join(". ",
                    ModelState.Values.Where(E => E.Errors.Count > 0)
                    .SelectMany(E => E.Errors)
                    .Select(E => E.ErrorMessage)
                    .ToArray());
                return BadRequest(validationErrors);
            }
            // если ошибок нет, сохраняем элемент
            int newId = 0;
            try
            {
                newId = _order.Add(order);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok(newId);
        }
        // PUT api/orders/3
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Order model)
        {
            var order = _order.Get(id);
            order.ProductName = model.ProductName; order.ProductPrice = model.ProductPrice;
            _order.Save(order);
        }
        // DELETE api/orders/3
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var order = _order.Get(id);
            _order.Delete(order);
        }
    }
}
