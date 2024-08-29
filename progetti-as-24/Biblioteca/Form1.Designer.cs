namespace Biblioteca
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
            btnSalvaAutore = new Button();
            dtDataNascita = new DateTimePicker();
            label3 = new Label();
            txtCognome = new TextBox();
            label2 = new Label();
            txtNome = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            grdAutori = new DataGridView();
            tabPage4 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdAutori).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1212, 495);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnSalvaAutore);
            tabPage1.Controls.Add(dtDataNascita);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(txtCognome);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtNome);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1204, 462);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Nuovo Autore";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSalvaAutore
            // 
            btnSalvaAutore.Location = new Point(327, 188);
            btnSalvaAutore.Name = "btnSalvaAutore";
            btnSalvaAutore.Size = new Size(94, 29);
            btnSalvaAutore.TabIndex = 6;
            btnSalvaAutore.Text = "Salva";
            btnSalvaAutore.UseVisualStyleBackColor = true;
            btnSalvaAutore.Click += btnSalvaAutore_Click;
            // 
            // dtDataNascita
            // 
            dtDataNascita.Location = new Point(163, 136);
            dtDataNascita.Name = "dtDataNascita";
            dtDataNascita.Size = new Size(250, 27);
            dtDataNascita.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 133);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 4;
            label3.Text = "Data di nascita";
            // 
            // txtCognome
            // 
            txtCognome.Location = new Point(158, 79);
            txtCognome.Name = "txtCognome";
            txtCognome.Size = new Size(125, 27);
            txtCognome.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 76);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 2;
            label2.Text = "Cognome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(143, 24);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(125, 27);
            txtNome.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 19);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1204, 462);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Nuovo Libro";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(grdAutori);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1204, 462);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Elenco autori";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // grdAutori
            // 
            grdAutori.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdAutori.Dock = DockStyle.Fill;
            grdAutori.Location = new Point(0, 0);
            grdAutori.Name = "grdAutori";
            grdAutori.RowHeadersWidth = 51;
            grdAutori.RowTemplate.Height = 29;
            grdAutori.Size = new Size(1204, 462);
            grdAutori.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1204, 462);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Elenco libri";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1212, 495);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdAutori).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private DateTimePicker dtDataNascita;
        private Label label3;
        private TextBox txtCognome;
        private Label label2;
        private TextBox txtNome;
        private Label label1;
        private Button btnSalvaAutore;
        private DataGridView grdAutori;
    }
}