namespace OtomasyonProje.Forms
{
    partial class Ayarlar
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
            this.cikisYap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cikisYap
            // 
            this.cikisYap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cikisYap.AutoSize = true;
            this.cikisYap.Font = new System.Drawing.Font("Montserrat SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisYap.ForeColor = System.Drawing.Color.Gainsboro;
            this.cikisYap.Location = new System.Drawing.Point(396, 248);
            this.cikisYap.Name = "cikisYap";
            this.cikisYap.Size = new System.Drawing.Size(156, 37);
            this.cikisYap.TabIndex = 0;
            this.cikisYap.Text = "ÇIKIŞ YAP";
            this.cikisYap.Click += new System.EventHandler(this.cikisYap_Click);
            // 
            // Ayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1014, 558);
            this.Controls.Add(this.cikisYap);
            this.Name = "Ayarlar";
            this.Text = "Ayarlar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cikisYap;
    }
}