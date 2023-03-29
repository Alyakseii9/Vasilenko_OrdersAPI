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
                new Order{Id = 1, Buer = "Материалы", Cena = 30 },
                new Order{Id = 2, Buer ="Комплектующие", Cena = 45},
                new Order{Id = 3, Buer ="Расходники", Cena = 60}
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
            _order.Where(p => p.Id == order.Id).ToList().ForEach(x => { x.Buer = order.Buer; x.Cena = order.Cena; });
        }
        public void Delete(Order order)
        {
            _order.Remove(order);
        }

       
    }
}
