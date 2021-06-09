using MN_Groop_A.P.S.Domain;
using MN_Groop_A.P.S.IRepositories;
using MN_Groop_A.P.S.IServices;
using MN_Groop_A.P.S.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MN_Groop_A.P.S.services
{
    public class KundeServices : IKundeServices
    {
        private readonly IKundeRepository _kundeRepository;
        public KundeServices(IKundeRepository kundeRepository)
        {
            _kundeRepository = kundeRepository;
        }
        public async Task<List<Kunde>> GetAllKundes()
        {
            var kunde = await _kundeRepository.GetAll();
            return kunde;
        }
       
        public async Task<Kunde> GetKundeById(int id)
        {
            var kunde = await _kundeRepository.GetById(id);
            return kunde;
        }
        public Task<Kunde> Create(Kunde kunde)
        {
            throw new NotImplementedException();
        }
        public Task<Kunde> Update(int id, Kunde kunde)
        {
            throw new NotImplementedException();
        }
        public Task<Kunde> Delete(int id)
        {
            throw new NotImplementedException();
        }

    }
}
