using Vasilenko_OrdersAPI.Models;

namespace Vasilenko_OrdersAPI.Services
{
    public interface IOrder
    {
        IEnumerable<Order> GetAll();
        public Order Get(int id);
        int Add(Order newOrder);
        void Save(Order order);
        void Delete(Order order);
    }
}
