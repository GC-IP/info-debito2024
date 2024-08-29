using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liste
{
    public class GestoreListeCollegate
    {
        public void MetodoConGliEsempi()
        {
            // per implementare dei grafi, si possono usare le LinkedList<T>, ma anche altre soluzioni
            // qui vediamo nello specifico come funziona una LinkedList
            // T è il tipo dell'elemento (che andrà nel nodo della lista)

            // dichiarazione di una linkedlist di stringhe
            var listaCollegata = new LinkedList<string>();

            // proviamo a gestire un testo come una LinkedList di parole
            // l'aggiunta restituisce sempre un nodo (un LinkedListNode)
            var silvia = listaCollegata.AddFirst("Silvia");

            // per aggiungere altre parole abbiamo diverse opzioni
            // - sappiamo dove stanno nella lista e usiamo quindi l'oggetto lista
            // - sappiamo in che relazione stanno rispetto a un nodo che abbiamo già, quindi usiamo il nodo
            
            // opzione 1.
            var lontano = listaCollegata.AddLast("lontano");

            // opzione 2.
            var rimembri = listaCollegata.AddAfter(silvia, "rimembri");
            var di = listaCollegata.AddBefore(lontano, "di");

            // gli elementi (nodi) si possono rimuovere, in funzione della posizione nella lista 
            // la lista può essere navigata con .Next() e .Previous()

        }
    }
}
