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
        public void Attach(IGameNotifier observer)
        {
            throw new NotImplementedException();
        }

        public void Detach(IGameNotifier observer)
        {
            throw new NotImplementedException();
        }

        public void Notify(string hitStatus)
        {
            throw new NotImplementedException();
        }
    }
}
