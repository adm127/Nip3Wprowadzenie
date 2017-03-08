using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    public class Kwadrat: Prostokat
    {
        private double a;
        
        public Kwadrat(double a):base(a, a)// Jako przykad tego ze "dziedziczenie" w prawdziwym swiecie nie musi oznaczyc logicznego "dziedziczenia" w kodowaniu
        {
            this.a = a;
        }

        override public double ObliczPole()
        {
            return a * a;
        }

        override public double ObliczObwod()
        {
            return 4 * a;
        }
    }
}
