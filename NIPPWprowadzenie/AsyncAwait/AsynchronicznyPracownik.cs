using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
    /*
        asynchronicznosc to co innego niz wielowatkowosc, przyklad:
        Chcesz zrobic sniadanie (tosty + jajka) i posprzatac po sobie kuchnie
            a) synchronicznie: gotujesz jajka, gdy sie skoncza robisz tosty, gdy sie skoncza sprzatasz kuchnie
            b) asynchronicznie: nastawiasz jajka + ustawiasz czasomierz, potem nastawiasz tosty + ustawiasz czasowmierz, 
                przechodzisz do sprzatania kuchni. Gdy ktorys z czasomierzy zakonczy odliczanie konczysz gotowac/robic jajka/tosty
            c) wielowatkowo: zatrudniasz dwoch kucharzy, jeden robi jajka, drugi tosty. Tobie zostaje koordynacja ich pracy, 
                no i musisz im zaplacic ;-)
    */

    public class AsynchronicznyPracownik
    {
        private string nazwaPracownika = string.Empty;

        public AsynchronicznyPracownik(string nazwaPracownika)
        {
            this.nazwaPracownika = nazwaPracownika;
        }

        public async Task PracujAsync(int liczbaJednostekPracy, int predkoscPracy)
        {
            // poniewaz chcemy w tasku zrobic await na metodzie delay, to caly task musi byc oznaczony jako async
            await Task.Run(async () =>
            {
                for (int i = 0; i < liczbaJednostekPracy; i++)
                {
                    Console.WriteLine($"{nazwaPracownika} pracuje...");
                    await Task.Delay(predkoscPracy);
                    // nie chcemy tu blokowac watku, tylko opoznic wykonanie taska, stad delay zamiast sleep
                    //Thread.Sleep(przedkoscPracy);
                }

                Console.WriteLine($"{nazwaPracownika} zakonczyl prace");
            });
        }
    }
}
