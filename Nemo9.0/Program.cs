using System;
using System.Collections.Concurrent;
using System.Text;
using System.Linq;

namespace Nemo9._0
{
    //test
    class Program
    {
        static void Main(string[] args)
        {
            int liczba = Convert.ToInt32(Console.ReadLine());
            int wynik, reszta;
            (wynik, reszta) = liczba.DzielenieZReszta(3);
            Console.WriteLine($"{liczba}/3={wynik}r{reszta}");
            int wynik2;
            string word = Convert.ToString(Console.ReadLine());
            (wynik2) = word.ZliczZnaki(word);

            var reklama = new Reklama("Kup teraz", GrupaWiekowa.Dorosli | GrupaWiekowa.Mlodziez, Zainstresowania.Komputery);
            for (int i = 0; i <= GrupaWiekowa.Dorosli.SumaGrupWiekowych(); i++)
            {
                Console.WriteLine((GrupaWiekowa)i);
            }
        }
    }
}
