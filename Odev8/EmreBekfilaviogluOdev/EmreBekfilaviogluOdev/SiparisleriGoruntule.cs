using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmreBekfilaviogluOdev;

namespace EmreBekfilaviogluOdev
{
    public partial class SiparisleriGoruntule : Form
    {
        public SiparisleriGoruntule(List<Menu> siparis,List<EkMalzeme> eklenenEkMalzemeler)
        {
            InitializeComponent();
            this.siparisler = siparis;
            this.eklenenEkMalzemeler = eklenenEkMalzemeler;
        }
        List<Menu> siparisler;
        List<EkMalzeme> eklenenEkMalzemeler;

      
        private void SiparisleriGoruntule_Load(object sender, EventArgs e)
        {
            double ciro = 0;
            int satilanUrunAdedi = 0;
            double ekMalzemeGeliri = 0;
            foreach (Menu menu in siparisler)
            {
                lstGecmisSiparisler.Items.Add(menu.ListeyeYazdir());
                ciro += menu.FiyatHesapla();
            }

            lblToplamSiparis.Text = siparisler.Count.ToString();
            lblCiro.Text = ciro.ToString("C2");
            
            
            foreach(Menu menu in siparisler)
            {
                satilanUrunAdedi += menu.MenuAdedi;
            }
            lblSatilanUrun.Text = (satilanUrunAdedi + eklenenEkMalzemeler.Count).ToString();

            foreach(EkMalzeme ekMalzeme in eklenenEkMalzemeler)
            {
                ekMalzemeGeliri += ekMalzeme.UrunFiyat;
            }
            lblEkMalzemeGeliri.Text = ekMalzemeGeliri.ToString("C2");

        }

 
    }
}
