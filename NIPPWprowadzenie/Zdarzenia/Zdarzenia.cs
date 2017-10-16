using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NIPPWprowadzenie
{
    public class Zdarzenia
    {
        //public delegate void ObliczeniaDelegate(int wynik);
        //public ObliczeniaDelegate RaportujDelegat;
        //public event ObliczeniaDelegate RaportujDelegat;
        //public event EventHandler<WynikEventArgs> RaportujGeneric;
        //public event ObliczeniaDelegate Raportuj;

        public void UruchomObliczenia()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(10);


                //if (RaportujDelegat != null) { this.RaportujDelegat(i); };
                //this.RaportujGeneric(this, new WynikEventArgs() { Wynik = i });
                //this.Raportuj(this, new EventArgs());
            }
        }
    }

    public class WynikEventArgs : EventArgs
    {
        public int Wynik { get; set; }
    }
}
