namespace Seminarski
{
    partial class FrmBrisanjeClanaPosade
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
            this.ClanoviPosadeGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ClanoviPosadeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ClanoviPosadeGrid
            // 
            this.ClanoviPosadeGrid.AllowUserToAddRows = false;
            this.ClanoviPosadeGrid.AllowUserToDeleteRows = false;
            this.ClanoviPosadeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClanoviPosadeGrid.Location = new System.Drawing.Point(2, 55);
            this.ClanoviPosadeGrid.Name = "ClanoviPosadeGrid";
            this.ClanoviPosadeGrid.ReadOnly = true;
            this.ClanoviPosadeGrid.RowHeadersWidth = 72;
            this.ClanoviPosadeGrid.RowTemplate.Height = 31;
            this.ClanoviPosadeGrid.Size = new System.Drawing.Size(814, 379);
            this.ClanoviPosadeGrid.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(338, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Obrisi Izabranog Clana Posade";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(385, 13);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(403, 29);
            this.textBoxSearch.TabIndex = 2;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search:";
            // 
            // FrmBrisanjeClanaPosade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 548);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ClanoviPosadeGrid);
            this.Name = "FrmBrisanjeClanaPosade";
            this.Text = "Brisanje Clana Posade";
            this.Load += new System.EventHandler(this.FrmBrisanjeClanaPosade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClanoviPosadeGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ClanoviPosadeGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label1;
    }
}