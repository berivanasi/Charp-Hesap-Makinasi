
namespace Hesap_makinesi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_bölme = new System.Windows.Forms.Button();
            this.btn_çarpma = new System.Windows.Forms.Button();
            this.btn_çıkarma = new System.Windows.Forms.Button();
            this.btn_toplama = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_bölme);
            this.groupBox1.Controls.Add(this.btn_çarpma);
            this.groupBox1.Controls.Add(this.btn_çıkarma);
            this.groupBox1.Controls.Add(this.btn_toplama);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(151, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 334);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hesap Makinası";
            // 
            // btn_bölme
            // 
            this.btn_bölme.Location = new System.Drawing.Point(247, 225);
            this.btn_bölme.Name = "btn_bölme";
            this.btn_bölme.Size = new System.Drawing.Size(163, 58);
            this.btn_bölme.TabIndex = 4;
            this.btn_bölme.Text = "Bölme";
            this.btn_bölme.UseVisualStyleBackColor = true;
            this.btn_bölme.Click += new System.EventHandler(this.btn_bölme_Click);
            // 
            // btn_çarpma
            // 
            this.btn_çarpma.Location = new System.Drawing.Point(97, 225);
            this.btn_çarpma.Name = "btn_çarpma";
            this.btn_çarpma.Size = new System.Drawing.Size(163, 58);
            this.btn_çarpma.TabIndex = 3;
            this.btn_çarpma.Text = "Çarpma";
            this.btn_çarpma.UseVisualStyleBackColor = true;
            this.btn_çarpma.Click += new System.EventHandler(this.btn_çarpma_Click);
            // 
            // btn_çıkarma
            // 
            this.btn_çıkarma.Location = new System.Drawing.Point(247, 167);
            this.btn_çıkarma.Name = "btn_çıkarma";
            this.btn_çıkarma.Size = new System.Drawing.Size(163, 58);
            this.btn_çıkarma.TabIndex = 2;
            this.btn_çıkarma.Text = "Çıkarma";
            this.btn_çıkarma.UseVisualStyleBackColor = true;
            this.btn_çıkarma.Click += new System.EventHandler(this.btn_çıkarma_Click);
            // 
            // btn_toplama
            // 
            this.btn_toplama.Location = new System.Drawing.Point(97, 167);
            this.btn_toplama.Name = "btn_toplama";
            this.btn_toplama.Size = new System.Drawing.Size(163, 58);
            this.btn_toplama.TabIndex = 1;
            this.btn_toplama.Text = "Toplama";
            this.btn_toplama.UseVisualStyleBackColor = true;
            this.btn_toplama.Click += new System.EventHandler(this.btn_toplama_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(141, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_bölme;
        private System.Windows.Forms.Button btn_çarpma;
        private System.Windows.Forms.Button btn_çıkarma;
        private System.Windows.Forms.Button btn_toplama;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

