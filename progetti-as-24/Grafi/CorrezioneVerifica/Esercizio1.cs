namespace CorrezioneVerifica
{
    public class Esercizio1
    {
        List<int> listaDiInteri = new List<int>();

        public static void Esegui()
        {
            var es1 = new Esercizio1();
            Console.WriteLine("*** Inserimento ***");
            int numero = 0;
            string stringa;
            while (numero != -1)
            {
                Console.WriteLine("Inserisci un valore (* per terminare): ");
                stringa = Console.ReadLine();
                if (stringa == "*")
                {
                    break;
                }
                numero = int.Parse(stringa);
                es1.InserisciNumero(numero);
            }
            es1.Stampa();

            Console.WriteLine("Inserisci un valore da ricercare nella lista:");
            stringa = Console.ReadLine();
            numero = int.Parse(stringa);
            Console.WriteLine($"Il numero {numero} è stato trovato " +
                $"all'indice {es1.RicercaValoreSingolo(numero)}");

            Console.WriteLine("Molto bene :-)");

            Console.WriteLine("Inserisci un valore MIN per la ricerca:");
            stringa = Console.ReadLine();
            int da = int.Parse(stringa);
            Console.WriteLine("Inserisci un valore MAX per la ricerca:");
            stringa = Console.ReadLine();
            int a = int.Parse(stringa);
            Console.WriteLine($"Il primo numero trovato da {da} a {a}" +
                $" è => {es1.RicercaPerIntervalloDiValori(da, a)}");

            Console.WriteLine("Inserisci un valore da cancellare dalla lista:");
            stringa = Console.ReadLine();
            numero = int.Parse(stringa);
            Console.WriteLine($"Il numero {numero} " +
                $"{(es1.CancellaValore(numero) ? "è" : "non è")} stato cancellato!");
            es1.Stampa();

            Console.WriteLine("Yuppi! Es1 finito! :-D");
        }

        public void Stampa()
        {
            Console.WriteLine("--- CHECKPOINT ---");
            for (int i = 0; i < listaDiInteri.Count; i++)
            {
                Console.WriteLine($"Indice: {i} - Numero: {listaDiInteri[i]}");
            }
            Console.WriteLine("---    ----    ---");
        }
        public void InserisciNumero(int numero)
        {
            listaDiInteri.Add(numero);
            listaDiInteri.Sort();
        }
        public int RicercaValoreSingolo(int valoreDaCercare)
        { 
            return listaDiInteri.IndexOf(valoreDaCercare);
        }
        public int? RicercaPerIntervalloDiValori(int da, int a)
        {
            // lambda
            // return listaDiInteri.Where(n => n >= da && n <= a).FirstOrDefault();

            // ciclo
            foreach (int n in listaDiInteri)
            { 
                if(n >= da && n <= a)
                {
                    return n;
                }
            }
            return null;
        }
        public bool CancellaValore(int valoreDaCancellare)
        {
            if(listaDiInteri.IndexOf(valoreDaCancellare) != -1)
            {
                listaDiInteri.Remove(valoreDaCancellare);
                return true;
            }
            return false;
        }
    }
}
