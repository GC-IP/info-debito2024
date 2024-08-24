using es_1_recupero.Repository;

namespace es_1_recupero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbQualifica.DataSource = QualificaRepository.ElencoQualifiche();
            gvArtigiani.DataSource = ArtigianoRepository.ElencoArtigiani();
        }
    }
}
