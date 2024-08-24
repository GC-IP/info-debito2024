using System.Text.Json;
using Debito_Es1.Model;

namespace Debito_Es1.Repository
{
    public class MenuRepository
    {

        const string FileJsonMenue = "menu.json";

        public static List<Menu> ElencoMenu()
        {
            if (!File.Exists(FileJsonMenue))
            {
                File.WriteAllText(FileJsonMenue, "[]");
            }
            var json = File.ReadAllText(FileJsonMenue);
            var lista = JsonSerializer.Deserialize<List<Menu>>(json);
            return lista;
        }
        public static void AggiungiMenu(Menu menu)
        {
            var lista = ElencoMenu();
            lista.Add(menu);
            var json = JsonSerializer.Serialize(lista);
            File.WriteAllText(FileJsonMenue, json);
        }
    }
}