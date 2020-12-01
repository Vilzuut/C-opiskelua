namespace Tietokilpailupeli
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
            this.Kuva = new System.Windows.Forms.PictureBox();
            this.KysymysLabel = new System.Windows.Forms.Label();
            this.VastausNappi1 = new System.Windows.Forms.Button();
            this.VastausNappi3 = new System.Windows.Forms.Button();
            this.VastausNappi2 = new System.Windows.Forms.Button();
            this.VastausNappi4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Kuva)).BeginInit();
            this.SuspendLayout();
            // 
            // Kuva
            // 
            this.Kuva.BackColor = System.Drawing.SystemColors.Window;
            this.Kuva.Image = global::Tietokilpailupeli.Properties.Resources.Welcome;
            this.Kuva.Location = new System.Drawing.Point(12, 12);
            this.Kuva.Name = "Kuva";
            this.Kuva.Size = new System.Drawing.Size(840, 291);
            this.Kuva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Kuva.TabIndex = 0;
            this.Kuva.TabStop = false;
            // 
            // KysymysLabel
            // 
            this.KysymysLabel.BackColor = System.Drawing.SystemColors.Window;
            this.KysymysLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KysymysLabel.Location = new System.Drawing.Point(12, 320);
            this.KysymysLabel.Name = "KysymysLabel";
            this.KysymysLabel.Size = new System.Drawing.Size(840, 39);
            this.KysymysLabel.TabIndex = 1;
            this.KysymysLabel.Text = "Kysymys tähän";
            this.KysymysLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VastausNappi1
            // 
            this.VastausNappi1.BackColor = System.Drawing.SystemColors.Window;
            this.VastausNappi1.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VastausNappi1.Location = new System.Drawing.Point(12, 391);
            this.VastausNappi1.Name = "VastausNappi1";
            this.VastausNappi1.Size = new System.Drawing.Size(327, 49);
            this.VastausNappi1.TabIndex = 2;
            this.VastausNappi1.Tag = "1";
            this.VastausNappi1.Text = "Vastaus tähän";
            this.VastausNappi1.UseVisualStyleBackColor = false;
            this.VastausNappi1.Click += new System.EventHandler(this.VastausEvent);
            // 
            // VastausNappi3
            // 
            this.VastausNappi3.BackColor = System.Drawing.SystemColors.Window;
            this.VastausNappi3.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            this.VastausNappi3.Location = new System.Drawing.Point(12, 457);
            this.VastausNappi3.Name = "VastausNappi3";
            this.VastausNappi3.Size = new System.Drawing.Size(327, 49);
            this.VastausNappi3.TabIndex = 3;
            this.VastausNappi3.Tag = "3";
            this.VastausNappi3.Text = "Vastaus tähän";
            this.VastausNappi3.UseVisualStyleBackColor = false;
            this.VastausNappi3.Click += new System.EventHandler(this.VastausEvent);
            // 
            // VastausNappi2
            // 
            this.VastausNappi2.BackColor = System.Drawing.SystemColors.Window;
            this.VastausNappi2.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            this.VastausNappi2.Location = new System.Drawing.Point(525, 391);
            this.VastausNappi2.Name = "VastausNappi2";
            this.VastausNappi2.Size = new System.Drawing.Size(327, 49);
            this.VastausNappi2.TabIndex = 4;
            this.VastausNappi2.Tag = "2";
            this.VastausNappi2.Text = "Vastaus tähän";
            this.VastausNappi2.UseVisualStyleBackColor = false;
            this.VastausNappi2.Click += new System.EventHandler(this.VastausEvent);
            // 
            // VastausNappi4
            // 
            this.VastausNappi4.BackColor = System.Drawing.SystemColors.Window;
            this.VastausNappi4.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            this.VastausNappi4.Location = new System.Drawing.Point(525, 457);
            this.VastausNappi4.Name = "VastausNappi4";
            this.VastausNappi4.Size = new System.Drawing.Size(327, 49);
            this.VastausNappi4.TabIndex = 5;
            this.VastausNappi4.Tag = "4";
            this.VastausNappi4.Text = "Vastaus tähän";
            this.VastausNappi4.UseVisualStyleBackColor = false;
            this.VastausNappi4.Click += new System.EventHandler(this.VastausEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(864, 540);
            this.Controls.Add(this.VastausNappi4);
            this.Controls.Add(this.VastausNappi2);
            this.Controls.Add(this.VastausNappi3);
            this.Controls.Add(this.VastausNappi1);
            this.Controls.Add(this.KysymysLabel);
            this.Controls.Add(this.Kuva);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tietokilpailupeli";
            ((System.ComponentModel.ISupportInitialize)(this.Kuva)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Kuva;
        private System.Windows.Forms.Label KysymysLabel;
        private System.Windows.Forms.Button VastausNappi1;
        private System.Windows.Forms.Button VastausNappi3;
        private System.Windows.Forms.Button VastausNappi2;
        private System.Windows.Forms.Button VastausNappi4;
    }
}

