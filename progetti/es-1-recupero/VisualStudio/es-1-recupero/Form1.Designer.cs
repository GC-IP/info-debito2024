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
            cmbQualifica = new ComboBox();
            gvArtigiani = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gvArtigiani).BeginInit();
            SuspendLayout();
            // 
            // cmbQualifica
            // 
            cmbQualifica.FormattingEnabled = true;
            cmbQualifica.Location = new Point(75, 43);
            cmbQualifica.Name = "cmbQualifica";
            cmbQualifica.Size = new Size(182, 33);
            cmbQualifica.TabIndex = 0;
            // 
            // gvArtigiani
            // 
            gvArtigiani.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvArtigiani.Location = new Point(75, 101);
            gvArtigiani.Name = "gvArtigiani";
            gvArtigiani.RowHeadersWidth = 62;
            gvArtigiani.Size = new Size(676, 304);
            gvArtigiani.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gvArtigiani);
            Controls.Add(cmbQualifica);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)gvArtigiani).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbQualifica;
        private DataGridView gvArtigiani;
    }
}
