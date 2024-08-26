using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using es_2_recupero.Model;

namespace es_2_recupero.Repository
{
    internal class VideogiocoRepository
    {
        const string FileJson = @"C:\Users\greta\OneDrive\Documenti\WORK N STUFF\school\Paleocapa\anno scolastico 2023-2024 (4ia)\INFO\info-debito2024\progetti\file-json\videogiochi.json";
        internal static void AggiungiVideogioco(Videogioco videogioco)
        {
            var lista = ElencoVideogiochi();
            lista.Add(videogioco);
            var json = JsonSerializer.Serialize(lista);
            File.WriteAllText(FileJson, json);
        }

        private static List<Videogioco> ElencoVideogiochi()
        {
            if (!File.Exists(FileJson))
            {
                File.WriteAllText(FileJson, "[]");
            }
            var json = File.ReadAllText(FileJson);
            var lista = JsonSerializer.Deserialize<List<Videogioco>>(json);
            return lista;
        }
    }
}
