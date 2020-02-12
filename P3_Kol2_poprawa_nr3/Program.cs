using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace P3_Kol2_poprawa_nr3
{
    public class Program
    {
        

        
        static void Main(string[] args)
        {
            Random a = new Random();

            Console.WriteLine("Zadanie.1");

            TimeSpan dt;
           
            string[] lis = { "Jelen", "Cus", "Nie","Antek","Kajtek" };

            List<int> lista = Enumerable.Range(0, 5).ToList();

            List<Playlista> piosenki = lista.Select(x => new Playlista(
                    lis[a.Next(0, 5)],
                    lis[a.Next(0, 5)],
                    dt = new TimeSpan(0, a.Next(0, 5), a.Next(0, 60))
             )).ToList() ;

            foreach (var item in piosenki)
            {
                Console.WriteLine($"{item.Tytul} {item.Autor} {item.Dlugosc}");
            }

            Console.WriteLine();

            double dlsuma = 0;

            List<Playlista> sortafl = piosenki.OrderBy(x => x.Tytul).ToList();

            List<Playlista> sortaflAutor = piosenki.OrderBy(x => x.Autor).ToList();

            foreach (var item in sortafl)
            {
                Console.WriteLine($"{item.Tytul} {item.Autor} {item.Dlugosc}");
            }
            Console.WriteLine();
            foreach (var item in sortaflAutor)
            {
                Console.WriteLine($"{item.Tytul} {item.Autor} {item.Dlugosc}");
            }


            foreach (var item in piosenki)
            {
                dlsuma += item.Dlugosc.TotalSeconds;
            }
            int y = Convert.ToInt32(dlsuma);
            int min = y / 60;
            int sec = y % 60;

            TimeSpan dlmin = new TimeSpan(0, min, sec);//Nie wziołem pod uwagę godzin jezeli by dodac to ^int godzina=y/3600;

            Console.WriteLine();
            Console.WriteLine("Łączna długość to: "+dlmin);
            Console.WriteLine();

            Console.WriteLine("Zadanie.2");
            int ilosc = 20;

            int[] tab=new int[ilosc];

            for (int i = 0; i < ilosc; i++)
            {
                tab[i] = a.Next(0, 10);
            }

            for (int i = 0; i < ilosc; i++)
            {
                Console.Write(tab[i] + " ");
            }
            Console.WriteLine();
            tab.Ext();//<--- Tu jest wywołanie extension metody
            Console.WriteLine();
            for (int i = 0; i < ilosc; i++)
            {
                Console.Write(tab[i]+" ");
            }
            Console.WriteLine();

            Console.WriteLine("Zadanie.3");

            string tekst = "A jakis tam tekst to drukowania kserowania i kopiowania";
            Console.WriteLine();

            IKopiarka obj = new Kopiarka();
            Console.WriteLine( obj.Kopiuj(tekst));

            Console.WriteLine();
            Console.WriteLine("Zadanie.4");
            Console.WriteLine();

            var data1 = new DateTime(2020, 2, 11);
            var pier = new Cytat("Janek", "Cos1/Tytul", data1, "ZadymionyKrakow", "Wyd.org");

            var(aut1, dw1) = pier;
            Console.WriteLine($"{aut1} {dw1.Year}");
            Console.WriteLine();

            var data2 = new DateTime(2019, 5, 22);
            var drug = new Cytat("Kantek", "Cos2/Tytul", data2, "SloikoLandia", "Heliox");

            var (tyt2, aut2, mw2, wyd2, dw2) = drug;
            Console.WriteLine($"{tyt2} {aut2} {mw2} {wyd2} {dw2.Year}");

            Console.WriteLine();
            Console.WriteLine("Zadanie.5");


        }
    }
}
