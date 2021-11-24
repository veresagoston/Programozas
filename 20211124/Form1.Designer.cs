namespace _20211124
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
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblKartya = new System.Windows.Forms.Label();
            this.lblKezdo = new System.Windows.Forms.Label();
            this.lblCel = new System.Windows.Forms.Label();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.txtKartya = new System.Windows.Forms.TextBox();
            this.txtKezdo = new System.Windows.Forms.TextBox();
            this.txtCel = new System.Windows.Forms.TextBox();
            this.btnFajlbaIras = new System.Windows.Forms.Button();
            this.btnTorles = new System.Windows.Forms.Button();
            this.btnKeresés = new System.Windows.Forms.Button();
            this.btnFajlolvas = new System.Windows.Forms.Button();
            this.btnKiir = new System.Windows.Forms.Button();
            this.btnKilep = new System.Windows.Forms.Button();
            this.lbxEredmeny = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(99, 44);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(38, 13);
            this.lblDatum.TabIndex = 0;
            this.lblDatum.Text = "Dátum";
            // 
            // lblKartya
            // 
            this.lblKartya.AutoSize = true;
            this.lblKartya.Location = new System.Drawing.Point(99, 88);
            this.lblKartya.Name = "lblKartya";
            this.lblKartya.Size = new System.Drawing.Size(37, 13);
            this.lblKartya.TabIndex = 1;
            this.lblKartya.Text = "Kártya";
            // 
            // lblKezdo
            // 
            this.lblKezdo.AutoSize = true;
            this.lblKezdo.Location = new System.Drawing.Point(99, 128);
            this.lblKezdo.Name = "lblKezdo";
            this.lblKezdo.Size = new System.Drawing.Size(61, 13);
            this.lblKezdo.TabIndex = 2;
            this.lblKezdo.Text = "Kezdő szint";
            // 
            // lblCel
            // 
            this.lblCel.AutoSize = true;
            this.lblCel.Location = new System.Drawing.Point(99, 166);
            this.lblCel.Name = "lblCel";
            this.lblCel.Size = new System.Drawing.Size(46, 13);
            this.lblCel.TabIndex = 3;
            this.lblCel.Text = "Cél szint";
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(166, 37);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(100, 20);
            this.txtDatum.TabIndex = 4;
            // 
            // txtKartya
            // 
            this.txtKartya.Location = new System.Drawing.Point(166, 81);
            this.txtKartya.Name = "txtKartya";
            this.txtKartya.Size = new System.Drawing.Size(100, 20);
            this.txtKartya.TabIndex = 5;
            // 
            // txtKezdo
            // 
            this.txtKezdo.Location = new System.Drawing.Point(166, 125);
            this.txtKezdo.Name = "txtKezdo";
            this.txtKezdo.Size = new System.Drawing.Size(100, 20);
            this.txtKezdo.TabIndex = 6;
            // 
            // txtCel
            // 
            this.txtCel.Location = new System.Drawing.Point(166, 162);
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(100, 20);
            this.txtCel.TabIndex = 7;
            // 
            // btnFajlbaIras
            // 
            this.btnFajlbaIras.Location = new System.Drawing.Point(137, 250);
            this.btnFajlbaIras.Name = "btnFajlbaIras";
            this.btnFajlbaIras.Size = new System.Drawing.Size(85, 23);
            this.btnFajlbaIras.TabIndex = 8;
            this.btnFajlbaIras.Text = "Fájlba Írás";
            this.btnFajlbaIras.UseVisualStyleBackColor = true;
            this.btnFajlbaIras.Click += new System.EventHandler(this.BtnFajlbaIras_Click);
            // 
            // btnTorles
            // 
            this.btnTorles.Location = new System.Drawing.Point(240, 250);
            this.btnTorles.Name = "btnTorles";
            this.btnTorles.Size = new System.Drawing.Size(85, 23);
            this.btnTorles.TabIndex = 9;
            this.btnTorles.Text = "Törlés";
            this.btnTorles.UseVisualStyleBackColor = true;
            this.btnTorles.Click += new System.EventHandler(this.BtnTorles_Click);
            // 
            // btnKeresés
            // 
            this.btnKeresés.Location = new System.Drawing.Point(346, 250);
            this.btnKeresés.Name = "btnKeresés";
            this.btnKeresés.Size = new System.Drawing.Size(85, 23);
            this.btnKeresés.TabIndex = 10;
            this.btnKeresés.Text = "Keresés";
            this.btnKeresés.UseVisualStyleBackColor = true;
            this.btnKeresés.Click += new System.EventHandler(this.BtnKeresés_Click);
            // 
            // btnFajlolvas
            // 
            this.btnFajlolvas.Location = new System.Drawing.Point(137, 314);
            this.btnFajlolvas.Name = "btnFajlolvas";
            this.btnFajlolvas.Size = new System.Drawing.Size(85, 23);
            this.btnFajlolvas.TabIndex = 11;
            this.btnFajlolvas.Text = "Fájlba olvasás";
            this.btnFajlolvas.UseVisualStyleBackColor = true;
            this.btnFajlolvas.Click += new System.EventHandler(this.BtnFajlolvas_Click);
            // 
            // btnKiir
            // 
            this.btnKiir.Location = new System.Drawing.Point(240, 314);
            this.btnKiir.Name = "btnKiir";
            this.btnKiir.Size = new System.Drawing.Size(85, 23);
            this.btnKiir.TabIndex = 12;
            this.btnKiir.Text = "Kiiras listbox";
            this.btnKiir.UseVisualStyleBackColor = true;
            this.btnKiir.Click += new System.EventHandler(this.BtnKiir_Click);
            // 
            // btnKilep
            // 
            this.btnKilep.Location = new System.Drawing.Point(346, 314);
            this.btnKilep.Name = "btnKilep";
            this.btnKilep.Size = new System.Drawing.Size(85, 23);
            this.btnKilep.TabIndex = 13;
            this.btnKilep.Text = "Kilépés";
            this.btnKilep.UseVisualStyleBackColor = true;
            this.btnKilep.Click += new System.EventHandler(this.BtnKilep_Click);
            // 
            // lbxEredmeny
            // 
            this.lbxEredmeny.FormattingEnabled = true;
            this.lbxEredmeny.Location = new System.Drawing.Point(377, 32);
            this.lbxEredmeny.Name = "lbxEredmeny";
            this.lbxEredmeny.Size = new System.Drawing.Size(124, 147);
            this.lbxEredmeny.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbxEredmeny);
            this.Controls.Add(this.btnKilep);
            this.Controls.Add(this.btnKiir);
            this.Controls.Add(this.btnFajlolvas);
            this.Controls.Add(this.btnKeresés);
            this.Controls.Add(this.btnTorles);
            this.Controls.Add(this.btnFajlbaIras);
            this.Controls.Add(this.txtCel);
            this.Controls.Add(this.txtKezdo);
            this.Controls.Add(this.txtKartya);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.lblCel);
            this.Controls.Add(this.lblKezdo);
            this.Controls.Add(this.lblKartya);
            this.Controls.Add(this.lblDatum);
            this.Name = "Form1";
            this.Text = "Hotel LiftGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblKartya;
        private System.Windows.Forms.Label lblKezdo;
        private System.Windows.Forms.Label lblCel;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.TextBox txtKartya;
        private System.Windows.Forms.TextBox txtKezdo;
        private System.Windows.Forms.TextBox txtCel;
        private System.Windows.Forms.Button btnFajlbaIras;
        private System.Windows.Forms.Button btnTorles;
        private System.Windows.Forms.Button btnKeresés;
        private System.Windows.Forms.Button btnFajlolvas;
        private System.Windows.Forms.Button btnKiir;
        private System.Windows.Forms.Button btnKilep;
        private System.Windows.Forms.ListBox lbxEredmeny;
    }
}

