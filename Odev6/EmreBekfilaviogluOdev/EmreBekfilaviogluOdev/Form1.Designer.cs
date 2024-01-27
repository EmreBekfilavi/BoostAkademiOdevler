namespace EmreBekfilaviogluOdev
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtSifre = new TextBox();
            lblSifreDurumu = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(210, 28);
            label1.Name = "label1";
            label1.Size = new Size(232, 34);
            label1.TabIndex = 0;
            label1.Text = "Şifre Kontrol Programı";
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(155, 92);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(344, 23);
            txtSifre.TabIndex = 1;
            txtSifre.TextChanged += textBox1_TextChanged;
            // 
            // lblSifreDurumu
            // 
            lblSifreDurumu.AutoSize = true;
            lblSifreDurumu.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblSifreDurumu.Location = new Point(155, 141);
            lblSifreDurumu.Name = "lblSifreDurumu";
            lblSifreDurumu.Size = new Size(85, 20);
            lblSifreDurumu.TabIndex = 2;
            lblSifreDurumu.Text = "Şifre Giriniz";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSifreDurumu);
            Controls.Add(txtSifre);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSifre;
        private Label lblSifreDurumu;
    }
}
