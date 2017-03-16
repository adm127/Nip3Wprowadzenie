using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NipGeneratorMap.Interfaces
{
    public interface IDostarczycielZnakow
    {
        string[] ZnakiWysokosci();

        string ZnakNieokreslonejWysokosci();

        string ZnakKoncaLinii();

        string ZnakPoczatkuLinii();
    }
}
