using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_1_recupero.Model
{
    internal class Artigiano
    {
        public int CodiceArtigiano { get; set; }
        public string Nome { get; set; }
        public string ComuneResidenza { get; set; }
        public Qualifica Qualifica { get; set; }
        public float RichiestaPrezzo { get; set; }
    }
}
