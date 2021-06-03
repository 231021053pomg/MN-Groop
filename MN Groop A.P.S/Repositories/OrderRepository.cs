using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MN_Groop_A.P.S.Domain;
using MN_Groop_A.P.S.IRepositories;

namespace MN_Groop_A.P.S.Repositories
{
    public class OrderRepository : IOrder_DetailseRepository
    {
        public Task<List<Order_detalise>> GetAll()
        {
            throw new NotImplementedException();
        }
        public Task<Order_detalise> GetById(int id)
        {
            throw new NotImplementedException();
        }
        public Task<Order_detalise> Create(int antal, int stkpris, int produktid, int orderid)
        {
            throw new NotImplementedException();
        }
        public Task<Order_detalise> Update(int id, Order_detalise order_Detalise)
        {
            throw new NotImplementedException();
        }

        public Task<Order_detalise> Delete(int id)
        {
            throw new NotImplementedException();
        }

    }
}
