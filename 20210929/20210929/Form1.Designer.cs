namespace _20210929
{
    partial class Form1
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
            this.btnevszak = new System.Windows.Forms.Button();
            this.btnkilep = new System.Windows.Forms.Button();
            this.lblszoveg = new System.Windows.Forms.Label();
            this.lblsorszam = new System.Windows.Forms.Label();
            this.txtadat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnevszak
            // 
            this.btnevszak.Location = new System.Drawing.Point(50, 208);
            this.btnevszak.Name = "btnevszak";
            this.btnevszak.Size = new System.Drawing.Size(75, 23);
            this.btnevszak.TabIndex = 0;
            this.btnevszak.Text = "Évszak";
            this.btnevszak.UseVisualStyleBackColor = true;
            this.btnevszak.Click += new System.EventHandler(this.Btnevszak_Click);
            // 
            // btnkilep
            // 
            this.btnkilep.Location = new System.Drawing.Point(208, 208);
            this.btnkilep.Name = "btnkilep";
            this.btnkilep.Size = new System.Drawing.Size(75, 23);
            this.btnkilep.TabIndex = 1;
            this.btnkilep.Text = "Kilépés";
            this.btnkilep.UseVisualStyleBackColor = true;
            this.btnkilep.Click += new System.EventHandler(this.Btnkilep_Click);
            // 
            // lblszoveg
            // 
            this.lblszoveg.AutoSize = true;
            this.lblszoveg.Location = new System.Drawing.Point(148, 143);
            this.lblszoveg.Name = "lblszoveg";
            this.lblszoveg.Size = new System.Drawing.Size(35, 13);
            this.lblszoveg.TabIndex = 2;
            this.lblszoveg.Text = "label1";
            // 
            // lblsorszam
            // 
            this.lblsorszam.AutoSize = true;
            this.lblsorszam.Location = new System.Drawing.Point(39, 50);
            this.lblsorszam.Name = "lblsorszam";
            this.lblsorszam.Size = new System.Drawing.Size(86, 13);
            this.lblsorszam.TabIndex = 3;
            this.lblsorszam.Text = "Hónap sorszáma";
            // 
            // txtadat
            // 
            this.txtadat.Location = new System.Drawing.Point(169, 47);
            this.txtadat.Name = "txtadat";
            this.txtadat.Size = new System.Drawing.Size(100, 20);
            this.txtadat.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 274);
            this.Controls.Add(this.txtadat);
            this.Controls.Add(this.lblsorszam);
            this.Controls.Add(this.lblszoveg);
            this.Controls.Add(this.btnkilep);
            this.Controls.Add(this.btnevszak);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnevszak;
        private System.Windows.Forms.Button btnkilep;
        private System.Windows.Forms.Label lblszoveg;
        private System.Windows.Forms.Label lblsorszam;
        private System.Windows.Forms.TextBox txtadat;
    }
}

