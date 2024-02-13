using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EmreBekfilaviogluOdev
{
    public partial class SiparisOlustur : Form
    {
        public SiparisOlustur(List<Menu> menuler, List<Menu> siparis, List<EkMalzeme> ekMalzemeList, List<EkMalzeme> eklenenEkMalzemeler)
        {
            InitializeComponent();
            this.menuList = menuler;
            this.siparisler = siparis;
            this.ekMalzemeList = ekMalzemeList;
            this.eklenenEkMalzemeler = eklenenEkMalzemeler;
        }
        List<Menu> menuList;
        List<Menu> siparisler;
        List<EkMalzeme> ekMalzemeList;
        List<EkMalzeme> eklenenEkMalzemeler;

        List<Menu> askidaSiparisler = new List<Menu>();
        List<EkMalzeme> askidaEkMalzemeler = new List<EkMalzeme>();
        

        double labelFiyat = 0;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();

            Menu menuAdi = (Menu)cbMenu.SelectedItem;
            menu.UrunAdi = menuAdi.ToString();
            menu.MenuAdedi = int.Parse(numAdet.Value.ToString());

            Menu menuFiyati = (Menu)cbMenu.SelectedItem;
            menu.UrunFiyat = menuFiyati.UrunFiyat;

            menu.BoySecimi = BoySecimiGonder();
            menu.EkMalzemeFiyati = EkMalzemeFiyatiGonder();
            menu.SeciliEkMalzemeler = SeciliEkMalzemeleriGonder();

            labelFiyat += menu.FiyatHesapla();
            lblFiyat.Text = labelFiyat.ToString("C2");

            lstSiparisler.Items.Add(menu.ListeyeYazdir());
            askidaSiparisler.Add(menu);
            
            for(int i =0; i<menu.MenuAdedi; i++) //Menü Adedi Kadar ve Seçilen Ek Malzemeyi Doldur
            {
                AskidaEkMalzemeleriDoldur();
            }

            Temizle();
                       
            
        }

        public void Temizle()
        {
            foreach(Control control in this.Controls)
            {
                if(control is FlowLayoutPanel)
                {
                    FlowLayoutPanel flowLayoutPanel = (FlowLayoutPanel)control;
                    foreach(CheckBox checkBox in flowLayoutPanel.Controls)
                    {
                        checkBox.Checked = false;
                    }
                }
                else if(control is NumericUpDown)
                {
                    NumericUpDown numericUpDown = (NumericUpDown)control;
                    numericUpDown.Value = 0;
                }
                else if(control is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)control;
                    radioButton.Checked = false;
                }
                
            }
        }

        public void AskidaEkMalzemeleriDoldur()
        {
            foreach(CheckBox chkEkMalzeme in flowLayoutPanel1.Controls)
            {
                if (chkEkMalzeme.Checked)
                {
                    EkMalzeme ek = chkEkMalzeme.Tag as EkMalzeme;
                    askidaEkMalzemeler.Add(ek);
                }
            }
        }

        public string SeciliEkMalzemeleriGonder()
        {
            string seciliEkMalzemeler = string.Empty;
            foreach(CheckBox chkEkMalzeme in flowLayoutPanel1.Controls)
            {
                if (chkEkMalzeme.Checked)
                {
                    EkMalzeme ek = chkEkMalzeme.Tag as EkMalzeme;
                    seciliEkMalzemeler += ek.UrunAdi + ",";
                }
            }
            return seciliEkMalzemeler;
        }
        public double EkMalzemeFiyatiGonder()
        {
            double ekMalzemeFiyat = 0;
            foreach(CheckBox chkEkMalzeme in flowLayoutPanel1.Controls)
            {
                if (chkEkMalzeme.Checked)
                {
                    EkMalzeme ek = chkEkMalzeme.Tag as EkMalzeme;
                    ekMalzemeFiyat += ek.UrunFiyat;
                }
              
            }
            return ekMalzemeFiyat;
        }

        public double BoySecimiGonder()
        {
            double boySecimi;
            if (rdoBuyuk.Checked)
            {
                boySecimi = 1.2;
                return boySecimi;
            }
            else if (rdoOrta.Checked)
            {
                boySecimi = 1.1;
                return boySecimi;
            }
            else
            {
                boySecimi = 1;
                return boySecimi;
            }
        }

        private void SiparisOlustur_Load(object sender, EventArgs e)
        {
           
            foreach(EkMalzeme ekMalzeme in ekMalzemeList)
            {
                CheckBox chkEkMalzeme = new CheckBox();
                chkEkMalzeme.Text = ekMalzeme.UrunAdi;
                chkEkMalzeme.Tag = ekMalzeme;
                flowLayoutPanel1.Controls.Add(chkEkMalzeme);
            }

            foreach (Menu menu in menuList)
            {
                cbMenu.Items.Add(menu);
            }
        }

        private void btnSiparisOnayla_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Siparişi Onaylıyor Musunuz?", "Sipariş Onay", MessageBoxButtons.OKCancel);

            if(result == DialogResult.OK)
            {
                OnayliEkMalzemeleriDoldur();
                OnayliSiparisleriDoldur();
                HerSeyiTemizle();
                lblFiyat.Text = "0";
                labelFiyat = 0;
                
            }
        }

        private void OnayliSiparisleriDoldur()
        {
            foreach(Menu menu in askidaSiparisler)
            {
                siparisler.Add(menu);
            }
            askidaSiparisler.Clear();
        }

        private void OnayliEkMalzemeleriDoldur()
        {
            foreach(EkMalzeme ekMalzeme in askidaEkMalzemeler)
            {
                eklenenEkMalzemeler.Add(ekMalzeme);
            }
            askidaEkMalzemeler.Clear();
        }

        private void HerSeyiTemizle()
        {
            foreach(Control control in this.Controls)
            {
                if(control is ListBox)
                {
                    ListBox listBox = (ListBox)control;
                    listBox.Items.Clear();
                }
                else if(control is NumericUpDown)
                {
                    NumericUpDown numericUpDown = (NumericUpDown)control;
                    numericUpDown.Value = 0;
                }
            }
        }
    }
}
