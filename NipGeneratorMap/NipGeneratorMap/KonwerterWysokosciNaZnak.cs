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
        private IDostarczycielZnakow _dostarczycielZnakow;

        public KonwerterWysokosciNaZnak(IDostarczycielZnakow dostarczycielZnakow)
        {
            _dostarczycielZnakow = dostarczycielZnakow;
        }

        public string WysokoscNaZnak(int wartoscWysokosci)
        {
            if (_dostarczycielZnakow.ZnakiWysokosci().GetLowerBound(0) <= wartoscWysokosci && _dostarczycielZnakow.ZnakiWysokosci().GetUpperBound(0) >= wartoscWysokosci)
            {
                return _dostarczycielZnakow.ZnakiWysokosci()[wartoscWysokosci]; 
            }

            return _dostarczycielZnakow.ZnakNieokreslonejWysokosci();
        }

        public string ZnakKoncaLinii()
        {
            return _dostarczycielZnakow.ZnakKoncaLinii();
        }

        public string ZnakPoczatkuLinii()
        {
            return _dostarczycielZnakow.ZnakPoczatkuLinii();
        }
    }
}
