using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafi
{
    public class Arco<T>
    {
        public Nodo<T> Predecessore { get; set; }
        public Nodo<T> Successore { get; set; }
        public bool Orientato { get; set; }
        public  int Peso { get; set; }

        public Nodo<T> AltroNodo(Nodo<T> nodo)
        {
            if (Predecessore == nodo)
            {
                return Successore;
            }
            return Predecessore;
        }
    }
}
