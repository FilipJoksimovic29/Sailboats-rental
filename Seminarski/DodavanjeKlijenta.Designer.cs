namespace Seminarski
{
    partial class DodavanjeKlijenta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.jmbg = new System.Windows.Forms.TextBox();
            this.imeiprez = new System.Windows.Forms.TextBox();
            this.mestostanovanja = new System.Windows.Forms.TextBox();
            this.iskustvo = new System.Windows.Forms.TextBox();
            this.datumrodjklij = new System.Windows.Forms.DateTimePicker();
            this.DodavanjeKlj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "JMBG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ime i Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Datum Rodjenja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mesto Stanovanja:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Iskustvo";
            // 
            // jmbg
            // 
            this.jmbg.Location = new System.Drawing.Point(306, 83);
            this.jmbg.Name = "jmbg";
            this.jmbg.Size = new System.Drawing.Size(200, 29);
            this.jmbg.TabIndex = 5;
            // 
            // imeiprez
            // 
            this.imeiprez.Location = new System.Drawing.Point(306, 150);
            this.imeiprez.Name = "imeiprez";
            this.imeiprez.Size = new System.Drawing.Size(200, 29);
            this.imeiprez.TabIndex = 6;
            // 
            // mestostanovanja
            // 
            this.mestostanovanja.Location = new System.Drawing.Point(306, 292);
            this.mestostanovanja.Name = "mestostanovanja";
            this.mestostanovanja.Size = new System.Drawing.Size(200, 29);
            this.mestostanovanja.TabIndex = 8;
            // 
            // iskustvo
            // 
            this.iskustvo.Location = new System.Drawing.Point(306, 359);
            this.iskustvo.Name = "iskustvo";
            this.iskustvo.Size = new System.Drawing.Size(200, 29);
            this.iskustvo.TabIndex = 9;
            // 
            // datumrodjklij
            // 
            this.datumrodjklij.Location = new System.Drawing.Point(306, 224);
            this.datumrodjklij.Name = "datumrodjklij";
            this.datumrodjklij.Size = new System.Drawing.Size(200, 29);
            this.datumrodjklij.TabIndex = 10;
            // 
            // DodavanjeKlj
            // 
            this.DodavanjeKlj.Location = new System.Drawing.Point(199, 443);
            this.DodavanjeKlj.Name = "DodavanjeKlj";
            this.DodavanjeKlj.Size = new System.Drawing.Size(176, 44);
            this.DodavanjeKlj.TabIndex = 11;
            this.DodavanjeKlj.Text = "Dodaj Klijenta";
            this.DodavanjeKlj.UseVisualStyleBackColor = true;
            this.DodavanjeKlj.Click += new System.EventHandler(this.DodavanjeKlj_Click);
            // 
            // DodavanjeKlijenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 662);
            this.Controls.Add(this.DodavanjeKlj);
            this.Controls.Add(this.datumrodjklij);
            this.Controls.Add(this.iskustvo);
            this.Controls.Add(this.mestostanovanja);
            this.Controls.Add(this.imeiprez);
            this.Controls.Add(this.jmbg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DodavanjeKlijenta";
            this.Text = "DodavanjeKlijenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox jmbg;
        private System.Windows.Forms.TextBox imeiprez;
        private System.Windows.Forms.TextBox mestostanovanja;
        private System.Windows.Forms.TextBox iskustvo;
        private System.Windows.Forms.DateTimePicker datumrodjklij;
        private System.Windows.Forms.Button DodavanjeKlj;
    }
}