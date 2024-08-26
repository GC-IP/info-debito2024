using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_2_recupero.Model
{
    internal class VideogiochiPlus:Videogioco
    {
        public Accessorio Accessorio { get; set; }
        public string TipoServizio { get; set; }
    }
}
