
namespace _20210929_7feladat
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
            this.lblnagyobbik = new System.Windows.Forms.Label();
            this.lblkisebb = new System.Windows.Forms.Label();
            this.lbleredmeny = new System.Windows.Forms.Label();
            this.nagyobbik = new System.Windows.Forms.TextBox();
            this.kissebbik = new System.Windows.Forms.TextBox();
            this.txteredmeny = new System.Windows.Forms.TextBox();
            this.btnszamitas = new System.Windows.Forms.Button();
            this.btnkilep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnagyobbik
            // 
            this.lblnagyobbik.AutoSize = true;
            this.lblnagyobbik.Location = new System.Drawing.Point(51, 79);
            this.lblnagyobbik.Name = "lblnagyobbik";
            this.lblnagyobbik.Size = new System.Drawing.Size(108, 13);
            this.lblnagyobbik.TabIndex = 0;
            this.lblnagyobbik.Text = "Nagyobb egész szám";
            // 
            // lblkisebb
            // 
            this.lblkisebb.AutoSize = true;
            this.lblkisebb.Location = new System.Drawing.Point(51, 122);
            this.lblkisebb.Name = "lblkisebb";
            this.lblkisebb.Size = new System.Drawing.Size(104, 13);
            this.lblkisebb.TabIndex = 1;
            this.lblkisebb.Text = "kisebbik egész szám";
            // 
            // lbleredmeny
            // 
            this.lbleredmeny.AutoSize = true;
            this.lbleredmeny.Location = new System.Drawing.Point(109, 180);
            this.lbleredmeny.Name = "lbleredmeny";
            this.lbleredmeny.Size = new System.Drawing.Size(121, 13);
            this.lbleredmeny.TabIndex = 2;
            this.lbleredmeny.Text = "legnagyobb közös osztó";
            // 
            // nagyobbik
            // 
            this.nagyobbik.Location = new System.Drawing.Point(169, 79);
            this.nagyobbik.Name = "nagyobbik";
            this.nagyobbik.Size = new System.Drawing.Size(100, 20);
            this.nagyobbik.TabIndex = 3;
            // 
            // kissebbik
            // 
            this.kissebbik.Location = new System.Drawing.Point(169, 122);
            this.kissebbik.Name = "kissebbik";
            this.kissebbik.Size = new System.Drawing.Size(100, 20);
            this.kissebbik.TabIndex = 4;
            // 
            // txteredmeny
            // 
            this.txteredmeny.Location = new System.Drawing.Point(121, 227);
            this.txteredmeny.Name = "txteredmeny";
            this.txteredmeny.Size = new System.Drawing.Size(100, 20);
            this.txteredmeny.TabIndex = 5;
            // 
            // btnszamitas
            // 
            this.btnszamitas.Location = new System.Drawing.Point(65, 278);
            this.btnszamitas.Name = "btnszamitas";
            this.btnszamitas.Size = new System.Drawing.Size(75, 23);
            this.btnszamitas.TabIndex = 6;
            this.btnszamitas.Text = "Számitás";
            this.btnszamitas.UseVisualStyleBackColor = true;
            this.btnszamitas.Click += new System.EventHandler(this.btnszamitas_Click);
            // 
            // btnkilep
            // 
            this.btnkilep.Location = new System.Drawing.Point(211, 278);
            this.btnkilep.Name = "btnkilep";
            this.btnkilep.Size = new System.Drawing.Size(75, 23);
            this.btnkilep.TabIndex = 7;
            this.btnkilep.Text = "Kilépés";
            this.btnkilep.UseVisualStyleBackColor = true;
            this.btnkilep.Click += new System.EventHandler(this.btnkilep_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 340);
            this.Controls.Add(this.btnkilep);
            this.Controls.Add(this.btnszamitas);
            this.Controls.Add(this.txteredmeny);
            this.Controls.Add(this.kissebbik);
            this.Controls.Add(this.nagyobbik);
            this.Controls.Add(this.lbleredmeny);
            this.Controls.Add(this.lblkisebb);
            this.Controls.Add(this.lblnagyobbik);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnagyobbik;
        private System.Windows.Forms.Label lblkisebb;
        private System.Windows.Forms.Label lbleredmeny;
        private System.Windows.Forms.TextBox nagyobbik;
        private System.Windows.Forms.TextBox kissebbik;
        private System.Windows.Forms.TextBox txteredmeny;
        private System.Windows.Forms.Button btnszamitas;
        private System.Windows.Forms.Button btnkilep;
    }
}

