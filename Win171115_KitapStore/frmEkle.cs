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
    public partial class frmEkle : Form
    {
        public frmEkle()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            using (var db = new KitapContext())
            {
                var ktp = new Kitap();

                ktp.Ad = txtKitapAdi.Text;
                ktp.Fiyat = decimal.Parse(txtFiyat.Text);
                ktp.Tarih = DateTime.Now;
                ktp.KategoriID = (int)cmbKategoriler.SelectedValue;

                bool yazarVarMi = db.Yazarlar.Where(y => y.Ad == txtYzrAdi.Text && y.Soyad == txtYzrSoyadi.Text).ToList().Count > 0;



                if (yazarVarMi)
                {
                    ktp.YazarID = db.Yazarlar.Where(y => y.Ad == txtYzrAdi.Text && y.Soyad == txtYzrSoyadi.Text).FirstOrDefault().ID;
                }
                else
                {
                    var yzr = new Yazar();

                    yzr.Ad = txtYzrAdi.Text;
                    yzr.Soyad = txtYzrSoyadi.Text;

                    db.Yazarlar.Add(yzr);
                    ktp.YazarID = yzr.ID;

                }

                bool yEviVarMi = db.YayinEvleri.Where(y => y.Ad == txtYayinEvi.Text).ToList().Count > 0;


                if (yEviVarMi)
                {
                    ktp.YayinEviID = db.YayinEvleri.Where(y => y.Ad == txtYayinEvi.Text).FirstOrDefault().ID;
                }
                else
                {
                    var yEv = new YayinEvi();
                    yEv.Ad = txtYayinEvi.Text;

                    db.YayinEvleri.Add(yEv);

                    ktp.YayinEviID = yEv.ID;

                }


                db.Kitaplar.Add(ktp);
                db.SaveChanges();


                Temizle.temizle(this);


            }
        }

        private void frmEkle_Load(object sender, EventArgs e)
        {
            using (var db = new KitapContext())
            {
                cmbKategoriler.DataSource = db.Kategoriler.ToList();
                cmbKategoriler.DisplayMember = "Ad";
                cmbKategoriler.ValueMember = "ID";

            }
        }
    }
}
