using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    // dlaczego interface a nie inna abstrakcyjna klasa?
    // w skrocie: 
    // bo w c# nie ma dziedziczenia wielokrotnego! Nie mozna zrobic tak:

    //public abstract class Samochod
    //{
    //    public abstract void Jedz();
    //}

    //public abstract class Statek
    //{
    //    public abstract void Plyn();
    //}

    //public class Amfibia: Samochod, Statek
    //{
    //    public override void Jedz()
    //    {

    //    }
    //    public override void Plyn()
    //    {

    //    }
    //}

    // w C# (i innych jezykach, ktore wspieraja interface'y) bedzie to np. tak:

    public interface IPlywajacy // (jakies lepsze tlumaczenie)
    {
        void Plyn();
    }

    public interface IJezdzacy // (jakies lepsze tlumaczenie)
    {
        void Jedz();
    }

    public class Samochod : IJezdzacy
    {
        public void Jedz()
        {

        }
    }

    public class Statek : IPlywajacy
    {
        public void Plyn()
        {

        }
    }

    public class Amfibia : IJezdzacy, IPlywajacy
    {
        public void Jedz()
        {

        }

        public void Plyn()
        {

        }
    }
}
