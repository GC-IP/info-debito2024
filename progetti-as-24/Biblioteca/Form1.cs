namespace Biblioteca
{
    public partial class Form1 : Form
    {
        List<Autore> autori = new List<Autore>();
        public Form1()
        {
            InitializeComponent();
            grdAutori.DataSource = autori;
        }

        private void btnSalvaAutore_Click(object sender, EventArgs e)
        {
            var autore = new Autore
            {
                Cognome = txtCognome.Text,
                Nome = txtNome.Text,
                DataNascita = dtDataNascita.Value
            };
            autori.Add(autore);
            grdAutori.Update();
            grdAutori.Refresh();
        }
    }
}