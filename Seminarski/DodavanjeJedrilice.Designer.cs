namespace Seminarski
{
    partial class DodavanjeJedrilice
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
            this.reg = new System.Windows.Forms.TextBox();
            this.mod = new System.Windows.Forms.TextBox();
            this.tip = new System.Windows.Forms.TextBox();
            this.DodajJedrilicu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registracija:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tip:";
            // 
            // reg
            // 
            this.reg.Location = new System.Drawing.Point(262, 76);
            this.reg.Name = "reg";
            this.reg.Size = new System.Drawing.Size(127, 29);
            this.reg.TabIndex = 3;
            // 
            // mod
            // 
            this.mod.Location = new System.Drawing.Point(262, 134);
            this.mod.Name = "mod";
            this.mod.Size = new System.Drawing.Size(127, 29);
            this.mod.TabIndex = 4;
            // 
            // tip
            // 
            this.tip.Location = new System.Drawing.Point(262, 190);
            this.tip.Name = "tip";
            this.tip.Size = new System.Drawing.Size(127, 29);
            this.tip.TabIndex = 5;
            // 
            // DodajJedrilicu
            // 
            this.DodajJedrilicu.Location = new System.Drawing.Point(168, 256);
            this.DodajJedrilicu.Name = "DodajJedrilicu";
            this.DodajJedrilicu.Size = new System.Drawing.Size(167, 40);
            this.DodajJedrilicu.TabIndex = 6;
            this.DodajJedrilicu.Text = "Dodaj Jedrilicu";
            this.DodajJedrilicu.UseVisualStyleBackColor = true;
            this.DodajJedrilicu.Click += new System.EventHandler(this.DodajJedrilicu_Click);
            // 
            // DodavanjeJedrilice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 423);
            this.Controls.Add(this.DodajJedrilicu);
            this.Controls.Add(this.tip);
            this.Controls.Add(this.mod);
            this.Controls.Add(this.reg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DodavanjeJedrilice";
            this.Text = "Dodavanje Jedrilice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox reg;
        private System.Windows.Forms.TextBox mod;
        private System.Windows.Forms.TextBox tip;
        private System.Windows.Forms.Button DodajJedrilicu;
    }
}