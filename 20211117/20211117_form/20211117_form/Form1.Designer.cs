namespace _20211117_form
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
            this.lblSportpalya = new System.Windows.Forms.Label();
            this.lblHelyezes = new System.Windows.Forms.Label();
            this.lblPontszám = new System.Windows.Forms.Label();
            this.btnMegjelen = new System.Windows.Forms.Button();
            this.btnFajl = new System.Windows.Forms.Button();
            this.btnFeltolt = new System.Windows.Forms.Button();
            this.btnKeres = new System.Windows.Forms.Button();
            this.btnKilep = new System.Windows.Forms.Button();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.txtSport = new System.Windows.Forms.TextBox();
            this.txtHely = new System.Windows.Forms.TextBox();
            this.txtPont = new System.Windows.Forms.TextBox();
            this.lbxEredmeny = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(74, 44);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(38, 13);
            this.lblDatum.TabIndex = 0;
            this.lblDatum.Text = "Dátum";
            // 
            // lblSportpalya
            // 
            this.lblSportpalya.AutoSize = true;
            this.lblSportpalya.Location = new System.Drawing.Point(74, 86);
            this.lblSportpalya.Name = "lblSportpalya";
            this.lblSportpalya.Size = new System.Drawing.Size(57, 13);
            this.lblSportpalya.TabIndex = 1;
            this.lblSportpalya.Text = "Sportpálya";
            // 
            // lblHelyezes
            // 
            this.lblHelyezes.AutoSize = true;
            this.lblHelyezes.Location = new System.Drawing.Point(74, 129);
            this.lblHelyezes.Name = "lblHelyezes";
            this.lblHelyezes.Size = new System.Drawing.Size(50, 13);
            this.lblHelyezes.TabIndex = 2;
            this.lblHelyezes.Text = "Helyezés";
            // 
            // lblPontszám
            // 
            this.lblPontszám.AutoSize = true;
            this.lblPontszám.Location = new System.Drawing.Point(74, 163);
            this.lblPontszám.Name = "lblPontszám";
            this.lblPontszám.Size = new System.Drawing.Size(53, 13);
            this.lblPontszám.TabIndex = 3;
            this.lblPontszám.Text = "Pontszám";
            // 
            // btnMegjelen
            // 
            this.btnMegjelen.Location = new System.Drawing.Point(112, 271);
            this.btnMegjelen.Name = "btnMegjelen";
            this.btnMegjelen.Size = new System.Drawing.Size(92, 23);
            this.btnMegjelen.TabIndex = 4;
            this.btnMegjelen.Text = "Megjelenítés";
            this.btnMegjelen.UseVisualStyleBackColor = true;
            this.btnMegjelen.Click += new System.EventHandler(this.BtnMegjelen_Click);
            // 
            // btnFajl
            // 
            this.btnFajl.Location = new System.Drawing.Point(248, 271);
            this.btnFajl.Name = "btnFajl";
            this.btnFajl.Size = new System.Drawing.Size(75, 23);
            this.btnFajl.TabIndex = 5;
            this.btnFajl.Text = "Fájlba Írás";
            this.btnFajl.UseVisualStyleBackColor = true;
            this.btnFajl.Click += new System.EventHandler(this.BtnFajl_Click);
            // 
            // btnFeltolt
            // 
            this.btnFeltolt.Location = new System.Drawing.Point(393, 271);
            this.btnFeltolt.Name = "btnFeltolt";
            this.btnFeltolt.Size = new System.Drawing.Size(75, 23);
            this.btnFeltolt.TabIndex = 6;
            this.btnFeltolt.Text = "Feltöltés";
            this.btnFeltolt.UseVisualStyleBackColor = true;
            this.btnFeltolt.Click += new System.EventHandler(this.BtnFeltolt_Click);
            // 
            // btnKeres
            // 
            this.btnKeres.Location = new System.Drawing.Point(206, 324);
            this.btnKeres.Name = "btnKeres";
            this.btnKeres.Size = new System.Drawing.Size(75, 23);
            this.btnKeres.TabIndex = 7;
            this.btnKeres.Text = "Keresés";
            this.btnKeres.UseVisualStyleBackColor = true;
            // 
            // btnKilep
            // 
            this.btnKilep.Location = new System.Drawing.Point(349, 324);
            this.btnKilep.Name = "btnKilep";
            this.btnKilep.Size = new System.Drawing.Size(75, 23);
            this.btnKilep.TabIndex = 8;
            this.btnKilep.Text = "Kilépés";
            this.btnKilep.UseVisualStyleBackColor = true;
            this.btnKilep.Click += new System.EventHandler(this.BtnKilep_Click);
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(181, 41);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(100, 20);
            this.txtDatum.TabIndex = 9;
            // 
            // txtSport
            // 
            this.txtSport.Location = new System.Drawing.Point(181, 79);
            this.txtSport.Name = "txtSport";
            this.txtSport.Size = new System.Drawing.Size(100, 20);
            this.txtSport.TabIndex = 10;
            // 
            // txtHely
            // 
            this.txtHely.Location = new System.Drawing.Point(181, 122);
            this.txtHely.Name = "txtHely";
            this.txtHely.Size = new System.Drawing.Size(100, 20);
            this.txtHely.TabIndex = 11;
            // 
            // txtPont
            // 
            this.txtPont.Location = new System.Drawing.Point(179, 160);
            this.txtPont.Name = "txtPont";
            this.txtPont.Size = new System.Drawing.Size(100, 20);
            this.txtPont.TabIndex = 12;
            // 
            // lbxEredmeny
            // 
            this.lbxEredmeny.FormattingEnabled = true;
            this.lbxEredmeny.Location = new System.Drawing.Point(393, 33);
            this.lbxEredmeny.Name = "lbxEredmeny";
            this.lbxEredmeny.Size = new System.Drawing.Size(120, 147);
            this.lbxEredmeny.TabIndex = 13;
            this.lbxEredmeny.SelectedIndexChanged += new System.EventHandler(this.LbxEredmeny_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbxEredmeny);
            this.Controls.Add(this.txtPont);
            this.Controls.Add(this.txtHely);
            this.Controls.Add(this.txtSport);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.btnKilep);
            this.Controls.Add(this.btnKeres);
            this.Controls.Add(this.btnFeltolt);
            this.Controls.Add(this.btnFajl);
            this.Controls.Add(this.btnMegjelen);
            this.Controls.Add(this.lblPontszám);
            this.Controls.Add(this.lblHelyezes);
            this.Controls.Add(this.lblSportpalya);
            this.Controls.Add(this.lblDatum);
            this.Name = "Form1";
            this.Text = "ProstGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblSportpalya;
        private System.Windows.Forms.Label lblHelyezes;
        private System.Windows.Forms.Label lblPontszám;
        private System.Windows.Forms.Button btnMegjelen;
        private System.Windows.Forms.Button btnFajl;
        private System.Windows.Forms.Button btnFeltolt;
        private System.Windows.Forms.Button btnKeres;
        private System.Windows.Forms.Button btnKilep;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.TextBox txtSport;
        private System.Windows.Forms.TextBox txtHely;
        private System.Windows.Forms.TextBox txtPont;
        private System.Windows.Forms.ListBox lbxEredmeny;
    }
}

