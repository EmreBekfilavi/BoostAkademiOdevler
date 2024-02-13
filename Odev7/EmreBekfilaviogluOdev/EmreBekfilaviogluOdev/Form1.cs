namespace EmreBekfilaviogluOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Kisi> kisiler = new List<Kisi>();
        private void btnKisiEkle_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(kisiler);
            form2.ShowDialog();

            listBoxKisiler.Items.Clear();
            foreach (Kisi kisi in kisiler)
            {
                listBoxKisiler.Items.Add(kisi);
            }

            // listBoxKisiler.DataSource = kisiler; NEDEN ÇALIÞMIYOR!!!!!!

        }

        private void listBoxKisiler_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Kisi secilenKisi = (Kisi)listBoxKisiler.SelectedItem;
            MessageBox.Show(secilenKisi.BilgileriYazdir(), "Kiþi Bilgileri", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
