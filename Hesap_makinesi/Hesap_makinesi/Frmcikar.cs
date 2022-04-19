using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hesap_makinesi
{
    public partial class Frmcikar : Form
    {
        public Frmcikar()
        {
            InitializeComponent();
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txt_sayi1.Text);
            int sayi2 = Convert.ToInt32(txt_sayi2.Text);

            lbl_sonuc.Text = (sayi1 - sayi2).ToString();
        }
    }
}
