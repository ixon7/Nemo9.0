using System;
using System.Collections.Generic;
using System.Text;

namespace Nemo9._0
{
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
}
