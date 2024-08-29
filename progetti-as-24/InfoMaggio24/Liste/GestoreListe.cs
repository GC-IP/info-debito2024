using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liste
{
    public class GestoreListe
    {
        public void MetodoConGliEsempi()
        {
            // dichiarazione di una lista (ce ne sono diversi tipi, noi usiamo List<T>)
            // una lista di interi; il tipo T di elementi nella lista si mette nelle parentesi angolari <T>
            var lista = new List<int>();
            // si possono fare liste di elementi di qualsiasi tipo

            // la lista List<T> ha le seguenti caratteristiche di base:
            // - gli elementi nella lista conservano l'ordine con il quale essi sono stati inseriti
            // - è possibile inserire elementi duplicati
            // - è possibile accedere agli elementi della lista, consocendo la loro posizione (indice), che è un int e parte da 0

            // aggiunta di elementi alla lista

            // in fondo [...... , 1]
            //                    ^
            lista.Add(1);

            // all'inizio => indice = 0
            // [10, ...... ,1]
            //  ^
            lista.Insert(0, 10); // indice è il primo argomento, il numero è il secondo

            // in una posizione data => specifico l'indice, ricordando che il primo elemento ha sempre indice 0
            // [10, 20, ......, 1]
            //      ^
            lista.Insert(1, 20);
            
            // è possibile cancellare elementi dalla lista:
            // - conoscendo l'indice dell'elemento da rimuovere
            // - conoscendo il valore da rimuovere

            // per indice
            lista.RemoveAt(0);

            // per valore => rimuove SOLO la prima occorrenza del valore nella lista (se c'è)
            lista.Remove(10);

            // è possibile scorrere la lista (come qualunque altra collezione) con foreach()
            foreach (var elemento in lista) 
            { 
                // elemento è del tipo T definito per la lista (in questa caso <int>)
                Console.WriteLine(elemento.ToString());
            }
        }
    }
}
