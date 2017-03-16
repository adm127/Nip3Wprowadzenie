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
        private IDostarczycielWysokosci _dostarczyciel;

        public GeneratorKonsolowyMapy(IKonwerterWysokosciNaZnak konwerter, IDostarczycielWysokosci dostarczyciel)
        {
            _konwerter = konwerter;
            _dostarczyciel = dostarczyciel;
        }

        public void GenerujMape(string sciezkaPlikuWejsciowego)
        {
            var wysokosci = _dostarczyciel.Wysokosci(sciezkaPlikuWejsciowego);

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
