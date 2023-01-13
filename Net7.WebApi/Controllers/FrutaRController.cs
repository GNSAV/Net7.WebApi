using Microsoft.AspNetCore.Mvc;
using Net7.WebApi.Entidades;
using Net7.WebApi.Persistencia;
using Net7.WebApi.Repositorios;

namespace Net7.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FrutaRController : ControllerBase
    {
        private readonly Context context;
        private readonly IGenericRepository<Fruta> repo;

        public FrutaRController(Context context, IGenericRepository<Fruta> repo)
        {
            this.context = context;
            this.repo = repo;
        }

        // Este método es una acción de controlador en un controlador web API
        // que se encarga de obtener todas las frutas. La acción utiliza la propiedad
        // 'repo' de tipo 'IGenericRepository<Fruta>' para llamar al método 'GetAll()'
        // que devuelve todas las frutas. El resultado se devuelve al cliente como una
        // colección de frutas.

        [HttpGet]
        public IEnumerable<Fruta> GetFrutas() => repo.GetAll();
    }
}
