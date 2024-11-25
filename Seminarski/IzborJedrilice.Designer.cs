namespace Seminarski
{
    partial class IzborJedrilice
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
            this.dgvjedrilice = new System.Windows.Forms.DataGridView();
            this.txtpretragajedrilica = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvjedrilice)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvjedrilice
            // 
            this.dgvjedrilice.AllowUserToAddRows = false;
            this.dgvjedrilice.AllowUserToDeleteRows = false;
            this.dgvjedrilice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvjedrilice.Location = new System.Drawing.Point(2, 77);
            this.dgvjedrilice.Name = "dgvjedrilice";
            this.dgvjedrilice.ReadOnly = true;
            this.dgvjedrilice.RowHeadersWidth = 72;
            this.dgvjedrilice.RowTemplate.Height = 31;
            this.dgvjedrilice.Size = new System.Drawing.Size(800, 369);
            this.dgvjedrilice.TabIndex = 0;
            this.dgvjedrilice.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvjedrilice_CellMouseDoubleClick);
            // 
            // txtpretragajedrilica
            // 
            this.txtpretragajedrilica.Location = new System.Drawing.Point(142, 24);
            this.txtpretragajedrilica.Name = "txtpretragajedrilica";
            this.txtpretragajedrilica.Size = new System.Drawing.Size(160, 29);
            this.txtpretragajedrilica.TabIndex = 1;
            this.txtpretragajedrilica.TextChanged += new System.EventHandler(this.txtpretragajedrilica_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pretraga:";
            // 
            // IzborJedrilice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpretragajedrilica);
            this.Controls.Add(this.dgvjedrilice);
            this.Name = "IzborJedrilice";
            this.Text = "IzborJedrilice";
            ((System.ComponentModel.ISupportInitialize)(this.dgvjedrilice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvjedrilice;
        private System.Windows.Forms.TextBox txtpretragajedrilica;
        private System.Windows.Forms.Label label1;
    }
}