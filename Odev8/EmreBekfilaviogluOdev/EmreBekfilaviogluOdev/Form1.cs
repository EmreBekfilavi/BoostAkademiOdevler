using System.Collections.Generic;
using EmreBekfilaviogluOdev;

namespace EmreBekfilaviogluOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Menu> menuList = new List<Menu>();
        List<Menu> siparisler = new List<Menu>();
        List<EkMalzeme> ekMalzemeList = new List<EkMalzeme>();
        List<EkMalzeme> eklenenEkMalzemeler = new List<EkMalzeme>();

        private void sipariþOluþturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseForms();

            SiparisOlustur siparisOlustur = new SiparisOlustur(menuList,siparisler,ekMalzemeList,eklenenEkMalzemeler);
            siparisOlustur.MdiParent = this;

            siparisOlustur.Dock = DockStyle.Fill;
            this.Width = siparisOlustur.Width + 100;
            this.Height = siparisOlustur.Height + 100;

            siparisOlustur.Show();

        }

        private void sipariþleriGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseForms();

            SiparisleriGoruntule siparisleriGoruntule = new SiparisleriGoruntule(siparisler,eklenenEkMalzemeler);
            siparisleriGoruntule.MdiParent = this;

            siparisleriGoruntule.Dock = DockStyle.Fill;
            this.Width = siparisleriGoruntule.Width;
            this.Height = siparisleriGoruntule.Height + 100;

            siparisleriGoruntule.Show();
        }

        private void menuEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseForms();

            MenuEkle menuEkle = new MenuEkle(menuList);
            menuEkle.MdiParent = this;

            menuEkle.Dock = DockStyle.Fill;
            this.Width = menuEkle.Width;
            this.Height = menuEkle.Height;

            menuEkle.Show();
        }

        private void ekMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseForms();

            EkstraMalzemeEkle ekstraMalzemeEkle = new EkstraMalzemeEkle(ekMalzemeList);
            ekstraMalzemeEkle.MdiParent = this;

            ekstraMalzemeEkle.Dock = DockStyle.Fill;
            this.Width = ekstraMalzemeEkle.Width;
            this.Height = ekstraMalzemeEkle.Height;

            ekstraMalzemeEkle.Show();
        }

        private void CloseForms()
        {
            Form[] forms = this.MdiChildren;

            foreach (Form form in forms)
            {
                form.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SiparisOlustur siparisOlustur = new SiparisOlustur(menuList, siparisler, ekMalzemeList, eklenenEkMalzemeler);
            siparisOlustur.MdiParent = this;
            
            siparisOlustur.Dock = DockStyle.Fill;
            this.Width = siparisOlustur.Width + 100;
            this.Height = siparisOlustur.Height + 100;

            Menu menu1 = new Menu();
            menu1.UrunAdi = "Big King Menü";
            menu1.UrunFiyat = 120;
            menuList.Add(menu1);

            Menu menu2 = new Menu();
            menu2.UrunAdi = "King Chicken Menü";
            menu2.UrunFiyat = 100;
            menuList.Add(menu2);

            EkMalzeme ekMalzeme1 = new EkMalzeme();
            ekMalzeme1.UrunAdi = "Ketçap";
            ekMalzeme1.UrunFiyat = 5;
            ekMalzemeList.Add(ekMalzeme1);

            EkMalzeme ekMalzeme2 = new EkMalzeme();
            ekMalzeme2.UrunAdi = "Mayonez";
            ekMalzeme2.UrunFiyat = 5;
            ekMalzemeList.Add(ekMalzeme2);


            siparisOlustur.Show();
        }
    }
}
