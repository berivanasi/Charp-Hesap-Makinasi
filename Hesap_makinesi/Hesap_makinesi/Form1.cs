using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_toplama_Click(object sender, EventArgs e)
        {
            FrmTopla frmTopla = new FrmTopla();
            frmTopla.ShowDialog();
        }

        private void btn_çıkarma_Click(object sender, EventArgs e)
        {
            Frmcikar frmcikar = new Frmcikar();
            frmcikar.ShowDialog();
        }

        private void btn_bölme_Click(object sender, EventArgs e)
        {
            Frmbol frmbol = new Frmbol();
            frmbol.ShowDialog();
        }

        private void btn_çarpma_Click(object sender, EventArgs e)
        {
            Frcarp frcarp = new Frcarp();
            frcarp.ShowDialog();
        }
    }
}
