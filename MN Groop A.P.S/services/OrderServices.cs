using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MN_Groop_A.P.S.Domain;
using MN_Groop_A.P.S.IRepositories;
using MN_Groop_A.P.S.IServices;
using MN_Groop_A.P.S.Domain;



namespace MN_Groop_A.P.S.services
{
    public class OrderServices : IOrderRepository
    {
        private readonly IOrderRepository _orderRepository;
        public OrderServices(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public async Task<List<Order>> GetAll()
        {
            var order = await _orderRepository.GetAll();
            return order;
        }

        public async Task<Order> GetById(int id)
        {
            var order = await _orderRepository.GetById(id);
            return order;
        }
        public async Task<Order> Create(Order order)
        {
            var newOrder = await _orderRepository.Create(order);
            return newOrder;
        }

        public async Task<Order> Update(int id, Order order)
        {
            var editOrder = await _orderRepository.Update(id, order);
            return editOrder;
        }
        public async Task<Order> Delete(int id)
        {
            var order = await _orderRepository.Delete(id);
            return order;
        }

        public Task<Order> LoginId(int id)
        {
            throw new NotImplementedException();
        }

    }
}
