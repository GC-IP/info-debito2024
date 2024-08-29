namespace CorrezioneVerifica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // esecizio 1
            //Esercizio1.Esegui();
            
            // esercizio 2
            var es2 = new Esercizio2();
            Console.WriteLine("*** non lo so ***");
            string persona = "";

            while (persona != "0")
            {
                Console.WriteLine("Inserisci una persona (0 per terminare): ");
                persona = Console.ReadLine();
                if (persona == "0")
                {
                    break;
                }
                es2.InserisciPersona(persona);
            }
            es2.StampaGrafo();
            persona = "";
            while (persona != "0")
            {
                Console.WriteLine("Inserisci una conoscenza (pers1, pers2 / 0 per uscire): ");
                persona = Console.ReadLine();
                if (persona == "0")
                {
                    break;
                }
                var coppia = persona.Split(",");
                es2.InserisciConoscenza(coppia[0], coppia[1]);
            }

            Console.WriteLine("Inserisci un valore da ricercare nella lista:");
            persona = Console.ReadLine();
            var personeCheConosce = es2.ElencoPersoneCheConosce(persona);
            es2.Stampa(personeCheConosce);
            Console.WriteLine("yeeee :D");
            var personeDirette = es2.ElencoPersoneDirette(persona);
            es2.Stampa(personeDirette);

        }

    }
}
