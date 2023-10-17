using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace if_örnekleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            float sayi1, sayi2, ortalama=0;
            sayi1=Convert.ToSingle(txtSayi1.Text);
            sayi2= Convert.ToSingle(txtSayi2.Text);
            if (rbTopla.Checked)
            {
                ortalama = sayi1 + sayi2;
            }
            else if (rbCıkar.Checked)
            {
                ortalama = sayi1 - sayi2;
            }
            else if (rbCarp.Checked) 
            {
                ortalama = sayi1 * sayi2;
            }
            else
            {
                ortalama = sayi1 / sayi2;
            }
            lblSonuc.Text = "SONUÇ: " + ortalama.ToString();
        }
    }
}
