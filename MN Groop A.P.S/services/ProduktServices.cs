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

        public async Task<Produkt> Update(int id, Produkt produkt)
        {
            var editProdukt = await _produktRepository.Update(id, produkt);
            return editProdukt;

        }
        public async Task<Produkt> Create(Produkt produkt)
        {
            var newProdukt = await _produktRepository.Create(produkt);
            return newProdukt;
        }

        public async Task<Produkt> Delete(int id)
        {
            var produkt = await _produktRepository.Delete(id);
            return produkt;
        }
    }
}
