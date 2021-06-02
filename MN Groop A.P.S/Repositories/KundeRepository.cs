using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MN_Groop_A.P.S.Domain;
using MN_Groop_A.P.S.IRepositories;

namespace MN_Groop_A.P.S.Repositories
{
    public class KundeRepositoryb : IKundeRepository
    {
        public Task<Kunde> Create(string firstname, string lastname, string vejnavn, int postnummer)
        {
            throw new NotImplementedException();
        }

        public Task<Kunde> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Kunde>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Kunde> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Kunde> Update(int id, Kunde kunde)
        {
            throw new NotImplementedException();
        }
    }
}
