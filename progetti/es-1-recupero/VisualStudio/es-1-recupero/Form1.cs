using es_1_recupero.Controllers;
using es_1_recupero.Model;
using es_1_recupero.Repository;

namespace es_1_recupero
{
    public partial class Form1 : Form
    {
        GestioneQualifica gestioneQualifica;
        GestioneArtigiano gestioneArtigiano;

        public Form1()
        {
            InitializeComponent();
            gestioneQualifica = new GestioneQualifica();
            gestioneArtigiano = new GestioneArtigiano();

            cmbQualifica3.DataSource = QualificaRepository.ElencoQualifiche();
        }

        private void btnEs1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            var qualifica = new Qualifica
            {
                IdQualifica = txtQualifica.Text,
                AbilitazioneProfessionale = (rnd.Next(1, 3) % 2 == 0),
                MaxPrezzo = (float)Convert.ToDouble(this.txtPrezzoMaxQualifica.Text),
            };
            gestioneQualifica.InserisciQualifica(qualifica);

            var artigiano = new Artigiano
            {
                CodiceArtigiano = ArtigianoRepository.ElencoArtigiani().Count + 1,
                ComuneResidenza = txtComune.Text,
                Nome = txtNomeArtigiano.Text,
                Qualifica = qualifica,
                RichiestaPrezzo = (float)Convert.ToDouble(this.txtPrezzoArtigiano.Text),
            };

            gestioneArtigiano.InserisciArtigiano(artigiano);
        }

        private void btnCarica2_Click(object sender, EventArgs e)
        {
            var artigiano = ArtigianoRepository.ArtigianoPerCodice(Convert.ToInt32(this.txtCodice2.Text));
            txtNome2.Text = artigiano.Nome;
            txtComune2.Text = artigiano.ComuneResidenza;
            txtPrezzo2.Text = artigiano.RichiestaPrezzo.ToString();
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            var artigiano = new Artigiano
            {
                CodiceArtigiano = Convert.ToInt32(this.txtCodice2.Text),
                Nome = txtNome2.Text,
                RichiestaPrezzo = (float)Convert.ToDouble(this.txtPrezzo2.Text),
                ComuneResidenza = txtComune2.Text
            };
            gestioneArtigiano.ModificaArtigiano(Convert.ToInt32(this.txtCodice2.Text), artigiano);
        }

        private void btnCarica3_Click(object sender, EventArgs e)
        {
            gvArtigiani3.DataSource = gestioneArtigiano.CercaQualifica((Qualifica)cmbQualifica3.SelectedItem, this.chkNome3.Checked, this.chkComune3.Checked);
        }

        private void btnElimina4_Click(object sender, EventArgs e)
        {
            gestioneArtigiano.EliminaComune(txtComune4.Text);
        }

        private void btnCarica5_Click(object sender, EventArgs e)
        {
            dvArtigiani5.DataSource = gestioneArtigiano.PrezzoPiuBasso(txtQualifica5.Text);
        }

        private void btnAvvia6_Click(object sender, EventArgs e)
        {
            var qualifiche = QualificaRepository.ElencoQualifiche();
            var risultato = new List<KeyValuePair<string, float>>();
            foreach(var q in qualifiche)
            {
                risultato.Add(new KeyValuePair<string, float>(q.IdQualifica, gestioneArtigiano.CostoMedio(q.IdQualifica)));
            }
            gvQualifiche6.DataSource = risultato;
        }
    }
}
