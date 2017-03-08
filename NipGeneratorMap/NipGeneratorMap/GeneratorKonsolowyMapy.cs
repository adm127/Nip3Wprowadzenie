using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NipGeneratorMap.Interfaces;

namespace NipGeneratorMap
{
    public class GeneratorKonsolowyMapy : IGeneratorMapy
    {
        private IKonwerterWysokosciNaZnak _konwerter;

        public GeneratorKonsolowyMapy(IKonwerterWysokosciNaZnak konwerter)
        {
            _konwerter = konwerter;
        }

        public void GenerujMape(IDostarczycielWysokosci dostarczyciel)
        {
            var wysokosci = dostarczyciel.Wysokosci();

            for (int i = 0; i < wysokosci.Length; i++)
            {
                for (int j = 0; j < wysokosci[i].Length; j++)
                {
                    Console.Write(_konwerter.WysokoscNaZnak(wysokosci[i][j]));
                }
                Console.WriteLine();
            }
        }
    }
}
