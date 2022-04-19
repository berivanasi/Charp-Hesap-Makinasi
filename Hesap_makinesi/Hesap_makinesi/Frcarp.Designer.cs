
namespace Hesap_makinesi
{
    partial class Frcarp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_hesapla = new System.Windows.Forms.Button();
            this.lbl_sonuc = new System.Windows.Forms.Label();
            this.txt_sayi2 = new System.Windows.Forms.TextBox();
            this.txt_sayi1 = new System.Windows.Forms.TextBox();
            this.lbl_sayi2 = new System.Windows.Forms.Label();
            this.lbl_sayi1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.btn_hesapla);
            this.groupBox1.Controls.Add(this.lbl_sonuc);
            this.groupBox1.Controls.Add(this.txt_sayi2);
            this.groupBox1.Controls.Add(this.txt_sayi1);
            this.groupBox1.Controls.Add(this.lbl_sayi2);
            this.groupBox1.Controls.Add(this.lbl_sayi1);
            this.groupBox1.Location = new System.Drawing.Point(230, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 267);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Çarpma";
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.Location = new System.Drawing.Point(112, 187);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(75, 23);
            this.btn_hesapla.TabIndex = 5;
            this.btn_hesapla.Text = "Hesapla";
            this.btn_hesapla.UseVisualStyleBackColor = true;
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // lbl_sonuc
            // 
            this.lbl_sonuc.AutoSize = true;
            this.lbl_sonuc.Location = new System.Drawing.Point(147, 137);
            this.lbl_sonuc.Name = "lbl_sonuc";
            this.lbl_sonuc.Size = new System.Drawing.Size(40, 15);
            this.lbl_sonuc.TabIndex = 4;
            this.lbl_sonuc.Text = "Sonuç";
            // 
            // txt_sayi2
            // 
            this.txt_sayi2.Location = new System.Drawing.Point(147, 86);
            this.txt_sayi2.Name = "txt_sayi2";
            this.txt_sayi2.Size = new System.Drawing.Size(100, 23);
            this.txt_sayi2.TabIndex = 3;
            // 
            // txt_sayi1
            // 
            this.txt_sayi1.Location = new System.Drawing.Point(147, 48);
            this.txt_sayi1.Name = "txt_sayi1";
            this.txt_sayi1.Size = new System.Drawing.Size(100, 23);
            this.txt_sayi1.TabIndex = 2;
            // 
            // lbl_sayi2
            // 
            this.lbl_sayi2.AutoSize = true;
            this.lbl_sayi2.Location = new System.Drawing.Point(73, 89);
            this.lbl_sayi2.Name = "lbl_sayi2";
            this.lbl_sayi2.Size = new System.Drawing.Size(28, 15);
            this.lbl_sayi2.TabIndex = 1;
            this.lbl_sayi2.Text = "Sayi";
            // 
            // lbl_sayi1
            // 
            this.lbl_sayi1.AutoSize = true;
            this.lbl_sayi1.Location = new System.Drawing.Point(73, 48);
            this.lbl_sayi1.Name = "lbl_sayi1";
            this.lbl_sayi1.Size = new System.Drawing.Size(28, 15);
            this.lbl_sayi1.TabIndex = 0;
            this.lbl_sayi1.Text = "Sayi";
            // 
            // Frcarp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frcarp";
            this.Text = "Frcarp";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_hesapla;
        private System.Windows.Forms.Label lbl_sonuc;
        private System.Windows.Forms.TextBox txt_sayi2;
        private System.Windows.Forms.TextBox txt_sayi1;
        private System.Windows.Forms.Label lbl_sayi2;
        private System.Windows.Forms.Label lbl_sayi1;
    }
}