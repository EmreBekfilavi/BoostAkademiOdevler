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
    public partial class MenuEkle : Form
    {
        public MenuEkle(List<Menu> menuList)
        {
            InitializeComponent();
            this.menuList = menuList;
        }
        List<Menu> menuList;

        private void btnMenuEkle_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.UrunAdi = txtMenuEkle.Text;
            menu.UrunFiyat = (double)numMenuFiyat.Value;
            menuList.Add(menu);
            
            Temizle();
            
        }

        private void Temizle()
        {
            txtMenuEkle.Clear();
            numMenuFiyat.Value = 0;
        }

    
    }
}
