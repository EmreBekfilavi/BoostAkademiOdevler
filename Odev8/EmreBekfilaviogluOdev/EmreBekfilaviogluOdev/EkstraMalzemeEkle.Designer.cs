namespace EmreBekfilaviogluOdev
{
    partial class EkstraMalzemeEkle
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
            groupBox1 = new GroupBox();
            btnEkstraMalzemeEkle = new Button();
            numEkMalzemeFiyat = new NumericUpDown();
            txtEkMalzeme = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numEkMalzemeFiyat).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEkstraMalzemeEkle);
            groupBox1.Controls.Add(numEkMalzemeFiyat);
            groupBox1.Controls.Add(txtEkMalzeme);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(58, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(251, 206);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ekstra Malzeme Ekle";
            // 
            // btnEkstraMalzemeEkle
            // 
            btnEkstraMalzemeEkle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnEkstraMalzemeEkle.Location = new Point(77, 150);
            btnEkstraMalzemeEkle.Name = "btnEkstraMalzemeEkle";
            btnEkstraMalzemeEkle.Size = new Size(125, 32);
            btnEkstraMalzemeEkle.TabIndex = 5;
            btnEkstraMalzemeEkle.Text = "Ekle";
            btnEkstraMalzemeEkle.UseVisualStyleBackColor = true;
            btnEkstraMalzemeEkle.Click += btnEkstraMalzemeEkle_Click;
            // 
            // numEkMalzemeFiyat
            // 
            numEkMalzemeFiyat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numEkMalzemeFiyat.Location = new Point(77, 99);
            numEkMalzemeFiyat.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            numEkMalzemeFiyat.Name = "numEkMalzemeFiyat";
            numEkMalzemeFiyat.Size = new Size(128, 29);
            numEkMalzemeFiyat.TabIndex = 3;
            // 
            // txtEkMalzeme
            // 
            txtEkMalzeme.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEkMalzeme.Location = new Point(77, 45);
            txtEkMalzeme.Multiline = true;
            txtEkMalzeme.Name = "txtEkMalzeme";
            txtEkMalzeme.Size = new Size(128, 23);
            txtEkMalzeme.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 101);
            label2.Name = "label2";
            label2.Size = new Size(43, 21);
            label2.TabIndex = 1;
            label2.Text = "Fiyat";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 45);
            label1.Name = "label1";
            label1.Size = new Size(29, 21);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            // 
            // EkstraMalzemeEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EkstraMalzemeEkle";
            Text = "EkstraMalzemeEkle";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numEkMalzemeFiyat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private NumericUpDown numEkMalzemeFiyat;
        private TextBox txtEkMalzeme;
        private Label label2;
        private Label label1;
        private Button btnEkstraMalzemeEkle;
    }
}