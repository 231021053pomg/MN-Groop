﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MN_Groop_A.P.S.Domain;

namespace MN_Groop_A.P.S.IRepositories
{
    interface IOrder_DetailseRepository
    {
        Task<List<Order_detalise>> GetAll();
        Task<Order_detalise> GetById(int id);
        Task<Order_detalise> Create(int antal, int stkpris, int produktid, int orderid);
        Task<Order_detalise> Update(int id, Order_detalise order_Detalise);
        Task<Order_detalise> Delete(int id);
    }
}
