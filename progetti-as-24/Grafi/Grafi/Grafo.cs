namespace Grafi
{
    /// <summary>
    /// Per costruire un grafo, prima devo aggiungere i nodi, poi posso connettere i nodi
    /// usando degli archi
    /// </summary>
    public class Grafo<T>
    {
        public string Nome{ get; set; }
        public List<Nodo<T>> Nodi { get; set; } = new List<Nodo<T>>();
        public List<Arco<T>> Archi { get; set; } = new List<Arco<T>>();

        /// <summary>
        /// Aggiunge un nodo alla collezione di nodi del grafo
        /// </summary>
        /// <param name="nome">Il nome del nodo</param>
        /// <returns></returns>
        public Nodo<T> AggiungiNodo(string nome, T valore)
        {
            var n1 = Nodi.FirstOrDefault(e => e.Nome == nome);
            if(n1 != null)
            {
                throw new ArgumentException($"Il nodo {nome} esiste già");
            }

            var n = new Nodo<T>();
            n.Nome = nome;
            n.Valore = valore;
            Nodi.Add(n);
            return n;
        }
        /// <summary>
        /// Aggiunge un arco al grafo connettendo due nodi. I due nodi devono già essere stati aggiunti
        /// nel grafo. Se non ci sono restituisce un errore.
        /// </summary>
        /// <param name="nomeNodo1"></param>
        /// <param name="nomeNodo2"></param>
        public Arco<T> AggiungiArco(string nomeNodo1, string nomeNodo2)
        {
            // cerco nella collezione dei miei nodi, i nodi che hanno i nomi che mi sono stati passati come argomento
            var n1 = Nodi.FirstOrDefault(e => e.Nome == nomeNodo1);
            var n2 = Nodi.FirstOrDefault(e => e.Nome == nomeNodo2);
            if(n1 == null || n2 == null)
            {
                throw new ArgumentException("I nodi devono esistere per poter creare un arco");
            }

            // controllo se l'arco è gia stato aggiunto
            var giaAggiunto = Archi.FirstOrDefault(e => 
                e.Predecessore.Nome == nomeNodo1 && e.Successore.Nome == nomeNodo2 ||
                e.Predecessore.Nome == nomeNodo2 && e.Successore.Nome == nomeNodo1
            );
            if (giaAggiunto != null)
            {
                throw new ArgumentException($"L'arco che connette {nomeNodo1} e {nomeNodo2} esiste già");
            }

            var a = new Arco<T>();
            a.Orientato = false;
            a.Peso = 0;
            a.Predecessore = n1;
            a.Successore = n2;

            n1.Archi.Add(a);
            n2.Archi.Add(a);

            Archi.Add(a);
            return a;
        }
        public List<Nodo<T>> BFS(string nodoDiPartenza)
        {
            var sequenzaDiVisita = new List<Nodo<T>>(); 
            // algoritmo BFS 
            var sorgente = Nodi.FirstOrDefault(e => e.Nome == nodoDiPartenza);
            if (sorgente == null)
            {
                throw new ArgumentException($"Il nodo {nodoDiPartenza} indicato come sorgente, non esiste in questo grafo");
            }

            // inizializzo i nodi:
            foreach (var u in Nodi)
            {
                u.Visitato = false;
                u.Completato = false;
                u.DistanzaDallaSorgente = int.MaxValue;
                u.PredecessoreBFS = null;
            }
            // inzializzo il sorgente
            sorgente.Visitato = true;
            sorgente.DistanzaDallaSorgente = 0;
            var coda = new Queue<Nodo<T>>();
            coda.Enqueue(sorgente);
            sequenzaDiVisita.Add(sorgente);
            // ciclo BFS
            while ( coda.Count > 0 ) 
            {
                var nodoCorrente = coda.Dequeue();
                foreach ( var adiacenza in nodoCorrente.Archi )
                {
                    var altroNodo = adiacenza.AltroNodo(nodoCorrente);
                    if ( !altroNodo.Visitato )
                    {
                        altroNodo.Visitato = true;
                        altroNodo.DistanzaDallaSorgente = nodoCorrente.DistanzaDallaSorgente + 1;
                        altroNodo.PredecessoreBFS = nodoCorrente;
                        coda.Enqueue(altroNodo);
                        sequenzaDiVisita.Add(altroNodo);
                    }                        
                }
                nodoCorrente.Completato = true;
            }
            return sequenzaDiVisita;
        }
        public List<Nodo<T>> DFS()
        {
            var sequenzaDiVisita = new List<Nodo<T>>();
            // algoritmo DFS 
            // inizializzo i nodi:
            foreach (var u in Nodi)
            {
                u.Visitato = false;
                u.Completato = false;
                u.DistanzaDallaSorgente = int.MaxValue;
                u.PredecessoreBFS = null;
            }
            // ciclo DFS
            var prodonfitaRaggiunta = 0;
            foreach (var nodo in Nodi)
            {
                if (!nodo.Visitato)
                {
                    DFSVisitaRicorsiva(nodo, prodonfitaRaggiunta, sequenzaDiVisita);
                }
            }           
            return sequenzaDiVisita;
        }

        private void DFSVisitaRicorsiva(Nodo<T> nodoCorrente, int prodonfita, List<Nodo<T>> sequenzaDiVisita)
        {
            nodoCorrente.Visitato = true;
            sequenzaDiVisita.Add(nodoCorrente);
            nodoCorrente.DistanzaDallaSorgente = prodonfita;
            foreach(var arco in nodoCorrente.Archi)
            {
                var altroNodo = arco.AltroNodo(nodoCorrente);
                if(!altroNodo.Visitato)
                {
                    altroNodo.PredecessoreDFS = nodoCorrente;
                    var nuovaProfondita = prodonfita + 1;
                    DFSVisitaRicorsiva(altroNodo, nuovaProfondita, sequenzaDiVisita);
                }
            }
            nodoCorrente.Completato = true;
        }
    }
}
