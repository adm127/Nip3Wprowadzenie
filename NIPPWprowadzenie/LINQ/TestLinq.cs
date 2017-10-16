using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{

    static public class TestLinq
    {
        static private Zamowienie[] zamowienia =
        {
            new Zamowienie { ID = 1, IDKlienta = 1, Wartosc = 5 },
            new Zamowienie { ID = 2, IDKlienta = 1, Wartosc = 10 },
            new Zamowienie { ID = 3, IDKlienta = 2, Wartosc = 15 }
        };

        static private Klient[] klienci =
        {
            new Klient { ID = 1, Imie = "Jan", Nazwisko = "Kowalski" },
            new Klient { ID = 2, Imie = "Piotr", Nazwisko = "Nowak" },
        };

        static public IEnumerable<Zamowienie> ZamowieniaKlienta(int ID)
        {
            return from o in zamowienia
                   where o.IDKlienta == ID
                   select o;
        }

        static public int[] PrzykladAsParallel()
        {
            int[] dane = Enumerable.Range(1, 10000000).ToArray();

            int[] wyniki = null;
            wyniki = (from num in dane.AsParallel() // Mozna usunac AsParallel()
                      where num % 3 == 0
                      orderby num descending
                      select num).ToArray();

            return wyniki;

            // Wyniki na mojej maszynie:
            // Z uzyciem .AsParallel – 989 ms
            // Bez .AsParallel – 1415 ms
        }

        static public void LinqJoin()
        {
            var join = (from z in zamowienia
                   join k in klienci
                    on z.IDKlienta equals k.ID
                   select new { Nazwisko = k.Nazwisko, Wartosc = z.Wartosc}).ToList();

            foreach (var d in join)
            {
                Console.WriteLine($"{d.Nazwisko}: {d.Wartosc}");
            }
        }

        static public void LinqGroup()
        {
            var group = (from z in zamowienia
                        group z by z.IDKlienta into zg
                        select new {IDKlienta = zg.Key , Wartosc = zg.Sum(z => z.Wartosc), IDlist = zg.ToList() }).ToList();

            foreach (var d in group)
            {
                Console.WriteLine($"{d.IDKlienta}: {d.Wartosc}");
            }
        }
    }

    public class Zamowienie
    {
        public int ID { get; set; }
        public int IDKlienta { get; set; }
        public int Wartosc { get; set; }
    }

    public class Klient
    {
        public int ID { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
    }
}
