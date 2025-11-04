using GameFramework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework
{
    public class GameObservers : IGameObserver
    {
        private List<IGameObserver> _observers = new List<IGameObserver>();
        public void Attach(IGameObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IGameObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify(string hitStatus)
        {
            foreach (var observer in _observers)
            {
                observer.Notify(hitStatus);
            }
        }
    }
}
