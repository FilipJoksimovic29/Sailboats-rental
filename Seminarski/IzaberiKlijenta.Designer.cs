namespace Seminarski
{
    partial class IzaberiKlijenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridklijenti = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpretragaklijenata = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridklijenti)).BeginInit();
            this.SuspendLayout();
            // 
            // gridklijenti
            // 
            this.gridklijenti.AllowUserToAddRows = false;
            this.gridklijenti.AllowUserToDeleteRows = false;
            this.gridklijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridklijenti.Location = new System.Drawing.Point(0, 97);
            this.gridklijenti.Name = "gridklijenti";
            this.gridklijenti.ReadOnly = true;
            this.gridklijenti.RowHeadersWidth = 72;
            this.gridklijenti.RowTemplate.Height = 31;
            this.gridklijenti.Size = new System.Drawing.Size(800, 353);
            this.gridklijenti.TabIndex = 0;
            this.gridklijenti.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridklijenti_CellMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pretraga po Imenu ili  JMBG:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtpretragaklijenata
            // 
            this.txtpretragaklijenata.Location = new System.Drawing.Point(280, 25);
            this.txtpretragaklijenata.Name = "txtpretragaklijenata";
            this.txtpretragaklijenata.Size = new System.Drawing.Size(198, 29);
            this.txtpretragaklijenata.TabIndex = 2;
            this.txtpretragaklijenata.TextChanged += new System.EventHandler(this.txtpretragaklijenata_TextChanged);
            // 
            // IzaberiKlijenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtpretragaklijenata);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridklijenti);
            this.Name = "IzaberiKlijenta";
            this.Text = "IzaberiKlijenta";
            ((System.ComponentModel.ISupportInitialize)(this.gridklijenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridklijenti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpretragaklijenata;
    }
}