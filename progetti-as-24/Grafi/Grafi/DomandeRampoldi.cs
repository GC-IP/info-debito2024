using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Grafi
{
    public class DomandeRampoldi
    {
        public void Domanda1()
        {
            // contare i nodi di una lista o di un grafo che soddisfano determinati criteri;
            // ad esempio "contare tutti i nodi divisibili per 7"
            var numeri = new List<int>();
            numeri.Add(1);
            numeri.Add(5);
            numeri.Add(7);
            numeri.Add(23);
            numeri.Add(28);
            numeri.Add(11);
            numeri.Add(49);
            numeri.Add(6);
            numeri.Add(70);
            numeri.Add(3);
            numeri.Add(32);

            var numNodiDiv7 = numeri.Where(e => e % 7 == 0).Count();
            Console.WriteLine(numNodiDiv7);
        }
        public void Domanda2()
        {
            // data una stringa formattata o un file che rappresenta una lista o un grafo
            // implementare la funzione per l'importazione della stringa in una lista o in un grafo
            // uso il formato "1-2,2-4,1-4,2-3,3-5,4-5,3-6,5-6"
            var rappresetnazione = "1-2,2-4,1-4,2-3,3-5,4-5,3-6,5-6";
            var archi = rappresetnazione.Split(",");

            Grafo<string> grafo = new Grafo<string>();

            foreach(var a in archi)
            {
                var nodoSx = a.Substring(0, a.IndexOf("-"));
                var nodoDx = a.Substring(a.IndexOf("-") + 1);
                // il nodo di snistra
                try
                {
                    grafo.AggiungiNodo(nodoSx, nodoSx);

                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Nodo duplicato => skip");
                }
                // il nodo di destra
                try
                {
                    grafo.AggiungiNodo(nodoDx, nodoDx);

                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Nodo duplicato => skip");
                }
                // l'arco
                try
                {
                    grafo.AggiungiArco(nodoSx, nodoDx);

                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Arco duplicato => skip");
                }
                
            }
        }
        public void Domanda3()
        {
            // realizzare una funzione che esporti una lista o un grafo in una stringa formattata o un file
            var numeri = new List<int>();
            numeri.Add(1);
            numeri.Add(5);
            numeri.Add(7);
            numeri.Add(23);
            numeri.Add(28);
            numeri.Add(11);
            numeri.Add(49);
            numeri.Add(6);
            numeri.Add(70);
            numeri.Add(3);
            numeri.Add(32);

            // in una stroinga formattata
            var stringaFormattata = String.Join(',', numeri.ToArray());
            Console.WriteLine(stringaFormattata);

            // in un file JSON
            var json = JsonSerializer.Serialize(numeri.ToArray());
            Directory.CreateDirectory(@"C:\compito");
            File.AppendAllText(@"C:\compito\greta.txt", json);
        }
        public void Domanda4()
        {
            // creare un grafo di numeri e sommare il valore di tutti o ti tutti quelli raggiungibili a partire da un certo nodo
            Grafo<int> grafoDiInteri = new Grafo<int>();

            grafoDiInteri.Nome = "Test n.1";

            // aggiungo i nodi
            grafoDiInteri.AggiungiNodo("A", 10);
            grafoDiInteri.AggiungiNodo("B", 11);
            grafoDiInteri.AggiungiNodo("C", 24);
            grafoDiInteri.AggiungiNodo("D", 7);
            grafoDiInteri.AggiungiNodo("E", 18);
            grafoDiInteri.AggiungiNodo("F", 3);
            grafoDiInteri.AggiungiNodo("IRRAGGIUNGBILE", 33);

            // sistemo gli archi
            grafoDiInteri.AggiungiArco("A", "B");
            grafoDiInteri.AggiungiArco("A", "D");
            grafoDiInteri.AggiungiArco("A", "C");
            grafoDiInteri.AggiungiArco("B", "C");
            grafoDiInteri.AggiungiArco("C", "E");
            grafoDiInteri.AggiungiArco("C", "D");
            grafoDiInteri.AggiungiArco("D", "E");
            grafoDiInteri.AggiungiArco("D", "F");

            Console.WriteLine(grafoDiInteri.Nome);
            var sommaFinale = grafoDiInteri.BFS("C").Sum(e => e.Valore);
            Console.WriteLine($"La somma è {sommaFinale}");
        }
        public void Domanda5()
        {
            // creare un grafo di stringhe trovare la il nodo con la stringa più lunga raggiungibile a partire da un certo nodo
            Grafo<string> grafoDiStringhe = new Grafo<string>();

            grafoDiStringhe.Nome = "Test n.1";

            // aggiungo i nodi
            grafoDiStringhe.AggiungiNodo("A", "yuguyg");
            grafoDiStringhe.AggiungiNodo("B", "iugnhuokij  - yooooooooooooo!");
            grafoDiStringhe.AggiungiNodo("C", "iuy");
            grafoDiStringhe.AggiungiNodo("D", "ohi o");
            grafoDiStringhe.AggiungiNodo("E", "uyfgnuygighu ih");
            grafoDiStringhe.AggiungiNodo("F", "iugiugh");

            // sistemo gli archi
            grafoDiStringhe.AggiungiArco("A", "B");
            grafoDiStringhe.AggiungiArco("A", "D");
            grafoDiStringhe.AggiungiArco("A", "C");
            grafoDiStringhe.AggiungiArco("B", "C");
            grafoDiStringhe.AggiungiArco("C", "E");
            grafoDiStringhe.AggiungiArco("C", "D");
            grafoDiStringhe.AggiungiArco("D", "E");
            grafoDiStringhe.AggiungiArco("D", "F");

            Console.WriteLine(grafoDiStringhe.Nome);
            var listaVisite = grafoDiStringhe.BFS("C");
            var lunhgezzaStringaPiuLunga = listaVisite.Select(e => e.Valore.Length).Max();
            var primoNodoStringaPiuLunga = listaVisite.FirstOrDefault(e => e.Valore.Length == lunhgezzaStringaPiuLunga);
            Console.WriteLine($"Il nome del nodo che contiene la stringa più lunga è: {primoNodoStringaPiuLunga.Nome}");
        }
        public void ProvaFinale()
        {
            Grafo<int> grafoProva = new Grafo<int>();
            grafoProva.Nome = "Grafo prova"; // nome grafo

            //Nodi
            grafoProva.AggiungiNodo("A", 12);
            grafoProva.AggiungiNodo("B", 13);
            grafoProva.AggiungiNodo("C", 6);
            grafoProva.AggiungiNodo("D", 18);
            grafoProva.AggiungiNodo("E", 20);
            grafoProva.AggiungiNodo("F", 24);
            grafoProva.AggiungiNodo("G", 30);
            grafoProva.AggiungiNodo("H", 19);

            //Archi
            grafoProva.AggiungiArco("A", "B");
            grafoProva.AggiungiArco("B", "C");
            grafoProva.AggiungiArco("B", "D");
            grafoProva.AggiungiArco("C", "D");
            grafoProva.AggiungiArco("D", "E");
            grafoProva.AggiungiArco("E", "F");

            grafoProva.AggiungiArco("H", "G"); // staccati dal grafo principale

            // search partendo da C

            var nodiDFS = grafoProva.DFS();
            var sum = nodiDFS.Where(n => n.Valore % 6 == 0).Select(n => n.Valore).Sum();
            //int sum = 0;
            //foreach (var d in nodiDFS)
            //{
            //    if (d.Valore % 6 == 0)
            //    {
            //        sum += d.Valore;
            //    }
            //}
            Console.WriteLine($"(DFS) La somma dei nodi divisibili per 6 e': {sum}");

            var nodiBFS_C = grafoProva.BFS("C");
            sum = nodiBFS_C.Where(n => n.Valore % 6 == 0).Select(n => n.Valore).Sum();
            Console.WriteLine($" (BFS_C)La somma dei nodi divisibili per 6 e': {sum}");

            // search partendo da H (DFS sarebbe uguale, ho preferito tralasciarlo)
            var nodiBFS_H = grafoProva.BFS("H");
            sum = nodiBFS_H.Where(n => n.Valore % 6 == 0).Select(n => n.Valore).Sum();
            Console.WriteLine($" (BFS_H)La somma dei nodi divisibili per 6 e': {sum}");
        }
    }
}
