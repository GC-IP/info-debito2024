using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using es_2_recupero.Model;
using es_2_recupero.Repository;


namespace es_2_recupero.Controllers
{
    internal class GestioneVideogioco
    {
        public void InserisciVideogioco(Videogioco videogioco)
        {
            VideogiocoRepository.AggiungiVideogioco(videogioco);
        }
    }
}
