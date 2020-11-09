namespace Gitterhubber
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
            this.Etusivu = new System.Windows.Forms.Button();
            this.Tekstilaatikko = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Viesti = new System.Windows.Forms.Label();
            this.TekstiTahan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Etusivu
            // 
            this.Etusivu.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Etusivu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Etusivu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Etusivu.Location = new System.Drawing.Point(425, 217);
            this.Etusivu.Name = "Etusivu";
            this.Etusivu.Size = new System.Drawing.Size(102, 81);
            this.Etusivu.TabIndex = 0;
            this.Etusivu.Text = "Paina";
            this.Etusivu.UseVisualStyleBackColor = false;
            this.Etusivu.Click += new System.EventHandler(this.Etusivu_Click);
            // 
            // Tekstilaatikko
            // 
            this.Tekstilaatikko.Location = new System.Drawing.Point(385, 55);
            this.Tekstilaatikko.MaxLength = 33000;
            this.Tekstilaatikko.Name = "Tekstilaatikko";
            this.Tekstilaatikko.Size = new System.Drawing.Size(172, 20);
            this.Tekstilaatikko.TabIndex = 1;
            this.Tekstilaatikko.Text = "Anna Etunimesi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Viesti
            // 
            this.Viesti.AutoSize = true;
            this.Viesti.Location = new System.Drawing.Point(282, 137);
            this.Viesti.Name = "Viesti";
            this.Viesti.Size = new System.Drawing.Size(104, 13);
            this.Viesti.TabIndex = 3;
            this.Viesti.Text = "Tähän tulee vastaus";
            this.Viesti.Visible = false;
            // 
            // TekstiTahan
            // 
            this.TekstiTahan.AutoSize = true;
            this.TekstiTahan.Location = new System.Drawing.Point(282, 58);
            this.TekstiTahan.Name = "TekstiTahan";
            this.TekstiTahan.Size = new System.Drawing.Size(79, 13);
            this.TekstiTahan.TabIndex = 4;
            this.TekstiTahan.Text = "Anna etunimesi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 450);
            this.Controls.Add(this.TekstiTahan);
            this.Controls.Add(this.Viesti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tekstilaatikko);
            this.Controls.Add(this.Etusivu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Etusivu;
        private System.Windows.Forms.TextBox Tekstilaatikko;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Viesti;
        private System.Windows.Forms.Label TekstiTahan;
    }
}

