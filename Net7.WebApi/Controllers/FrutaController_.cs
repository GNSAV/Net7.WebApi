//using Microsoft.AspNetCore.Mvc;
//using Net7.WebApi.Entidades;
//using Net7.WebApi.Modelos;
//using Net7.WebApi.Persistencia;

//namespace Net7.WebApi.Controllers
//{
//    [ApiController]
//    [Route("api/[controller]")]
//    public class FrutaController : ControllerBase
//    {
//        private readonly Context context;        
//        public FrutaController(Context context)
//        {
//            this.context = context; 
//        }


//        [HttpGet]
//        public IEnumerable<Fruta> GetFrutas()
//        {
//            return context.Frutas.AsEnumerable();
//        }
//    }
//}
