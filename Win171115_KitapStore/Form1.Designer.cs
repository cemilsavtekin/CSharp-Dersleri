namespace Win171115_KitapStore
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminPaneliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.msDuzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.msCikisYap = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsGirisYap = new System.Windows.Forms.ToolStripButton();
            this.tsTxtSifre = new System.Windows.Forms.ToolStripTextBox();
            this.tsLblSifre = new System.Windows.Forms.ToolStripLabel();
            this.tsTxtKulAdi = new System.Windows.Forms.ToolStripTextBox();
            this.tsLblKulAdi = new System.Windows.Forms.ToolStripLabel();
            this.tsCikisYap = new System.Windows.Forms.ToolStripButton();
            this.tsLblKullanici = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgKitaplar = new System.Windows.Forms.DataGridView();
            this.lstListe = new System.Windows.Forms.ListBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.msYayincilar = new System.Windows.Forms.ToolStripMenuItem();
            this.msYazarlar = new System.Windows.Forms.ToolStripMenuItem();
            this.msKategoriler = new System.Windows.Forms.ToolStripMenuItem();
            this.msSonCikanlar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgKitaplar)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminPaneliToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(808, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminPaneliToolStripMenuItem
            // 
            this.adminPaneliToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msEkle,
            this.msDuzenle,
            this.msCikisYap});
            this.adminPaneliToolStripMenuItem.Name = "adminPaneliToolStripMenuItem";
            this.adminPaneliToolStripMenuItem.Size = new System.Drawing.Size(138, 32);
            this.adminPaneliToolStripMenuItem.Text = "Admin Paneli";
            // 
            // msEkle
            // 
            this.msEkle.Name = "msEkle";
            this.msEkle.Size = new System.Drawing.Size(166, 32);
            this.msEkle.Text = "Ekle";
            // 
            // msDuzenle
            // 
            this.msDuzenle.Name = "msDuzenle";
            this.msDuzenle.Size = new System.Drawing.Size(166, 32);
            this.msDuzenle.Text = "Düzenle";
            // 
            // msCikisYap
            // 
            this.msCikisYap.Name = "msCikisYap";
            this.msCikisYap.Size = new System.Drawing.Size(166, 32);
            this.msCikisYap.Text = "Çıkış Yap";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsGirisYap,
            this.tsTxtSifre,
            this.tsLblSifre,
            this.tsTxtKulAdi,
            this.tsLblKulAdi,
            this.tsCikisYap,
            this.tsLblKullanici});
            this.toolStrip1.Location = new System.Drawing.Point(0, 36);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(808, 35);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsGirisYap
            // 
            this.tsGirisYap.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsGirisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tsGirisYap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsGirisYap.Image = ((System.Drawing.Image)(resources.GetObject("tsGirisYap.Image")));
            this.tsGirisYap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsGirisYap.Name = "tsGirisYap";
            this.tsGirisYap.Size = new System.Drawing.Size(91, 32);
            this.tsGirisYap.Text = "Giriş Yap";
            // 
            // tsTxtSifre
            // 
            this.tsTxtSifre.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsTxtSifre.Name = "tsTxtSifre";
            this.tsTxtSifre.Size = new System.Drawing.Size(100, 35);
            // 
            // tsLblSifre
            // 
            this.tsLblSifre.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsLblSifre.Name = "tsLblSifre";
            this.tsLblSifre.Size = new System.Drawing.Size(51, 32);
            this.tsLblSifre.Text = "Şifre";
            // 
            // tsTxtKulAdi
            // 
            this.tsTxtKulAdi.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsTxtKulAdi.Name = "tsTxtKulAdi";
            this.tsTxtKulAdi.Size = new System.Drawing.Size(100, 35);
            // 
            // tsLblKulAdi
            // 
            this.tsLblKulAdi.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsLblKulAdi.Name = "tsLblKulAdi";
            this.tsLblKulAdi.Size = new System.Drawing.Size(120, 32);
            this.tsLblKulAdi.Text = "Kullanıcı Adı";
            // 
            // tsCikisYap
            // 
            this.tsCikisYap.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsCikisYap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsCikisYap.Image = ((System.Drawing.Image)(resources.GetObject("tsCikisYap.Image")));
            this.tsCikisYap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsCikisYap.Name = "tsCikisYap";
            this.tsCikisYap.Size = new System.Drawing.Size(92, 32);
            this.tsCikisYap.Text = "Çıkış Yap";
            // 
            // tsLblKullanici
            // 
            this.tsLblKullanici.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsLblKullanici.Name = "tsLblKullanici";
            this.tsLblKullanici.Size = new System.Drawing.Size(85, 32);
            this.tsLblKullanici.Text = "Kullanıcı";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgKitaplar);
            this.panel1.Controls.Add(this.lstListe);
            this.panel1.Controls.Add(this.menuStrip2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 561);
            this.panel1.TabIndex = 2;
            // 
            // dgKitaplar
            // 
            this.dgKitaplar.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKitaplar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgKitaplar.Location = new System.Drawing.Point(243, 36);
            this.dgKitaplar.Name = "dgKitaplar";
            this.dgKitaplar.RowTemplate.Height = 24;
            this.dgKitaplar.Size = new System.Drawing.Size(565, 525);
            this.dgKitaplar.TabIndex = 2;
            // 
            // lstListe
            // 
            this.lstListe.BackColor = System.Drawing.SystemColors.Control;
            this.lstListe.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstListe.FormattingEnabled = true;
            this.lstListe.ItemHeight = 25;
            this.lstListe.Location = new System.Drawing.Point(0, 36);
            this.lstListe.Name = "lstListe";
            this.lstListe.Size = new System.Drawing.Size(243, 525);
            this.lstListe.TabIndex = 1;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msYayincilar,
            this.msYazarlar,
            this.msKategoriler,
            this.msSonCikanlar});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(808, 36);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // msYayincilar
            // 
            this.msYayincilar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.msYayincilar.Name = "msYayincilar";
            this.msYayincilar.Size = new System.Drawing.Size(105, 32);
            this.msYayincilar.Text = "Yayıncılar";
            // 
            // msYazarlar
            // 
            this.msYazarlar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.msYazarlar.Name = "msYazarlar";
            this.msYazarlar.Size = new System.Drawing.Size(91, 32);
            this.msYazarlar.Text = "Yazarlar";
            // 
            // msKategoriler
            // 
            this.msKategoriler.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.msKategoriler.Name = "msKategoriler";
            this.msKategoriler.Size = new System.Drawing.Size(121, 32);
            this.msKategoriler.Text = "Kategoriler";
            // 
            // msSonCikanlar
            // 
            this.msSonCikanlar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.msSonCikanlar.Name = "msSonCikanlar";
            this.msSonCikanlar.Size = new System.Drawing.Size(133, 32);
            this.msSonCikanlar.Text = "Son Çıkanlar";
            this.msSonCikanlar.Click += new System.EventHandler(this.msSonCikanlar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 632);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgKitaplar)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminPaneliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msEkle;
        private System.Windows.Forms.ToolStripMenuItem msDuzenle;
        private System.Windows.Forms.ToolStripMenuItem msCikisYap;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsGirisYap;
        private System.Windows.Forms.ToolStripTextBox tsTxtSifre;
        private System.Windows.Forms.ToolStripLabel tsLblSifre;
        private System.Windows.Forms.ToolStripTextBox tsTxtKulAdi;
        private System.Windows.Forms.ToolStripLabel tsLblKulAdi;
        private System.Windows.Forms.ToolStripButton tsCikisYap;
        private System.Windows.Forms.ToolStripLabel tsLblKullanici;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgKitaplar;
        private System.Windows.Forms.ListBox lstListe;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem msYayincilar;
        private System.Windows.Forms.ToolStripMenuItem msYazarlar;
        private System.Windows.Forms.ToolStripMenuItem msKategoriler;
        private System.Windows.Forms.ToolStripMenuItem msSonCikanlar;
    }
}

