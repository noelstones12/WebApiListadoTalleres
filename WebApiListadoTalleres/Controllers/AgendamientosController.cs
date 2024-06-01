using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiListadoTalleres.Entidades;

namespace WebApiListadoTalleres.Controllers
{
    [ApiController]
    [Route("Api/agendamientos")]
    public class AgendamientosController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public AgendamientosController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet("id:int")]
        public async Task<ActionResult<Agendamiento>> Get(int id)
        {
            return await context.DbAgendamientos.Include(x => x.Taller).FirstOrDefaultAsync(x => x.Id == id); 
        }

        [HttpPost]
        public async Task<ActionResult> Post(Agendamiento agendamiento)
        {
            var existeAgendamiento = await context.DbAgendamientos.AnyAsync(x => x.Id == agendamiento.TallerId);
                                                                                                                                     
            if (!existeAgendamiento)
            {
                return BadRequest($"No existe agendamiento de Id: {agendamiento.TallerId}");
            }
            context.Add(agendamiento);
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}
