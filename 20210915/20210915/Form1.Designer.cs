namespace _20210915
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
            this.lbladat1 = new System.Windows.Forms.Label();
            this.lbladat2 = new System.Windows.Forms.Label();
            this.txtadat1 = new System.Windows.Forms.TextBox();
            this.txtadat2 = new System.Windows.Forms.TextBox();
            this.btnosszeadas = new System.Windows.Forms.Button();
            this.btnkivonas = new System.Windows.Forms.Button();
            this.btnszorzas = new System.Windows.Forms.Button();
            this.lbleredmeny = new System.Windows.Forms.Label();
            this.lblmuvelet = new System.Windows.Forms.Label();
            this.txteredmeny = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbladat1
            // 
            this.lbladat1.AutoSize = true;
            this.lbladat1.Location = new System.Drawing.Point(50, 39);
            this.lbladat1.Name = "lbladat1";
            this.lbladat1.Size = new System.Drawing.Size(35, 13);
            this.lbladat1.TabIndex = 0;
            this.lbladat1.Text = "Adat1";
            // 
            // lbladat2
            // 
            this.lbladat2.AutoSize = true;
            this.lbladat2.Location = new System.Drawing.Point(50, 81);
            this.lbladat2.Name = "lbladat2";
            this.lbladat2.Size = new System.Drawing.Size(35, 13);
            this.lbladat2.TabIndex = 1;
            this.lbladat2.Text = "Adat2";
            // 
            // txtadat1
            // 
            this.txtadat1.Location = new System.Drawing.Point(116, 39);
            this.txtadat1.Name = "txtadat1";
            this.txtadat1.Size = new System.Drawing.Size(100, 20);
            this.txtadat1.TabIndex = 2;
            // 
            // txtadat2
            // 
            this.txtadat2.Location = new System.Drawing.Point(116, 81);
            this.txtadat2.Name = "txtadat2";
            this.txtadat2.Size = new System.Drawing.Size(100, 20);
            this.txtadat2.TabIndex = 3;
            // 
            // btnosszeadas
            // 
            this.btnosszeadas.Location = new System.Drawing.Point(53, 145);
            this.btnosszeadas.Name = "btnosszeadas";
            this.btnosszeadas.Size = new System.Drawing.Size(75, 23);
            this.btnosszeadas.TabIndex = 4;
            this.btnosszeadas.Text = "Összeadás";
            this.btnosszeadas.UseVisualStyleBackColor = true;
            this.btnosszeadas.Click += new System.EventHandler(this.Btnosszeadas_Click);
            // 
            // btnkivonas
            // 
            this.btnkivonas.Location = new System.Drawing.Point(53, 201);
            this.btnkivonas.Name = "btnkivonas";
            this.btnkivonas.Size = new System.Drawing.Size(75, 23);
            this.btnkivonas.TabIndex = 5;
            this.btnkivonas.Text = "Kivonás";
            this.btnkivonas.UseVisualStyleBackColor = true;
            this.btnkivonas.Click += new System.EventHandler(this.Btnkivonas_Click);
            // 
            // btnszorzas
            // 
            this.btnszorzas.Location = new System.Drawing.Point(53, 259);
            this.btnszorzas.Name = "btnszorzas";
            this.btnszorzas.Size = new System.Drawing.Size(75, 23);
            this.btnszorzas.TabIndex = 6;
            this.btnszorzas.Text = "Szorzás";
            this.btnszorzas.UseVisualStyleBackColor = true;
            this.btnszorzas.Click += new System.EventHandler(this.Btnszorzas_Click);
            // 
            // lbleredmeny
            // 
            this.lbleredmeny.AutoSize = true;
            this.lbleredmeny.Location = new System.Drawing.Point(216, 183);
            this.lbleredmeny.Name = "lbleredmeny";
            this.lbleredmeny.Size = new System.Drawing.Size(54, 13);
            this.lbleredmeny.TabIndex = 7;
            this.lbleredmeny.Text = "Eredmény";
            // 
            // lblmuvelet
            // 
            this.lblmuvelet.AutoSize = true;
            this.lblmuvelet.Location = new System.Drawing.Point(305, 150);
            this.lblmuvelet.Name = "lblmuvelet";
            this.lblmuvelet.Size = new System.Drawing.Size(29, 13);
            this.lblmuvelet.TabIndex = 8;
            this.lblmuvelet.Text = "label";
            this.lblmuvelet.Visible = false;
            this.lblmuvelet.Click += new System.EventHandler(this.Lblmuvelet_Click);
            // 
            // txteredmeny
            // 
            this.txteredmeny.Location = new System.Drawing.Point(308, 180);
            this.txteredmeny.Name = "txteredmeny";
            this.txteredmeny.Size = new System.Drawing.Size(100, 20);
            this.txteredmeny.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 319);
            this.Controls.Add(this.txteredmeny);
            this.Controls.Add(this.lblmuvelet);
            this.Controls.Add(this.lbleredmeny);
            this.Controls.Add(this.btnszorzas);
            this.Controls.Add(this.btnkivonas);
            this.Controls.Add(this.btnosszeadas);
            this.Controls.Add(this.txtadat2);
            this.Controls.Add(this.txtadat1);
            this.Controls.Add(this.lbladat2);
            this.Controls.Add(this.lbladat1);
            this.Name = "Form1";
            this.Text = "Műveletek";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbladat1;
        private System.Windows.Forms.Label lbladat2;
        private System.Windows.Forms.TextBox txtadat1;
        private System.Windows.Forms.TextBox txtadat2;
        private System.Windows.Forms.Button btnosszeadas;
        private System.Windows.Forms.Button btnkivonas;
        private System.Windows.Forms.Button btnszorzas;
        private System.Windows.Forms.Label lbleredmeny;
        private System.Windows.Forms.Label lblmuvelet;
        private System.Windows.Forms.TextBox txteredmeny;
    }
}

