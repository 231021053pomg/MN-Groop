using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MN_Groop_A.P.S.Domain;
using MN_Groop_A.P.S.IRepositories;

namespace MN_Groop_A.P.S.Repositories
{
    public class Order_DetailseRepository : IOrderRepository
    {
        public Task<Order> Create(int id, DateTime orderdate)
        {
            throw new NotImplementedException();
        }

        public Task<Order> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Order>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Order> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Order> LoginId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Order> Update(int id, Order order)
        {
            throw new NotImplementedException();
        }
    }
}
