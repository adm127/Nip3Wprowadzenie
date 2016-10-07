using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    /*
        Polimorfizm jest wtedy gdy:
            - traktujesz klasy pochodne przez wskaznik na klase bazowa
            - klasy pochodne maja rozne implementacje metody wirtualnej i 
            podczas jej wywolania (z obiektu na ktory mamy wskaznik na klase
            bazowa) 
                wykonywana jest specyficzna implementacja 
                (zalezna od instancji obiektu a nie od wskaznika na ten obiekt)
    */

    public abstract class Postac
    {
        public abstract void Narysuj();
    }

    public class Wojownik : Postac
    {
        public override void Narysuj()
        {
            Console.WriteLine(@",/|\
//&')
'')(
(( )
)( (
(=M=[)###########>
(( )
(( )_
((__,)");
        }
    }

    public class Mag : Postac
    {
        public override void Narysuj()
        {
            Console.WriteLine(@" (\.   \      ,/)
  \(   |\     )/
  //\  | \   /\\
 (/ /\_#oo#_/\ \)
  \/\  ####  /\/
       `##'");
        }
    }

    public class Lucznik : Postac
    {
        public override void Narysuj()
        {
            Console.WriteLine(@"       (
    () |\       - _                        _
    <==|=@        _ >>>--->               (o)
    [\ |/       -                         /|\
    ||`(                                 / | \
    LL");
        }
    }
}
