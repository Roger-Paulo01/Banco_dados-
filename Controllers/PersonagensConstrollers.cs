using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RpgApi.Data;
using RpgApi.DataContext;
using Microsoft.EntityFrameworkCore;
using RpgApi.Models;



namespace RpgApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonagensConstrollers : ControllerBase
    {

        private readonly DataContex _context;

        public PersonagensConstrollers(DataContex context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Tasks<IActionResult> GetSingle(int id)
        {
            try
            {
                Personagem p = await _context.TB_PERSONAGENS
                    .FirstOrDefaultAsync(pBusca => pBusca.Id == id);

                return Ok(p);    
            }
            catch (System.Exception ex)
            {
                
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetAll")]
        public async Tasks<IActionResult> Get()
        {
            try
            {
                List<Personagem> lista = await _context.TB_PERSONAGENS.ToListAsync();
                return ok(lista);
            }
            catch (System.Exception ex)
            {               
                return BadRequest(ex.Message);
            }
        }


    }
}