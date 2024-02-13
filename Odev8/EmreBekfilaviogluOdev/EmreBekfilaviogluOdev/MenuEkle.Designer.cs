namespace EmreBekfilaviogluOdev
{
    partial class MenuEkle
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
            btnMenuEkle = new Button();
            numMenuFiyat = new NumericUpDown();
            txtMenuEkle = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMenuFiyat).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnMenuEkle);
            groupBox1.Controls.Add(numMenuFiyat);
            groupBox1.Controls.Add(txtMenuEkle);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(53, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(270, 220);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Menü Ekle";
            // 
            // btnMenuEkle
            // 
            btnMenuEkle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenuEkle.Location = new Point(94, 141);
            btnMenuEkle.Name = "btnMenuEkle";
            btnMenuEkle.Size = new Size(125, 32);
            btnMenuEkle.TabIndex = 4;
            btnMenuEkle.Text = "Ekle";
            btnMenuEkle.UseVisualStyleBackColor = true;
            btnMenuEkle.Click += btnMenuEkle_Click;
            // 
            // numMenuFiyat
            // 
            numMenuFiyat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numMenuFiyat.Location = new Point(94, 95);
            numMenuFiyat.Maximum = new decimal(new int[] { 250, 0, 0, 0 });
            numMenuFiyat.Name = "numMenuFiyat";
            numMenuFiyat.Size = new Size(125, 29);
            numMenuFiyat.TabIndex = 3;
            // 
            // txtMenuEkle
            // 
            txtMenuEkle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMenuEkle.Location = new Point(94, 48);
            txtMenuEkle.Multiline = true;
            txtMenuEkle.Name = "txtMenuEkle";
            txtMenuEkle.Size = new Size(125, 23);
            txtMenuEkle.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(24, 97);
            label2.Name = "label2";
            label2.Size = new Size(43, 21);
            label2.TabIndex = 1;
            label2.Text = "Fiyat";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(24, 48);
            label1.Name = "label1";
            label1.Size = new Size(29, 21);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            // 
            // MenuEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuEkle";
            Text = "MenuEkle";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMenuFiyat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private NumericUpDown numMenuFiyat;
        private TextBox txtMenuEkle;
        private Label label2;
        private Button btnMenuEkle;
    }
}