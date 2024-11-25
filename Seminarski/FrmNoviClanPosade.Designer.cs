namespace Seminarski
{
    partial class FrmNoviClanPosade
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
            this.txtclanid = new System.Windows.Forms.TextBox();
            this.txtclanime = new System.Windows.Forms.TextBox();
            this.txtclaniskustvo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnzapamticlanaposade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtclanid
            // 
            this.txtclanid.Location = new System.Drawing.Point(80, 53);
            this.txtclanid.Name = "txtclanid";
            this.txtclanid.Size = new System.Drawing.Size(100, 29);
            this.txtclanid.TabIndex = 0;
            // 
            // txtclanime
            // 
            this.txtclanime.Location = new System.Drawing.Point(355, 53);
            this.txtclanime.Name = "txtclanime";
            this.txtclanime.Size = new System.Drawing.Size(100, 29);
            this.txtclanime.TabIndex = 1;
            // 
            // txtclaniskustvo
            // 
            this.txtclaniskustvo.Location = new System.Drawing.Point(588, 53);
            this.txtclaniskustvo.Name = "txtclaniskustvo";
            this.txtclaniskustvo.Size = new System.Drawing.Size(100, 29);
            this.txtclaniskustvo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ime i Prezime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(492, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Iskustvo:";
            // 
            // btnzapamticlanaposade
            // 
            this.btnzapamticlanaposade.Location = new System.Drawing.Point(264, 148);
            this.btnzapamticlanaposade.Name = "btnzapamticlanaposade";
            this.btnzapamticlanaposade.Size = new System.Drawing.Size(239, 62);
            this.btnzapamticlanaposade.TabIndex = 6;
            this.btnzapamticlanaposade.Text = "Zapamti";
            this.btnzapamticlanaposade.UseVisualStyleBackColor = true;
            this.btnzapamticlanaposade.Click += new System.EventHandler(this.btnzapamticlanaposade_Click);
            // 
            // FrmNoviClanPosade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 292);
            this.Controls.Add(this.btnzapamticlanaposade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtclaniskustvo);
            this.Controls.Add(this.txtclanime);
            this.Controls.Add(this.txtclanid);
            this.Name = "FrmNoviClanPosade";
            this.Text = "FrmNoviClanPosade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtclanid;
        private System.Windows.Forms.TextBox txtclanime;
        private System.Windows.Forms.TextBox txtclaniskustvo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnzapamticlanaposade;
    }
}