namespace Gelateria
{
    public partial class fmPrincipale : Form
    {
        List<Prodotto> listinoMenu = new List<Prodotto>();
        List<string> gusti = new List<string>();

        public fmPrincipale()
        {
            InitializeComponent();
            // coni
            listinoMenu.Add(new Prodotto
            {
                Nome = "Cono grande",
                NumeroGusti = 3,
                Prezzo = 3.0F
            });
            listinoMenu.Add(new Prodotto
            {
                Nome = "Cono medio",
                NumeroGusti = 2,
                Prezzo = 2.5F
            });
            listinoMenu.Add(new Prodotto
            {
                Nome = "Cono piccolo",
                NumeroGusti = 1,
                Prezzo = 2.0F
            });
            // coppette
            listinoMenu.Add(new Prodotto
            {
                Nome = "Coppetta grande",
                NumeroGusti = 3,
                Prezzo = 3.0F
            });
            listinoMenu.Add(new Prodotto
            {
                Nome = "Coppetta media",
                NumeroGusti = 2,
                Prezzo = 2.5F
            });
            listinoMenu.Add(new Prodotto
            {
                Nome = "Coppetta piccola",
                NumeroGusti = 1,
                Prezzo = 2.0F
            });
            cmbProdotto.DataSource = listinoMenu;
            cmbProdotto.DisplayMember = "DescrizioneMenu";
            // gusti
            gusti.Add("Fior di latte");
            gusti.Add("Banana di Java");
        }
    }
}
