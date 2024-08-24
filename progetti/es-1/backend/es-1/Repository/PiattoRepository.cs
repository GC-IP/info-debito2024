using System.Text.Json;
using Debito_Es1.Model;

namespace Debito_Es1.Repository
{
    public class PiattoRepository
    {

        const string FileJson = @"C:\Users\greta\OneDrive\Documenti\WORK N STUFF\school\Paleocapa\anno scolastico 2023-2024 (4ia)\INFO\info-debito2024\progetti\file-json\piatti.json";

        public static List<Piatto> ElencoPiatti()
        {
            if(!File.Exists(FileJson))
            {
                File.WriteAllText(FileJson, "[]");
            }
            var json = File.ReadAllText(FileJson);
            var lista = JsonSerializer.Deserialize<List<Piatto>>(json);
            return lista;
        }
        public static void AggiungiPiatto(Piatto piatto)
        {
            var lista = ElencoPiatti();
            lista.Add(piatto);
            var json = JsonSerializer.Serialize(lista);
            File.WriteAllText(FileJson, json);
        }
    }
}
