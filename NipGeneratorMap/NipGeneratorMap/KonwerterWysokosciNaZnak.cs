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
        IOgranicznikWysokosci _ogranicznik;
        

        public KonwerterWysokosciNaZnak(IOgranicznikWysokosci ogranicznik)
        {
            _ogranicznik = ogranicznik;
        }

        public char WysokoscNaZnak(int wartoscWysokosci)
        {
            if(!_ogranicznik.CzyPoprawnaWysokosc(wartoscWysokosci))
            {
                return '█';
            }

            return Wysokosci.ZnakiWysokosci[wartoscWysokosci];
        }
    }
}
