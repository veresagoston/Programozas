namespace _20210922_3feladat
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
            this.lblkerulet = new System.Windows.Forms.Label();
            this.lblterulet = new System.Windows.Forms.Label();
            this.txbsugar = new System.Windows.Forms.TextBox();
            this.txbkerulet = new System.Windows.Forms.TextBox();
            this.txbterulet = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "sugár";
            // 
            // lblkerulet
            // 
            this.lblkerulet.AutoSize = true;
            this.lblkerulet.Location = new System.Drawing.Point(12, 62);
            this.lblkerulet.Name = "lblkerulet";
            this.lblkerulet.Size = new System.Drawing.Size(63, 13);
            this.lblkerulet.TabIndex = 1;
            this.lblkerulet.Text = "kör kerülete";
            this.lblkerulet.Visible = false;
            // 
            // lblterulet
            // 
            this.lblterulet.AutoSize = true;
            this.lblterulet.Location = new System.Drawing.Point(132, 62);
            this.lblterulet.Name = "lblterulet";
            this.lblterulet.Size = new System.Drawing.Size(60, 13);
            this.lblterulet.TabIndex = 2;
            this.lblterulet.Text = "kör területe";
            this.lblterulet.Visible = false;
            // 
            // txbsugar
            // 
            this.txbsugar.Location = new System.Drawing.Point(51, 6);
            this.txbsugar.Name = "txbsugar";
            this.txbsugar.Size = new System.Drawing.Size(100, 20);
            this.txbsugar.TabIndex = 3;
            // 
            // txbkerulet
            // 
            this.txbkerulet.Enabled = false;
            this.txbkerulet.Location = new System.Drawing.Point(12, 78);
            this.txbkerulet.Name = "txbkerulet";
            this.txbkerulet.Size = new System.Drawing.Size(100, 20);
            this.txbkerulet.TabIndex = 4;
            // 
            // txbterulet
            // 
            this.txbterulet.Enabled = false;
            this.txbterulet.Location = new System.Drawing.Point(135, 78);
            this.txbterulet.Name = "txbterulet";
            this.txbterulet.Size = new System.Drawing.Size(100, 20);
            this.txbterulet.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "kör";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(135, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "gömb";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(250, 175);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 210);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbterulet);
            this.Controls.Add(this.txbkerulet);
            this.Controls.Add(this.txbsugar);
            this.Controls.Add(this.lblterulet);
            this.Controls.Add(this.lblkerulet);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblkerulet;
        private System.Windows.Forms.Label lblterulet;
        private System.Windows.Forms.TextBox txbsugar;
        private System.Windows.Forms.TextBox txbkerulet;
        private System.Windows.Forms.TextBox txbterulet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

