using Grafi;

namespace ConsoleGrafi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Il grafo è di tipo generico T; T può essere qualunque TIPO e diventerà
            // il tipo dei nodi del grafo
            Grafo<string> grafoDiStringhe = new Grafo<string>();
            Grafo<Exception> grafoDiEccezioni = new Grafo<Exception>();


            // facciamo un grafo che contiene valori interi...
            Grafo<int> grafoDiInteri = new Grafo<int>();

            grafoDiInteri.Nome = "Test n.1";

            // aggiungo i nodi
            grafoDiInteri.AggiungiNodo("A", 10);
            grafoDiInteri.AggiungiNodo("B", 11);
            grafoDiInteri.AggiungiNodo("C", 24);
            grafoDiInteri.AggiungiNodo("D", 7);
            grafoDiInteri.AggiungiNodo("E", 18);
            grafoDiInteri.AggiungiNodo("F", 3);

            // sistemo gli archi
            grafoDiInteri.AggiungiArco("A", "B");
            grafoDiInteri.AggiungiArco("A", "D");
            grafoDiInteri.AggiungiArco("A", "C");
            grafoDiInteri.AggiungiArco("B", "C");
            grafoDiInteri.AggiungiArco("C", "E");
            grafoDiInteri.AggiungiArco("C", "D");
            grafoDiInteri.AggiungiArco("D", "E");
            grafoDiInteri.AggiungiArco("D", "F");

            // questi sono esempi di errori....
            //g.AggiungiArco("D", "G");
            //g.AggiungiArco("D", "F");

            Console.WriteLine(grafoDiInteri.Nome);
            foreach (var n in grafoDiInteri.BFS("C"))
            {
                Console.WriteLine($"Nodo: {n.Nome}: distanza dalla sorgente: {n.DistanzaDallaSorgente}");
            }


            Grafo<int> esempioBFS = new Grafo<int>();
            esempioBFS.Nome = "Esempio BFS delle fotocopie";

            esempioBFS.AggiungiNodo("r", 0);
            esempioBFS.AggiungiNodo("s", 0);
            esempioBFS.AggiungiNodo("t", 0);
            esempioBFS.AggiungiNodo("u", 0);
            esempioBFS.AggiungiNodo("v", 0);
            esempioBFS.AggiungiNodo("w", 0);
            esempioBFS.AggiungiNodo("x", 0);
            esempioBFS.AggiungiNodo("y", 0);

            esempioBFS.AggiungiArco("v", "r");
            esempioBFS.AggiungiArco("r", "s");
            esempioBFS.AggiungiArco("s", "w");
            esempioBFS.AggiungiArco("w", "t");
            esempioBFS.AggiungiArco("w", "x");
            esempioBFS.AggiungiArco("t", "x");
            esempioBFS.AggiungiArco("t", "u");
            esempioBFS.AggiungiArco("u", "y");
            esempioBFS.AggiungiArco("x", "y");

            Console.WriteLine("BFS " + esempioBFS.Nome);
            foreach (var n in esempioBFS.BFS("s"))
            {
                Console.WriteLine($"Nodo: {n.Nome}: distanza dalla sorgente: {n.DistanzaDallaSorgente}");
            }

            Grafo<int> esempioDFS = new Grafo<int>();
            esempioDFS.Nome = "Esempio DFS delle fotocopie";

            esempioDFS.AggiungiNodo("1", 0);
            esempioDFS.AggiungiNodo("2", 0);
            esempioDFS.AggiungiNodo("3", 0);
            esempioDFS.AggiungiNodo("4", 0);
            esempioDFS.AggiungiNodo("5", 0);
            esempioDFS.AggiungiNodo("6", 0);

            esempioDFS.AggiungiArco("1", "2");
            esempioDFS.AggiungiArco("1", "4");
            esempioDFS.AggiungiArco("2", "4");
            esempioDFS.AggiungiArco("2", "3");
            esempioDFS.AggiungiArco("4", "5");
            esempioDFS.AggiungiArco("3", "6");
            esempioDFS.AggiungiArco("3", "5");
            esempioDFS.AggiungiArco("5", "6");

            Console.WriteLine("DFS " + esempioDFS.Nome);
            foreach (var n in esempioDFS.DFS())
            {
                Console.WriteLine($"Nodo: {n.Nome}: distanza dalla sorgente: {n.DistanzaDallaSorgente}");
            }

            var domande = new DomandeRampoldi();
            domande.Domanda1();
            domande.Domanda2();
            domande.Domanda3();
            domande.Domanda4();
            domande.Domanda5();
            domande.ProvaFinale();
        }
    }
}
