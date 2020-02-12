using System;
using System.Collections.Generic;
using System.Text;

namespace P3_Kol2_poprawa_nr3
{
    public class Playlista
    {
        public string Tytul { get; set; }
        public string Autor { get; set; }
        public TimeSpan Dlugosc{get;set;}

        public Playlista(string Tytul,string Autor,TimeSpan Dlugosc)
        {
            this.Autor = Autor;
            this.Tytul = Tytul;
            this.Dlugosc = Dlugosc;
        }
    }
}
