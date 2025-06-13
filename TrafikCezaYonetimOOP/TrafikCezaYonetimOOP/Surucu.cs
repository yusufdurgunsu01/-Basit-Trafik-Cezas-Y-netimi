using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafikCezaYonetimOOP
{
    internal class Surucu
    {
        public string TcNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Plaka { get; set; }
        public List<Ceza> Cezalar { get; set; }

        public Surucu()
        {
            Cezalar = new List<Ceza>();
        }

        public decimal ToplamCezaTutari()
        {
            return Cezalar.Sum(c => c.Tutar);
        }

        public override string ToString()
        {
            return $"{Plaka} - {Ad} {Soyad} - TC: {TcNo} - Toplam Ceza: {ToplamCezaTutari()} TL";
        }
    }
}
