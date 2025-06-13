using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
namespace TrafikCezaYonetimOOP
{
    public partial class Form1 : Form
    {
        string dosyaYolu = Path.Combine(Application.StartupPath, "cezalar.txt");
        List<Surucu> suruculer = new List<Surucu>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(dosyaYolu))
            {
                File.Create(dosyaYolu).Close(); // Dosyayı oluştur ve kapat
            }


            VerileriYukle();
            Listele();
        }

        private void VerileriYukle()
        {
            suruculer.Clear();

            string[] satirlar = File.ReadAllLines(dosyaYolu);

            foreach (string satir in satirlar)
            {
                var parca = satir.Split(',');

                if (parca.Length < 8)
                    continue;

                string plaka = parca[0];
                string ad = parca[1];
                string soyad = parca[2];
                string tc = parca[3];
                if (!DateTime.TryParse(parca[4], out DateTime tarih)) continue;
                string cezaTuru = parca[5];
                if (!decimal.TryParse(parca[6], out decimal tutar)) continue;
                string aciklama = parca[7];

                Ceza ceza = new Ceza
                {
                    Tarih = tarih,
                    CezaTuru = cezaTuru,
                    Tutar = tutar,
                    Aciklama = aciklama
                };

                var surucu = suruculer.FirstOrDefault(s => s.TcNo == tc);
                if (surucu == null)
                {
                    surucu = new Surucu
                    {
                        Plaka = plaka,
                        Ad = ad,
                        Soyad = soyad,
                        TcNo = tc
                    };
                    suruculer.Add(surucu);
                }

                surucu.Cezalar.Add(ceza);
            }
        }

        private void Listele()
        {
            lstSuruculer.Items.Clear();

            foreach (var surucu in suruculer)
            {
                lstSuruculer.Items.Add($"[Sürücü] {surucu.Ad} {surucu.Soyad} - TC: {surucu.TcNo} - Plaka: {surucu.Plaka}");

                foreach (var ceza in surucu.Cezalar)
                {
                    lstSuruculer.Items.Add($"   ? {ceza.Tarih.ToShortDateString()} | {ceza.CezaTuru} | {ceza.Tutar} TL | {ceza.Aciklama}");
                }
            }
        }

        private void ListeleYeniCeza(string tc, DateTime tarih)
        {
            lstSuruculer.Items.Clear();
            var surucu = suruculer.FirstOrDefault(s => s.TcNo == tc);
            if (surucu != null)
            {
                var yeniCeza = surucu.Cezalar.FirstOrDefault(c => c.Tarih.Date == tarih.Date);
                if (yeniCeza != null)
                {
                    lstSuruculer.Items.Add($"[Sürücü] {surucu.Ad} {surucu.Soyad} - TC: {surucu.TcNo} - Plaka: {surucu.Plaka}");
                    lstSuruculer.Items.Add($"   • {yeniCeza.Tarih.ToShortDateString()} | {yeniCeza.CezaTuru} | {yeniCeza.Tutar} TL | {yeniCeza.Aciklama}");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            string plaka = txtPlaka.Text.Trim();
            string ad = txtAd.Text.Trim();
            string soyad = txtSoyad.Text.Trim();
            string tc = txtTc.Text.Trim();
            string cezaTuru = txtCezaTuru.Text.Trim();
            decimal tutar = decimal.Parse(txtTutar.Text);
            string aciklama = txtAciklama.Text.Trim();
            DateTime tarih = dtpTarih.Value;

            string yeniSatir = $"{plaka},{ad},{soyad},{tc},{tarih.ToShortDateString()},{cezaTuru},{tutar},{aciklama}";
            File.AppendAllText(dosyaYolu, yeniSatir + Environment.NewLine);

            VerileriYukle();
            ListeleYeniCeza(tc, tarih);
            MessageBox.Show("Ceza başarıyla eklendi.");
        }

        private void btnAra_Click_1(object sender, EventArgs e)
        {
            string arananPlaka = txtAraPlaka.Text.Trim().ToUpper();
            lstSuruculer.Items.Clear();

            var bulunanlar = suruculer
                .Where(s => s.Plaka.ToUpper() == arananPlaka)
                .ToList();

            if (!bulunanlar.Any())
            {
                MessageBox.Show("Sürücü bulunamadı.");
                return;
            }

            foreach (var surucu in bulunanlar)
            {
                foreach (var ceza in surucu.Cezalar)
                {
                    lstSuruculer.Items.Add(
                        $"{surucu.Plaka} - {surucu.Ad} {surucu.Soyad} - TC: {surucu.TcNo} - Tarih: {ceza.Tarih:dd.MM.yyyy} - Tür: {ceza.CezaTuru} - Tutar: {ceza.Tutar} TL - Açıklama: {ceza.Aciklama}"
                    );
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string tc = txtSilTc.Text.Trim();
            DateTime tarih = dtpSilTarih.Value;

            if (string.IsNullOrEmpty(tc))
            {
                MessageBox.Show("Lütfen TC numarası girin.");
                return;
            }

            // TC numarasına göre sürücüyü bul
            var surucu = suruculer.FirstOrDefault(s => s.TcNo == tc);
            if (surucu == null)
            {
                MessageBox.Show("Bu TC numarasına sahip sürücü bulunamadı.");
                return;
            }

            // Tarihe göre cezayı bul
            var silinecekCeza = surucu.Cezalar.FirstOrDefault(c => c.Tarih.Date == tarih.Date);
            if (silinecekCeza == null)
            {
                MessageBox.Show("Bu tarihte kayıtlı ceza bulunamadı.");
                return;
            }

            // Sadece seçilen tarihteki cezayı sil
            surucu.Cezalar.Remove(silinecekCeza);

            // Dosyayı güncelle - sadece kalan cezaları yaz
            var yeniSatirlar = new List<string>();
            foreach (var s in suruculer)
            {
                foreach (var c in s.Cezalar)
                {
                    yeniSatirlar.Add($"{s.Plaka},{s.Ad},{s.Soyad},{s.TcNo},{c.Tarih.ToShortDateString()},{c.CezaTuru},{c.Tutar},{c.Aciklama}");
                }
            }
            File.WriteAllLines(dosyaYolu, yeniSatirlar);

            // Arayüzü güncelle - sadece kalan cezaları göster
            lstSuruculer.Items.Clear();
            foreach (var s in suruculer)
            {
                if (s.Cezalar.Any())
                {
                    lstSuruculer.Items.Add($"[Sürücü] {s.Ad} {s.Soyad} - TC: {s.TcNo} - Plaka: {s.Plaka}");
                    foreach (var c in s.Cezalar)
                    {
                        lstSuruculer.Items.Add($"   • {c.Tarih.ToShortDateString()} | {c.CezaTuru} | {c.Tutar} TL | {c.Aciklama}");
                    }
                }
            }

            MessageBox.Show("Seçilen tarihteki ceza başarıyla silindi.");
        }
    }
}
