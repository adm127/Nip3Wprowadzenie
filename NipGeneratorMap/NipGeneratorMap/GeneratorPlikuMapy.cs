using System.IO;
using NipGeneratorMap.Interfaces;

namespace NipGeneratorMap
{
    public class GeneratorPlikuMapy: IGeneratorMapy
    {
        private string _sciezkaPlikuWynikowego;
        private IKonwerterWysokosciNaZnak _konwerter;
        private IDostarczycielWysokosci _dostarczyciel;

        public GeneratorPlikuMapy(string sciezkaPlikuWynikowego, IKonwerterWysokosciNaZnak konwerter, IDostarczycielWysokosci dostarczyciel)
        {
            _sciezkaPlikuWynikowego = sciezkaPlikuWynikowego;
            _konwerter = konwerter;
            _dostarczyciel = dostarczyciel;
        }

        public void GenerujMape(string sciezkaPlikuWejsciowego)
        {
            var wysokosci = _dostarczyciel.Wysokosci(sciezkaPlikuWejsciowego);

            using (var sw = new StreamWriter(_sciezkaPlikuWynikowego, true))
            {
                for (int i = 0; i < wysokosci.Length; i++)
                {
                    for (int j = 0; j < wysokosci[i].Length; j++)
                    {
                        sw.Write(_konwerter.WysokoscNaZnak(wysokosci[i][j]));
                    }
                    sw.WriteLine();
                }
            }
        }
    }
}