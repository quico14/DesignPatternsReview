namespace ObserverPattern
{
    public interface IObserver
    {
        void Update(IObservable observable);
    }
}