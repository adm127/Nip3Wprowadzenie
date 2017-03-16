using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteka;
using Microsoft.Practices.Unity;

namespace DependencyInjection
{
    public class DependencyInjectionPrzyklad
    {
        public void Wykonaj()
        {
            // 1
            //IPostac postac = new Adam();
            //IDostarczyciel dostarczyciel = new Autobus(postac);
            //dostarczyciel.Dostarcz();

            // 2
            //IPostac postac = new Adam();
            //IDostarczyciel dostarczyciel = new Samochod(postac, "Kraków");
            //dostarczyciel.Dostarcz();

            // 3
            //var container = new UnityContainer();

            //// wyciagnac do osobnej metody
            //container.RegisterType<IPostac, Adam>();
            //container.RegisterType<IDostarczyciel, Autobus>();
            ////container.RegisterType<IDostarczyciel, Samochod>("mojeAuto", new InjectionConstructor(container.Resolve<IPostac>(),  "Wrocław"));

            //var dostarczyciel = container.Resolve<IDostarczyciel>();
            //dostarczyciel.Dostarcz();

            // 4
            //var container = new UnityContainer();

            //// wyciagnac do osobnej metody
            //container.RegisterType<IPostac, Adam>();
            //container.RegisterType<IDostarczyciel, Autobus>();
            //container.RegisterType<IDostarczyciel, DostarczycielSerwujacyDrinki>("drinkowyDostarczyciel");
            //var dostarczyciel = container.Resolve<IDostarczyciel>("drinkowyDostarczyciel");
            //dostarczyciel.Dostarcz();
        }
    }
}
