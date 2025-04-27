using CustomAttributeOrnek;

namespace CustomAttributeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci
            {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                Bolum = txtBolum.Text
            };

            // Dogrula metodu false dönerse MessageBox hata mesajýný gösterir.
            if (ZorunlulukKontrolu.Dogrula(ogr))
            {
                MessageBox.Show($"Giriþ baþarýlý,\nAd: {txtAd.Text},\nSoyad:{txtSoyad.Text},\nBölüm:{txtBolum.Text} ");
            }
            else
            {
            }
        }



    }

}
