namespace formsapp
{
    partial class ogretmenekle
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
            this.grpogretmen = new System.Windows.Forms.GroupBox();
            this.lbload = new System.Windows.Forms.Label();
            this.lblosoyad = new System.Windows.Forms.Label();
            this.lbltc = new System.Windows.Forms.Label();
            this.txtoad = new System.Windows.Forms.TextBox();
            this.txtosoyad = new System.Windows.Forms.TextBox();
            this.txttc = new System.Windows.Forms.TextBox();
            this.btnokayit = new System.Windows.Forms.Button();
            this.grpogretmen.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpogretmen
            // 
            this.grpogretmen.Controls.Add(this.txttc);
            this.grpogretmen.Controls.Add(this.txtosoyad);
            this.grpogretmen.Controls.Add(this.txtoad);
            this.grpogretmen.Controls.Add(this.lbltc);
            this.grpogretmen.Controls.Add(this.lblosoyad);
            this.grpogretmen.Controls.Add(this.lbload);
            this.grpogretmen.Location = new System.Drawing.Point(53, 41);
            this.grpogretmen.Name = "grpogretmen";
            this.grpogretmen.Size = new System.Drawing.Size(474, 241);
            this.grpogretmen.TabIndex = 0;
            this.grpogretmen.TabStop = false;
            this.grpogretmen.Text = "OgretmenKayıt";
            // 
            // lbload
            // 
            this.lbload.AutoSize = true;
            this.lbload.Location = new System.Drawing.Point(62, 55);
            this.lbload.Name = "lbload";
            this.lbload.Size = new System.Drawing.Size(27, 16);
            this.lbload.TabIndex = 0;
            this.lbload.Text = "Adi";
            // 
            // lblosoyad
            // 
            this.lblosoyad.AutoSize = true;
            this.lblosoyad.Location = new System.Drawing.Point(65, 97);
            this.lblosoyad.Name = "lblosoyad";
            this.lblosoyad.Size = new System.Drawing.Size(47, 16);
            this.lblosoyad.TabIndex = 1;
            this.lblosoyad.Text = "Soyad";
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Location = new System.Drawing.Point(68, 140);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(25, 16);
            this.lbltc.TabIndex = 2;
            this.lbltc.Text = "TC";
            // 
            // txtoad
            // 
            this.txtoad.Location = new System.Drawing.Point(176, 55);
            this.txtoad.Name = "txtoad";
            this.txtoad.Size = new System.Drawing.Size(100, 22);
            this.txtoad.TabIndex = 3;
            // 
            // txtosoyad
            // 
            this.txtosoyad.Location = new System.Drawing.Point(176, 97);
            this.txtosoyad.Name = "txtosoyad";
            this.txtosoyad.Size = new System.Drawing.Size(100, 22);
            this.txtosoyad.TabIndex = 4;
            // 
            // txttc
            // 
            this.txttc.Location = new System.Drawing.Point(176, 133);
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(100, 22);
            this.txttc.TabIndex = 5;
            // 
            // btnokayit
            // 
            this.btnokayit.Location = new System.Drawing.Point(229, 339);
            this.btnokayit.Name = "btnokayit";
            this.btnokayit.Size = new System.Drawing.Size(171, 42);
            this.btnokayit.TabIndex = 1;
            this.btnokayit.Text = "Kayit";
            this.btnokayit.UseVisualStyleBackColor = true;
            this.btnokayit.Click += new System.EventHandler(this.btnokayit_Click);
            // 
            // ogretmenekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnokayit);
            this.Controls.Add(this.grpogretmen);
            this.Name = "ogretmenekle";
            this.Text = "ogretmenekle";
            this.grpogretmen.ResumeLayout(false);
            this.grpogretmen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpogretmen;
        private System.Windows.Forms.TextBox txttc;
        private System.Windows.Forms.TextBox txtosoyad;
        private System.Windows.Forms.TextBox txtoad;
        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.Label lblosoyad;
        private System.Windows.Forms.Label lbload;
        private System.Windows.Forms.Button btnokayit;
    }
}