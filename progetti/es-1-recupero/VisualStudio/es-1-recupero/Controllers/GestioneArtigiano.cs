using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using es_1_recupero.Model;
using es_1_recupero.Repository;

namespace es_1_recupero.Controllers
{
    internal class GestioneArtigiano
    {
        public void InserisciArtigiano(Artigiano artigiano)
        {
            ArtigianoRepository.AggiungiArtigiano(artigiano);
        }

        public void ModificaArtigiano(int codiceArtigiano, Artigiano artigiano)
        {
            if(codiceArtigiano == artigiano.CodiceArtigiano)
            {
                ArtigianoRepository.ModificaArtigiano(artigiano);
            }
        }

        public void EliminaComune(string comuneResidenza)
        {
            var lista = ArtigianoRepository.ElencoArtigiani();
            foreach (var a in lista)
            {
                if (a.ComuneResidenza == comuneResidenza && !a.Qualifica.AbilitazioneProfessionale)
                {
                    ArtigianoRepository.EliminaArtigiano(a);
                }
            }
        }

        public List<Artigiano> CercaQualifica(Qualifica qualifica, bool ordPerNome, bool ordPerComune)
        {
            var lista = ArtigianoRepository.ElencoArtigiani();
            var qualificati = lista.Where(a => a.Qualifica?.IdQualifica  == qualifica.IdQualifica);
            if(ordPerNome)
            {
                return qualificati.OrderBy(a => a.Nome).ToList();
            }
            if (ordPerComune)
            {
                return qualificati.OrderBy(a => a.ComuneResidenza).ToList();
            }
            return qualificati.ToList();
        }

        public List<Artigiano> PrezzoPiuBasso(string idQualifica)
        {
            var lista = ArtigianoRepository.ElencoArtigiani();
            var qualificati = lista.Where(a => a.Qualifica?.IdQualifica == idQualifica).ToList();
            var prezzoPiuBasso = qualificati.Min(a => a.RichiestaPrezzo);
            return qualificati.Where(a => a.RichiestaPrezzo == prezzoPiuBasso).ToList();
        }

        public float CostoMedio(string idQualifica)
        {
            var lista = ArtigianoRepository.ElencoArtigiani();
            var qualificati = lista.Where(a => a.Qualifica?.IdQualifica == idQualifica).ToList();
            if(qualificati.Count == 0)
            {
                return 0;
            }
            return qualificati.Average(a => a.RichiestaPrezzo);
        }
    }
}
