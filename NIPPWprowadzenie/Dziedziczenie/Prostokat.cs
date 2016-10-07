using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    public class Prostokat: Figura
    {
        double a, b, c, d;

        public Prostokat(double a, double b, double c, double d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public override double ObliczPole()
        {
            return a * b;
        }

        public override double ObliczObwod()
        {
            return a + b + c + d;
        }
    }
}
