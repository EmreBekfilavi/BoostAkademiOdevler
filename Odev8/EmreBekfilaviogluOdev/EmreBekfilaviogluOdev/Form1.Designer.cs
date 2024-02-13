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
            menuStrip1 = new MenuStrip();
            siparişYönetimiToolStripMenuItem = new ToolStripMenuItem();
            siparişOluşturToolStripMenuItem = new ToolStripMenuItem();
            siparişleriGörüntüleToolStripMenuItem = new ToolStripMenuItem();
            ürünYönetimiToolStripMenuItem = new ToolStripMenuItem();
            menuEkleToolStripMenuItem = new ToolStripMenuItem();
            ekMalzemeEkleToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { siparişYönetimiToolStripMenuItem, ürünYönetimiToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // siparişYönetimiToolStripMenuItem
            // 
            siparişYönetimiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { siparişOluşturToolStripMenuItem, siparişleriGörüntüleToolStripMenuItem });
            siparişYönetimiToolStripMenuItem.Name = "siparişYönetimiToolStripMenuItem";
            siparişYönetimiToolStripMenuItem.Size = new Size(103, 20);
            siparişYönetimiToolStripMenuItem.Text = "Sipariş Yönetimi";
            // 
            // siparişOluşturToolStripMenuItem
            // 
            siparişOluşturToolStripMenuItem.Name = "siparişOluşturToolStripMenuItem";
            siparişOluşturToolStripMenuItem.Size = new Size(180, 22);
            siparişOluşturToolStripMenuItem.Text = "Sipariş Oluştur";
            siparişOluşturToolStripMenuItem.Click += siparişOluşturToolStripMenuItem_Click;
            // 
            // siparişleriGörüntüleToolStripMenuItem
            // 
            siparişleriGörüntüleToolStripMenuItem.Name = "siparişleriGörüntüleToolStripMenuItem";
            siparişleriGörüntüleToolStripMenuItem.Size = new Size(180, 22);
            siparişleriGörüntüleToolStripMenuItem.Text = "Siparişleri Görüntüle";
            siparişleriGörüntüleToolStripMenuItem.Click += siparişleriGörüntüleToolStripMenuItem_Click;
            // 
            // ürünYönetimiToolStripMenuItem
            // 
            ürünYönetimiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuEkleToolStripMenuItem, ekMalzemeEkleToolStripMenuItem });
            ürünYönetimiToolStripMenuItem.Name = "ürünYönetimiToolStripMenuItem";
            ürünYönetimiToolStripMenuItem.Size = new Size(95, 20);
            ürünYönetimiToolStripMenuItem.Text = "Ürün Yönetimi";
            // 
            // menuEkleToolStripMenuItem
            // 
            menuEkleToolStripMenuItem.Name = "menuEkleToolStripMenuItem";
            menuEkleToolStripMenuItem.Size = new Size(180, 22);
            menuEkleToolStripMenuItem.Text = "Menu Ekle";
            menuEkleToolStripMenuItem.Click += menuEkleToolStripMenuItem_Click;
            // 
            // ekMalzemeEkleToolStripMenuItem
            // 
            ekMalzemeEkleToolStripMenuItem.Name = "ekMalzemeEkleToolStripMenuItem";
            ekMalzemeEkleToolStripMenuItem.Size = new Size(180, 22);
            ekMalzemeEkleToolStripMenuItem.Text = "Ek Malzeme Ekle";
            ekMalzemeEkleToolStripMenuItem.Click += ekMalzemeEkleToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem siparişYönetimiToolStripMenuItem;
        private ToolStripMenuItem siparişOluşturToolStripMenuItem;
        private ToolStripMenuItem siparişleriGörüntüleToolStripMenuItem;
        private ToolStripMenuItem ürünYönetimiToolStripMenuItem;
        private ToolStripMenuItem menuEkleToolStripMenuItem;
        private ToolStripMenuItem ekMalzemeEkleToolStripMenuItem;
    }
}
