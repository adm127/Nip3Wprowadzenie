using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NipGeneratorMap.Interfaces;

namespace NipGeneratorMap
{
    /// <summary>
    /// Klasa czytajaca pliki mapy firmy Acme
    /// (Znaki: 0 1 2 3 4 5 6 7 8 9 a b c)
    /// </summary>
    public class PlikowyDostarczycielWysokosci : IDostarczycielWysokosci
    {
        private string _sciezkaPlikuWejsciowego;
        private IKonwerterZnakuNaWysokosc _konwerter;

        public PlikowyDostarczycielWysokosci(string sciezkaPlikuWejsciowego, IKonwerterZnakuNaWysokosc konwerter)
        {
            _sciezkaPlikuWejsciowego = sciezkaPlikuWejsciowego;
            _konwerter = konwerter;
        }

        public int[][] Wysokosci()
        {
            using (var streamReader = new StreamReader(_sciezkaPlikuWejsciowego))
            {
                var dlugoscMapy = int.Parse(streamReader.ReadLine());
                var wysokoscMapy = int.Parse(streamReader.ReadLine());

                int[][] wartosciWysokosci = new int[dlugoscMapy][];

                for (int i = 0; i < dlugoscMapy; i++)
                {
                    wartosciWysokosci[i] = new int[wysokoscMapy];
                }

                for (int i = 0; i < wartosciWysokosci.Length; i++)
                {
                    for (int j = 0; j < wartosciWysokosci[i].Length; j++)
                    {
                        wartosciWysokosci[i][j] = _konwerter.ZnakNaWysokosc((char)streamReader.Read());
                    }

                    streamReader.ReadLine();
                }

                return wartosciWysokosci;
            }
        }
    }
}
