using MN_Groop_A.P.S.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MN_Groop_A.P.S.Domain;

namespace MN_Groop_A.P.S.Repositories
{
    public class KategoriRepository : IKategoriRepository
    {
        public Task<Kategori> Create(string title, string beskrivelse)
        {
            throw new NotImplementedException();
        }

        public Task<Kategori> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Kategori>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Kategori> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Kategori> Update(int id, Kategori kategori)
        {
            throw new NotImplementedException();
        }
    }
}
