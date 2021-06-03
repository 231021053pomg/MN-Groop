using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MN_Groop_A.P.S.Domain;
using MN_Groop_A.P.S.IRepositories;

namespace MN_Groop_A.P.S.Repositories
{
    public class ProduktRepository : IProduktRepository
    {
        public Task<List<Produkt>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Produkt> GetById(int id)
        {
            throw new NotImplementedException();
        }
        public Task<Produkt> Create(string name, string beskrivelse, int pris)
        {
            throw new NotImplementedException();
        }
        public Task<Produkt> Update(int id, Produkt produkt)
        {
            throw new NotImplementedException();
        }

        public Task<Produkt> Delete(int id)
        {
            throw new NotImplementedException();
        }

    }
}
