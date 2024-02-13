namespace EmreBekfilaviogluOdev
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtAdSoyad = new TextBox();
            txtTelefon = new TextBox();
            txtYas = new TextBox();
            txtAdres = new TextBox();
            btnKaydet = new Button();
            btnListeyeDon = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 41);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 80);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "Telefon";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 120);
            label3.Name = "label3";
            label3.Size = new Size(24, 15);
            label3.TabIndex = 2;
            label3.Text = "Yas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(85, 159);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 3;
            label4.Text = "Adres";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(149, 38);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(156, 23);
            txtAdSoyad.TabIndex = 4;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(149, 77);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(156, 23);
            txtTelefon.TabIndex = 5;
            // 
            // txtYas
            // 
            txtYas.Location = new Point(149, 117);
            txtYas.Name = "txtYas";
            txtYas.Size = new Size(156, 23);
            txtYas.TabIndex = 6;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(149, 156);
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(156, 83);
            txtAdres.TabIndex = 7;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(149, 258);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(156, 38);
            btnKaydet.TabIndex = 8;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnListeyeDon
            // 
            btnListeyeDon.Location = new Point(149, 302);
            btnListeyeDon.Name = "btnListeyeDon";
            btnListeyeDon.Size = new Size(156, 38);
            btnListeyeDon.TabIndex = 9;
            btnListeyeDon.Text = "Listeye Dön";
            btnListeyeDon.UseVisualStyleBackColor = true;
            btnListeyeDon.Click += btnListeyeDon_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnListeyeDon);
            Controls.Add(btnKaydet);
            Controls.Add(txtAdres);
            Controls.Add(txtYas);
            Controls.Add(txtTelefon);
            Controls.Add(txtAdSoyad);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtAdSoyad;
        private TextBox txtTelefon;
        private TextBox txtYas;
        private TextBox txtAdres;
        private Button btnKaydet;
        private Button btnListeyeDon;
    }
}