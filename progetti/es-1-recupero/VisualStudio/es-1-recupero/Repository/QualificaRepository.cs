using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using es_1_recupero.Model;

namespace es_1_recupero.Repository
{
    internal class QualificaRepository
    {
        const string FileJson = @"C:\Users\greta\OneDrive\Documenti\WORK N STUFF\school\Paleocapa\anno scolastico 2023-2024 (4ia)\INFO\info-debito2024\progetti\file-json\qualifiche.json";

        public static List<Qualifica> ElencoQualifiche()
        {
            if (!File.Exists(FileJson))
            {
                File.WriteAllText(FileJson, "[]");
            }
            var json = File.ReadAllText(FileJson);
            var lista = JsonSerializer.Deserialize<List<Qualifica>>(json);
            return lista;
        }
        public static void AggiungiQualifica(Qualifica qualifica)
        {
            var lista = ElencoQualifiche();
            lista.Add(qualifica);
            var json = JsonSerializer.Serialize(lista);
            File.WriteAllText(FileJson, json);
        }
    }
}
