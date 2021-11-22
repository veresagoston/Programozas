namespace _20210922
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
            this.lblsugar = new System.Windows.Forms.Label();
            this.lblkerulet = new System.Windows.Forms.Label();
            this.lblterulet = new System.Windows.Forms.Label();
            this.txtadat = new System.Windows.Forms.TextBox();
            this.txtkerulet = new System.Windows.Forms.TextBox();
            this.txtterulet = new System.Windows.Forms.TextBox();
            this.btnkor = new System.Windows.Forms.Button();
            this.btngomb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblsugar
            // 
            this.lblsugar.AutoSize = true;
            this.lblsugar.Location = new System.Drawing.Point(73, 66);
            this.lblsugar.Name = "lblsugar";
            this.lblsugar.Size = new System.Drawing.Size(35, 13);
            this.lblsugar.TabIndex = 0;
            this.lblsugar.Text = "Sugár";
            // 
            // lblkerulet
            // 
            this.lblkerulet.AutoSize = true;
            this.lblkerulet.Location = new System.Drawing.Point(92, 150);
            this.lblkerulet.Name = "lblkerulet";
            this.lblkerulet.Size = new System.Drawing.Size(58, 13);
            this.lblkerulet.TabIndex = 1;
            this.lblkerulet.Text = "Kör kerület";
            // 
            // lblterulet
            // 
            this.lblterulet.AutoSize = true;
            this.lblterulet.Location = new System.Drawing.Point(292, 150);
            this.lblterulet.Name = "lblterulet";
            this.lblterulet.Size = new System.Drawing.Size(55, 13);
            this.lblterulet.TabIndex = 2;
            this.lblterulet.Text = "Kör terület";
            // 
            // txtadat
            // 
            this.txtadat.Location = new System.Drawing.Point(143, 66);
            this.txtadat.Name = "txtadat";
            this.txtadat.Size = new System.Drawing.Size(100, 20);
            this.txtadat.TabIndex = 3;
            // 
            // txtkerulet
            // 
            this.txtkerulet.Location = new System.Drawing.Point(92, 184);
            this.txtkerulet.Name = "txtkerulet";
            this.txtkerulet.Size = new System.Drawing.Size(100, 20);
            this.txtkerulet.TabIndex = 4;
            // 
            // txtterulet
            // 
            this.txtterulet.Location = new System.Drawing.Point(295, 184);
            this.txtterulet.Name = "txtterulet";
            this.txtterulet.Size = new System.Drawing.Size(100, 20);
            this.txtterulet.TabIndex = 5;
            // 
            // btnkor
            // 
            this.btnkor.Location = new System.Drawing.Point(92, 236);
            this.btnkor.Name = "btnkor";
            this.btnkor.Size = new System.Drawing.Size(75, 23);
            this.btnkor.TabIndex = 6;
            this.btnkor.Text = "Kör";
            this.btnkor.UseVisualStyleBackColor = true;
            this.btnkor.Click += new System.EventHandler(this.Btnkor_Click);
            // 
            // btngomb
            // 
            this.btngomb.Location = new System.Drawing.Point(295, 236);
            this.btngomb.Name = "btngomb";
            this.btngomb.Size = new System.Drawing.Size(75, 23);
            this.btngomb.TabIndex = 7;
            this.btngomb.Text = "Gömb";
            this.btngomb.UseVisualStyleBackColor = true;
            this.btngomb.Click += new System.EventHandler(this.Btngomb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 329);
            this.Controls.Add(this.btngomb);
            this.Controls.Add(this.btnkor);
            this.Controls.Add(this.txtterulet);
            this.Controls.Add(this.txtkerulet);
            this.Controls.Add(this.txtadat);
            this.Controls.Add(this.lblterulet);
            this.Controls.Add(this.lblkerulet);
            this.Controls.Add(this.lblsugar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsugar;
        private System.Windows.Forms.Label lblkerulet;
        private System.Windows.Forms.Label lblterulet;
        private System.Windows.Forms.TextBox txtadat;
        private System.Windows.Forms.TextBox txtkerulet;
        private System.Windows.Forms.TextBox txtterulet;
        private System.Windows.Forms.Button btnkor;
        private System.Windows.Forms.Button btngomb;
    }
}

