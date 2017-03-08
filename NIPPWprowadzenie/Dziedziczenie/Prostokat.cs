using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    public class Prostokat: Figura
    {
        double a, b;

        public Prostokat(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public override double ObliczPole()
        {
            return a * b;
        }

        public override double ObliczObwod()
        {
            return a + a + b + b;
        }
    }
}
