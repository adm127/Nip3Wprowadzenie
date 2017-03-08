using System.IO;
using NipGeneratorMap.Interfaces;

namespace NipGeneratorMap
{
    public class GeneratorPlikuMapy: IGeneratorMapy
    {
        private string _sciezkaPlikuWynikowego;
        private IKonwerterWysokosciNaZnak _konwerter;

        public GeneratorPlikuMapy(string sciezkaPlikuWynikowego, IKonwerterWysokosciNaZnak konwerter)
        {
            _sciezkaPlikuWynikowego = sciezkaPlikuWynikowego;
            _konwerter = konwerter;
        }

        public void GenerujMape(IDostarczycielWysokosci dostarczyciel)
        {
            var wysokosci = dostarczyciel.Wysokosci();

            using (var sw = new StreamWriter(_sciezkaPlikuWynikowego))
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