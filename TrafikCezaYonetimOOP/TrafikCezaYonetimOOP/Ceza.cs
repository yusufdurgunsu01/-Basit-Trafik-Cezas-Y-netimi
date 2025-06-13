using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafikCezaYonetimOOP
{
    internal class Ceza
    {
        public DateTime Tarih { get; set; }
        public string CezaTuru { get; set; }
        public decimal Tutar { get; set; }
        public string Aciklama { get; set; }

        public override string ToString()
        {
            return $"{Tarih.ToShortDateString()} - {CezaTuru} - {Tutar} TL - {Aciklama}";
        }
    }
}
