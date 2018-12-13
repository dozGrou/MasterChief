namespace MasterChief
{
    public interface IObserver<T>
    {
        void Update(T data);
    }
}