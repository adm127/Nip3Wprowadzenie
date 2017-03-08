using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NipGeneratorMap.Interfaces;

namespace NipGeneratorMap
{
    public class KonwerterZnakuNaWysokoscMapex : IKonwerterZnakuNaWysokosc
    {
        public int ZnakNaWysokosc(char znak)
        {
            switch (znak)
            {
                case 'a':
                    return 0;
                case 'b':
                    return 1;
                case 'c':
                    return 2;
                case 'd':
                    return 3;
                case 'e':
                    return 4;
                case 'f':
                    return 5;
                case 'g':
                    return 6;
                case 'h':
                    return 7;
                case 'i':
                    return 8;
                case 'j':
                    return 9;
                case 'k':
                    return 9;
                case 'l':
                    return 10;
                case 'm':
                    return 10;
                case 'n':
                    return 11;
                case 'o':
                    return 11;
                case 'p':
                    return 12;
                case 'q':
                    return 12;
                default:
                    return ' ';
            }
        }
    }
}
