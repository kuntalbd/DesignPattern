using System;

namespace ObserverPattern
{
    class BTVNewsAgency : IObserver
    {
        public void StateChanged(int Temperature)
        {
            Console.Write("Welcome to BTV. Todays temperature is: " + Temperature + " degree \n");
        }
    }
}