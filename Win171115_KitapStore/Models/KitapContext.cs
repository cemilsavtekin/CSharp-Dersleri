using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win171115_KitapStore.Models
{
    public class KitapContext:DbContext
    {
        public KitapContext():base("KitapStore")
        {
            Database.SetInitializer<KitapContext>(new DropCreateDatabaseIfModelChanges<KitapContext>());
        }

        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<Uye> Uyeler { get; set; }
        public DbSet<YayinEvi> YayinEvleri { get; set; }
        public DbSet<Yazar> Yazarlar { get; set; }

    }
}
