using System.Text.Json;
using Debito_Es1.Model;

namespace Debito_Es1.Repository
{
    public class MenuRepository
    {

        const string FileJson = @"C:\Users\greta\OneDrive\Documenti\WORK N STUFF\school\Paleocapa\anno scolastico 2023-2024 (4ia)\INFO\info-debito2024\progetti\file-json\menu.json";

        public static List<Menu> ElencoMenu()
        {
            if (!File.Exists(FileJson))
            {
                File.WriteAllText(FileJson, "[]");
            }
            var json = File.ReadAllText(FileJson);
            var lista = JsonSerializer.Deserialize<List<Menu>>(json);
            return lista;
        }
        public static void AggiungiMenu(Menu menu)
        {
            var lista = ElencoMenu();
            lista.Add(menu);
            var json = JsonSerializer.Serialize(lista);
            File.WriteAllText(FileJson, json);
        }
    }
}