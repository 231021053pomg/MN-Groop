using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using MN_Groop_A.P.S.Database;
using MN_Groop_A.P.S.Repositories;
using MN_Groop_A.P.S.Domain;
using Microsoft.EntityFrameworkCore;


namespace Test_MN_GroopAPS
{
    public class TestRepositories
    {
        private readonly DbContextOptions<MNGroupDBConktext> _options;
        private readonly MNGroupDBConktext _context;
        public TestRepositories()
        {
            _options = new DbContextOptionsBuilder<MNGroupDBConktext>()
                .UseInMemoryDatabase(databaseName: "RepositoryDatabase")
                .Options;


            _context = new MNGroupDBConktext(_options);
            _context.Database.EnsureDeleted();

            //adding manule for test 1
            _context.Produkt.Add(new Produkt
            {
                Id = 1,
                Name = "Monster",
                Beskrivelse ="med citrion og lemon curd",
                Pris = 20
            }) ;

            //adding manule for test 2
            _context.Produkt.Add(new Produkt
            {
                Id = 2,
                Name = "cult",
                Beskrivelse = "med yosu og lemon curd",
                Pris = 20
            });

            //adding manule for test 3
            _context.Produkt.Add(new Produkt
            {
                Id = 3,
                Name = "smag",
                Beskrivelse = "med jordbær og lemon",
                Pris = 25
            });

            _context.SaveChanges();

        }

        [Fact]
        public async Task GetAllProdukts_ShoudReturn_whenProduktsEksist()
        {
            //arrange
            ProduktRepository produktRepository = new ProduktRepository(_context);

            //act 
            var produkt = await produktRepository.GetAll();

            //assert
            Assert.NotNull(produkt);
            Assert.Equal(3, produkt.Count);

        }
    }
}
