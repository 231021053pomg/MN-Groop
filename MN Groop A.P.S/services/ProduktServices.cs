using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MN_Groop_A.P.S.Domain;
using MN_Groop_A.P.S.Repositories;
using MN_Groop_A.P.S.IRepositories;

namespace MN_Groop_A.P.S.services
{
    public class ProduktServices : IProduktRepository
    {
        private readonly IProduktRepository _produktRepository;
        public ProduktServices(IProduktRepository produktRepository)
        {
            _produktRepository = produktRepository;
        }

        public async Task<List<Produkt>> GetAll()
        {
            var produkt = await _produktRepository.GetAll();
            return produkt;
        }

        public async Task<Produkt> GetById(int id)
        {
            var produkt = await _produktRepository.GetById(id);
            return produkt;
        }

        public Task<Produkt> Update(int id, Produkt produkt)
        {
            throw new NotImplementedException();
        }
        public Task<Produkt> Create(Produkt produkt)
        {
            throw new NotImplementedException();
        }

        public Task<Produkt> Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
