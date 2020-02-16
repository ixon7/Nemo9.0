using System;
using System.Collections.Generic;
using System.Text;

namespace Nemo9._0
{
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
}
