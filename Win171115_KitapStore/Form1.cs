using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Win171115_KitapStore.Models;

namespace Win171115_KitapStore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        KitapContext db = new KitapContext();

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void msSonCikanlar_Click(object sender, EventArgs e)
        {
            DateTime trh = DateTime.Now.AddMonths(-1);

            var sonuc = (from k in db.Kitaplar
                         where k.Tarih >= trh
                         select new
                         {
                             Kitap=k.Ad,
                             Yazar=k.yazar.Ad+" "+k.yazar.Soyad,
                             Kategori=k.kategori.Ad,
                             YayinEvi=k.yayinEvi.Ad,
                             k.Fiyat
                         }
                       ).ToList();

            dgKitaplar.DataSource = sonuc;
        }
    }
}
