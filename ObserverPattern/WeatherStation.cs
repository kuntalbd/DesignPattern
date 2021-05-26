using System.Collections.Generic;

namespace ObserverPattern
{
    public class WeatherStation : ISubject
    {
        private List<IObserver> _observerList;
        private int _temperature;
        public int Temperature
        {
            get { return _temperature; }
            set
            {
                _temperature = value;
                UpdateObservers();
            }
        }

        public WeatherStation()
        {
            _observerList = new List<IObserver>();
        }


        public void Attach(IObserver observer)
        {
            _observerList.Add(observer);
        }


        public void UpdateObservers()
        {
            _observerList.ForEach(x => x.StateChanged(this._temperature));
        }


    }
}