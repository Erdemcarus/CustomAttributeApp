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

            // Dogrula metodu false d�nerse MessageBox hata mesaj�n� g�sterir.
            if (ZorunlulukKontrolu.Dogrula(ogr))
            {
                MessageBox.Show($"Giri� ba�ar�l�,\nAd: {txtAd.Text},\nSoyad:{txtSoyad.Text},\nB�l�m:{txtBolum.Text} ");
            }
            else
            {
            }
        }



    }

}
