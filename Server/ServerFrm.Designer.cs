namespace Server
{
    partial class ServerFrm
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
            this.svrstart = new System.Windows.Forms.Button();
            this.svrstop = new System.Windows.Forms.Button();
            this.txtsvrinfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // svrstart
            // 
            this.svrstart.Location = new System.Drawing.Point(75, 60);
            this.svrstart.Name = "svrstart";
            this.svrstart.Size = new System.Drawing.Size(140, 57);
            this.svrstart.TabIndex = 0;
            this.svrstart.Text = "Start";
            this.svrstart.UseVisualStyleBackColor = true;
            this.svrstart.Click += new System.EventHandler(this.svrstart_Click);
            // 
            // svrstop
            // 
            this.svrstop.Location = new System.Drawing.Point(268, 65);
            this.svrstop.Name = "svrstop";
            this.svrstop.Size = new System.Drawing.Size(140, 52);
            this.svrstop.TabIndex = 1;
            this.svrstop.Text = "Stop";
            this.svrstop.UseVisualStyleBackColor = true;
            this.svrstop.Click += new System.EventHandler(this.svrstop_Click);
            // 
            // txtsvrinfo
            // 
            this.txtsvrinfo.Location = new System.Drawing.Point(75, 172);
            this.txtsvrinfo.Name = "txtsvrinfo";
            this.txtsvrinfo.ReadOnly = true;
            this.txtsvrinfo.Size = new System.Drawing.Size(333, 29);
            this.txtsvrinfo.TabIndex = 2;
            // 
            // ServerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 294);
            this.Controls.Add(this.txtsvrinfo);
            this.Controls.Add(this.svrstop);
            this.Controls.Add(this.svrstart);
            this.Name = "ServerFrm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button svrstart;
        private System.Windows.Forms.Button svrstop;
        private System.Windows.Forms.TextBox txtsvrinfo;
    }
}

