using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmreBekfilaviogluOdev
{
    public partial class Form2 : Form
    {
        public Form2(List<Kisi> kisis)
        {
            InitializeComponent();
            Kisiler = kisis;
        }

        List<Kisi> Kisiler;

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kisi kisi = new Kisi();
            kisi.AdSoyad = txtAdSoyad.Text;
            kisi.Telefon = txtTelefon.Text;
            kisi.Yas = int.Parse(txtYas.Text);
            kisi.Adres = txtAdres.Text;

            Kisiler.Add(kisi);

            txtAdSoyad.Clear();
            txtTelefon.Clear();
            txtYas.Clear();
            txtAdres.Clear();
        }

        private void btnListeyeDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
