using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Win171115_KitapStore.Models;

namespace Win171115_KitapStore
{
    public class DataInitializer: DropCreateDatabaseIfModelChanges<KitapContext>
    {
        protected override void Seed(KitapContext context)
        {
            List<Kategori> kategoriler = new List<Kategori>()
            {
                new Kategori() {Ad="Edebiyat" },
                new Kategori() {Ad="Tarih" },
                new Kategori() {Ad="Sosyoloji" },
                new Kategori() {Ad="Psikoloji" },
                new Kategori() {Ad="Ders" },
                new Kategori() {Ad="Araştorma" },
                new Kategori() {Ad="Şiir" }
            };

            foreach (var item in kategoriler)
            {
                context.Kategoriler.Add(item);
            }

            context.SaveChanges();
        }
    }
}
