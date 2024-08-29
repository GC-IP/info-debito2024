namespace Gelateria
{
    partial class fmPrincipale
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
            lytEsterno = new TableLayoutPanel();
            lytFase1 = new TableLayoutPanel();
            lytSceltaProdotto = new TableLayoutPanel();
            label1 = new Label();
            cmbProdotto = new ComboBox();
            btnConfermaProdotto = new Button();
            lytEsterno.SuspendLayout();
            lytFase1.SuspendLayout();
            lytSceltaProdotto.SuspendLayout();
            SuspendLayout();
            // 
            // lytEsterno
            // 
            lytEsterno.ColumnCount = 1;
            lytEsterno.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            lytEsterno.Controls.Add(lytFase1, 0, 0);
            lytEsterno.Dock = DockStyle.Fill;
            lytEsterno.Location = new Point(0, 0);
            lytEsterno.Name = "lytEsterno";
            lytEsterno.RowCount = 3;
            lytEsterno.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            lytEsterno.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            lytEsterno.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            lytEsterno.Size = new Size(1210, 486);
            lytEsterno.TabIndex = 0;
            // 
            // lytFase1
            // 
            lytFase1.ColumnCount = 2;
            lytFase1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            lytFase1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            lytFase1.Controls.Add(lytSceltaProdotto, 0, 0);
            lytFase1.Dock = DockStyle.Fill;
            lytFase1.Location = new Point(3, 3);
            lytFase1.Name = "lytFase1";
            lytFase1.RowCount = 1;
            lytFase1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            lytFase1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            lytFase1.Size = new Size(1204, 155);
            lytFase1.TabIndex = 0;
            // 
            // lytSceltaProdotto
            // 
            lytSceltaProdotto.ColumnCount = 1;
            lytSceltaProdotto.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            lytSceltaProdotto.Controls.Add(label1, 0, 0);
            lytSceltaProdotto.Controls.Add(cmbProdotto, 0, 1);
            lytSceltaProdotto.Controls.Add(btnConfermaProdotto, 0, 2);
            lytSceltaProdotto.Dock = DockStyle.Fill;
            lytSceltaProdotto.Location = new Point(3, 3);
            lytSceltaProdotto.Name = "lytSceltaProdotto";
            lytSceltaProdotto.RowCount = 3;
            lytSceltaProdotto.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            lytSceltaProdotto.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            lytSceltaProdotto.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            lytSceltaProdotto.Size = new Size(596, 149);
            lytSceltaProdotto.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(590, 30);
            label1.TabIndex = 0;
            label1.Text = "Scegli un prodotto";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbProdotto
            // 
            cmbProdotto.Dock = DockStyle.Fill;
            cmbProdotto.Font = new Font("Segoe UI", 14F);
            cmbProdotto.FormattingEnabled = true;
            cmbProdotto.Location = new Point(3, 33);
            cmbProdotto.Name = "cmbProdotto";
            cmbProdotto.Size = new Size(590, 39);
            cmbProdotto.TabIndex = 1;
            // 
            // btnConfermaProdotto
            // 
            btnConfermaProdotto.Dock = DockStyle.Right;
            btnConfermaProdotto.Location = new Point(499, 122);
            btnConfermaProdotto.Name = "btnConfermaProdotto";
            btnConfermaProdotto.Size = new Size(94, 24);
            btnConfermaProdotto.TabIndex = 2;
            btnConfermaProdotto.Text = "Conferma";
            btnConfermaProdotto.UseVisualStyleBackColor = true;
            // 
            // fmPrincipale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 486);
            Controls.Add(lytEsterno);
            Name = "fmPrincipale";
            Text = "Gelateria";
            lytEsterno.ResumeLayout(false);
            lytFase1.ResumeLayout(false);
            lytSceltaProdotto.ResumeLayout(false);
            lytSceltaProdotto.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel lytEsterno;
        private TableLayoutPanel lytFase1;
        private TableLayoutPanel lytSceltaProdotto;
        private Label label1;
        private ComboBox cmbProdotto;
        private Button btnConfermaProdotto;
    }
}
