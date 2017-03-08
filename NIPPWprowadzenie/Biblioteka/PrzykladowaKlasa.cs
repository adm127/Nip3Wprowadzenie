using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class PrzykladowaKlasa
    {
        int bardzoWaznaLiczba;
        public PrzykladowaKlasa(int bardzoWaznaLiczba)
        {
            this.bardzoWaznaLiczba = bardzoWaznaLiczba;
        }

        //Mozna sie pobawic - pokazac co sie stanie gdy wykomentujemy te funkcje (domyslne dzialania 'toString').
        public override string ToString()
        {
            return $"Moja bardzo wazna liczba to: {bardzoWaznaLiczba}";
        }

        public string PrzykladIf(double testowanaZmienna)
        {
            if (testowanaZmienna > 0.5)
            {
                return $"Testowana zmienna byla wieksza niz 0.5";
            }
            else
            {
                return $"Testowana zmienna byla mniejsza niz 0.5";
            }
        }

        public string PrzykladFor(int liczbaIteracji)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < liczbaIteracji; i++)
            {
                sb.AppendLine($"Iteracja nr {i}");
            }

            return sb.ToString();
        }
    }
}
