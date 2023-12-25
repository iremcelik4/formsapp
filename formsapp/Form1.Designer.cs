namespace formsapp
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
            this.grpogrenci = new System.Windows.Forms.GroupBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtnumara = new System.Windows.Forms.TextBox();
            this.lblad = new System.Windows.Forms.Label();
            this.lblsoyad = new System.Windows.Forms.Label();
            this.lblnumara = new System.Windows.Forms.Label();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.grpogrenci.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpogrenci
            // 
            this.grpogrenci.Controls.Add(this.lblnumara);
            this.grpogrenci.Controls.Add(this.lblsoyad);
            this.grpogrenci.Controls.Add(this.lblad);
            this.grpogrenci.Controls.Add(this.txtnumara);
            this.grpogrenci.Controls.Add(this.txtsoyad);
            this.grpogrenci.Controls.Add(this.txtad);
            this.grpogrenci.Location = new System.Drawing.Point(12, 12);
            this.grpogrenci.Name = "grpogrenci";
            this.grpogrenci.Size = new System.Drawing.Size(406, 196);
            this.grpogrenci.TabIndex = 0;
            this.grpogrenci.TabStop = false;
            this.grpogrenci.Text = "ogrenci bilgileri";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(64, 49);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(100, 22);
            this.txtad.TabIndex = 0;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(64, 97);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(100, 22);
            this.txtsoyad.TabIndex = 1;
            // 
            // txtnumara
            // 
            this.txtnumara.Location = new System.Drawing.Point(64, 142);
            this.txtnumara.Name = "txtnumara";
            this.txtnumara.Size = new System.Drawing.Size(100, 22);
            this.txtnumara.TabIndex = 2;
            // 
            // lblad
            // 
            this.lblad.AutoSize = true;
            this.lblad.Location = new System.Drawing.Point(197, 55);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(24, 16);
            this.lblad.TabIndex = 3;
            this.lblad.Text = "Ad";
            // 
            // lblsoyad
            // 
            this.lblsoyad.AutoSize = true;
            this.lblsoyad.Location = new System.Drawing.Point(196, 97);
            this.lblsoyad.Name = "lblsoyad";
            this.lblsoyad.Size = new System.Drawing.Size(47, 16);
            this.lblsoyad.TabIndex = 4;
            this.lblsoyad.Text = "Soyad";
            // 
            // lblnumara
            // 
            this.lblnumara.AutoSize = true;
            this.lblnumara.Location = new System.Drawing.Point(200, 142);
            this.lblnumara.Name = "lblnumara";
            this.lblnumara.Size = new System.Drawing.Size(55, 16);
            this.lblnumara.TabIndex = 5;
            this.lblnumara.Text = "Numara";
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(146, 243);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(75, 23);
            this.btnkaydet.TabIndex = 6;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.grpogrenci);
            this.Name = "Form1";
            this.Text = "Ogrenci kayıt";
            this.grpogrenci.ResumeLayout(false);
            this.grpogrenci.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpogrenci;
        private System.Windows.Forms.Label lblnumara;
        private System.Windows.Forms.Label lblsoyad;
        private System.Windows.Forms.Label lblad;
        private System.Windows.Forms.TextBox txtnumara;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Button btnkaydet;
    }
}

