using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            Uzupelnij istniejace klasy, aby odczytywaly pliki map Acme i Mapex zgodnie z instrukcja:

            - stworz dwie klasy, majace konwertowac znaki z plikow obu firm i zwracac wysokosc (liczbe od 0 - 12). 
                Klasy maja implementowac IKonwerterZnakuNaWysokosc. Nazawy np. KonwerterZnakuNaWysokoscAcme, KonwerterZnakuNaWysokoscMapex
            - stworz klase, ktora bedzie dostarczala wiadomosci z pliku (np. PlikowyDostarczycielWysokosci), ta klasa implementowac IDostarczycielWysokosci,
                w konstruktorze ma przyjmowac sciezke do pliku (string) oraz ma byc niezalezna od konkretnej firmy (musi przyjmowac konwerter - rowniez w konstruktorze).
                Klasa ma czytac podany plik i zwracac int[][] wartosci wysokosci (patrz IDostarczycielWysokosci)
            - stworz klase konwertujaca wysokosc (int) na znak z tablicy Wysokosci.ZnakiWysokosci (ma implementowac IKonwerterWysokosciNaZnak).
                Klasa ma sprawdzac, czy podana wysokosc (int) miesci sie w zakresie tablicy, jesli nie, to ma zwracac znak Wysokosci.ZnakNieokreslonejWysokosci.
            - stworz dwie klasy, ktore beda generowaly mape, jedna bedzie ja wyswietlac na konsoli, druga bedzie tworzyla plik z narysowana mapa. Obie klasy
                maja implementowac IGeneratorMapy. Obie klasy w konstruktorze przyjmowac powinny IKonwerterWysokosciNaZnak. Dodatkowo klasa, ktora tworzy plik
                z narysowana mapa, powinna w konstruktorze przyjmowac sciezke do pliku wynikowego.
            */

        static void Main(string[] args)
        {
            //var konwerter = new KonwerterWysokosciNaZnak();

            //var generator = new GeneratorKonsolowyMapy(konwerter);

            //var konwerterAcme = new KonwerterZnakuNaWysokoscAcme();
            //var dostarczycielWysokosciAcme = new PlikowyDostarczycielWysokosci(@"MapyAcme\Mapa2.txt", konwerterAcme);

            //generator.GenerujMape(dostarczycielWysokosciAcme);
        }       
    }
}
