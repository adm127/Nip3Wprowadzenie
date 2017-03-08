using Biblioteka;
using LINQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kolekcje;
using Dziedziczenie;
using AsyncAwait;

namespace NIPPWprowadzenie
{
    class Program
    {
        static void Main(string[] args)
        {
            // #1 Potrzebne jest dodanie referencji do 'biblioteki'
            //PrzykladowaKlasa pierwszyObiekt = new PrzykladowaKlasa(5);
            //string wynik = pierwszyObiekt.PrzykladIf(3);

            //string wynik = pierwszyObiekt.PrzykladFor(33);

            //string wynik = pierwszyObiekt.ToString();
            //Console.WriteLine(wynik);

            // przyklady kolekcji
            //var kolekcje = new PrzykladyKolekcji();
            //kolekcje.PrzykladUzyciaListy();
            //kolekcje.PrzykladUzyciaTablicy();
            //kolekcje.PrzykladUzyciaSlownika();

            // #2 przyklad polimorfizmu
            //IList<Postac> postacie = new List<Postac>()
            //{
            //    new Stan(),
            //    new Cartman(),
            //    new Cartman(),
            //    new Kenny(),
            //    new Stan()
            //};
            //NarysujPostacie(postacie);

            // #3 przyklad async/await
            //MainAsync().Wait();

            // pod debugiem
            //var lambdaZmienna = new LambdaKlasa();
            //Func<int, bool> mojWarunek = (a) => { return a > 10; };
            //var wynik = lambdaZmienna.Odfiltruj(mojWarunek);
            ////var wynik = lambdaZmienna.Odfiltruj((a) => { return a > 10; });
            //lambdaZmienna.CzyWiekszyOdStu(() => 10);

            // pod debugiem
            //var wynik = TestLinq.PrzykladAsParallel();
            //var zamowienia = TestLinq.ZamowieniaKlienta(1);

            Console.ReadLine();
        }

        private static void NarysujPostacie(IList<Postac> postacie)
        {
            Console.WriteLine();
            Console.WriteLine();

            // ta metoda nie ma pojecia jakie postacie sa w kolekcji, ale dzieki polimorfizmowi kazda z tych postaci
            // narysuje sie tak jak powinna
            // Co wiecej: metoda rysujaca nie bedzie zmieniana nawet jesli zostana stworzone nowe klasy postaci!
            foreach (Postac postac in postacie)
            {
                postac.Narysuj();

                Console.WriteLine();
                Console.WriteLine();
            }
        }

        static async Task MainAsync()
        {
            var pracownik1 = new AsynchronicznyPracownik("nowak");
            var pracownik2 = new AsynchronicznyPracownik("kowalski");

            var zadanie1 = pracownik1.PracujAsync(15, 1000);
            var zadanie2 = pracownik2.PracujAsync(25, 750);

            await Task.WhenAll(zadanie1, zadanie2);
        }
    }
}
