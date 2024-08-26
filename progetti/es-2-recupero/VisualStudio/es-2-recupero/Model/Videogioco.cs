using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_2_recupero.Model
{
    internal class Videogioco
    {
        public string Nome { get; set; }
        public DittaProduttrice DittaProduttrice { get; set; }
        public float CostoVideogioco { get; set; }
    }
}
