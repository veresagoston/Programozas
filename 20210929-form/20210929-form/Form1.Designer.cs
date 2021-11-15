namespace _20210929_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbszam = new System.Windows.Forms.TextBox();
            this.txbgyok = new System.Windows.Forms.TextBox();
            this.btnszamol = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "szám";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "négyzetgyök";
            // 
            // txbszam
            // 
            this.txbszam.Location = new System.Drawing.Point(97, 23);
            this.txbszam.Name = "txbszam";
            this.txbszam.Size = new System.Drawing.Size(100, 20);
            this.txbszam.TabIndex = 2;
            // 
            // txbgyok
            // 
            this.txbgyok.Location = new System.Drawing.Point(97, 96);
            this.txbgyok.Name = "txbgyok";
            this.txbgyok.Size = new System.Drawing.Size(100, 20);
            this.txbgyok.TabIndex = 3;
            // 
            // btnszamol
            // 
            this.btnszamol.Location = new System.Drawing.Point(21, 147);
            this.btnszamol.Name = "btnszamol";
            this.btnszamol.Size = new System.Drawing.Size(75, 23);
            this.btnszamol.TabIndex = 4;
            this.btnszamol.Text = "Számolás";
            this.btnszamol.UseVisualStyleBackColor = true;
            this.btnszamol.Click += new System.EventHandler(this.Btnszamol_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(122, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 220);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnszamol);
            this.Controls.Add(this.txbgyok);
            this.Controls.Add(this.txbszam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Négyzetgyök számítás";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbszam;
        private System.Windows.Forms.TextBox txbgyok;
        private System.Windows.Forms.Button btnszamol;
        private System.Windows.Forms.Button button2;
    }
}

