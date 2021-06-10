using MN_Groop_A.P.S.Domain;
using MN_Groop_A.P.S.IRepositories;
using MN_Groop_A.P.S.services;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Test_MN_GroopAPS
{
    public class KategoriServiceTests
    {
        private readonly KategoriServices _sut;
        private readonly Mock<IKategoriRepository> _kategoriRepositoryMock = new();

        public KategoriServiceTests()
        {
            _sut = new KategoriServices(_kategoriRepositoryMock.Object);
        }

        [Fact]
        public async Task Create_ShouldFailIfNullIsPassed()
        {
            // Arrange
            _kategoriRepositoryMock
                .Setup(x => x.Create(It.IsAny<Kategori>()))
                .ReturnsAsync(() => null);

            // Act
            var Kategori = await _sut.Create(null);

            // Assert
            Assert.Null(Kategori);
        }

        [Fact]
        public async Task GetByIdAsync_ShouldReturnNothing_WhenAuthorDoesNotExist()
        {
            // Arrange
            // make the MockRepo return null when any Kategori is requested
            _kategoriRepositoryMock
                .Setup(x => x.GetById(It.IsAny<int>()))
                .ReturnsAsync(() => null);

            // Act
            // try to get a single Kategori with the id == 1
            var Kategori = await _sut.GetKategoriById(1);

            // Assert
            Assert.Null(Kategori);
        }

        [Fact]
        public async Task GetByIdAsync_ShouldReturnKategori_WhenKategoriExists()
        {
            // Arrange
            // setup the Mock Kategori data
           
            var KategoriTitle = "Sennep";
            var KategorBeskrivelse = "Den er stærk";
            var KategoriProdukts = "Saucer";


            {

                Title = KategoriTitle;
                Beskrivelse = KategorBeskrivelse;
                PProduktsrodukt = KategoriProdukts;
            };
           
            // Act
            var Kategori = await _sut.GetAuthorById(authorId);

            // Assert
            Assert.Equal(mockAuthor, Kategori);

        }
    }
}
