using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gelateria
{
    internal class Prodotto
    {
        // decisi dalla gelateria
        public float Prezzo { get; set; }
        public string Nome { get; set; }
        public int NumeroGusti { get; set; }

        // decisi dal cliente
        public bool Panna { get; set; }
        public List<string> Gusti { get; set; }

        public string DescrizioneMenu 
        {
            get
            {
                return $"{Nome} - € {Prezzo.ToString("0.00")}"; 
            } 
        }
    }
}
