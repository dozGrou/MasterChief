namespace MasterChiefRoom
{
    public interface IObserver<T>
    {
        void Update(T data);
    }
}