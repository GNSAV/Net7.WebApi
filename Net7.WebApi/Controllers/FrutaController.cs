using Microsoft.AspNetCore.Mvc;
using Net7.WebApi.Entidades;
using Net7.WebApi.Persistencia;
using Net7.WebApi.Repositorios;
using System.Net;

namespace Net7.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FrutaController : ControllerBase
    {
        private readonly IGenericRepository<Fruta> repo;
        public FrutaController(IGenericRepository<Fruta> repo) => this.repo = repo;

        // Este método es una acción de controlador en un controlador web API
        // que se encarga de obtener todas las frutas. La acción utiliza la propiedad
        // 'repo' de tipo 'IGenericRepository<Fruta>' para llamar al método 'GetAll()'
        // que devuelve todas las frutas. El resultado se devuelve al cliente como una
        // colección de frutas.

        [HttpGet]
        public IEnumerable<Fruta> GetFrutas() => repo.GetAll();

        [HttpGet("{id}")]
        public async Task<ActionResult<Fruta>> GetById(int id)
        {
            var result = repo.GetById(id);
            if(result == null)
            {
                return NotFound("No se encontro la fruta.");
            }
            return result;  
        }


        [HttpPost]
        public Fruta Post(Fruta data)
        {
            repo.Insert(data);
            repo.SaveChanges();
            return data;   
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var result = repo.Delete(id);
            if (result)
            {
                repo.SaveChanges();
                return Ok($"Eliminado la fruta con id : {id}");
            }

            return NotFound($"No se elimino la fruta con id : {id}");
            
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Fruta fruta)
        {
            var existingFruta = repo.GetById(id);
            if (existingFruta == null)
            {
                return NotFound();
            }

            repo.Update(fruta);
            repo.SaveChanges();

            return Ok();
        }


        //[HttpGet("{id}")]
        //public async Task<ActionResult<Caja>> GetById(Guid id)
        //{
        //    var result = await mediator.Send(new GetCajaByIdQuery(id));
        //    if (result == null)
        //    {
        //        return NotFound();
        //    }
        //    return result;
        //}
    }
}
