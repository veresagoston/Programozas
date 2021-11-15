namespace _20210922_4
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnrendez = new System.Windows.Forms.Button();
            this.txbadat1 = new System.Windows.Forms.TextBox();
            this.txbadat3 = new System.Windows.Forms.TextBox();
            this.txbadat2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(131, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "bezár";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnrendez
            // 
            this.btnrendez.Location = new System.Drawing.Point(25, 129);
            this.btnrendez.Name = "btnrendez";
            this.btnrendez.Size = new System.Drawing.Size(75, 23);
            this.btnrendez.TabIndex = 1;
            this.btnrendez.Text = "rendez";
            this.btnrendez.UseVisualStyleBackColor = true;
            this.btnrendez.Click += new System.EventHandler(this.Btnrendez_Click);
            // 
            // txbadat1
            // 
            this.txbadat1.Location = new System.Drawing.Point(131, 16);
            this.txbadat1.Name = "txbadat1";
            this.txbadat1.Size = new System.Drawing.Size(100, 20);
            this.txbadat1.TabIndex = 2;
            // 
            // txbadat3
            // 
            this.txbadat3.Location = new System.Drawing.Point(131, 68);
            this.txbadat3.Name = "txbadat3";
            this.txbadat3.Size = new System.Drawing.Size(100, 20);
            this.txbadat3.TabIndex = 3;
            // 
            // txbadat2
            // 
            this.txbadat2.Location = new System.Drawing.Point(131, 42);
            this.txbadat2.Name = "txbadat2";
            this.txbadat2.Size = new System.Drawing.Size(100, 20);
            this.txbadat2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "első szám";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "második szám";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "harmadik szám";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 190);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbadat2);
            this.Controls.Add(this.txbadat3);
            this.Controls.Add(this.txbadat1);
            this.Controls.Add(this.btnrendez);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnrendez;
        private System.Windows.Forms.TextBox txbadat1;
        private System.Windows.Forms.TextBox txbadat3;
        private System.Windows.Forms.TextBox txbadat2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

