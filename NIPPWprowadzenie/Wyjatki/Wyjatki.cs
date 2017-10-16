using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIPPWprowadzenie
{
    public class Wyjatki
    {
        public void Uruchom()
        {

            //Podziel(10, 4, 2);

            //Podziel(10, 2, -4);


            //try
            //{
            //    Podziel(10, 2, -4);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //    throw ex;
            //}

        }

        //Wariant 1
        public void Podziel(int a, int b, int c)
        {
            Console.WriteLine("Start.");
            for (int i = b; i >= c; i--)
            {
                Console.WriteLine($"Wynik dzielenia {a} przez {i} to {a / i}");
            }

            Console.WriteLine("Koniec.");
        }

        //Wariant 2
        //public void Podziel(int a, int b, int c)
        //{
        //    Console.WriteLine("Start.");
        //    for (int i = b; i >= c; i--)
        //    {
        //        if (i == 0)
        //        {
        //            throw new Exception("Nie mozna podzielic przez zero");
        //            throw new DzieleniePrzezZero(a, b, c);
        //        }

        //        Console.WriteLine($"Wynik dzielenia {a} przez {i} to {a / i}");
        //    }

        //    Console.WriteLine("Koniec.");
        //}

        //wariant 3
        //public void Podziel(int a, int b, int c)
        //{
        //    try
        //    {
        //        Console.WriteLine("Start.");
        //        for (int i = b; i >= c; i--)
        //        {
        //            if (i == 0)
        //            {
        //                throw new Exception("Nie mozna podzielic przez zero");
        //            }

        //            Console.WriteLine($"Wynik dzielenia {a} przez {i} to {a / i}");
        //        }
        //    }
        //    catch (Exception dEx)
        //    {
        //        throw new DzieleniePrzezZero(a, b, c);
        //    }
        //    finally
        //    {
        //        Console.WriteLine("Koniec.");
        //    }
        //}
    }

    //public class DzieleniePrzezZero : Exception
    //{
    //    public int a { get; set; }
    //    public int b { get; set; }
    //    public int c { get; set; }

    //    public DzieleniePrzezZero(int a, int b, int c) : base("Dzielenie przez zero.")
    //    {
    //        this.a = a;
    //        this.b = b;
    //        this.c = c;
    //    }

    //    public override string ToString()
    //    {
    //        return $"`{base.ToString()} \n\n Parametry wywolania: a={a} b={b} c={c}";
    //    }
    //}
}
