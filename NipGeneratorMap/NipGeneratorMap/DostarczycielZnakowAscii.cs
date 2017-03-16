using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NipGeneratorMap.Interfaces;

namespace NipGeneratorMap
{
    public class DostarczycielZnakowAscii: IDostarczycielZnakow
    {
        static readonly string[] _znakiWysokosci = { " ", "`", ".", ":", "/", "+", "o", "s", "y", "d", "m", "N", "M" };

        static readonly string _znakNieokreslonejWysokosci = "█";

        public string[] ZnakiWysokosci()
        {
            return _znakiWysokosci;
        }

        public string ZnakKoncaLinii()
        {
            return string.Empty;
        }

        public string ZnakNieokreslonejWysokosci()
        {
            return _znakNieokreslonejWysokosci;
        }

        public string ZnakPoczatkuLinii()
        {
            return string.Empty;
        }
    }
}
