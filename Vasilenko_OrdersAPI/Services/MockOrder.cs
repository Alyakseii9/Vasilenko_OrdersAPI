using Vasilenko_OrdersAPI.Models;

namespace Vasilenko_OrdersAPI.Services
{
    public sealed class MockOrder : IOrder
    {
        private List<Order> _order;
        public MockOrder()
        {
            _order = new List<Order>
            {
                new Order{Id = 1, ProductName = "Материалы", ProductPrice = 30 },
                new Order{Id = 2, ProductName ="Комплектующие", ProductPrice = 45},
                new Order{Id = 3, ProductName ="Расходники", ProductPrice = 60}
            };
        }
        public IEnumerable<Order> GetAll()
        {
            return _order;
        }
        public Order Get(int id)
        {
            return _order.FirstOrDefault(x => x.Id.Equals(id)) ?? new Order() { Id = -1 };
        }
        public int Add(Order newOrder)
        {
            newOrder.Id = _order.Max(p => p.Id) + 1;
            _order.Add(newOrder);
            return newOrder.Id;
        }
        public void Save(Order order)
        {
            _order.Where(p => p.Id == order.Id).ToList().ForEach(x => { x.ProductName = order.ProductName; x.ProductPrice = order.ProductPrice; });
        }
        public void Delete(Order order)
        {
            _order.Remove(order);
        }

       
    }
}
