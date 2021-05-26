namespace ObserverPattern
{
    public interface ISubject
    {
        void Attach(IObserver observer);
        void UpdateObservers();
    }
}