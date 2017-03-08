using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NipGeneratorMap
{
    class Program
    {
        static void Main(string[] args)
        {
            var konwerter = new KonwerterWysokosciNaZnak();

            var generator = new GeneratorPlikuMapy("c:\\test\\wynik.txt", konwerter);
        }
    }
}
