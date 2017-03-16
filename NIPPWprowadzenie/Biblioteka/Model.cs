using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    #region klasy dla przykladu DI/Dekorator
    // ============= POSTAC ==============
    public interface IPostac
    {
        void WydrukujPozycje();

        void UstawPozycje(string pozycja);
    }

    public class Adam : IPostac
    {
        private string _pozycja = "Katowice";

        public void WydrukujPozycje()
        {
            Console.WriteLine($"    Adam znajduje sie w {_pozycja}");
        }

        public void UstawPozycje(string pozycja)
        {
            _pozycja = pozycja;
        }
    }

    public class Jan : IPostac
    {
        private string _pozycja = "Warszawa";

        public void WydrukujPozycje()
        {
            Console.WriteLine($"    Jan znajduje sie w {_pozycja}");
        }

        public void UstawPozycje(string pozycja)
        {
            _pozycja = pozycja;
        }
    }

    // ============= DOSTARCZYCIEL ==============
    public interface IDostarczyciel
    {
        void Dostarcz();
    }

    public class Samochod : IDostarczyciel
    {
        private IPostac _postac;
        private string _pozycjaDocelowa;

        public Samochod(IPostac postac, string pozycjaDocelowa)
        {
            _postac = postac;
            _pozycjaDocelowa = pozycjaDocelowa;
        }

        public void Dostarcz()
        {
            _postac.WydrukujPozycje();
            Console.WriteLine($"Samochod rozpoczyna dostarczanie");
            _postac.UstawPozycje(_pozycjaDocelowa);
            Console.WriteLine($"Samochod zakonczyl dostarczanie");
            _postac.WydrukujPozycje();
        }
    }

    public class Autobus : IDostarczyciel
    {
        private IPostac _postac;

        public Autobus(IPostac postac)
        {
            _postac = postac;
        }

        public void Dostarcz()
        {
            _postac.WydrukujPozycje();
            Console.WriteLine($"Autobus rozpoczyna dostarczanie");
            _postac.UstawPozycje("Gdańsk");
            Console.WriteLine($"Autobus zakonczyl dostarczanie");
            _postac.WydrukujPozycje();
        }
    }

    public class Samolot : IDostarczyciel
    {
        private IPostac _postac;

        public Samolot(IPostac postac)
        {
            _postac = postac;
        }

        public void Dostarcz()
        {
            _postac.WydrukujPozycje();
            Console.WriteLine($"Samolot rozpoczyna dostarczanie");
            _postac.UstawPozycje("Gdańsk");
            Console.WriteLine($"Samolot zakonczyl dostarczanie");
            _postac.WydrukujPozycje();
        }
    }
    #endregion
}
