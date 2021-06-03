using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MN_Groop_A.P.S.Domain;
using MN_Groop_A.P.S.IRepositories;

namespace MN_Groop_A.P.S.Repositories
{
    public class DeliveryRepository: IDeliveryRepository
    {
        public Task<Delivery> Create(string name, string addresse, int leveringspris, string leveringsmetode)
        {
            throw new NotImplementedException();
        }

        public Task<Delivery> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Delivery>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Delivery> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Delivery> Update(int id, Delivery delivery)
        {
            throw new NotImplementedException();
        }
    }
}
}
