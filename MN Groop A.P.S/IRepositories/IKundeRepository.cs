﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MN_Groop_A.P.S.Domain;

namespace MN_Groop_A.P.S.IRepositories
{
    interface IKundeRepository
    {
        Task<List<Kunde>> GetAll();
        Task<Kunde> GetById(int id);
        Task<Kunde> Create(string firstname, string lastname, string vejnavn, int postnummer, string email);
        Task<Kunde> Update(int id, Kunde kunde);
        Task<Kunde> Delete(int id);
    }
}
