namespace ObserverPattern
{
    public interface IObservable
    {
        void Notify();
        void AddObserver(IObserver observer);
        void DeleteObserver(IObserver observer);
    }
}
