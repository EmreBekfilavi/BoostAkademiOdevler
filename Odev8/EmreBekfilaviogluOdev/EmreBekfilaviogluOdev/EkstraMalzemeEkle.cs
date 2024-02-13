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
    public partial class EkstraMalzemeEkle : Form
    {
        public EkstraMalzemeEkle(List<EkMalzeme> ekMalzemeList)
        {
            InitializeComponent();
            this.ekMalzemeList = ekMalzemeList;
        }
        List<EkMalzeme> ekMalzemeList;

        private void btnEkstraMalzemeEkle_Click(object sender, EventArgs e)
        {
            EkMalzeme ekMalzeme = new EkMalzeme();
            ekMalzeme.UrunAdi = txtEkMalzeme.Text;
            ekMalzeme.UrunFiyat = (double)numEkMalzemeFiyat.Value;
            ekMalzemeList.Add(ekMalzeme);

            Temizle();
        }

        private void Temizle()
        {
            txtEkMalzeme.Clear();
            numEkMalzemeFiyat.Value = 0;
        }
    }
}
