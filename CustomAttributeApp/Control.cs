using CustomAttributeApp;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace CustomAttributeOrnek
{
    public static class ZorunlulukKontrolu
    {
        public static bool Dogrula(object nesne)
        {
            var alanlar = nesne.GetType().GetFields(BindingFlags.Public | BindingFlags.Instance);

            foreach (var alan in alanlar)
            {
                var attr = (ZorunluAlanAttribute)Attribute.GetCustomAttribute(alan, typeof(ZorunluAlanAttribute));
                if (attr != null)
                {
                    string deger = alan.GetValue(nesne) as string;
                    if (string.IsNullOrWhiteSpace(deger))
                    {
                        // Burada hata mesajını doğrudan MessageBox ile gösteriyoruz
                        MessageBox.Show(attr.HataMesaji, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }

            return true;  // Tüm alanlar doğruysa true dönecek
        }
    }
}
