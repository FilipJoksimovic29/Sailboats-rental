namespace Seminarski
{
    partial class IzborClanaPosade
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
            this.dgvclanposade = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpretragaclanovaposade = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvclanposade)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvclanposade
            // 
            this.dgvclanposade.AllowUserToAddRows = false;
            this.dgvclanposade.AllowUserToDeleteRows = false;
            this.dgvclanposade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvclanposade.Location = new System.Drawing.Point(12, 91);
            this.dgvclanposade.Name = "dgvclanposade";
            this.dgvclanposade.ReadOnly = true;
            this.dgvclanposade.RowHeadersWidth = 72;
            this.dgvclanposade.RowTemplate.Height = 31;
            this.dgvclanposade.Size = new System.Drawing.Size(784, 329);
            this.dgvclanposade.TabIndex = 0;
            this.dgvclanposade.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvclanposade_CellMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pretraga:";
            // 
            // txtpretragaclanovaposade
            // 
            this.txtpretragaclanovaposade.Location = new System.Drawing.Point(112, 36);
            this.txtpretragaclanovaposade.Name = "txtpretragaclanovaposade";
            this.txtpretragaclanovaposade.Size = new System.Drawing.Size(152, 29);
            this.txtpretragaclanovaposade.TabIndex = 2;
            this.txtpretragaclanovaposade.TextChanged += new System.EventHandler(this.txtpretragaclanovaposade_TextChanged);
            // 
            // IzborClanaPosade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtpretragaclanovaposade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvclanposade);
            this.Name = "IzborClanaPosade";
            this.Text = "IzborClanaPosade";
            ((System.ComponentModel.ISupportInitialize)(this.dgvclanposade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvclanposade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpretragaclanovaposade;
    }
}