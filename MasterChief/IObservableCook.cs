using System.Collections.Generic;
using MasterChief.Tools;

namespace MasterChief
{
    public interface IObservableCook<T, U> : IObservable<T, U> where T : class where U : class
    {
        void NotifyCleanTools(List<Tool> tools);
    }
}