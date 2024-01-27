namespace EmreBekfilaviogluOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtSifre.Text.Length < 6 || !HarfVarMi(txtSifre.Text))
            {
                lblSifreDurumu.Text = "Düþük";
                lblSifreDurumu.ForeColor = Color.Red;
            }
            else if (SayiVarMi(txtSifre.Text) && OzelKarakterVarMi(txtSifre.Text))
            {
                lblSifreDurumu.Text = "Yüksek";
                lblSifreDurumu.ForeColor = Color.Green;
            }
            else if (SayiVarMi(txtSifre.Text) || OzelKarakterVarMi(txtSifre.Text))
            {
                lblSifreDurumu.Text = "Orta";
                lblSifreDurumu.ForeColor = Color.Blue;
            }
        }

        static bool SayiVarMi(string text)
        {
            foreach (char chr in text)
            {
                if (Char.IsDigit(chr))
                {
                    return true;
                }

            }
            return false;

        }

        static bool OzelKarakterVarMi(string text)
        {
            foreach (char chr in text)
            {
                if (Char.IsSymbol(chr))
                {
                    return true;
                }

                if (Char.IsPunctuation(chr))
                {
                    return true;
                }

                if (Char.IsSeparator(chr))
                {
                    return true;
                }
            }

            return false;
        }

        static bool HarfVarMi(string text)
        {
            foreach(char chr in text)
            {
                if (Char.IsLetter(chr))
                {
                    return true;
                }
            }

            return false;
        }

    }
}
