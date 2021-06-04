using MN_Groop_A.P.S.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MN_Groop_A.P.S.IRepositories
{
    interface IDeliveryRepository
    {
        Task<List<Delivery>> GetAll();
        Task<Delivery> GetById(int id);
        Task<Delivery> Create(string name, string addresse, int leveringspris, string leveringsmetode);
        Task<Delivery> Update(int id, Delivery delivery);
        Task<Delivery> Delete(int id);
    }
}
