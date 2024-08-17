using Debito_Es1.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Debito_Es1.Controllers
{
    [Route("api/piatti")]
    [ApiController]
    public class PiattiController : ControllerBase
    {
        public List<Piatto> ElencoPiatti()
        {
            var lista = new List<Piatto>();
            lista.Add(new Piatto
            {
                Nome = "Pasta",
                Calorie = 150
            });
            lista.Add(new Piatto
            {
                Nome = "Riso",
                Calorie = 128
            });
            return lista;
        }
    }
}
