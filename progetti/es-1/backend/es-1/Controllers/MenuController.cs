using Debito_Es1.Model;
using Microsoft.AspNetCore.Mvc;

namespace Debito_Es1.Controllers
{
    [Route("api/menu")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        [HttpGet]
        public List<Menu> ElencoMenu()
        {
            var lista = new List<Menu>();
            lista.Add(new Menu
            {
                Giorno = "Lunedi",
            
            });
            return lista;
        }
    }
}
