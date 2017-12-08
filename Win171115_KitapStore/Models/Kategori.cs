﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win171115_KitapStore.Models
{
    [Table("Kategoriler")]
    public class Kategori
    {
        public int ID { get; set; }
        public string Ad { get; set; }


        public List<Kitap> Kitaplar { get; set; }

    }
}
