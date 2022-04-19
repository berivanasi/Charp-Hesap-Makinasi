
namespace Hesap_makinesi
{
    partial class FrmOrtalama
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
            this.lbl_sinav = new System.Windows.Forms.Label();
            this.lbl_2sinav = new System.Windows.Forms.Label();
            this.lbl_ortala = new System.Windows.Forms.Label();
            this.txt_1sinav = new System.Windows.Forms.TextBox();
            this.txt_2sinav = new System.Windows.Forms.TextBox();
            this.btn_hesap = new System.Windows.Forms.Button();
            this.grp_islem = new System.Windows.Forms.GroupBox();
            this.grp_islem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_sinav
            // 
            this.lbl_sinav.AutoSize = true;
            this.lbl_sinav.Location = new System.Drawing.Point(80, 44);
            this.lbl_sinav.Name = "lbl_sinav";
            this.lbl_sinav.Size = new System.Drawing.Size(44, 15);
            this.lbl_sinav.TabIndex = 0;
            this.lbl_sinav.Text = "1.Sınav";
            // 
            // lbl_2sinav
            // 
            this.lbl_2sinav.AutoSize = true;
            this.lbl_2sinav.Location = new System.Drawing.Point(80, 85);
            this.lbl_2sinav.Name = "lbl_2sinav";
            this.lbl_2sinav.Size = new System.Drawing.Size(44, 15);
            this.lbl_2sinav.TabIndex = 1;
            this.lbl_2sinav.Text = "2.Sınav";
            // 
            // lbl_ortala
            // 
            this.lbl_ortala.AutoSize = true;
            this.lbl_ortala.Location = new System.Drawing.Point(107, 139);
            this.lbl_ortala.Name = "lbl_ortala";
            this.lbl_ortala.Size = new System.Drawing.Size(56, 15);
            this.lbl_ortala.TabIndex = 2;
            this.lbl_ortala.Text = "Ortalama";
            // 
            // txt_1sinav
            // 
            this.txt_1sinav.Location = new System.Drawing.Point(145, 36);
            this.txt_1sinav.Name = "txt_1sinav";
            this.txt_1sinav.Size = new System.Drawing.Size(147, 23);
            this.txt_1sinav.TabIndex = 3;
            // 
            // txt_2sinav
            // 
            this.txt_2sinav.Location = new System.Drawing.Point(145, 77);
            this.txt_2sinav.Name = "txt_2sinav";
            this.txt_2sinav.Size = new System.Drawing.Size(147, 23);
            this.txt_2sinav.TabIndex = 4;
            // 
            // btn_hesap
            // 
            this.btn_hesap.Location = new System.Drawing.Point(170, 162);
            this.btn_hesap.Name = "btn_hesap";
            this.btn_hesap.Size = new System.Drawing.Size(122, 46);
            this.btn_hesap.TabIndex = 5;
            this.btn_hesap.Text = "Hesapla";
            this.btn_hesap.UseVisualStyleBackColor = true;
            this.btn_hesap.Click += new System.EventHandler(this.btn_hesap_Click);
            // 
            // grp_islem
            // 
            this.grp_islem.BackColor = System.Drawing.SystemColors.Control;
            this.grp_islem.Controls.Add(this.btn_hesap);
            this.grp_islem.Controls.Add(this.txt_2sinav);
            this.grp_islem.Controls.Add(this.txt_1sinav);
            this.grp_islem.Controls.Add(this.lbl_ortala);
            this.grp_islem.Controls.Add(this.lbl_2sinav);
            this.grp_islem.Controls.Add(this.lbl_sinav);
            this.grp_islem.Location = new System.Drawing.Point(247, 88);
            this.grp_islem.Name = "grp_islem";
            this.grp_islem.Size = new System.Drawing.Size(365, 261);
            this.grp_islem.TabIndex = 6;
            this.grp_islem.TabStop = false;
            this.grp_islem.Text = "İşlem Kaydı";
            // 
            // FrmOrtalama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grp_islem);
            this.Name = "FrmOrtalama";
            this.Text = "FrmOrtalama";
            this.grp_islem.ResumeLayout(false);
            this.grp_islem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_sinav;
        private System.Windows.Forms.Label lbl_2sinav;
        private System.Windows.Forms.Label lbl_ortala;
        private System.Windows.Forms.TextBox txt_1sinav;
        private System.Windows.Forms.TextBox txt_2sinav;
        private System.Windows.Forms.Button btn_hesap;
        private System.Windows.Forms.GroupBox grp_islem;
    }
}