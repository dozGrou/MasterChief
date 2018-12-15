namespace MasterChiefRoom
{
    public interface IObservable<T, U> where T : class where U : class
    {
        void Attach(T observer);
        void Detach(T observer);
        void Notify(U data);
    }
}