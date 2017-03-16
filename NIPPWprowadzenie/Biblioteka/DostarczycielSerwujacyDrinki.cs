using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class DostarczycielSerwujacyDrinki: IDostarczyciel
    {
        // https://pl.wikipedia.org/wiki/Dekorator_(wzorzec_projektowy)

        private IDostarczyciel _dekorowanyDostarczyciel;

        public DostarczycielSerwujacyDrinki(IDostarczyciel dekorowanyDostarczyciel)
        {
            _dekorowanyDostarczyciel = dekorowanyDostarczyciel;
        }

        public void Dostarcz()
        {
            Console.WriteLine("Dostarczanie drinków pasażerom");
            _dekorowanyDostarczyciel.Dostarcz();
        }
    }
}
