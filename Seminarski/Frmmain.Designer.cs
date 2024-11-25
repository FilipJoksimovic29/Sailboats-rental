namespace Seminarski
{
    partial class Frmmain
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
            this.pozdrav = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klijentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jedrilicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clanaPosadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klijentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.jedrilicaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clanPosadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.izaberiklijenta = new System.Windows.Forms.Button();
            this.dgvodabranislanovi = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtodabranklijent = new System.Windows.Forms.TextBox();
            this.txtodabranajedrilica = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvodabranislanovi)).BeginInit();
            this.SuspendLayout();
            // 
            // pozdrav
            // 
            this.pozdrav.AutoSize = true;
            this.pozdrav.Location = new System.Drawing.Point(48, 94);
            this.pozdrav.Name = "pozdrav";
            this.pozdrav.Size = new System.Drawing.Size(64, 25);
            this.pozdrav.TabIndex = 0;
            this.pozdrav.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajToolStripMenuItem,
            this.obrisiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(819, 38);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.klijentToolStripMenuItem,
            this.jedrilicaToolStripMenuItem,
            this.clanaPosadeToolStripMenuItem});
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(86, 34);
            this.dodajToolStripMenuItem.Text = "Dodaj";
            // 
            // klijentToolStripMenuItem
            // 
            this.klijentToolStripMenuItem.Name = "klijentToolStripMenuItem";
            this.klijentToolStripMenuItem.Size = new System.Drawing.Size(255, 40);
            this.klijentToolStripMenuItem.Text = "Klijent";
            this.klijentToolStripMenuItem.Click += new System.EventHandler(this.klijentToolStripMenuItem_Click);
            // 
            // jedrilicaToolStripMenuItem
            // 
            this.jedrilicaToolStripMenuItem.Name = "jedrilicaToolStripMenuItem";
            this.jedrilicaToolStripMenuItem.Size = new System.Drawing.Size(255, 40);
            this.jedrilicaToolStripMenuItem.Text = "Jedrilica";
            this.jedrilicaToolStripMenuItem.Click += new System.EventHandler(this.jedrilicaToolStripMenuItem_Click);
            // 
            // clanaPosadeToolStripMenuItem
            // 
            this.clanaPosadeToolStripMenuItem.Name = "clanaPosadeToolStripMenuItem";
            this.clanaPosadeToolStripMenuItem.Size = new System.Drawing.Size(255, 40);
            this.clanaPosadeToolStripMenuItem.Text = "Clana Posade";
            this.clanaPosadeToolStripMenuItem.Click += new System.EventHandler(this.clanaPosadeToolStripMenuItem_Click);
            // 
            // obrisiToolStripMenuItem
            // 
            this.obrisiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.klijentToolStripMenuItem1,
            this.jedrilicaToolStripMenuItem1,
            this.clanPosadeToolStripMenuItem});
            this.obrisiToolStripMenuItem.Name = "obrisiToolStripMenuItem";
            this.obrisiToolStripMenuItem.Size = new System.Drawing.Size(85, 34);
            this.obrisiToolStripMenuItem.Text = "Obrisi";
            // 
            // klijentToolStripMenuItem1
            // 
            this.klijentToolStripMenuItem1.Name = "klijentToolStripMenuItem1";
            this.klijentToolStripMenuItem1.Size = new System.Drawing.Size(244, 40);
            this.klijentToolStripMenuItem1.Text = "Klijent";
            this.klijentToolStripMenuItem1.Click += new System.EventHandler(this.klijentToolStripMenuItem1_Click);
            // 
            // jedrilicaToolStripMenuItem1
            // 
            this.jedrilicaToolStripMenuItem1.Name = "jedrilicaToolStripMenuItem1";
            this.jedrilicaToolStripMenuItem1.Size = new System.Drawing.Size(244, 40);
            this.jedrilicaToolStripMenuItem1.Text = "Jedrilica";
            // 
            // clanPosadeToolStripMenuItem
            // 
            this.clanPosadeToolStripMenuItem.Name = "clanPosadeToolStripMenuItem";
            this.clanPosadeToolStripMenuItem.Size = new System.Drawing.Size(244, 40);
            this.clanPosadeToolStripMenuItem.Text = "Clan Posade";
            this.clanPosadeToolStripMenuItem.Click += new System.EventHandler(this.clanPosadeToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 818);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Datum Izdavanja:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 886);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Datum Vracanja:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(295, 818);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(295, 886);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 61);
            this.button1.TabIndex = 6;
            this.button1.Text = "Izaberi Jedrilicu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(53, 402);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(287, 48);
            this.button3.TabIndex = 8;
            this.button3.Text = "Dodaj clana posade na turu";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // izaberiklijenta
            // 
            this.izaberiklijenta.Location = new System.Drawing.Point(53, 160);
            this.izaberiklijenta.Name = "izaberiklijenta";
            this.izaberiklijenta.Size = new System.Drawing.Size(216, 60);
            this.izaberiklijenta.TabIndex = 10;
            this.izaberiklijenta.Text = "Izaberi Klijenta";
            this.izaberiklijenta.UseVisualStyleBackColor = true;
            this.izaberiklijenta.Click += new System.EventHandler(this.izaberiklijenta_Click);
            // 
            // dgvodabranislanovi
            // 
            this.dgvodabranislanovi.AllowUserToAddRows = false;
            this.dgvodabranislanovi.AllowUserToDeleteRows = false;
            this.dgvodabranislanovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvodabranislanovi.Location = new System.Drawing.Point(53, 468);
            this.dgvodabranislanovi.Name = "dgvodabranislanovi";
            this.dgvodabranislanovi.ReadOnly = true;
            this.dgvodabranislanovi.RowHeadersWidth = 72;
            this.dgvodabranislanovi.RowTemplate.Height = 31;
            this.dgvodabranislanovi.Size = new System.Drawing.Size(702, 201);
            this.dgvodabranislanovi.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Izabrani clanovi posade za turu:";
            // 
            // txtodabranklijent
            // 
            this.txtodabranklijent.Location = new System.Drawing.Point(321, 175);
            this.txtodabranklijent.Name = "txtodabranklijent";
            this.txtodabranklijent.ReadOnly = true;
            this.txtodabranklijent.Size = new System.Drawing.Size(434, 29);
            this.txtodabranklijent.TabIndex = 13;
            // 
            // txtodabranajedrilica
            // 
            this.txtodabranajedrilica.Location = new System.Drawing.Point(321, 272);
            this.txtodabranajedrilica.Name = "txtodabranajedrilica";
            this.txtodabranajedrilica.ReadOnly = true;
            this.txtodabranajedrilica.Size = new System.Drawing.Size(434, 29);
            this.txtodabranajedrilica.TabIndex = 14;
            // 
            // Frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 1009);
            this.Controls.Add(this.txtodabranajedrilica);
            this.Controls.Add(this.txtodabranklijent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvodabranislanovi);
            this.Controls.Add(this.izaberiklijenta);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pozdrav);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frmmain";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvodabranislanovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pozdrav;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klijentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jedrilicaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button izaberikl;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button izaberiklijenta;
        private System.Windows.Forms.ToolStripMenuItem clanaPosadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrisiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klijentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem jedrilicaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clanPosadeToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvodabranislanovi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtodabranklijent;
        private System.Windows.Forms.TextBox txtodabranajedrilica;
    }
}