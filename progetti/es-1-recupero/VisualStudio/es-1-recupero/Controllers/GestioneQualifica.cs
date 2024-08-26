using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using es_1_recupero.Model;
using es_1_recupero.Repository;

namespace es_1_recupero.Controllers
{
    internal class GestioneQualifica
    {
        public void InserisciQualifica(Qualifica qualifica)
        {
            QualificaRepository.AggiungiQualifica(qualifica);
        }
    }
}
