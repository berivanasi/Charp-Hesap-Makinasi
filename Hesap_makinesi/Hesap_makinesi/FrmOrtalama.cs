using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hesap_makinesi
{
    public partial class FrmOrtalama : Form
    {
        public FrmOrtalama()
        {
            InitializeComponent();
        }

        public double ortalamahesapla(double not1,double not2)
        {
            double sonuc = (not1 + not2) / 2;
            return sonuc;

        }

        private void btn_hesap_Click(object sender, EventArgs e)
        {
            double yazili1 = Convert.ToDouble(txt_1sinav.Text);
            double yazili2 = Convert.ToDouble(txt_2sinav.Text);
            double ortalama = ortalamahesapla(yazili1, yazili2);
            lbl_ortala.Text = "Ortalama :" + ortalama.ToString();
        }
    }
}
