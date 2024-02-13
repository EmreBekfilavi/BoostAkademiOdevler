namespace EmreBekfilaviogluOdev
{
    partial class SiparisOlustur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisOlustur));
            pictureBox1 = new PictureBox();
            cbMenu = new ComboBox();
            rdoKucuk = new RadioButton();
            rdoOrta = new RadioButton();
            rdoBuyuk = new RadioButton();
            label2 = new Label();
            numAdet = new NumericUpDown();
            btnEkle = new Button();
            lstSiparisler = new ListBox();
            btnSiparisOnayla = new Button();
            label1 = new Label();
            lblFiyat = new Label();
            label3 = new Label();
            label4 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAdet).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(19, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 126);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // cbMenu
            // 
            cbMenu.FormattingEnabled = true;
            cbMenu.Location = new Point(19, 144);
            cbMenu.Name = "cbMenu";
            cbMenu.Size = new Size(218, 23);
            cbMenu.TabIndex = 1;
            // 
            // rdoKucuk
            // 
            rdoKucuk.AutoSize = true;
            rdoKucuk.Location = new Point(43, 327);
            rdoKucuk.Name = "rdoKucuk";
            rdoKucuk.Size = new Size(58, 19);
            rdoKucuk.TabIndex = 3;
            rdoKucuk.TabStop = true;
            rdoKucuk.Text = "Küçük";
            rdoKucuk.UseVisualStyleBackColor = true;
            // 
            // rdoOrta
            // 
            rdoOrta.AutoSize = true;
            rdoOrta.Location = new Point(107, 327);
            rdoOrta.Name = "rdoOrta";
            rdoOrta.Size = new Size(48, 19);
            rdoOrta.TabIndex = 4;
            rdoOrta.TabStop = true;
            rdoOrta.Text = "Orta";
            rdoOrta.UseVisualStyleBackColor = true;
            // 
            // rdoBuyuk
            // 
            rdoBuyuk.AutoSize = true;
            rdoBuyuk.Location = new Point(161, 327);
            rdoBuyuk.Name = "rdoBuyuk";
            rdoBuyuk.Size = new Size(58, 19);
            rdoBuyuk.TabIndex = 5;
            rdoBuyuk.TabStop = true;
            rdoBuyuk.Text = "Büyük";
            rdoBuyuk.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 364);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 7;
            label2.Text = "Adet";
            // 
            // numAdet
            // 
            numAdet.Location = new Point(87, 362);
            numAdet.Name = "numAdet";
            numAdet.Size = new Size(150, 23);
            numAdet.TabIndex = 8;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(43, 397);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(194, 41);
            btnEkle.TabIndex = 9;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // lstSiparisler
            // 
            lstSiparisler.FormattingEnabled = true;
            lstSiparisler.ItemHeight = 15;
            lstSiparisler.Location = new Point(293, 12);
            lstSiparisler.Name = "lstSiparisler";
            lstSiparisler.Size = new Size(428, 334);
            lstSiparisler.TabIndex = 10;
            // 
            // btnSiparisOnayla
            // 
            btnSiparisOnayla.Location = new Point(557, 375);
            btnSiparisOnayla.Name = "btnSiparisOnayla";
            btnSiparisOnayla.Size = new Size(164, 55);
            btnSiparisOnayla.TabIndex = 11;
            btnSiparisOnayla.Text = "Siparişi Onayla";
            btnSiparisOnayla.UseVisualStyleBackColor = true;
            btnSiparisOnayla.Click += btnSiparisOnayla_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(293, 379);
            label1.Name = "label1";
            label1.Size = new Size(76, 28);
            label1.TabIndex = 12;
            label1.Text = "Toplam";
            // 
            // lblFiyat
            // 
            lblFiyat.AutoSize = true;
            lblFiyat.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblFiyat.ForeColor = Color.Red;
            lblFiyat.Location = new Point(375, 379);
            lblFiyat.Name = "lblFiyat";
            lblFiyat.Size = new Size(161, 28);
            lblFiyat.TabIndex = 13;
            lblFiyat.Text = "Ödenecek Tutar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 309);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 15;
            label3.Text = "Boyu Seçiniz";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 180);
            label4.Name = "label4";
            label4.Size = new Size(128, 15);
            label4.TabIndex = 16;
            label4.Text = "Ekstra Malzeme Seçiniz";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(19, 206);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(218, 100);
            flowLayoutPanel1.TabIndex = 17;
            // 
            // SiparisOlustur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblFiyat);
            Controls.Add(label1);
            Controls.Add(btnSiparisOnayla);
            Controls.Add(lstSiparisler);
            Controls.Add(btnEkle);
            Controls.Add(numAdet);
            Controls.Add(label2);
            Controls.Add(rdoBuyuk);
            Controls.Add(rdoOrta);
            Controls.Add(rdoKucuk);
            Controls.Add(cbMenu);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SiparisOlustur";
            Text = "SiparisOlustur";
            Load += SiparisOlustur_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAdet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ComboBox cbMenu;
        private RadioButton rdoKucuk;
        private RadioButton rdoOrta;
        private RadioButton rdoBuyuk;
        private Label label2;
        private NumericUpDown numAdet;
        private Button btnEkle;
        private ListBox lstSiparisler;
        private Button btnSiparisOnayla;
        private Label label1;
        private Label lblFiyat;
        private Label label3;
        private Label label4;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}