using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MN_Groop_A.P.S.Domain;
using MN_Groop_A.P.S.IRepositories;

namespace MN_Groop_A.P.S.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        public Task<Login> Create(string email, string password)
        {
            throw new NotImplementedException();
        }

        public Task<Login> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Login>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Login> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Login> IsAdmin(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Login> Update(int id, Login login)
        {
            throw new NotImplementedException();
        }
    }
}
