using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MN_Groop_A.P.S.Domain;

namespace MN_Groop_A.P.S.IRepositories
{
    interface IOrderRepository
    {
        Task<List<Order>> GetAll();
        Task<Order> GetById(int id);
        Task<Order> Create(int id, DateTime )
    }
}
