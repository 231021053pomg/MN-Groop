using MN_Groop_A.P.S.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MN_Groop_A.P.S.IRepositories
{
    interface IDeliveryRepository
    {

        Task<Delivery> Create(int Antal, string name, string addresse, int leveringspris, string leveringsmetode);
        Task<Delivery> Update(int id, Delivery delivery);
        Task<Delivery> Delete(int id);
    }
}
