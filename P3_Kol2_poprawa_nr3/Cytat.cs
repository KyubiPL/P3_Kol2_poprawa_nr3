using System;
using System.Collections.Generic;
using System.Text;

namespace P3_Kol2_poprawa_nr3
{
    public class Cytat
    {
        public string Autor { get; set; }
        public string Tytul { get; set; }
        public DateTime DataWydania { get; set; }
        public string MiejsceWydania { get; set; }
        public string Wydawnictwo { get; set; }

        public Cytat(string aut,string tyt,DateTime dw,string mw,string wyd)
        {
            this.Autor = aut;
            this.Tytul = tyt;
            this.DataWydania = dw;
            this.MiejsceWydania = mw;
            this.Wydawnictwo = wyd;
        }

        public void Deconstruct(out string aut,out DateTime dt)
        {
            aut = Autor;
            dt = DataWydania;
        }

        public void Deconstruct(out string tyt,out string aut,out string mw,out string wyd,out DateTime dw)
        {
            tyt = Tytul;
            aut = Autor;
            mw = MiejsceWydania;
            wyd = Wydawnictwo;
            dw = DataWydania;
        }
    }
}
