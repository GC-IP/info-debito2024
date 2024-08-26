namespace es_1_recupero
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label5 = new Label();
            txtComune = new TextBox();
            label3 = new Label();
            txtPrezzoMaxQualifica = new TextBox();
            label4 = new Label();
            txtPrezzoArtigiano = new TextBox();
            label2 = new Label();
            txtQualifica = new TextBox();
            label1 = new Label();
            txtNomeArtigiano = new TextBox();
            btnEs1 = new Button();
            tabPage2 = new TabPage();
            btnModifica = new Button();
            label9 = new Label();
            label8 = new Label();
            txtComune2 = new TextBox();
            label7 = new Label();
            txtPrezzo2 = new TextBox();
            label6 = new Label();
            txtNome2 = new TextBox();
            btnCarica2 = new Button();
            txtCodice2 = new TextBox();
            tabPage3 = new TabPage();
            chkComune3 = new CheckBox();
            chkNome3 = new CheckBox();
            btnCarica3 = new Button();
            gvArtigiani3 = new DataGridView();
            cmbQualifica3 = new ComboBox();
            tabPage4 = new TabPage();
            txtComune4 = new TextBox();
            btnElimina4 = new Button();
            label10 = new Label();
            tabPage5 = new TabPage();
            btnCarica5 = new Button();
            label11 = new Label();
            txtQualifica5 = new TextBox();
            tabPage6 = new TabPage();
            cmbQualifiche6 = new ComboBox();
            label12 = new Label();
            dataGridView1 = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvArtigiani3).BeginInit();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1271, 535);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(txtComune);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(txtPrezzoMaxQualifica);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(txtPrezzoArtigiano);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtQualifica);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtNomeArtigiano);
            tabPage1.Controls.Add(btnEs1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1263, 497);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(849, 52);
            label5.Name = "label5";
            label5.Size = new Size(79, 25);
            label5.TabIndex = 10;
            label5.Text = "Comune";
            // 
            // txtComune
            // 
            txtComune.Location = new Point(1042, 52);
            txtComune.Name = "txtComune";
            txtComune.Size = new Size(150, 31);
            txtComune.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(468, 107);
            label3.Name = "label3";
            label3.Size = new Size(172, 25);
            label3.TabIndex = 8;
            label3.Text = "Prezzo max qualifica";
            // 
            // txtPrezzoMaxQualifica
            // 
            txtPrezzoMaxQualifica.Location = new Point(657, 107);
            txtPrezzoMaxQualifica.Name = "txtPrezzoMaxQualifica";
            txtPrezzoMaxQualifica.Size = new Size(150, 31);
            txtPrezzoMaxQualifica.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(468, 52);
            label4.Name = "label4";
            label4.Size = new Size(139, 25);
            label4.TabIndex = 6;
            label4.Text = "Prezzo artigiano";
            // 
            // txtPrezzoArtigiano
            // 
            txtPrezzoArtigiano.Location = new Point(657, 52);
            txtPrezzoArtigiano.Name = "txtPrezzoArtigiano";
            txtPrezzoArtigiano.Size = new Size(150, 31);
            txtPrezzoArtigiano.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 107);
            label2.Name = "label2";
            label2.Size = new Size(131, 25);
            label2.TabIndex = 4;
            label2.Text = "Nome qualifica";
            // 
            // txtQualifica
            // 
            txtQualifica.Location = new Point(264, 107);
            txtQualifica.Name = "txtQualifica";
            txtQualifica.Size = new Size(150, 31);
            txtQualifica.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 52);
            label1.Name = "label1";
            label1.Size = new Size(136, 25);
            label1.TabIndex = 2;
            label1.Text = "Nome artigiano";
            // 
            // txtNomeArtigiano
            // 
            txtNomeArtigiano.Location = new Point(264, 52);
            txtNomeArtigiano.Name = "txtNomeArtigiano";
            txtNomeArtigiano.Size = new Size(150, 31);
            txtNomeArtigiano.TabIndex = 1;
            // 
            // btnEs1
            // 
            btnEs1.Location = new Point(204, 191);
            btnEs1.Name = "btnEs1";
            btnEs1.Size = new Size(304, 73);
            btnEs1.TabIndex = 0;
            btnEs1.Text = "Esegui codice es. 1";
            btnEs1.UseVisualStyleBackColor = true;
            btnEs1.Click += btnEs1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnModifica);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(txtComune2);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(txtPrezzo2);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(txtNome2);
            tabPage2.Controls.Add(btnCarica2);
            tabPage2.Controls.Add(txtCodice2);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1263, 497);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnModifica
            // 
            btnModifica.Location = new Point(543, 244);
            btnModifica.Name = "btnModifica";
            btnModifica.Size = new Size(112, 34);
            btnModifica.TabIndex = 9;
            btnModifica.Text = "Modifica";
            btnModifica.UseVisualStyleBackColor = true;
            btnModifica.Click += btnModifica_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(54, 58);
            label9.Name = "label9";
            label9.Size = new Size(66, 25);
            label9.TabIndex = 8;
            label9.Text = "Codice";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(532, 117);
            label8.Name = "label8";
            label8.Size = new Size(79, 25);
            label8.TabIndex = 7;
            label8.Text = "Comune";
            // 
            // txtComune2
            // 
            txtComune2.Location = new Point(638, 116);
            txtComune2.Name = "txtComune2";
            txtComune2.Size = new Size(150, 31);
            txtComune2.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(532, 172);
            label7.Name = "label7";
            label7.Size = new Size(64, 25);
            label7.TabIndex = 5;
            label7.Text = "Prezzo";
            // 
            // txtPrezzo2
            // 
            txtPrezzo2.Location = new Point(638, 171);
            txtPrezzo2.Name = "txtPrezzo2";
            txtPrezzo2.Size = new Size(150, 31);
            txtPrezzo2.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(532, 59);
            label6.Name = "label6";
            label6.Size = new Size(61, 25);
            label6.TabIndex = 3;
            label6.Text = "Nome";
            // 
            // txtNome2
            // 
            txtNome2.Location = new Point(638, 58);
            txtNome2.Name = "txtNome2";
            txtNome2.Size = new Size(150, 31);
            txtNome2.TabIndex = 2;
            // 
            // btnCarica2
            // 
            btnCarica2.Location = new Point(151, 116);
            btnCarica2.Name = "btnCarica2";
            btnCarica2.Size = new Size(112, 34);
            btnCarica2.TabIndex = 1;
            btnCarica2.Text = "Carica";
            btnCarica2.UseVisualStyleBackColor = true;
            btnCarica2.Click += btnCarica2_Click;
            // 
            // txtCodice2
            // 
            txtCodice2.Location = new Point(151, 55);
            txtCodice2.Name = "txtCodice2";
            txtCodice2.Size = new Size(150, 31);
            txtCodice2.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(chkComune3);
            tabPage3.Controls.Add(chkNome3);
            tabPage3.Controls.Add(btnCarica3);
            tabPage3.Controls.Add(gvArtigiani3);
            tabPage3.Controls.Add(cmbQualifica3);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1263, 497);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // chkComune3
            // 
            chkComune3.AutoSize = true;
            chkComune3.Location = new Point(794, 56);
            chkComune3.Name = "chkComune3";
            chkComune3.Size = new Size(192, 29);
            chkComune3.TabIndex = 4;
            chkComune3.Text = "Ordina per comune";
            chkComune3.UseVisualStyleBackColor = true;
            // 
            // chkNome3
            // 
            chkNome3.AutoSize = true;
            chkNome3.Location = new Point(586, 56);
            chkNome3.Name = "chkNome3";
            chkNome3.Size = new Size(174, 29);
            chkNome3.TabIndex = 3;
            chkNome3.Text = "Ordina per nome";
            chkNome3.UseVisualStyleBackColor = true;
            // 
            // btnCarica3
            // 
            btnCarica3.Location = new Point(425, 51);
            btnCarica3.Name = "btnCarica3";
            btnCarica3.Size = new Size(112, 34);
            btnCarica3.TabIndex = 2;
            btnCarica3.Text = "Carica";
            btnCarica3.UseVisualStyleBackColor = true;
            btnCarica3.Click += btnCarica3_Click;
            // 
            // gvArtigiani3
            // 
            gvArtigiani3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvArtigiani3.Location = new Point(195, 112);
            gvArtigiani3.Name = "gvArtigiani3";
            gvArtigiani3.RowHeadersWidth = 62;
            gvArtigiani3.Size = new Size(791, 334);
            gvArtigiani3.TabIndex = 1;
            // 
            // cmbQualifica3
            // 
            cmbQualifica3.DisplayMember = "IdQualifica";
            cmbQualifica3.FormattingEnabled = true;
            cmbQualifica3.Location = new Point(195, 51);
            cmbQualifica3.Name = "cmbQualifica3";
            cmbQualifica3.Size = new Size(182, 33);
            cmbQualifica3.TabIndex = 0;
            cmbQualifica3.ValueMember = "IdQualifica";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(txtComune4);
            tabPage4.Controls.Add(btnElimina4);
            tabPage4.Controls.Add(label10);
            tabPage4.Location = new Point(4, 34);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1263, 497);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtComune4
            // 
            txtComune4.Location = new Point(144, 45);
            txtComune4.Name = "txtComune4";
            txtComune4.Size = new Size(150, 31);
            txtComune4.TabIndex = 2;
            // 
            // btnElimina4
            // 
            btnElimina4.Location = new Point(300, 42);
            btnElimina4.Name = "btnElimina4";
            btnElimina4.Size = new Size(112, 34);
            btnElimina4.TabIndex = 1;
            btnElimina4.Text = "elimina";
            btnElimina4.UseVisualStyleBackColor = true;
            btnElimina4.Click += btnElimina4_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(60, 48);
            label10.Name = "label10";
            label10.Size = new Size(79, 25);
            label10.TabIndex = 0;
            label10.Text = "Comune";
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(btnCarica5);
            tabPage5.Controls.Add(label11);
            tabPage5.Controls.Add(txtQualifica5);
            tabPage5.Location = new Point(4, 34);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(1263, 497);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "5";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnCarica5
            // 
            btnCarica5.Location = new Point(244, 52);
            btnCarica5.Name = "btnCarica5";
            btnCarica5.Size = new Size(112, 34);
            btnCarica5.TabIndex = 2;
            btnCarica5.Text = "Carica";
            btnCarica5.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(127, 24);
            label11.Name = "label11";
            label11.Size = new Size(80, 25);
            label11.TabIndex = 1;
            label11.Text = "Qualifica";
            // 
            // txtQualifica5
            // 
            txtQualifica5.Location = new Point(88, 52);
            txtQualifica5.Name = "txtQualifica5";
            txtQualifica5.Size = new Size(150, 31);
            txtQualifica5.TabIndex = 0;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(dataGridView1);
            tabPage6.Controls.Add(label12);
            tabPage6.Controls.Add(cmbQualifiche6);
            tabPage6.Location = new Point(4, 34);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(1263, 497);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "6";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // cmbQualifiche6
            // 
            cmbQualifiche6.FormattingEnabled = true;
            cmbQualifiche6.Location = new Point(270, 49);
            cmbQualifiche6.Name = "cmbQualifiche6";
            cmbQualifiche6.Size = new Size(182, 33);
            cmbQualifiche6.TabIndex = 0;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(56, 49);
            label12.Name = "label12";
            label12.Size = new Size(159, 25);
            label12.TabIndex = 1;
            label12.Text = "Seleziona Qualifica";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(56, 100);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(510, 296);
            dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1271, 535);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gvArtigiani3).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnEs1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private Label label2;
        private TextBox txtQualifica;
        private Label label1;
        private TextBox txtNomeArtigiano;
        private Label label3;
        private TextBox txtPrezzoMaxQualifica;
        private Label label4;
        private TextBox txtPrezzoArtigiano;
        private Label label5;
        private TextBox txtComune;
        private Button btnModifica;
        private Label label9;
        private Label label8;
        private TextBox txtComune2;
        private Label label7;
        private TextBox txtPrezzo2;
        private Label label6;
        private TextBox txtNome2;
        private Button btnCarica2;
        private TextBox txtCodice2;
        private Button btnCarica3;
        private DataGridView gvArtigiani3;
        private ComboBox cmbQualifica3;
        private CheckBox chkComune3;
        private CheckBox chkNome3;
        private TextBox txtComune4;
        private Button btnElimina4;
        private Label label10;
        private TextBox txtQualifica5;
        private Button btnCarica5;
        private Label label11;
        private DataGridView dataGridView1;
        private Label label12;
        private ComboBox cmbQualifiche6;
    }
}
