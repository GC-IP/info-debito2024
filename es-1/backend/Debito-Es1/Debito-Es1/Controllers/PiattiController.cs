using Debito_Es1.Model;
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
            var lista = new List<Piatto>();
            lista.Add(new Piatto
            {
                Nome = "Pasta",
                Descrizione = "bho, cosa si descrive della pasta?",
                Calorie = 150,
                Prezzo = 15
            });
            lista.Add(new Piatto
            {
                Nome = "Riso",
                Descrizione = "bho, cosa si descrive del riso?",
                Calorie = 128,
                Prezzo = 10
            });
            lista.Add(new Piatto
            {
                Nome = "Zuppa",
                Calorie = 75,
                Prezzo = 16
            });
            return lista;
        }
    }
}
