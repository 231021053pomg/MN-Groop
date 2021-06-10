using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MN_Groop_A.P.S.services;
using MN_Groop_A.P.S.Repositories;
using MN_Groop_A.P.S.Domain;
using MN_Groop_A.P.S.IServices;

namespace MN_Groop_A.P.S.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KategoriController : ControllerBase
    {
        private readonly IKategoriServices _kategoriServices;
        public KategoriController(IKategoriServices kategoriServices)
        {
            _kategoriServices = kategoriServices;
        }
        //Https://localhost:5001/api
        [HttpGet]
         public async Task<IActionResult> GetAll()
        {
            var kategori = await _kategoriServices.GetAllkategoris();
            return Ok(kategori);
        }
        //Https://localhost:5001/api
        [HttpPost]
        public async Task<IActionResult> Create(Kategori kategori)
        {
            try
            {
                if (kategori == null)
                {
                    return BadRequest("Kategori fail....");
                }
                var newKategori = await _kategoriServices.Create(kategori);
                return Ok(newKategori);
            }
            catch (Exception ex)
            {

                return Problem(ex.Message);
            }
            
        }
    }
}
