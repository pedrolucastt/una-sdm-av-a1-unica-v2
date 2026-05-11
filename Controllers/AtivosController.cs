using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetroAtivosSeuRA.Data;
using PetroAtivosSeuRA.Models;

namespace PetroAtivosSeuRA.Controllers
{
    [ApiController]
    [Route("ativos")]
    public class AtivosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AtivosController(AppDbContext context)
        {
            _context = context;
        }

        // GET /ativos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ativo>>> Get()
        {
            return await _context.Ativos.ToListAsync();
        }

        // GET /ativos/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Ativo>> GetById(int id)
        {
            var ativo = await _context.Ativos.FindAsync(id);

            if (ativo == null)
            {
                return NotFound();
            }

            return ativo;
        }

        // POST /ativos
        [HttpPost]
        public async Task<ActionResult<Ativo>> Post(Ativo ativo)
        {
            _context.Ativos.Add(ativo);

            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetById),
                new { id = ativo.Id },
                ativo
            );
        }
    }
}
