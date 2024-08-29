namespace Grafi
{
    /// <summary>
    /// Un nodo è un elemento da usare in un grafo
    /// </summary>
    public class Nodo<T>
    {
        public string Nome { get; set; }
        public T Valore { get; set; }
        public bool Visitato { get; set; } = false;
        public bool Completato { get; set; } = false;
        public int DistanzaDallaSorgente { get; set; }
        public Nodo<T> PredecessoreBFS { get; set; }
        public Nodo<T> PredecessoreDFS { get; set; }
        public List<Arco<T>> Archi { get; set; } = new List<Arco<T>>();

        public Nodo<T> AltroNodo(Arco<T> arco)
        {
            if(arco.Predecessore == this)
            {
                return arco.Successore;
            }
            return arco.Predecessore;
        }

    }
}
