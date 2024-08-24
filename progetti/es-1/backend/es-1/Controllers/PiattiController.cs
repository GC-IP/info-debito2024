using Debito_Es1.Model;
using Debito_Es1.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Debito_Es1.Controllers
{
    [Route("api/piatti")]
    [ApiController]
    public class PiattiController : ControllerBase
    {
        [HttpGet]
        public List<Piatto> ElencoPiatti()
        {
            var lista = PiattoRepository.ElencoPiatti();
            return lista;
        }
        [HttpPost]
        public void AggiungiPiatto(Piatto piatto)
        {
            PiattoRepository.AggiungiPiatto(piatto);
        }
    }
}
