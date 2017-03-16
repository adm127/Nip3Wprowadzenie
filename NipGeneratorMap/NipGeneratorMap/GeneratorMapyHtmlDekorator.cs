using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NipGeneratorMap.Interfaces;

namespace NipGeneratorMap
{
    public class GeneratorMapyHtmlDekorator: IGeneratorMapy
    {
        private string _sciezkaPlikuWynikowego;
        private IGeneratorMapy _generator;

        public GeneratorMapyHtmlDekorator(string sciezkaPlikuWynikowego, IGeneratorMapy generator)
        {
            _generator = generator;
            _sciezkaPlikuWynikowego = sciezkaPlikuWynikowego;
        }

        public void GenerujMape(string sciezkaPlikuWejsciowego)
        {
            using (var sw = new StreamWriter(_sciezkaPlikuWynikowego))
            {
                sw.Write(@"<html><style>table { border-collapse: collapse; } td { padding: 4px; }</style><body><table><tbody>");
            }

            _generator.GenerujMape(sciezkaPlikuWejsciowego);

            using (var sw = new StreamWriter(_sciezkaPlikuWynikowego, true))
            {
                sw.Write(@"</tbody></table></body></html>");
            }
        }
    }
}
