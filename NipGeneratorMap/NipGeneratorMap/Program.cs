using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using NipGeneratorMap.Interfaces;

namespace NipGeneratorMap
{
    class Program
    {
        /* Tresc zadania:
                Istnieja na rynku dwie firmy, ktore dostarczaja mapy wysokosci terenu. Kazda ma swoj format zapisu.
                Firma Acme:
                    rozroznia 13 poziomow wysokosci, ponumerowane od 0 - 9 oraz klejno a, b, c (0 - najnizsza wysokosc, c - najwyzsza).
                Firma Mapex
                    rozroznia 17 poziomow wysokosci, kazda kalejna litera alfabetu (abcdefghijklmnopq).

                Kazda z nich udostepnia pliki w swoim formacie zapisu. Specyfikacja pliku:
                    - 1 linia - jedna liczba stanowiaca szerokosc mapy - W
                    - 2 linia - jedna liczba stanowiaca wysokosc mapy - H
                    - od 3 linii do (W + 2) znajduje sie ciag znakow (w formacie firmy Acme/Mapex) reprezentujacych wysokosci (ciag znakow o dlugosci H)

                przyklad mapy Acme:

                3
                3
                122
                34a
                ab3

                przyklad mapy Mapex:

                3
                3
                aaf
                bac
                dop

            Uzupelnij istniejace klasy, aby odczytywaly pliki map Acme i Mapex zgodnie z instrukcja na slajdach.
            */

        static void Main(string[] args)
        {            
            var konwerter = new KonwerterWysokosciNaZnak();
            var konwerterAcme = new KonwerterZnakuNaWysokoscAcme();
            var dostarczycielWysokosci = new PlikowyDostarczycielWysokosci(konwerterAcme);

            var generator = new GeneratorKonsolowyMapy(konwerter, dostarczycielWysokosci);

            generator.GenerujMape(@"MapyAcme\Mapa2.txt");
        }       
    }
}
