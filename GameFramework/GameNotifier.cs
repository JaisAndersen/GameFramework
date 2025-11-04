using GameFramework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework
{
    public class GameNotifier : IGameNotifier
    {
        private IGameObserver _observer;

        public GameNotifier(IGameObserver observer)
        {
            _observer = observer;
        }

        public void Update(string hitStatus)
        {
            _observer.Notify(hitStatus);
            GameFrameworkLogger.Instance.LogInformation($"GameNotifier received update: {hitStatus}");
        }
    }
}
