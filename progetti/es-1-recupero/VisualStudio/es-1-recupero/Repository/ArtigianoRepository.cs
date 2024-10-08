﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using es_1_recupero.Model;

namespace es_1_recupero.Repository
{
    internal class ArtigianoRepository
    {
        const string FileJson = @"C:\Users\greta\OneDrive\Documenti\WORK N STUFF\school\Paleocapa\anno scolastico 2023-2024 (4ia)\INFO\info-debito2024\progetti\file-json\artigiani.json";

        public static List<Artigiano> ElencoArtigiani()
        {
            if (!File.Exists(FileJson))
            {
                File.WriteAllText(FileJson, "[]");
            }
            var json = File.ReadAllText(FileJson);
            var lista = JsonSerializer.Deserialize<List<Artigiano>>(json);
            return lista;
        }
        public static void AggiungiArtigiano(Artigiano artigiano)
        {
            var lista = ElencoArtigiani();
            lista.Add(artigiano);
            var json = JsonSerializer.Serialize(lista);
            File.WriteAllText(FileJson, json);
        }

        internal static void ModificaArtigiano(Artigiano artigiano)
        {
            var lista = ElencoArtigiani();
            var arti = lista.FirstOrDefault(a => a.CodiceArtigiano == artigiano.CodiceArtigiano);
            if(arti == null)
            {
                return;
            }
            arti.RichiestaPrezzo = artigiano.RichiestaPrezzo;
            arti.Qualifica = artigiano.Qualifica;
            arti.Nome = artigiano.Nome;
            arti.ComuneResidenza = artigiano.ComuneResidenza;
;
            var json = JsonSerializer.Serialize(lista);
            File.WriteAllText(FileJson, json);
        }

        internal static void EliminaArtigiano(Artigiano artigiano)
        {
            var lista = ElencoArtigiani();
            var arti = lista.FirstOrDefault(a => a.CodiceArtigiano == artigiano.CodiceArtigiano);
            if (arti != null)
            {
                lista.Remove(arti);
                var json = JsonSerializer.Serialize(lista);
                File.WriteAllText(FileJson, json);
            }
        }

        internal static Artigiano ArtigianoPerCodice(int codiceArtigiano)
        {
            var lista = ElencoArtigiani();
            var arti = lista.FirstOrDefault(a => a.CodiceArtigiano == codiceArtigiano);
            return arti;
        }
    }
}
