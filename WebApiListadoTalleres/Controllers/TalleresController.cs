using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiListadoTalleres.Entidades;

namespace WebApiListadoTalleres.Controllers
{
    [ApiController]
    [Route("Api/talleres")]
    public class TalleresController: ControllerBase
    {
        private readonly ApplicationDbContext context;

        public TalleresController(ApplicationDbContext context) 
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Taller>>> Get() 
        {
            return await context.DbTalleres.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult> Post(Taller taller) 
        {
            context.Add(taller);
            await context.SaveChangesAsync();
            return Ok();
        }
        [HttpPut("(id:int)")] // api/talleres/id(numeración)
        public async Task<ActionResult> Put(Taller taller, int id) 
        {
            if (taller.Id != id)
            {
                return BadRequest("Id del autor no coincide con el Id de la URL");
            }

            var existe = await context.DbTalleres.AnyAsync(x => x.Id == id);


            if (!existe)
            {
                return NotFound();
            }

            context.Update(taller);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("(id:int)")] // api/talleres/id(numeración)
        public async Task<ActionResult> Delete(int id) 
        {
            var existe = await context.DbTalleres.AnyAsync(x => x.Id == id);

            if (!existe)
            { 
                return NotFound();
            }

            context.Remove(new Taller() { Id = id });
            await context.SaveChangesAsync();
            return Ok();
        }

    }
}
