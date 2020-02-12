using System;
using System.Collections.Generic;
using System.Text;

namespace P3_Kol2_poprawa_nr3
{
    public class Kopiarka : IKopiarka
    {
         string IKopiarka.Kopiuj(string tekst)
        {
          //  IDrukarka drukuj = new Drukuj(tekst);
          // ISkaner skanuj = new Skanuj();

            return tekst;
        }

        void IDrukarka.Drukuj(string tekst)
        {
            Console.WriteLine("Drukuj " + tekst);
        }

         string ISkaner.Skanuj()
        {
            Console.WriteLine("Skanuje....");
            return "";
        }
    }
}
