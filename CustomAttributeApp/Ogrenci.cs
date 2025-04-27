using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributeApp
{
    public class Ogrenci
    {
        [ZorunluAlan("Ad boş bırakılamaz.")]
        public string Ad;

        [ZorunluAlan("Soyad boş bırakılamaz.")]
        public string Soyad;

        [ZorunluAlan("Bölüm boş bırakılamaz.")]
        public string Bolum;





    }
}
