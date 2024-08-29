using Grafi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrezioneVerifica
{
    public class Esercizio2
    {
        Grafo<string> grafoPersone = new Grafo<string>();
        public void StampaGrafo()
        {
            Stampa(grafoPersone.Nodi);
        }

        public void Stampa(List<Nodo<string>> listaNodi)
        {
            Console.WriteLine("--- CHECKPOINT ---");
            foreach (var n in listaNodi)
            {
                Console.WriteLine($"Nodo: {n.Nome}: distanza dalla sorgente: {n.DistanzaDallaSorgente}");
            }
            Console.WriteLine("---    ----    ---");
        }
        public void InserisciPersona(string persona)
        {
            grafoPersone.AggiungiNodo(persona, persona);
        }
        public void InserisciConoscenza(string persona1, string persona2)
        {
            grafoPersone.AggiungiArco(persona1, persona2);
        }

        internal List<Nodo<string>> ElencoPersoneCheConosce(string persona)
        {
            var lista = grafoPersone.DFS();
            return lista;
        }

        internal List<Nodo<string>> ElencoPersoneDirette(string persona)
        {
            var lista = grafoPersone.BFS(persona);
            return lista;
        }
    }
}
