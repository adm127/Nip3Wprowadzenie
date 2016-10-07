using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dziedziczenie
{
    public class Trojkat: Figura
    {
        double a, b, c, h;
        public Trojkat(double a, double b, double c, double h)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.h = h;
        }

        public override double ObliczPole()
        {
            return (a / 2) * h;
        }

        public override double ObliczObwod()
        {
            return a + b + c;
        }
    }
}
