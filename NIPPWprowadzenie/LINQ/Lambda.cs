using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class LambdaKlasa
    {
        IList<int> listaLiczb = new List<int>();

        public LambdaKlasa()
        {
            for (int i = 0; i < 1000; i++)
            {
                listaLiczb.Add(i);
            }

            //listaLiczb.Where(p => p > 100);
        }

        public IList<int> Odfiltruj(Func<int, bool> filtr)
        {
            IList<int> kolekcjaLiczb = new List<int>();

            foreach (var liczba in listaLiczb)
            {
                if(filtr(liczba))
                {
                    kolekcjaLiczb.Add(liczba);
                }
            }

            return kolekcjaLiczb;
        }

        public bool CzyWiekszyOdStu(Func<int> dajWynik)
        {
            if(dajWynik() > 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void WykonajOperacje(Action operacja)
        {
            operacja();
        }
    }
}
