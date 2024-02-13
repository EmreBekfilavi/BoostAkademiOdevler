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
            listBoxKisiler = new ListBox();
            btnKisiEkle = new Button();
            SuspendLayout();
            // 
            // listBoxKisiler
            // 
            listBoxKisiler.FormattingEnabled = true;
            listBoxKisiler.ItemHeight = 15;
            listBoxKisiler.Location = new Point(170, 54);
            listBoxKisiler.Name = "listBoxKisiler";
            listBoxKisiler.Size = new Size(274, 184);
            listBoxKisiler.TabIndex = 0;
            listBoxKisiler.MouseDoubleClick += listBoxKisiler_MouseDoubleClick;
            // 
            // btnKisiEkle
            // 
            btnKisiEkle.Location = new Point(170, 255);
            btnKisiEkle.Name = "btnKisiEkle";
            btnKisiEkle.Size = new Size(274, 43);
            btnKisiEkle.TabIndex = 1;
            btnKisiEkle.Text = "Yeni Müşteri Ekle";
            btnKisiEkle.UseVisualStyleBackColor = true;
            btnKisiEkle.Click += btnKisiEkle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnKisiEkle);
            Controls.Add(listBoxKisiler);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxKisiler;
        private Button btnKisiEkle;
    }
}
