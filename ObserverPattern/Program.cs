namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherStation weatherStation = new WeatherStation();
           
            weatherStation.Attach(new SomoyTvNewsAgency());
            weatherStation.Attach(new BTVNewsAgency());

            weatherStation.Temperature = 30;
            weatherStation.Temperature = 40;

        }

    }
}
