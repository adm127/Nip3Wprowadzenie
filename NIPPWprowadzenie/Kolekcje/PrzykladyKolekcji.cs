using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcje
{
    public class PrzykladyKolekcji
    {
        IList<string> listaNapisow;
        string[] tablicaNapisow;
        IDictionary<string, string> slownikNapisow;

        public void PrzykladUzyciaListy()
        {
            listaNapisow = new List<string>();
            listaNapisow.Add("Jeden");
            listaNapisow.Add("Dwa");
            listaNapisow.Add("Trzy");
            listaNapisow.Add("Cztery");
            listaNapisow.Add("Piec");

            Console.WriteLine($"listaNapisow zawiera {listaNapisow.Count} elementow");

            // albo tak:
            // (porzucamy wskaznik do pierwszej listy!)

            listaNapisow = new List<string>()
            {
                "Jeden",
                "Dwa",
                "Trzy",
                "Cztery",
                "Piec"
            };

            Console.WriteLine($"listaNapisow zawiera {listaNapisow.Count} elementow");

            listaNapisow.Add("Szesc");

            Console.WriteLine("Wszystkie elementy listy:");
            foreach (var napis in listaNapisow)
            {
                Console.WriteLine(napis);
            }

            if (listaNapisow.Contains("Dwa"))
            {
                Console.WriteLine("listaNapisow zawiera element \"Dwa\"");
            }
            else
            {
                Console.WriteLine("listaNapisow nie zawiera elementu \"Dwa\"");
            }

            if (listaNapisow.Contains("Siedem"))
            {
                Console.WriteLine("listaNapisow zawiera element \"Siedem\"");
            }
            else
            {
                Console.WriteLine("listaNapisow nie zawiera elementu \"Siedem\"");
            }
            
            Console.WriteLine("Usuwamy element");
            string dwa = "Dwa";
            listaNapisow.Add(dwa);
            listaNapisow.Remove(dwa);
            if (listaNapisow.Contains(dwa))
            {
                Console.WriteLine("listaNapisow zawiera element \"Dwa\"");
            }
            else
            {
                Console.WriteLine("listaNapisow nie zawiera elementu \"Dwa\"");
            }
        }

        public void PrzykladUzyciaTablicy()
        {
            tablicaNapisow = new string[5];
            tablicaNapisow[0] = "Jeden";
            tablicaNapisow[1] = "Dwa";
            tablicaNapisow[2] = "Trzy";
            tablicaNapisow[3] = "Cztery";
            tablicaNapisow[4] = "Piec";

            // to rzuci bledem System.IndexOutOfRangeException:
            //tablicaNapisow[5] = "Szesc";

            // nie ma metody Add:
            //tablicaNapisow.Add("Siedem");

            // ale rowniez mozna zainicjalizowac cala liste:

            tablicaNapisow = new string[]
            {
                "Jeden",
                "Dwa",
                "Trzy",
                "Cztery",
                "Piec"
            };

            // mozemy sprawdzic wielkosc tablicy w konkretnym wymiarze (ale zdanie!)
            Console.WriteLine("Gorny wymiar granicy" + tablicaNapisow.GetUpperBound(0));
            Console.WriteLine("Dolny wymiar granicy" + tablicaNapisow.GetLowerBound(0));

            // mozemy sie odwolywac do n-tego elementu kolekcji
            Console.WriteLine($"Trzeci element tablicy to: {tablicaNapisow[2]}");
        }

        public void PrzykladUzyciaSlownika()
        {
            slownikNapisow = new Dictionary<string, string>();

            // add ma dwa parametry:
            slownikNapisow.Add("akowalski", "Ksiegowy");
            slownikNapisow.Add("cnorris", "Straznik");
            slownikNapisow.Add("ccezary", "Posterunkowy");
            slownikNapisow.Add("jfasola", "Imigrant");
            slownikNapisow.Add("hhodor", "Odzwierny");
            slownikNapisow.Add("wwszywka", "Degustator");

            // albo tak:
            slownikNapisow = new Dictionary<string, string>()
            {
                { "akowalski", "Ksiegowy" },
                { "cnorris", "Straznik" },
                { "ccezary", "Posterunkowy" },
                { "jfasola", "IEmigrant" },
                { "hhodor", "Odzwierny" },
                { "wwszywka", "Degustator" }
            };

            foreach (var rolaOsoby in slownikNapisow)
            {
                Console.WriteLine($"osoba {rolaOsoby.Key} to {rolaOsoby.Value}");
            }

            Console.WriteLine($"hhodor to {slownikNapisow["hhodor"]}");
        }
    }
}
