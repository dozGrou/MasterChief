using System.Collections.Generic;
using MasterChief.Tools;

namespace MasterChief
{
    public interface IObserverCook<T> : IObserver<T>
    {
        void UpdateCleanTools(List<Tool> tools);
    }
}