namespace CalcolatriceDiGreta
{
    public partial class Form1 : Form
    {
        public int Operando { get; set; }
        public string Operatore { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Operando = int.Parse(txtDisplay.Text);
            lblOperazione.Text = txtDisplay.Text + " + ";
            Operatore = "+";
            txtDisplay.Text = "";
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;

            button17.Enabled = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Operando = int.Parse(txtDisplay.Text);
            lblOperazione.Text += txtDisplay.Text + " - ";
            Operatore = "-";
            txtDisplay.Text = "";
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;

            button17.Enabled = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Operando = int.Parse(txtDisplay.Text);
            lblOperazione.Text += txtDisplay.Text + " * ";
            Operatore = "*";
            txtDisplay.Text = "";
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;

            button17.Enabled = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Operando = int.Parse(txtDisplay.Text);
            lblOperazione.Text += txtDisplay.Text + " / ";
            Operatore = "/";
            txtDisplay.Text = "";
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;

            button17.Enabled = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            var operando = int.Parse(txtDisplay.Text);
            lblOperazione.Text += txtDisplay.Text + " = ";
            switch (Operatore)
            {
                case "+":
                    lblOperazione.Text += (Operando + operando).ToString();
                    break;
                case "-":
                    lblOperazione.Text += (Operando - operando).ToString();
                    break;
                case "*":
                    lblOperazione.Text += (Operando * operando).ToString();
                    break;
                case "/":
                    lblOperazione.Text += (Operando / operando).ToString();
                    break;
            }
            txtDisplay.Text = "";
            button17.Enabled = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            lblOperazione.Text = "";
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;

            button17.Enabled = false;
        }
    }
}