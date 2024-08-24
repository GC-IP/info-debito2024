using System.Text.Json;
using Debito_Es1.Model;

namespace Debito_Es1.Repository
{
    public class PiattoRepository
    {

        const string FileJsonPiatti = "piatti.json";

        public static List<Piatto> ElencoPiatti()
        {
            if(!File.Exists(FileJsonPiatti))
            {
                File.WriteAllText(FileJsonPiatti, "[]");
            }
            var json = File.ReadAllText(FileJsonPiatti);
            var lista = JsonSerializer.Deserialize<List<Piatto>>(json);
            return lista;
        }
        public static void AggiungiPiatto(Piatto piatto)
        {
            var lista = ElencoPiatti();
            lista.Add(piatto);
            var json = JsonSerializer.Serialize(lista);
            File.WriteAllText(FileJsonPiatti, json);
        }
    }
}
