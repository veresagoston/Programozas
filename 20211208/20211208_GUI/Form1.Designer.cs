namespace _20211208_GUI
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
            this.lblOra = new System.Windows.Forms.Label();
            this.lblPerc = new System.Windows.Forms.Label();
            this.lblHivasszam = new System.Windows.Forms.Label();
            this.lblNev = new System.Windows.Forms.Label();
            this.txtOra = new System.Windows.Forms.TextBox();
            this.txtPerc = new System.Windows.Forms.TextBox();
            this.txtHivasszam = new System.Windows.Forms.TextBox();
            this.txtNev = new System.Windows.Forms.TextBox();
            this.lbxEredmeny = new System.Windows.Forms.ListBox();
            this.btnTorles = new System.Windows.Forms.Button();
            this.btnFajlba = new System.Windows.Forms.Button();
            this.btnKilep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOra
            // 
            this.lblOra.AutoSize = true;
            this.lblOra.Location = new System.Drawing.Point(96, 48);
            this.lblOra.Name = "lblOra";
            this.lblOra.Size = new System.Drawing.Size(24, 13);
            this.lblOra.TabIndex = 0;
            this.lblOra.Text = "Óra";
            // 
            // lblPerc
            // 
            this.lblPerc.AutoSize = true;
            this.lblPerc.Location = new System.Drawing.Point(96, 86);
            this.lblPerc.Name = "lblPerc";
            this.lblPerc.Size = new System.Drawing.Size(29, 13);
            this.lblPerc.TabIndex = 1;
            this.lblPerc.Text = "Perc";
            // 
            // lblHivasszam
            // 
            this.lblHivasszam.AutoSize = true;
            this.lblHivasszam.Location = new System.Drawing.Point(96, 124);
            this.lblHivasszam.Name = "lblHivasszam";
            this.lblHivasszam.Size = new System.Drawing.Size(63, 13);
            this.lblHivasszam.TabIndex = 2;
            this.lblHivasszam.Text = "Hívás szám";
            // 
            // lblNev
            // 
            this.lblNev.AutoSize = true;
            this.lblNev.Location = new System.Drawing.Point(96, 157);
            this.lblNev.Name = "lblNev";
            this.lblNev.Size = new System.Drawing.Size(27, 13);
            this.lblNev.TabIndex = 3;
            this.lblNev.Text = "Név";
            // 
            // txtOra
            // 
            this.txtOra.Location = new System.Drawing.Point(185, 40);
            this.txtOra.Name = "txtOra";
            this.txtOra.Size = new System.Drawing.Size(100, 20);
            this.txtOra.TabIndex = 4;
            // 
            // txtPerc
            // 
            this.txtPerc.Location = new System.Drawing.Point(185, 78);
            this.txtPerc.Name = "txtPerc";
            this.txtPerc.Size = new System.Drawing.Size(100, 20);
            this.txtPerc.TabIndex = 5;
            // 
            // txtHivasszam
            // 
            this.txtHivasszam.Location = new System.Drawing.Point(185, 116);
            this.txtHivasszam.Name = "txtHivasszam";
            this.txtHivasszam.Size = new System.Drawing.Size(100, 20);
            this.txtHivasszam.TabIndex = 6;
            // 
            // txtNev
            // 
            this.txtNev.Location = new System.Drawing.Point(185, 157);
            this.txtNev.Name = "txtNev";
            this.txtNev.Size = new System.Drawing.Size(100, 20);
            this.txtNev.TabIndex = 7;
            // 
            // lbxEredmeny
            // 
            this.lbxEredmeny.FormattingEnabled = true;
            this.lbxEredmeny.Location = new System.Drawing.Point(338, 40);
            this.lbxEredmeny.Name = "lbxEredmeny";
            this.lbxEredmeny.Size = new System.Drawing.Size(120, 134);
            this.lbxEredmeny.TabIndex = 8;
            // 
            // btnTorles
            // 
            this.btnTorles.Location = new System.Drawing.Point(99, 234);
            this.btnTorles.Name = "btnTorles";
            this.btnTorles.Size = new System.Drawing.Size(75, 23);
            this.btnTorles.TabIndex = 9;
            this.btnTorles.Text = "Törlés";
            this.btnTorles.UseVisualStyleBackColor = true;
            this.btnTorles.Click += new System.EventHandler(this.BtnTorles_Click);
            // 
            // btnFajlba
            // 
            this.btnFajlba.Location = new System.Drawing.Point(226, 234);
            this.btnFajlba.Name = "btnFajlba";
            this.btnFajlba.Size = new System.Drawing.Size(134, 23);
            this.btnFajlba.TabIndex = 10;
            this.btnFajlba.Text = "Fájlba írás, Listboxba";
            this.btnFajlba.UseVisualStyleBackColor = true;
            this.btnFajlba.Click += new System.EventHandler(this.BtnFajlba_Click);
            // 
            // btnKilep
            // 
            this.btnKilep.Location = new System.Drawing.Point(99, 287);
            this.btnKilep.Name = "btnKilep";
            this.btnKilep.Size = new System.Drawing.Size(75, 23);
            this.btnKilep.TabIndex = 11;
            this.btnKilep.Text = "Kilépés";
            this.btnKilep.UseVisualStyleBackColor = true;
            this.btnKilep.Click += new System.EventHandler(this.BtnKilep_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKilep);
            this.Controls.Add(this.btnFajlba);
            this.Controls.Add(this.btnTorles);
            this.Controls.Add(this.lbxEredmeny);
            this.Controls.Add(this.txtNev);
            this.Controls.Add(this.txtHivasszam);
            this.Controls.Add(this.txtPerc);
            this.Controls.Add(this.txtOra);
            this.Controls.Add(this.lblNev);
            this.Controls.Add(this.lblHivasszam);
            this.Controls.Add(this.lblPerc);
            this.Controls.Add(this.lblOra);
            this.Name = "Form1";
            this.Text = "HívásGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOra;
        private System.Windows.Forms.Label lblPerc;
        private System.Windows.Forms.Label lblHivasszam;
        private System.Windows.Forms.Label lblNev;
        private System.Windows.Forms.TextBox txtOra;
        private System.Windows.Forms.TextBox txtPerc;
        private System.Windows.Forms.TextBox txtHivasszam;
        private System.Windows.Forms.TextBox txtNev;
        private System.Windows.Forms.ListBox lbxEredmeny;
        private System.Windows.Forms.Button btnTorles;
        private System.Windows.Forms.Button btnFajlba;
        private System.Windows.Forms.Button btnKilep;
    }
}

