namespace InfoAprile24
{
    public partial class Form1 : Form
    {
        //dichiaro e creo una lista di interi
        List<int> listaNumeri = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }
        // button1 aggiunge all'inizio il testo che c'è nella text1
        // convertito in un intero
        private void button1_Click(object sender, EventArgs e)
        {
            listaNumeri.Insert(0, int.Parse(textBox1.Text));
            Ridisegna();
            // ripulisco i controlli che ho usato
            textBox1.Text = string.Empty;
        }
        // button2 aggiunge alla fine il testo che c'è nella text1
        // convertito in un intero
        private void button2_Click(object sender, EventArgs e)
        {
            listaNumeri.Add(int.Parse(textBox1.Text));
            Ridisegna();
            // ripulisco i controlli che ho usato
            textBox1.Text = string.Empty;
        }
        // button3 aggiunge il testo che c'è nella text1
        // convertito in un intero nella posizione (indice) indicata in text3 
        // convertito anch'esso in un intero
        private void button3_Click(object sender, EventArgs e)
        {
            listaNumeri.Insert(int.Parse(textBox3.Text), int.Parse(textBox1.Text));
            Ridisegna();
            // ripulisco i controlli che ho usato
            textBox1.Text = string.Empty;
            textBox3.Text = string.Empty;
        }
        // button4 elimina il numero nella posizione (indice) indicata in text4 
        // convertito anch'esso in un intero
        private void button4_Click(object sender, EventArgs e)
        {
            listaNumeri.RemoveAt(int.Parse(textBox4.Text));
            Ridisegna();
            // ripulisco i controlli che ho usato
            textBox4.Text = string.Empty;
        }
        // button5 elimina il numero il cui valore è nella text5
        // convertito anch'esso in un intero
        private void button5_Click(object sender, EventArgs e)
        {
            listaNumeri.Remove(int.Parse(textBox5.Text));
            Ridisegna();
            // ripulisco i controlli che ho usato
            textBox5.Text = string.Empty;
        }
        // ridisegno il contenuto della text2 (multiriga)
        // riportando in ordine tutti i numeri nella List
        // e indicando l'indice a cui si trovano
        private void Ridisegna()
        {
            textBox2.Text = string.Empty;
            int indice = 0; // per identificare gli elementi della lista per posizione e non valore
            foreach (int numeroDellaLista in listaNumeri)
            {
                textBox2.AppendText("Indice: " + indice.ToString() + " => ");
                textBox2.AppendText(numeroDellaLista.ToString());
                textBox2.AppendText(Environment.NewLine);
                indice++;
            }
        }
    }
}
