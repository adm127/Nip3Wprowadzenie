using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NipGeneratorMap.Interfaces;

namespace NipGeneratorMap
{
    public class KonwerterWysokosciNaZnak: IKonwerterWysokosciNaZnak
    {
        public string WysokoscNaZnak(int wartoscWysokosci)
        {
            if (Wysokosci.ZnakiWysokosci.GetLowerBound(0) <= wartoscWysokosci && Wysokosci.ZnakiWysokosci.GetUpperBound(0) >= wartoscWysokosci)
            {
                return Wysokosci.ZnakiWysokosci[wartoscWysokosci]; 
            }

            return Wysokosci.ZnakNieokreslonejWysokosci;
        }
    }
}
