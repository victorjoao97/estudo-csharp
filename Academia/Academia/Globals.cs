using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia
{
    class Globals
    {
        public static string version = "1.0";
        public static bool logged = false;
        public static long nivel = 0;

        public static void Logon(long _nivel)
        {
            logged = true;
            nivel = _nivel;
        }

        public static void Logoff()
        {
            logged = false;
            nivel = 0;
        }
    }
}
