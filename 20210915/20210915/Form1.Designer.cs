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
            this.btnosszeadas = new System.Windows.Forms.Button();
            this.btnkivonas = new System.Windows.Forms.Button();
            this.btnszorzas = new System.Windows.Forms.Button();
            this.txbadat1 = new System.Windows.Forms.TextBox();
            this.txberedmeny = new System.Windows.Forms.TextBox();
            this.txbadat2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.lblmuvelet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnosszeadas
            // 
            this.btnosszeadas.Location = new System.Drawing.Point(15, 83);
            this.btnosszeadas.Name = "btnosszeadas";
            this.btnosszeadas.Size = new System.Drawing.Size(75, 23);
            this.btnosszeadas.TabIndex = 0;
            this.btnosszeadas.Text = "Összeadás";
            this.btnosszeadas.UseVisualStyleBackColor = true;
            this.btnosszeadas.Click += new System.EventHandler(this.Btnosszeadas_Click);
            // 
            // btnkivonas
            // 
            this.btnkivonas.Location = new System.Drawing.Point(15, 112);
            this.btnkivonas.Name = "btnkivonas";
            this.btnkivonas.Size = new System.Drawing.Size(75, 23);
            this.btnkivonas.TabIndex = 1;
            this.btnkivonas.Text = "Kivonás";
            this.btnkivonas.UseVisualStyleBackColor = true;
            this.btnkivonas.Click += new System.EventHandler(this.Btnkivonas_Click);
            // 
            // btnszorzas
            // 
            this.btnszorzas.Location = new System.Drawing.Point(15, 141);
            this.btnszorzas.Name = "btnszorzas";
            this.btnszorzas.Size = new System.Drawing.Size(75, 23);
            this.btnszorzas.TabIndex = 2;
            this.btnszorzas.Text = "Szorzás";
            this.btnszorzas.UseVisualStyleBackColor = true;
            this.btnszorzas.Click += new System.EventHandler(this.Btnszorzas_Click);
            // 
            // txbadat1
            // 
            this.txbadat1.Location = new System.Drawing.Point(52, 6);
            this.txbadat1.Name = "txbadat1";
            this.txbadat1.Size = new System.Drawing.Size(100, 20);
            this.txbadat1.TabIndex = 3;
            // 
            // txberedmeny
            // 
            this.txberedmeny.Location = new System.Drawing.Point(155, 114);
            this.txberedmeny.Name = "txberedmeny";
            this.txberedmeny.Size = new System.Drawing.Size(100, 20);
            this.txberedmeny.TabIndex = 4;
            // 
            // txbadat2
            // 
            this.txbadat2.Location = new System.Drawing.Point(52, 35);
            this.txbadat2.Name = "txbadat2";
            this.txbadat2.Size = new System.Drawing.Size(100, 20);
            this.txbadat2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "adat1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "adat2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "eredmény";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(243, 163);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 9;
            this.exit.Text = "exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // lblmuvelet
            // 
            this.lblmuvelet.AutoSize = true;
            this.lblmuvelet.Location = new System.Drawing.Point(152, 93);
            this.lblmuvelet.Name = "lblmuvelet";
            this.lblmuvelet.Size = new System.Drawing.Size(119, 13);
            this.lblmuvelet.TabIndex = 10;
            this.lblmuvelet.Text = "Használj egy műveletet!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 198);
            this.Controls.Add(this.lblmuvelet);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbadat2);
            this.Controls.Add(this.txberedmeny);
            this.Controls.Add(this.txbadat1);
            this.Controls.Add(this.btnszorzas);
            this.Controls.Add(this.btnkivonas);
            this.Controls.Add(this.btnosszeadas);
            this.Name = "Form1";
            this.Text = "Műveletek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnosszeadas;
        private System.Windows.Forms.Button btnkivonas;
        private System.Windows.Forms.Button btnszorzas;
        private System.Windows.Forms.TextBox txbadat1;
        private System.Windows.Forms.TextBox txberedmeny;
        private System.Windows.Forms.TextBox txbadat2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label lblmuvelet;
    }
}

