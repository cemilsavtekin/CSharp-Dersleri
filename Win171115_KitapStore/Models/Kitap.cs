using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Win171115_KitapStore.Models
{
    [Table("Kitaplar")]
    public class Kitap
    {

        public int Id { get; set; }
        public string Ad { get; set; }
        public DateTime? Tarih { get; set; }

        [Column(TypeName = "Money")]
        public decimal? Fiyat { get; set; }



        public int KategoriID { get; set; }
        [ForeignKey("KategoriID")]
        public Kategori kategori { get; set; }


        public int YayinEviID { get; set; }
        [ForeignKey("YayinEviID")]
        public YayinEvi yayinEvi { get; set; }



        public int YazarID { get; set; }
        [ForeignKey("YazarID")]
        public Yazar yazar { get; set; }


    }
}
