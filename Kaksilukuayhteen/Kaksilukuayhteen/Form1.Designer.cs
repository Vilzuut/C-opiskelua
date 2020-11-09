namespace Kaksilukuayhteen
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
            this.Luku1 = new System.Windows.Forms.Label();
            this.Luku2 = new System.Windows.Forms.Label();
            this.Tekstilaatikko1 = new System.Windows.Forms.TextBox();
            this.Tekstilaatikko2 = new System.Windows.Forms.TextBox();
            this.Laskeyhteen = new System.Windows.Forms.Button();
            this.Vastauslabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Luku1
            // 
            this.Luku1.AutoSize = true;
            this.Luku1.Location = new System.Drawing.Point(254, 104);
            this.Luku1.Name = "Luku1";
            this.Luku1.Size = new System.Drawing.Size(76, 13);
            this.Luku1.TabIndex = 0;
            this.Luku1.Text = "Anna luku yksi";
            // 
            // Luku2
            // 
            this.Luku2.AutoSize = true;
            this.Luku2.Location = new System.Drawing.Point(254, 137);
            this.Luku2.Name = "Luku2";
            this.Luku2.Size = new System.Drawing.Size(83, 13);
            this.Luku2.TabIndex = 1;
            this.Luku2.Text = "Anna luku kaksi";
            // 
            // Tekstilaatikko1
            // 
            this.Tekstilaatikko1.Location = new System.Drawing.Point(353, 104);
            this.Tekstilaatikko1.Name = "Tekstilaatikko1";
            this.Tekstilaatikko1.Size = new System.Drawing.Size(100, 20);
            this.Tekstilaatikko1.TabIndex = 2;
            // 
            // Tekstilaatikko2
            // 
            this.Tekstilaatikko2.Location = new System.Drawing.Point(353, 137);
            this.Tekstilaatikko2.Name = "Tekstilaatikko2";
            this.Tekstilaatikko2.Size = new System.Drawing.Size(100, 20);
            this.Tekstilaatikko2.TabIndex = 3;
            // 
            // Laskeyhteen
            // 
            this.Laskeyhteen.Location = new System.Drawing.Point(257, 178);
            this.Laskeyhteen.Name = "Laskeyhteen";
            this.Laskeyhteen.Size = new System.Drawing.Size(196, 44);
            this.Laskeyhteen.TabIndex = 4;
            this.Laskeyhteen.Text = "Laske luvut yhteen";
            this.Laskeyhteen.UseVisualStyleBackColor = true;
            this.Laskeyhteen.Click += new System.EventHandler(this.Laskeyhteen_Click);
            // 
            // Vastauslabel
            // 
            this.Vastauslabel.AutoSize = true;
            this.Vastauslabel.Location = new System.Drawing.Point(262, 246);
            this.Vastauslabel.Name = "Vastauslabel";
            this.Vastauslabel.Size = new System.Drawing.Size(75, 13);
            this.Vastauslabel.TabIndex = 5;
            this.Vastauslabel.Text = "Vastaus tähän";
            this.Vastauslabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Vastauslabel);
            this.Controls.Add(this.Laskeyhteen);
            this.Controls.Add(this.Tekstilaatikko2);
            this.Controls.Add(this.Tekstilaatikko1);
            this.Controls.Add(this.Luku2);
            this.Controls.Add(this.Luku1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Luku1;
        private System.Windows.Forms.Label Luku2;
        private System.Windows.Forms.TextBox Tekstilaatikko1;
        private System.Windows.Forms.TextBox Tekstilaatikko2;
        private System.Windows.Forms.Button Laskeyhteen;
        private System.Windows.Forms.Label Vastauslabel;
    }
}

