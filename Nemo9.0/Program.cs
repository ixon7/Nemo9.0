using System;
using System.Collections.Concurrent;
using System.Text;
using System.Linq;

namespace Nemo9._0
{
    
    public static class ExtensionMethods
    {
        public static (int wynik, int resztaZDzielenia) DzielenieZReszta(this int liczba, int dzielnik)
        {
            return (liczba / dzielnik, liczba % dzielnik);
    }
        public static int ZliczZnaki(this string tekst, char znak)
        {
            return tekst.Count(x => x.Equals(znak));
        }
        public static int ZliczZnaki(this string tekst, string znak)
        {
            if (znak.Length>1)
            {
                throw new ArgumentException();
            }
            return ZliczZnaki(tekst, znak[0]);
        }
        public static int SumaGrupWiekowych(this GrupaWiekowa grupa)
        {
            Enum.GetValues(typeof(GrupaWiekowa))
                .Cast<int>()
                .Sum();

            int suma = 0;
            foreach (var item in Enum.GetValues(typeof(GrupaWiekowa)))
            {
                suma += (int)item;
            }
        return suma;
        }
    }
    [Flags]
    public enum GrupaWiekowa
    {
        Brak = 0,
        Dzieci = 1,     // 0001
        Mlodziez = 2,   // 0010
        Dorosli = 4,    // 0100
        Starsi = 8,     // 1000
        //Pelnoletni = 12 // 1100
    }
    public enum Zainstresowania
    {
        Komputery,
        Lalki
    }
    public class Reklama
    {
        public string tekst;
        public GrupaWiekowa grupaWiekowa;
        public Zainstresowania zainstresowania;

        public Reklama(string tekst, GrupaWiekowa grupaWiekowa, Zainstresowania zainstresowania)
        {
            this.grupaWiekowa = grupaWiekowa;
            this.zainstresowania = zainstresowania;
        }
    }

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
