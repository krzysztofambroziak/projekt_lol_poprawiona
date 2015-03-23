using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Projekt_lol_poprawiony
{
        class Baza
    {
        private static BazaLOLDataContext dt = new BazaLOLDataContext();
        private Baza()
        {
        }
        public static BazaLOLDataContext Polaczenie
        {
            get { return dt; }
        }
    }

    class KlientWeb
    {
        private static WebClient wk = new WebClient();
        private KlientWeb()
        {
        }
        public static WebClient Polaczenie
        {
            get { return wk; }
        }
    }
}
