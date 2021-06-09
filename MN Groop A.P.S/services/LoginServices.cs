using MN_Groop_A.P.S.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MN_Groop_A.P.S.IRepositories;
using MN_Groop_A.P.S.Repositories;
using MN_Groop_A.P.S.services;

namespace MN_Groop_A.P.S.services
{
    public class LoginServices : ILoginRepository
    {
        private readonly ILoginRepository _loginRepository;
        public LoginServices(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }

        public async Task<List<Login>> GetAll()
        {
            var login = await _loginRepository.GetAll();
            return login;

        }
        public async Task<Login> GetById(int id)
        {
            var login = await _loginRepository.GetById(id);
            return login;
        }
        public  Task<Login> Create(Login login)
        {
            throw new NotImplementedException();
        }
        public Task<Login> Update(int id, Login login)
        {
            throw new NotImplementedException();
        }

        public  Task<Login> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Login> IsAdmin(int id)
        {
            throw new NotImplementedException();
        }

    }
}
