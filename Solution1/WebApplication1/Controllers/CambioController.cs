using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CambioController : ControllerBase
    {
        Conversor c = new Conversor();
        

        private readonly ILogger<CambioController> _logger;

        public CambioController(ILogger<CambioController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetCambio")]
        public IEnumerable<Cambio> Get()
        {

            Cambio cambio = new Cambio
            {
                units = c.units, 
                toUnits = c.toUnits, 
                fromUnits = c.fromUnits, 
            };

            // Devuelve una colección que contiene ese único objeto Cambio
            return new List<Cambio> { cambio };

        }

        public IEnumerable<Cambio>

       
    }
}