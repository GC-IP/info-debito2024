using Debito_Es1.Model;

namespace Debito_Es1.Model
{
    public class Menu
    {
        public string Giorno { get; set; }
        public int Codice { get; set; }
        public Piatto Primo { get; set; }
        public Piatto Secondo { get; set; }
        public string Bevanda { get; set; }
        public int NumAntipasti { get; set; }
        public bool Dolce { get; set; }
        public float PrezzoTOT { get; set; }


    }
}