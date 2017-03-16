using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NipGeneratorMap.Interfaces;

namespace NipGeneratorMap
{
    public class DostarczycielZnakowHtml : IDostarczycielZnakow
    {
        static readonly string[] _znakiWysokosci = {
            "<td style=\"background-color:#EFEBE9\"></td>",
            "<td style=\"background-color:#D7CCC8\"></td>",
            "<td style=\"background-color:#BCAAA4\"></td>",
            "<td style=\"background-color:#A1887F\"></td>",
            "<td style=\"background-color:#8D6E63\"></td>",
            "<td style=\"background-color:#795548\"></td>",
            "<td style=\"background-color:#6D4C41\"></td>",
            "<td style=\"background-color:#5D4037\"></td>",
            "<td style=\"background-color:#4E342E\"></td>",
            "<td style=\"background-color:#3E2723\"></td>",
            "<td style=\"background-color:#2D2117\"></td>",
            "<td style=\"background-color:#1D1710\"></td>",
            "<td style=\"background-color:#000500\"></td>"
        };

        public string[] ZnakiWysokosci()
        {
            return _znakiWysokosci;
        }

        public string ZnakKoncaLinii()
        {
            return "</tr>";
        }

        public string ZnakPoczatkuLinii()
        {
            return "<tr>";
        }

        public string ZnakNieokreslonejWysokosci()
        {
            return "<td style=\"background-color:#FF0000\"></td>";
        }
    }
}
