using System;

namespace ObserverPattern
{
    class SomoyTvNewsAgency : IObserver
    {
        public void StateChanged(int Temperature)
        {
            Console.Write("Welcome to Somoy TV. Todays temperature is: " + Temperature + " degree \n");
        }
    }
}