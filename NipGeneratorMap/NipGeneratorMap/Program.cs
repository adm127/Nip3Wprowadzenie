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

            
                1) podepnij DI container (Unity), zarejestruj wszystkie potrzebne typy (dobrze to zrobic w osobnej metodzie), zresolwuj IGeneratorMapy i wygeneruj mape na konsole. 
	                - Program powinien dzialac po wywolaniu generator.GenerujMape(@"MapyAcme\Mapa2.txt");
                2) zrefaktoruj KonwerterWysokosciNaZnak tak, aby nie mial na sztywno zapisanych znakow z klasy Wysokosci - wprowadz dodatkowa warstwe abstrakcji (tzn, stworz nowy interface + klase, ktora bedzie zwracala znaki ASCII)
	                - zarejestruj dodatkowy typ w DI contenerze
	                - Program wciaz powinien dzialac po wywolaniu generator.GenerujMape(@"MapyAcme\Mapa2.txt");
	                - jakies uwagi do tego punktu? (okazja do otrzymania plusa)
                3) stworz klase, ktora bedzie generowala mape w postaci tabelki HTMLowej (<tr><td style="background-color:#445566"></td><td style="background-color:#ffbb11"></td>...</tr>...)
	                - wynik powinien zawierac tylko i wylacznie tabele, bez tagow HTML - body, head etc.
	                - Uwaga: to nie jest nowa klasa implementujaca IGeneratorMapy!
	                - (d) ktos widzi jakis klopot z z wygenerowanym HTMLem?
			            - w HTMLowej tabelce nowy rekord to nie jest "\n\r" tylko zamkniecie </tr>, w dodatku kazdy wiersz musimy zaczynac od otwracie taga <tr>
				            - zmodyfikowac IDostarczycielZnakow (i IKonwerterWysokosciNaZnak - dlaczego?) dodajac metody:
					            - ZnakKoncaLinii i wywolywac ja przed sw.WriteLine() w GeneratorPlikuMapy
					            - ZnakPoczatkuLinii i wywolywac ja przed rozpoczeciem nowej linii w GeneratorPlikuMapy
		
	                - program wciaz powinien dzialac, 
	                - zmodyfikuj DI container aby uzywal nowo napisanej klasy	
	                - program wciaz powinien dzialac, ale wynik tabeli HTMLowej na konsoli nie bedzie zbyt czytelny :-)
	                - zomydyfikuj DI container aby uzywal klasy generujacej plik a nie wyswietlajacej wszystko na konsole
	                - wynikiem dzialania programu powinien byc plik z tabelka HTML
                4) stworz dekorator dla IGeneratorMapy, ktory utworzy strone HTML podzielona na dwie kolumny. W prawej kolumnie powinna znajdowac sie tabelka z mapa wysokosci.
	                - udekoruj klase stworzona w punkcie 3) - tzn. poprawnie skonfiguruj DI container
	                - wynikiem powinna byc strona HTML (otworz ja w przegladarce), ktora w prawej czesci ekranu stworzy mape wysokosci
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
